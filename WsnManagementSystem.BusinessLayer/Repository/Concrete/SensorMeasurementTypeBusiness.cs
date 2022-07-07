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
    public class SensorMeasurementTypeBusiness : IDatabaseBusiness<SensorMeasurementType>
    {
        public void Delete(SensorMeasurementType entity)
        {
            using (var db = new WsnDbEntities())
            {
                db.SensorMeasurementTypes.Remove(entity);
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new WsnDbEntities())
            {
                var entity = db.SensorMeasurementTypes.Find(id);
                db.SensorMeasurementTypes.Remove(entity);
                db.SaveChanges();
            }
        }

        public SensorMeasurementType Get(Expression<Func<SensorMeasurementType, bool>> predicate)
        {
            using (var db = new WsnDbEntities())
            {
                return db.SensorMeasurementTypes.Where(predicate).FirstOrDefault();
            }
        }

        public List<SensorMeasurementType> GetAll()
        {
            using (var db = new WsnDbEntities())
            {
                return db.SensorMeasurementTypes.ToList();
            }
        }

        public List<SensorMeasurementType> GetAll(Expression<Func<SensorMeasurementType, bool>> predicate)
        {
            using (var db = new WsnDbEntities())
            {
                return db.SensorMeasurementTypes.Where(predicate).ToList();
            }
        }

        public SensorMeasurementType GetById(int id)
        {
            using (var db = new WsnDbEntities())
            {
                return db.SensorMeasurementTypes.Find(id);
            }
        }

        public void Insert(SensorMeasurementType entity)
        {
            using (var db = new WsnDbEntities())
            {
                db.SensorMeasurementTypes.Add(entity);
                db.SaveChanges();
            }
        }

        public void Update(SensorMeasurementType entity)
        {
            using (var db = new WsnDbEntities())
            {
                db.SensorMeasurementTypes.Attach(entity);
                db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
