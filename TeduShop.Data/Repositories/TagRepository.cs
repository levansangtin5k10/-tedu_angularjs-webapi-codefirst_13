using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface ITagRepository:IRepository<TagRepository>
    {

    }
    public class TagRepository : RepositoryBase<Tag>, ITagRepository
    {
        public TagRepository(DbFactory dbFactory) : base(dbFactory)
        {

        }

        public void Add(TagRepository entity)
        {
            throw new NotImplementedException();
        }

        public bool CheckContains(Expression<Func<TagRepository, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public int Count(Expression<Func<TagRepository, bool>> where)
        {
            throw new NotImplementedException();
        }

        public void Delete(TagRepository entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteMulti(Expression<Func<TagRepository, bool>> where)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TagRepository> GetMulti(Expression<Func<TagRepository, bool>> predicate, string[] includes = null)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TagRepository> GetMultiPaging(Expression<Func<TagRepository, bool>> filter, out int total, int index = 0, int size = 50, string[] includes = null)
        {
            throw new NotImplementedException();
        }

        public TagRepository GetSingleByCondition(Expression<Func<TagRepository, bool>> expression, string[] includes = null)
        {
            throw new NotImplementedException();
        }

        public void Update(TagRepository entity)
        {
            throw new NotImplementedException();
        }

        TagRepository IRepository<TagRepository>.Add(TagRepository entity)
        {
            throw new NotImplementedException();
        }

        TagRepository IRepository<TagRepository>.Delete(TagRepository entity)
        {
            throw new NotImplementedException();
        }

        TagRepository IRepository<TagRepository>.Delete(int id)
        {
            throw new NotImplementedException();
        }

       

        IEnumerable<TagRepository> IRepository<TagRepository>.GetAll(string[] includes)
        {
            throw new NotImplementedException();
        }

        IEnumerable<TagRepository> IRepository<TagRepository>.GetMulti(Expression<Func<TagRepository, bool>> predicate, string[] includes)
        {
            throw new NotImplementedException();
        }

        IEnumerable<TagRepository> IRepository<TagRepository>.GetMultiPaging(Expression<Func<TagRepository, bool>> filter, out int total, int index, int size, string[] includes)
        {
            throw new NotImplementedException();
        }

        TagRepository IRepository<TagRepository>.GetSingleById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
