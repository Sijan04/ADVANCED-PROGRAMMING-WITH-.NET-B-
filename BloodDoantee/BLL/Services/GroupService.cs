using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Group = DAL.EF.Group;

namespace BLL.Services
{
    public class GroupService
    {
        public static List<GroupDTO> GetGroups()   //using Auto mapper we connected between two class
        {
          var data=  DataAccessFactory.GroupDataAccess().Get();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Group, GroupDTO>());
            var mapper=new Mapper(config);
            var groups=mapper.Map<List<GroupDTO>>(data);  //List convert data by list
            return groups;
        }
        public static GroupDTO Get(int id)
        {
            var data= DataAccessFactory.GroupDataAccess().Get(id);

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Group, GroupDTO>());
            var mapper = new Mapper(config);
           var group=mapper.Map<GroupDTO>(data);
            return group;


        }
        public static bool Add(GroupDTO dto)
        {

            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<GroupDTO, Group>();
                cfg.CreateMap<Group, GroupDTO>();
            });
            var mapper = new Mapper(config);
            var group = mapper.Map<Group>(dto);
            var result =DataAccessFactory.GroupDataAccess().ADD(group);
            return result;
        }

       // public static object Get()
       // {
       //     throw new NotImplementedException();
       // }
    }
}
