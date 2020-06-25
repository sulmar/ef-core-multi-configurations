using System;

namespace EFCoreMulti.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Weight { get; set; }
        public int Growth { get; set; }
    }
}
