using CleanArchitecture.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entity
{
    public class Car : BaseEntity
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int EnginePower { get; set; }
    }
}
