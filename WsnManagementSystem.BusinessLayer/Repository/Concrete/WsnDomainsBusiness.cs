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
    public class WsnDomainsBusiness : IDatabaseBusiness<WsnDomain>
    {
        public void Delete(WsnDomain entity)
        {
            using (var db = new WsnDbEntities())
            {
                db.WsnDomains.Remove(entity);
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new WsnDbEntities())
            {
                var entity = db.WsnDomains.Find(id);
                db.WsnDomains.Remove(entity);
                db.SaveChanges();
            }
        }

        public WsnDomain Get(Expression<Func<WsnDomain, bool>> predicate)
        {
            using (var db = new WsnDbEntities())
            {
                return db.WsnDomains.Where(predicate).FirstOrDefault();
            }
        }

        public List<WsnDomain> GetAll()
        {
            using (var db = new WsnDbEntities())
            {
                return db.WsnDomains.ToList();
            }
        }

        public List<WsnDomain> GetAll(Expression<Func<WsnDomain, bool>> predicate)
        {
            using (var db = new WsnDbEntities())
            {
                return db.WsnDomains.Where(predicate).ToList();
            }
        }

        public WsnDomain GetById(int id)
        {
            using (var db = new WsnDbEntities())
            {
                return db.WsnDomains.Find(id);
            }
        }

        public void Insert(WsnDomain entity)
        {
            using (var db = new WsnDbEntities())
            {
                db.WsnDomains.Add(entity);
                db.SaveChanges();
            }
        }

        public void Update(WsnDomain entity)
        {
            using (var db = new WsnDbEntities())
            {
                db.WsnDomains.Attach(entity);
                db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
