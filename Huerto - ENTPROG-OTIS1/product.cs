using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huerto___ENTPROG___OTIS1
{
    public class product
{
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Qty { get; set; }
        public string Unit { get; set; }
        public DateTime DateAdded { get; set; } = DateTime.Now;
        public DateTime DateModified { get; set; } = DateTime.Now;
    }
}
