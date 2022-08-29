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
        public Dictionary<string, dynamic> Create(T model);
        public Dictionary<string, dynamic> Update(T model); 
        public Dictionary<string, dynamic> Delete(int id);
        public Dictionary<string, dynamic> GetAll();
        public T GetById(int id);
    }
}
