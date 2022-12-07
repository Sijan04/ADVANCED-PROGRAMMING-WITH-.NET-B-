using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
     class UserRepo : IRepo<User, string, User>, IAuth
    {
        public User ADD(User OBJ)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<User> Get()
        {
            throw new NotImplementedException();
        }

        public User Get(string id)
        {
            throw new NotImplementedException();
        }

        public bool Update(User OBJ)
        {
            throw new NotImplementedException();
        }


        public User Authenticate(string uname, string pass)
        {
            return null;
        }

    }
}
