using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc.TestProject.Models
{
    public class ContactAddressVM
    {
        public ContactModel ContactVM { get; set; }
        public List<AddressModel> Addresses { get; set; }

        public ContactAddressVM()
        {
            this.Addresses = new List<AddressModel>();
            this.Addresses.Add(new AddressModel());
            this.Addresses.Add(new AddressModel());
            this.Addresses.Add(new AddressModel());
        }
    }
}