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
    public class DistrictBusiness : IDatabaseBusiness<District>
    {
        public void Delete(District entity)
        {
            using (var db = new WsnDbEntities())
            {
                db.Districts.Remove(entity);
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new WsnDbEntities())
            {
                var entity = db.Districts.Find(id);
                db.Districts.Remove(entity);
                db.SaveChanges();
            }
        }

        public District Get(Expression<Func<District, bool>> predicate)
        {
            using (var db = new WsnDbEntities())
            {
                return db.Districts.Where(predicate).FirstOrDefault();
            }
        }

        public List<District> GetAll()
        {
            using (var db = new WsnDbEntities())
            {
                return db.Districts.ToList();
            }
        }

        public List<District> GetAll(Expression<Func<District, bool>> predicate)
        {
            using (var db = new WsnDbEntities())
            {
                return db.Districts.Where(predicate).ToList();
            }
        }

        public District GetById(int id)
        {
            using (var db = new WsnDbEntities())
            {
                return db.Districts.Find(id);
            }
        }

        public void Insert(District entity)
        {
            using (var db = new WsnDbEntities())
            {
                db.Districts.Add(entity);
                db.SaveChanges();
            }
        }

        public void Update(District entity)
        {
            using (var db = new WsnDbEntities())
            {
                db.Districts.Attach(entity);
                db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
