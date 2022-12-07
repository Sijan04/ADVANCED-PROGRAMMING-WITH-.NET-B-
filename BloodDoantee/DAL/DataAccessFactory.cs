using DAL.EF;
using DAL.Interfaces;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class   DataAccessFactory              //dataaccessfactory
    {
        public static IRepo<Group ,int, bool> GroupDataAccess()
        {

            return new GrpRepo();
        }

        public static IRepo<Donor,int,Donor> DonorDataAccess()
        {
            return new DonorRepo();
        }

        public static IRepo<User,string,User> UserDataAccess()
        {
            return new UserRepo();
        }
        //example
       public static IAuth AuthDataAccess()    //Abstractions
        {
            return new UserRepo();
        }
    }
}
