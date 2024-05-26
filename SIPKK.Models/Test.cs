using SIPKK.Ultilities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPKK.Models
{
    public class Test : CuidTimestampedEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int Number { get; set; }
        public bool TruOrFalse { get; set; }
    }
}
