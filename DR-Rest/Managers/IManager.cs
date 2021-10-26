using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using ModelLib;

namespace DR_Rest.Manager
{
    interface IManager
    {
        IEnumerable<Model> Get();

        Model Get(int id);

        IEnumerable<Model> GetfromSubstring(string s);

        IEnumerable<Model> GetWithFilther(FilterItem filter);

        bool Create(Model value);

        bool Update(int id, Model value);

        Model Delete(int id);




    }
}
