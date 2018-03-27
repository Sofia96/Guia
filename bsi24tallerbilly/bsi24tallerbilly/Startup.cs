using bsi24tallerbilly.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using System.Linq;

[assembly: OwinStartupAttribute(typeof(bsi24tallerbilly.Startup))]
namespace bsi24tallerbilly
{
    public partial class Startup
    {

        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateDefautlRolesAndUsers();
        }

        private ApplicationDbContext db = new ApplicationDbContext();

        private void CreateUser(string _Email, string _FullName, string _Password, string _Role)
        {
            var usermanager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));

            //Verificate/Create
            CreateRole(_Role);
            //Create User
            var NewUser = new ApplicationUser()
            {
                Email = _Email,
                UserName = _Email,
                FullName = _FullName
            };
            var ChkUser = usermanager.Create(NewUser, _Password);
            if (ChkUser.Succeeded)
            {
                var result = usermanager.AddToRole(NewUser.Id, _Role);
            }

        }

        //This method will create default users and roles
        private void CreateRole(string RoleName)
        {
            var rolemanager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));
            //Create the first Administrator
            if (!rolemanager.RoleExists(RoleName))
            {
                //Fist step create Administrator role
                var NewRole = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                NewRole.Name = RoleName;
                rolemanager.Create(NewRole);
            }
        }

        private void CreateDefautlRolesAndUsers()
        {
            if (db.Users.Count() == 0)
            {
                CreateUser("sergio31.96@gmail.com", "Sergio Segura", "SOC@4862", "Developer");
                CreateUser("Admin@BillyWorkshop.com", "Billy", "kKb@F5", "Administrator");
                CreateUser("test@BillyWorkshop.com", "Carlitos", "Carlitos2018", "Standar");
            }
        }
    }
}
