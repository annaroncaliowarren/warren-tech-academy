using Data.ContextSalesApi;
using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseModel
    {
        List<T> entities;

        public BaseRepository()
        {
            this.entities = new List<T>();
        }

        public virtual Dictionary<string, dynamic> Create(T model)
        {
            Dictionary<string, dynamic> resultMap = new Dictionary<string, dynamic>();

            using (SalesApiContext salesContext = new SalesApiContext())
            {
                salesContext.Set<T>().Add(model);
                resultMap.Add("Add", model);
                salesContext.SaveChanges();
            }

            return resultMap;
        }

        public virtual Dictionary<string, dynamic> Delete(int id)
        {
            T model = GetById(id);
            Dictionary<string, dynamic> resultMap = new Dictionary<string, dynamic>();

            using (SalesApiContext salesContext = new SalesApiContext())
            {
                salesContext.Entry<T>(model).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                resultMap.Add("Delete", model);
                salesContext.SaveChanges();
            }

            return resultMap;
        }

        public virtual Dictionary<string, dynamic> GetAll()
        {
            Dictionary<string, dynamic> resultMap = new Dictionary<string, dynamic>();

            using (SalesApiContext salesContext = new SalesApiContext())
            {
                entities = salesContext.Set<T>().ToList();
                resultMap.Add("result", entities);
            }

            return resultMap;
        }

        public virtual T GetById(int id)
        {
            T model = null;

            using (SalesApiContext salesContext = new SalesApiContext())
            {
                model = salesContext.Set<T>().Find(id);
            }

            return model;
        }

        public virtual Dictionary<string, dynamic> Update(T model)
        {
            Dictionary<string, dynamic> resultMap = new Dictionary<string, dynamic>();

            using (SalesApiContext salesContext = new SalesApiContext())
            {
                salesContext.Entry<T>(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                resultMap.Add("Change", model);
                salesContext.SaveChanges();
            }

            return resultMap;
        }
    }
}
