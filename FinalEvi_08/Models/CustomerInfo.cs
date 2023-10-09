using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FinalEvi_08.Models
{
    public partial class CustomerInfo
    {
        public int Id { get; set; }
        public string CustoName { get; set; }
        public string CustoAddress { get; set; }
        public int? PhoneNo { get; set; }
        public int? Age { get; set; }
        public decimal? Salary { get; set; }
        public DateTime? DateOfB { get; set; }
    }
}
