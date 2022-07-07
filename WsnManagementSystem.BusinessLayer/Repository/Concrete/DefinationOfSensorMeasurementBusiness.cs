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
    public class DefinationOfSensorMeasurementBusiness : IDatabaseBusiness<DefinationOfSensorMeasurement>
    {
        public void Delete(DefinationOfSensorMeasurement entity)
        {
            using (var db = new WsnDbEntities())
            {
                db.DefinationOfSensorMeasurements.Remove(entity);
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new WsnDbEntities())
            {
                var entity = db.DefinationOfSensorMeasurements.Find(id);
                db.DefinationOfSensorMeasurements.Remove(entity);
                db.SaveChanges();
            }
        }

        public DefinationOfSensorMeasurement Get(Expression<Func<DefinationOfSensorMeasurement, bool>> predicate)
        {
            using (var db = new WsnDbEntities())
            {
                return db.DefinationOfSensorMeasurements.Where(predicate).FirstOrDefault();
            }
        }

        public List<DefinationOfSensorMeasurement> GetAll()
        {
            using (var db = new WsnDbEntities())
            {
                return db.DefinationOfSensorMeasurements.ToList();
            }
        }

        public List<DefinationOfSensorMeasurement> GetAll(Expression<Func<DefinationOfSensorMeasurement, bool>> predicate)
        {
            using (var db = new WsnDbEntities())
            {
                return db.DefinationOfSensorMeasurements.Where(predicate).ToList();
            }
        }

        public DefinationOfSensorMeasurement GetById(int id)
        {
            using (var db = new WsnDbEntities())
            {
                return db.DefinationOfSensorMeasurements.Find(id);
            }
        }

        public void Insert(DefinationOfSensorMeasurement entity)
        {
            using (var db = new WsnDbEntities())
            {
                db.DefinationOfSensorMeasurements.Add(entity);
                db.SaveChanges();
            }
        }

        public void Update(DefinationOfSensorMeasurement entity)
        {
            using (var db = new WsnDbEntities())
            {
                db.DefinationOfSensorMeasurements.Attach(entity);
                db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
