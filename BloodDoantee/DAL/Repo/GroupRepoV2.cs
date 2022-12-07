using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class GroupRepoV2 : IRepo<Group, int, bool>
    {
        public bool ADD(Group OBJ)
        {
            throw new NotImplementedException();
        }

        public Group Authenticate(string uname, string pass)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Group> Get()
        {
            throw new NotImplementedException();
        }

        public Group Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Group OBJ)
        {
            throw new NotImplementedException();
        }
    }
}
