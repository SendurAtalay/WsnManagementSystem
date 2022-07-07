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
    public class CountriesBusiness : IDatabaseBusiness<Country>
    {
        public void Delete(Country entity)
        {
            using (var db = new WsnDbEntities())
            {
                db.Countries.Remove(entity);
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new WsnDbEntities())
            {
                var entity = db.Countries.Find(id);
                db.Countries.Remove(entity);
                db.SaveChanges();
            }
        }

        public Country Get(Expression<Func<Country, bool>> predicate)
        {
            using (var db = new WsnDbEntities())
            {
                return db.Countries.Where(predicate).FirstOrDefault();
            }
        }

        public List<Country> GetAll()
        {
            using (var db = new WsnDbEntities())
            {
                return db.Countries.ToList();
            }
        }

        public List<Country> GetAll(Expression<Func<Country, bool>> predicate)
        {
            using (var db = new WsnDbEntities())
            {
                return db.Countries.Where(predicate).ToList();
            }
        }

        public Country GetById(int id)
        {
            using (var db = new WsnDbEntities())
            {
                return db.Countries.Find(id);
            }
        }

        public void Insert(Country entity)
        {
            using (var db = new WsnDbEntities())
            {
                db.Countries.Add(entity);
                db.SaveChanges();
            }
        }

        public void Update(Country entity)
        {
            using (var db = new WsnDbEntities())
            {
                db.Countries.Attach(entity);
                db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
