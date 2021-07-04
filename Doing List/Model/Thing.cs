using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doing_List.Model
{
    class Thing
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Dedline { get; set; }
        public bool IsDone { get; set; }
        public User Who { get; set; }
    }
}
