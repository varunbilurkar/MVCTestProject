using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc.TestProject.Models
{
    public class ContactModel
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get { return FirstName + LastName; }
        }

         
    }
}