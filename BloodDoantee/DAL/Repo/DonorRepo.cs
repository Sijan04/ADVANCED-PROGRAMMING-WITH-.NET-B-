using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    class DonorRepo : IRepo<Donor, int, Donor>      
    {

        BloodDonateEntities db;
        private Donor obj;

        internal DonorRepo()
        {
            db = new BloodDonateEntities();
        }
        public  Donor  ADD(Donor obj)
        {
            db.Donors.Add(obj);
            db.SaveChanges();
            return obj;
        }

        public Donor Authenticate(string uname, string pass)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            db.Donors.Remove(db.Donors.Find(id));
            return db.SaveChanges()>0;            //savachanges means it's returen numeric value(1,2,3)
           

        }

        public List<Donor> Get()
        {
            return db.Donors.ToList();
        }
            
        public Donor Get(int id)
        {
            return db.Donors.Find(id);
        }

        public bool Update(Donor OBJ)
        {
            var ext = db.Donors.Find(obj.Id);
            db.Entry(ext).CurrentValues.SetValues(OBJ);
            return db.SaveChanges()>0;
        }
    }
}
