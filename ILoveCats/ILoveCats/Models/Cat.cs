
using System;

namespace ILoveCats.Models
{
    public class Cat
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public bool Sex { get; set; }
        public string Breed { get; set; }
        public string Colour { get; set; }
        public string Coat { get; set; }

    }
}
