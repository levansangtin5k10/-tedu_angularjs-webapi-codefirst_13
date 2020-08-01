using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface ISystemConfig:IRepository<SystemConfig>
    {

    }
    public class SystemConfigRepository : RepositoryBase<SystemConfig>, ISystemConfig
    {
        public SystemConfigRepository(DbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
