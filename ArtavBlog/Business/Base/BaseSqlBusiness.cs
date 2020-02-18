using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArtavBlog.Models.Base;
using ArtavBlog.Repository.Base;
using Microsoft.EntityFrameworkCore;


namespace ArtavBlog.Business.Base
{
    public class BaseSqlBusiness<T> : ISqlBaseRepository<T> where T : ModelObject
    {
        private BlogContext _context;
        private DbSet<T> _dataList;

        public BaseSqlBusiness(BlogContext context)
        {
            _context = context;
            _dataList = _context.Set<T>();
        }

        public virtual List<T> GetAllData()
        {
            return _dataList.Where(p => !p.IsDeleted).ToList();
        }

        public virtual List<T> GetDataByCustomFilter(Func<T, bool> source)
        {
            return _dataList.Where(p => !p.IsDeleted).Where(source).ToList();
        }

        public virtual T GetSingleDataById(string id)
        {
            return _dataList.Where(p => !p.IsDeleted).FirstOrDefault(p => p.ID == id);
        }

        public async virtual Task<bool> InsertInstance(T instance, bool wantToFillFormalProperties = true)
        {
            try
            {
                if (wantToFillFormalProperties)
                    FillFormalProperties();
                await _dataList.AddAsync(instance);
                return await _context.SaveChangesAsync() == 1;
            }
            catch (Exception ex)
            {
                return false;
            }
            void FillFormalProperties()
            {
                instance.ID = Guid.NewGuid().ToString();
                instance.CreateDateAndTime = DateTime.Now;
                instance.LastModifiedDateAndTime = DateTime.Now;
                instance.IsDeleted = false;
            }
        }

        public virtual async Task<bool> DeleteDataById(string id)
        {
            var entity = await _dataList.FirstOrDefaultAsync(p => p.IsDeleted);
            if (entity != null)
            {
                _dataList.Remove(entity);
                _context.Entry(entity).State = EntityState.Deleted;
                return await _context.SaveChangesAsync() == 1;
            }
            else
                return false;
        }


        public virtual async Task<bool> UpdateInstance(T instance)
        {
            _dataList.Update(instance);
            return await _context.SaveChangesAsync() == 1;
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public virtual async Task<bool> UpdateRange(IEnumerable<T> instance)
        {
            _dataList.UpdateRange(instance);
            return await _context.SaveChangesAsync() == 1;
        }

        public List<T> GetDataByQuery(string queryText)
        {
            
            return _dataList.FromSqlRaw(queryText).ToList();
        }
    }
}
