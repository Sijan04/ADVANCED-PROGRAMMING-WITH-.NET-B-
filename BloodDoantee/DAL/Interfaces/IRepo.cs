using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IRepo <CLASS,ID,RESULT>     //Interface public
    {
        List<CLASS> Get();

        CLASS Get(ID id);

        RESULT ADD(CLASS OBJ);

        bool Delete(ID id);

        bool Update(CLASS OBJ);

        CLASS Authenticate(string uname, string pass);
       
    }
}
