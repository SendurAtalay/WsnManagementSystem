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
    public class SensorNetworkBusiness : IDatabaseBusiness<SensorNetwork>
    {
        public void Delete(SensorNetwork entity)
        {
            using (var db = new WsnDbEntities())
            {
                db.SensorNetworks.Remove(entity);
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new WsnDbEntities())
            {
                var entity = db.SensorNetworks.Find(id);
                db.SensorNetworks.Remove(entity);
                db.SaveChanges();
            }
        }

        public SensorNetwork Get(Expression<Func<SensorNetwork, bool>> predicate)
        {
            using (var db = new WsnDbEntities())
            {
                return db.SensorNetworks.Where(predicate).FirstOrDefault();
            }
        }

        public List<SensorNetwork> GetAll()
        {
            using (var db = new WsnDbEntities())
            {
                return db.SensorNetworks.ToList();
            }
        }

        public List<SensorNetwork> GetAll(Expression<Func<SensorNetwork, bool>> predicate)
        {
            using (var db = new WsnDbEntities())
            {
                return db.SensorNetworks.Where(predicate).ToList();
            }
        }

        public SensorNetwork GetById(int id)
        {
            using (var db = new WsnDbEntities())
            {
                return db.SensorNetworks.Find(id);
            }
        }

        public void Insert(SensorNetwork entity)
        {
            using (var db = new WsnDbEntities())
            {
                db.SensorNetworks.Add(entity);
                db.SaveChanges();
            }
        }

        public void Update(SensorNetwork entity)
        {
            using (var db = new WsnDbEntities())
            {
                db.SensorNetworks.Attach(entity);
                db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
        public List<SP_SensorNetworks_Result> GetSensorNetworks()
        {
            using (var db = new WsnDbEntities())
            {
                return db.SP_SensorNetworks().ToList();

            }
        }

    }
}
