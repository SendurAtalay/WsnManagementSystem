using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WsnManagementSystem.BusinessLayer.Repository.Abstract;
using WsnManagementSystem.DataLayer;

namespace WsnManagementSystem.BusinessLayer.Repository.Concrete
{
    public class CountyBusiness : IDatabaseBusiness<County>
    {
        public void Delete(County entity)
        {
            using (var db = new WsnDbEntities())
            {
                db.Counties.Remove(entity);
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new WsnDbEntities())
            {
                var entity = db.Counties.Find(id);
                db.Counties.Remove(entity);
                db.SaveChanges();
            }
        }

        public County Get(Expression<Func<County, bool>> predicate)
        {
            using (var db = new WsnDbEntities())
            {
                return db.Counties.Where(predicate).FirstOrDefault();
            }
        }

        public List<County> GetAll()
        {
            using (var db = new WsnDbEntities())
            {
                return db.Counties.ToList();
            }
        }

        public List<County> GetAll(Expression<Func<County, bool>> predicate)
        {
            using (var db = new WsnDbEntities())
            {
                return db.Counties.Where(predicate).ToList();
            }
        }

        public County GetById(int id)
        {
            using (var db = new WsnDbEntities())
            {
                return db.Counties.Find(id);
            }
        }

        public void Insert(County entity)
        {
            using (var db = new WsnDbEntities())
            {
                db.Counties.Add(entity);
                db.SaveChanges();
            }
        }

        public void Update(County entity)
        {
            using (var db = new WsnDbEntities())
            {
                db.Counties.Attach(entity);
                db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
        public List<SP_GetCounties_Result> GetCounties()
        {
            using (var db = new WsnDbEntities())
            {
                return db.SP_GetCounties().ToList();

            }
        }
        public List<County> GetCountiesByCity(int cityID)
        {
            using (var db = new WsnDbEntities())
            {
                return db.Counties.Where(c => c.CityID == cityID).ToList();
            }
        }
    }
}
