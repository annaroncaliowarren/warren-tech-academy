using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    internal interface IRepository<T> where T : BaseModel
    {
        Dictionary<string, dynamic> Create(T model);
        Dictionary<string, dynamic> Update(T model);
        Dictionary<string, dynamic> Delete(int id);
        Dictionary<string, dynamic> GetAll();
        T GetById(int id);
    }
}
