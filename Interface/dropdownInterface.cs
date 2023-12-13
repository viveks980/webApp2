using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Interface
{
    public interface dropdownInterface
    {
        List<clientList> GetClientList();
        ResponseModel deleteProject(int id);
        user editProject(int id);
        ResponseModel updateuser(user objmodel);
    }
}
