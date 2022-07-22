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
    public class WsnCoordinatorBusiness : IDatabaseBusiness<WsnCoordinator>
    {
        public void Delete(WsnCoordinator entity)
        {
            using (var db = new WsnDbEntities())
            {
                db.WsnCoordinators.Remove(entity);
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new WsnDbEntities())
            {
                var entity = db.WsnCoordinators.Find(id);
                db.WsnCoordinators.Remove(entity);
                db.SaveChanges();
            }
        }

        public WsnCoordinator Get(Expression<Func<WsnCoordinator, bool>> predicate)
        {
            using (var db = new WsnDbEntities())
            {
                return db.WsnCoordinators.Where(predicate).FirstOrDefault();
            }
        }

        public List<WsnCoordinator> GetAll()
        {
            using (var db = new WsnDbEntities())
            {
                return db.WsnCoordinators.ToList();
            }
        }

        public List<WsnCoordinator> GetAll(Expression<Func<WsnCoordinator, bool>> predicate)
        {
            using (var db = new WsnDbEntities())
            {
                return db.WsnCoordinators.Where(predicate).ToList();
            }
        }

        public WsnCoordinator GetById(int id)
        {
            using (var db = new WsnDbEntities())
            {
                return db.WsnCoordinators.Find(id);
            }
        }

        public void Insert(WsnCoordinator entity)
        {
            using (var db = new WsnDbEntities())
            {
                db.WsnCoordinators.Add(entity);
                db.SaveChanges();
            }
        }

        public void Update(WsnCoordinator entity)
        {
            using (var db = new WsnDbEntities())
            {
                db.WsnCoordinators.Attach(entity);
                db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
        public List<SP_GetWsnCoordinators_Result> GetWsnCoordinators()
        {
            using (var db = new WsnDbEntities())
            {
                return db.SP_GetWsnCoordinators().ToList();

            }

        }
    }
}

