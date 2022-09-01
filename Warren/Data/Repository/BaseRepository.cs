using Data.Context;
using Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseModel
    {
        Dictionary<string, dynamic> dictionaryModels;
      
        public BaseRepository()
        {
            dictionaryModels = new Dictionary<string, dynamic>();
        }

        public virtual List<T> GetAll()
        {
            List<T> list = new List<T>();

            using (WarrenContext warrenContext = new WarrenContext()) // para não deixar o banco aberto toda vez que o método é acionado
            {
                list = warrenContext.Set<T>().ToList();
            }

            return list;
        }

        public virtual Dictionary<string, dynamic> Create(T model)
        {
            using (WarrenContext warrenContext = new WarrenContext())
            {
                warrenContext.Set<T>().Add(model);
                dictionaryModels.Add("Add", model);
                warrenContext.SaveChanges();
            }

            return dictionaryModels;
        }

        public virtual Dictionary<string, dynamic> Delete(int id)
        {
            T model = GetById(id);

            using (WarrenContext warrenContext = new WarrenContext())
            {
                warrenContext.Entry<T>(model).State = EntityState.Deleted;
                dictionaryModels.Add("Deleted", model);
                warrenContext.SaveChanges();
            }

            return dictionaryModels;
        }

        public virtual T GetById(int id)
        {
            T model = null;

            using (WarrenContext warrenContext = new WarrenContext())
            {
                model = warrenContext.Set<T>().Find(id);
            }

            return model;
        }

        public virtual Dictionary<string, dynamic> Update(T model)
        {
            dictionaryModels.Add("Old", GetById(model.Id));

            using (WarrenContext warrenContext = new WarrenContext())
            {
                warrenContext.Entry<T>(model).State = EntityState.Modified;
                dictionaryModels.Add("New", model);
                warrenContext.SaveChanges();
            }

            return dictionaryModels;
        }
    }
}
