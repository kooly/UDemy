using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMVC_APP.Models
{
    public class NewCustomerViewModel
    {
        public Customer Customer { get; set; }
        public IEnumerable<MemberShipType> membershiptype { get; set; }

    }
}