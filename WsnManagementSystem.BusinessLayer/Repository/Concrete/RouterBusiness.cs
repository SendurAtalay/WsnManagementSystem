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
    public class RouterBusiness : IDatabaseBusiness<Router>
    {
        public void Delete(Router entity)
        {
            using (var db = new WsnDbEntities())
            {
                db.Routers.Remove(entity);
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new WsnDbEntities())
            {
                var entity = db.Routers.Find(id);
                db.Routers.Remove(entity);
                db.SaveChanges();
            }
        }

        public Router Get(Expression<Func<Router, bool>> predicate)
        {
            using (var db = new WsnDbEntities())
            {
                return db.Routers.Where(predicate).FirstOrDefault();
            }
        }

        public List<Router> GetAll()
        {
            using (var db = new WsnDbEntities())
            {
                return db.Routers.ToList();
            }
        }

        public List<Router> GetAll(Expression<Func<Router, bool>> predicate)
        {
            using (var db = new WsnDbEntities())
            {
                return db.Routers.Where(predicate).ToList();
            }
        }

        public Router GetById(int id)
        {
            using (var db = new WsnDbEntities())
            {
                return db.Routers.Find(id);
            }
        }

        public void Insert(Router entity)
        {
            using (var db = new WsnDbEntities())
            {
                db.Routers.Add(entity);
                db.SaveChanges();
            }
        }

        public void Update(Router entity)
        {
            using (var db = new WsnDbEntities())
            {
                db.Routers.Attach(entity);
                db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
