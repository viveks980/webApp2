﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2
{
    public interface UserInterface
    {
         ResponseModel adduser(user objmodel);

        List<user> getprojectdetails();
        

    }
}
