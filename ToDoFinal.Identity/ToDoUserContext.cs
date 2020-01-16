using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ToDoFinal.Identity
{
    public class ToDoUserContext : IdentityDbContext<ToDoUser>
    {
        public ToDoUserContext(DbContextOptions<ToDoUserContext> options)
            : base(options)
        {

        }
    }
}
