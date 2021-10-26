using Microsoft.AspNetCore.Mvc.ApplicationModels;
using ModelLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.Features;

namespace DR_Rest.Manager
{
    public class Manager : IManager
    {

        private static readonly List<Model> _data = new List<Model>()

        {
            new Model(1, "Eminem", "When im gone", 120, 2006),
            new Model(2, "Lukas graham", "Drunken", 150, 2015)
        };
        public bool Create(Model value)
        {
            _data.Add(value);
            return true;
        }

        public Model Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Model> Get()
        {
            return new List<Model>(_data);
        }

        public Model Get(int id)
        {
            if (_data.Exists(i => i.Id == id))
            {
                return _data.Find(i => i.Id == id);
            }

            throw new KeyNotFoundException();
        }

        public IEnumerable<Model> GetfromSubstring(string s)
        {
            return _data.Where(i => i.Title.ToLower().Contains(s.ToLower()));
        }

        public IEnumerable<Model> GetWithFilther(FilterItem filter)
        {
            if (filter.LowYear > 0 && filter.HighYear == 0)
            {
                return _data.Where(i => i.PublicYear >= filter.LowYear);
            } else if (filter.HighYear > filter.LowYear)
            {
                return _data.Where(i => i.PublicYear >= filter.LowYear && i.PublicYear <= filter.HighYear);
            }
            else
            {
                return _data;
            }
        }

        public bool Update(int id, Model value)
        {
            return true;
            //hej
        }
    }
}
