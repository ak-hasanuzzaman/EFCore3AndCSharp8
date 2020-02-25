using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore3AndCSharp8.Models
{
    public class Cat
    {
        public string Name { get; set; }
        public int CatId { get; set; }
        public int OwnerId { get; set; }
        public Owner Owner { get; set; }
    }
}
