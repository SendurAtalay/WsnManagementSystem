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
    public class WsnStatueBusiness : IDatabaseBusiness<WsnStatu>
    {
        public void Delete(WsnStatu entity)
        {
            using (var db = new WsnDbEntities())
            {
                db.WsnStatus.Remove(entity);
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new WsnDbEntities())
            {
                var entity = db.WsnStatus.Find(id);
                db.WsnStatus.Remove(entity);
                db.SaveChanges();
            }
        }

        public WsnStatu Get(Expression<Func<WsnStatu, bool>> predicate)
        {
            using (var db = new WsnDbEntities())
            {
                return db.WsnStatus.Where(predicate).FirstOrDefault();
            }
        }

        public List<WsnStatu> GetAll()
        {
            using (var db = new WsnDbEntities())
            {
                return db.WsnStatus.ToList();
            }
        }

        public List<WsnStatu> GetAll(Expression<Func<WsnStatu, bool>> predicate)
        {
            using (var db = new WsnDbEntities())
            {
                return db.WsnStatus.Where(predicate).ToList();
            }
        }

        public WsnStatu GetById(int id)
        {
            using (var db = new WsnDbEntities())
            {
                return db.WsnStatus.Find(id);
            }
        }

        public void Insert(WsnStatu entity)
        {
            using (var db = new WsnDbEntities())
            {
                db.WsnStatus.Add(entity);
                db.SaveChanges();
            }
        }

        public void Update(WsnStatu entity)
        {
            using (var db = new WsnDbEntities())
            {
                db.WsnStatus.Attach(entity);
                db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
