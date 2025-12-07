using System;
using System.Data.Entity;
using System.Web.Mvc;  // IMPORT: System.Web.Mvc namespace

namespace HelloWorld
{
    // Using Entity Framework 6 DbContext - not compatible with .NET Core
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("DefaultConnection")
        {
        }

        public DbSet<User> Users { get; set; }
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }

    // CLASS REFERENCE: Inheriting from System.Web.Mvc.Controller
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // FIELD REFERENCE: ModelState property from System.Web.Mvc.Controller
            var isValid = ModelState.IsValid;

            // METHOD REFERENCE: View() method from Controller
            return View();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Minimal ASP.NET MVC Sample");
            Console.WriteLine("===========================");
            Console.WriteLine();
            Console.WriteLine("Expected incidents for System.Web.Mvc.*:");
            Console.WriteLine("1. IMPORT: Line 3 - using System.Web.Mvc;");
            Console.WriteLine("2. CLASS: Line 25 - Controller inheritance");
            Console.WriteLine("3. FIELD: Line 30 - ModelState.IsValid");
            Console.WriteLine("4. METHOD: Line 33 - View()");
            Console.WriteLine();
            Console.WriteLine("Total: 3-4 incidents");
        }
    }
}
