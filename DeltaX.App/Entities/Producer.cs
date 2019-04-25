using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeltaX.App.Entities
{
    public class Producer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Gender Sex { get; set; }
        public DateTime DOB { get; set; }
        public string Bio { get; set; }
    }
}
