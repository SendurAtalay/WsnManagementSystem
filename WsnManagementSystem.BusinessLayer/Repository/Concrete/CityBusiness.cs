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
    public class CityBusiness : IDatabaseBusiness<City>
    {
        public void Delete(City entity)
        {
            using (var db=new WsnDbEntities())
            {
                db.Cities.Remove(entity);
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new WsnDbEntities())
            {
                var entity = db.Cities.Find(id);
                db.Cities.Remove(entity);
                db.SaveChanges();
            }
        }

        public City Get(Expression<Func<City, bool>> predicate)
        {
            using (var db = new WsnDbEntities())
            {
                return db.Cities.Where(predicate).FirstOrDefault();
            }
        }

        public List<City> GetAll()
        {
            using (var db = new WsnDbEntities())
            {
                return db.Cities.ToList();
            }
        }

        public List<City> GetAll(Expression<Func<City, bool>> predicate)
        {
            using (var db = new WsnDbEntities())
            {
                return db.Cities.Where(predicate).ToList();
            }
        }

        public City GetById(int id)
        {
            using (var db = new WsnDbEntities())
            {
                return db.Cities.Find(id);
            }
        }

        public void Insert(City entity)
        {
            using (var db = new WsnDbEntities())
            {
                db.Cities.Add(entity);
                db.SaveChanges();
            }
        }

        public void Update(City entity)
        {
            using (var db = new WsnDbEntities())
            {
                db.Cities.Attach(entity);
                db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public List<SP_Cities_Result> GetCities()
        {
            using (var db = new WsnDbEntities())
            {
                return db.SP_Cities().ToList();
            }
        }
        public List<City> GetCitiesByCountry(int countryID)
        {
            using (var db = new WsnDbEntities())
            {
                return db.Cities.Where(c=>c.CountryID == countryID).ToList();
            }
        }
    }
}
