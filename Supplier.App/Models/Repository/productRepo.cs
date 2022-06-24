using Huerto___ENTPROG___OTIS1;
using Huerto___ENTPROG___OTIS1.DataModel;
using Huerto___ENTPROG___OTIS1.Repository;

namespace Supplier.App.Models.Repository
{
    public class productRepo : GenericRepo<product>, IProductRepo
    {
        public productRepo(AppDbContext context) : base(context)
        {
        }
    }
}
