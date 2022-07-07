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
    public class RouterSensorBusiness : IDatabaseBusiness<RouterSensor>
    {
        public void Delete(RouterSensor entity)
        {
            using (var db = new WsnDbEntities())
            {
                db.RouterSensors.Remove(entity);
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new WsnDbEntities())
            {
                var entity = db.RouterSensors.Find(id);
                db.RouterSensors.Remove(entity);
                db.SaveChanges();
            }
        }

        public RouterSensor Get(Expression<Func<RouterSensor, bool>> predicate)
        {
            using (var db = new WsnDbEntities())
            {
                return db.RouterSensors.Where(predicate).FirstOrDefault();
            }
        }

        public List<RouterSensor> GetAll()
        {
            using (var db = new WsnDbEntities())
            {
                return db.RouterSensors.ToList();
            }
        }

        public List<RouterSensor> GetAll(Expression<Func<RouterSensor, bool>> predicate)
        {
            using (var db = new WsnDbEntities())
            {
                return db.RouterSensors.Where(predicate).ToList();
            }
        }

        public RouterSensor GetById(int id)
        {
            using (var db = new WsnDbEntities())
            {
                return db.RouterSensors.Find(id);
            }
        }

        public void Insert(RouterSensor entity)
        {
            using (var db = new WsnDbEntities())
            {
                db.RouterSensors.Add(entity);
                db.SaveChanges();
            }
        }

        public void Update(RouterSensor entity)
        {
            using (var db = new WsnDbEntities())
            {
                db.RouterSensors.Attach(entity);
                db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
