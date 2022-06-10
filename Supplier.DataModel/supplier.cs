using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supplier.DataModel
{
    public class supplier
    {
        public int SupplierID { get; set; }
        public string? CompanyName { get; set;}
        public string? Address { get; set; }
        public string? Representative { get; set; }
        public string? ContactNo { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }

        
    }
}
