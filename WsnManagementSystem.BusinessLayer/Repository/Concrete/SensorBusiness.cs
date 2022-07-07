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
    public class SensorBusiness : IDatabaseBusiness<Sensor>
    {
        public void Delete(Sensor entity)
        {
            using (var db = new WsnDbEntities())
            {
                db.Sensors.Remove(entity);
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new WsnDbEntities())
            {
                var entity = db.Sensors.Find(id);
                db.Sensors.Remove(entity);
                db.SaveChanges();
            }
        }

        public Sensor Get(Expression<Func<Sensor, bool>> predicate)
        {
            using (var db = new WsnDbEntities())
            {
                return db.Sensors.Where(predicate).FirstOrDefault();
            };
        }

        public List<Sensor> GetAll()
        {
            using (var db = new WsnDbEntities())
            {
                return db.Sensors.ToList();
            }
        }

        public List<Sensor> GetAll(Expression<Func<Sensor, bool>> predicate)
        {
            using (var db = new WsnDbEntities())
            {
                return db.Sensors.Where(predicate).ToList();
            }
        }

        public Sensor GetById(int id)
        {
            using (var db = new WsnDbEntities())
            {
                return db.Sensors.Find(id);
            }
        }

        public void Insert(Sensor entity)
        {
            using (var db = new WsnDbEntities())
            {
                db.Sensors.Add(entity);
                db.SaveChanges();
            }
        }

        public void Update(Sensor entity)
        {
            using (var db = new WsnDbEntities())
            {
                db.Sensors.Attach(entity);
                db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
