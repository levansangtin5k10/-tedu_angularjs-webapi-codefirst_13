using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface IProductTagRepository:IRepository<ProductTag>
    {

    }
    public class ProductTagRepository : RepositoryBase<ProductTag>, IProductRepository
    {
        public ProductTagRepository(DbFactory dbFactory) : base(dbFactory)
        {

        }

        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public bool CheckContains(Expression<Func<Product, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public int Count(Expression<Func<Product, bool>> where)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteMulti(Expression<Func<Product, bool>> where)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Product> GetMulti(Expression<Func<Product, bool>> predicate, string[] includes = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Product> GetMultiPaging(Expression<Func<Product, bool>> filter, out int total, int index = 0, int size = 50, string[] includes = null)
        {
            throw new NotImplementedException();
        }

        public Product GetSingleByCondition(Expression<Func<Product, bool>> expression, string[] includes = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }

        Product IRepository<Product>.Add(Product entity)
        {
            throw new NotImplementedException();
        }

        Product IRepository<Product>.Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        Product IRepository<Product>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Product> IRepository<Product>.GetAll(string[] includes)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Product> IRepository<Product>.GetMulti(Expression<Func<Product, bool>> predicate, string[] includes)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Product> IRepository<Product>.GetMultiPaging(Expression<Func<Product, bool>> filter, out int total, int index, int size, string[] includes)
        {
            throw new NotImplementedException();
        }

        Product IRepository<Product>.GetSingleById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
