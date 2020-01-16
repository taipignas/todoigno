using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ToDoFinal.Identity;
using ToDoFinal.Models;
using ToDoFinal.Services;

namespace ToDoFinal.Pages
{
    public partial class IndexModel : PageModel
    {
        private readonly UserManager<ToDoUser> _userManager;
        private readonly SignInManager<ToDoUser> _signInManager;
        private readonly ManageTasks _manageTasks;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(
            UserManager<ToDoUser> userManager,
            SignInManager<ToDoUser> signInManager,
            ManageTasks manageTasks,
            ILogger<IndexModel> logger
            )
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _manageTasks = manageTasks;
            _logger = logger;
        }

        public const string Hide = "_Name";
        public List<ToDoTask> Tasks { get; set; }
        [TempData]
        public string StatusMessage { get; set; }
        [TempData]
        public int HideCompleted { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            public int Id { get; set; }
            [StringLength(90, MinimumLength = 3)]
            public string Description { get; set; }
            public Priority Priority { get; set; }
            public DateTime DueDate { get; set; }
            public Status Status { get; set; }
        }

        //separate function to initiate or refresh data used in page
        private async Task LoadAsync(ToDoUser user)
        {
            var userId = await _userManager.GetUserIdAsync(user);
            Tasks = _manageTasks.GetTasks(userId);
            HideCompleted = HttpContext.Session.GetInt32(Hide) ?? default(int);
            Input = new InputModel
            {
            };
        }

        //page load
        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);

            if (user == null)
            {
                return Redirect("NewUser");
            }
            else
            {
                await _signInManager.RefreshSignInAsync(user);
                await LoadAsync(user);
                return Page();
            }
        }

        //page post AddTask
        public async Task<IActionResult> OnPostAddTaskAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid || Input.Description == null)
            {
                await LoadAsync(user);
                StatusMessage = "Task data format is not supported";
                // no front end validation intentionally to test this events logging @@@@cshtml line 67 add required attribute
                _logger.LogWarning($"User {user} sent wrong data .{Input.Id}.{Input.Description}.{Input.Priority}.{Input.DueDate}.{Input.Status}");
                return Page();
            }

            if (ModelState.IsValid && Input.Description.Length >= 3)
            {
                var userId = await _userManager.GetUserIdAsync(user);
                var dueDate = Input.DueDate.ToUniversalTime();
                ToDoTask task = new ToDoTask { Description = Input.Description, DueDate = dueDate, Priority = Input.Priority, Status = Input.Status, ToDoUserId = userId };
                _manageTasks.AddTask(task);
                _logger.LogInformation($"User {userId} added a task");
            }

            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Task has been added";
            return RedirectToPage();
        }

        //page post UpdateTask
        public async Task<IActionResult> OnPostUpdateTaskAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }
            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                StatusMessage = "Task data format is not supported";
                return Page();
            }
            else
            {
                string userId = await _userManager.GetUserIdAsync(user);
                DateTime dueDate = Input.DueDate.ToUniversalTime();
                //Create new task with new data
                ToDoTask task = new ToDoTask { DueDate = dueDate, Priority = Input.Priority, Status = Input.Status };
                //Send the new task to overwrite the desired task
                _manageTasks.UpdateTask(task, Input.Id);
                await _signInManager.RefreshSignInAsync(user);
                StatusMessage = "Task has been updated";
                return RedirectToPage();
            }
        }

        //page post Hide, hides or show completed tasks
        public IActionResult OnPostHideAsync()
        {
            if (HttpContext.Session.GetInt32(Hide) == 1)
            {
                HttpContext.Session.SetInt32(Hide, 0);
                StatusMessage = "Completed tasks will be displayed";
            }
            else
            {
                HttpContext.Session.SetInt32(Hide, 1);
                StatusMessage = "Completed tasks will be hidden";
            }
            HideCompleted = HttpContext.Session.GetInt32(Hide) ?? default(int);
            return RedirectToPage();
        }
    }
}
