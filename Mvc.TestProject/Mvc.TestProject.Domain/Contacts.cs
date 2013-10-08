using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mvc.TestProject.Domain
{
    public class Contact
    {
        public int Id { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }

        public virtual string FullName
        {
            get { return FirstName + LastName; }
        }

        public virtual List<Address> Addresses { get; set; }
    }
}
