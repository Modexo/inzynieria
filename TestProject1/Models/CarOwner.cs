using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject1.Models
{
    class CarOwner : Cars
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public Cars Car { get; set; }

    }
}
