using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeltaX.App.Entities
{
    public enum Gender
    {
        Male,
        Female,
        Others
    }
    public class Actor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Gender Sex { get; set; }
        public DateTime DOB { get; set; }
        public string Bio { get; set; }

    }
}
