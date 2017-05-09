using LysiSolutionNumber01.Models.Interfaces;
using System.Collections.Generic;

namespace TodoApi.Models
{
    public interface IDefaultRepository<T> where T : class
    {
        void Add(T item);
        IEnumerable<T> GetAll();
        T Find(long key);
        void Remove(long key);
        void Update(T item);
    }
}