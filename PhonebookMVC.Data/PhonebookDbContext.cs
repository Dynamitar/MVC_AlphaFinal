using Microsoft.AspNet.Identity.EntityFramework;
using PhonebookMVC.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonebookMVC.Data
{
    public class PhonebookDbContext : IdentityDbContext<ApplicationUser>
    {
        public PhonebookDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {

        }

        public static PhonebookDbContext Create()
        {
            return new PhonebookDbContext();
        }




    }
}
