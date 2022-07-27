using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperTutorial.Core.interfaces
{
    public interface IRepository<T> where T : class
    {
        int Insert(T obj);
        int Update(T obj);
        int DeleteById(int id);
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
}
