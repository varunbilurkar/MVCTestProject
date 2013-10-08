using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mvc.TestProject.Domain
{
    public class Address
    {
        public int Id { get; set; }
        public virtual string Line1 { get; set; }
        public virtual string City { get; set; }

        public virtual List<Contact> Contacts { get; set; }
    }
}
