using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using ToDoFinal.Identity;

namespace ToDoFinal.web.Pages.Account
{
    public class IndexModel : PageModel
    {
        private readonly UserManager<ToDoUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public IndexModel(
            UserManager<ToDoUser> userManager,
            RoleManager<IdentityRole> roleManager
            )
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);

            if (user == null)
            {
                return Redirect("NewUser");
            }

            //create administrator role if it doesnt exist
            if (!await _roleManager.RoleExistsAsync("Administrator")) 
                await _roleManager.CreateAsync(new IdentityRole("Administrator"));
            //assign admin the administrator role
            if(await _userManager.FindByNameAsync("admin") != null)
                if (!await _userManager.IsInRoleAsync(await _userManager.FindByNameAsync("admin"), "Administrator")) 
                    await _userManager.AddToRoleAsync(await _userManager.FindByNameAsync("admin"), "Administrator");

            return Page();
        }
    }
}
