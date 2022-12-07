using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
      class GrpRepo : IRepo<Group, int, bool>           // All REPO internal
    {
        BloodDonateEntities db;
        internal GrpRepo()
        {
            db = new BloodDonateEntities();
        }
        public bool ADD(Group OBJ)
        {
            db.Groups.Add(OBJ);
            return db.SaveChanges() > 0;


        }

        public Group Authenticate(string uname, string pass)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
           var ext=db.Groups.Find(id);
            db.Groups.Remove(ext);
            return db.SaveChanges() > 0;

        }

        public List<Group> Get()
        {
            return db.Groups.ToList();
        }

        public Group Get(int id)
        {
            return db.Groups.Find(id);
        }

        public bool Update(Group OBJ)
        {
            var ext = Get(OBJ.Id);
            db.Entry(ext).CurrentValues.SetValues(OBJ);
            return db.SaveChanges() > 0;
        }
    }
}
