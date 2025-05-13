using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using generics.Interfaces;
namespace generics.Entities
{
    class Person: IEntity
    {
        public int Id { get; set; }
        public string  Name { get; set; }
    }
}
