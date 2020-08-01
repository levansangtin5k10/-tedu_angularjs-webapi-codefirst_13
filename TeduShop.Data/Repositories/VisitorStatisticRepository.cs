using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface IVisitorStatistic:IRepository<VisitorStatistic>
    {

    }
    public class VisitorStatisticRepository : RepositoryBase<VisitorStatistic>, IVisitorStatistic
    {
        public VisitorStatisticRepository(DbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
