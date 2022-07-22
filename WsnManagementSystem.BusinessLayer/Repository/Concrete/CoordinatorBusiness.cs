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
    public class CoordinatorBusiness : IDatabaseBusiness<Coordinator>
    {
        public void Delete(Coordinator entity)
        {
            using (var db = new WsnDbEntities())
            {
                db.Coordinators.Remove(entity);
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new WsnDbEntities())
            {
                var entity = db.Coordinators.Find(id);
                db.Coordinators.Remove(entity);
                db.SaveChanges();
            }
        }

        public Coordinator Get(Expression<Func<Coordinator, bool>> predicate)
        {
            using (var db = new WsnDbEntities())
            {
                return db.Coordinators.Where(predicate).FirstOrDefault();
            }
        }

        public List<Coordinator> GetAll()
        {
            using (var db = new WsnDbEntities())
            {
                return db.Coordinators.ToList();
            }
        }

        public List<Coordinator> GetAll(Expression<Func<Coordinator, bool>> predicate)
        {
            using (var db = new WsnDbEntities())
            {
                return db.Coordinators.Where(predicate).ToList();
            }
        }

        public Coordinator GetById(int id)
        {
            using (var db = new WsnDbEntities())
            {
                return db.Coordinators.Find(id);
            }
        }

        public void Insert(Coordinator entity)
        {
            using (var db = new WsnDbEntities())
            {
                db.Coordinators.Add(entity);
                db.SaveChanges();
            }
        }

        public void Update(Coordinator entity)
        {
            using (var db = new WsnDbEntities())
            {
                db.Coordinators.Attach(entity);
                db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
        public List<SP_GetCoordinators_Result> GetCoordinators()
        {
            using (var db = new WsnDbEntities())
            {
                return db.SP_GetCoordinators().ToList();

            }
        }
    }
}
