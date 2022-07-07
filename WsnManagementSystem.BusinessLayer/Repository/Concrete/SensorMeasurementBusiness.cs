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
    public class SensorMeasurementBusiness : IDatabaseBusiness<SensorMeasurement>
    {
        public void Delete(SensorMeasurement entity)
        {
            using (var db = new WsnDbEntities())
            {
                db.SensorMeasurements.Remove(entity);
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new WsnDbEntities())
            {
                var entity = db.SensorMeasurements.Find(id);
                db.SensorMeasurements.Remove(entity);
                db.SaveChanges();
            }
        }

        public SensorMeasurement Get(Expression<Func<SensorMeasurement, bool>> predicate)
        {
            using (var db = new WsnDbEntities())
            {
                return db.SensorMeasurements.Where(predicate).FirstOrDefault();
            }
        }

        public List<SensorMeasurement> GetAll()
        {
            using (var db = new WsnDbEntities())
            {
                return db.SensorMeasurements.ToList();
            }
        }

        public List<SensorMeasurement> GetAll(Expression<Func<SensorMeasurement, bool>> predicate)
        {
            using (var db = new WsnDbEntities())
            {
                return db.SensorMeasurements.Where(predicate).ToList();
            }
        }

        public SensorMeasurement GetById(int id)
        {
            using (var db = new WsnDbEntities())
            {
                return db.SensorMeasurements.Find(id);
            }
        }

        public void Insert(SensorMeasurement entity)
        {
            using (var db = new WsnDbEntities())
            {
                db.SensorMeasurements.Add(entity);
                db.SaveChanges();
            }
        }

        public void Update(SensorMeasurement entity)
        {
            using (var db = new WsnDbEntities())
            {
                db.SensorMeasurements.Attach(entity);
                db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
