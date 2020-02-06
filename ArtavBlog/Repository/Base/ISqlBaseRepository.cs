using ArtavBlog.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtavBlog.Repository.Base
{
    public interface ISqlBaseRepository<T> : IDisposable where T : ModelObject
    {
        List<T> GetAllData();
        List<T> GetDataByCustomFilter(Func<T, bool> source);
        T GetSingleDataById(string id);
        Task<bool> InsertInstance(T instance, bool wantToFillFormalProperties);
        Task<bool> DeleteDataById(string id);
      //  Task<bool> DeleteDataByCustomFilter(Func<T, bool> source);
        Task<bool> UpdateInstance(T instance);
    }
}
