using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace institution
{
    public class DAO : MySql
    {
        public string[] param_co;
        private string Table;

        public DAO()
        {
            throw new System.NotImplementedException();
        }

        public List<Dictionary<string, string>> Select()
        {
            throw new System.NotImplementedException();
        }

        public int Update()
        {
            throw new System.NotImplementedException();
        }

        public int insert()
        {
            throw new System.NotImplementedException();
        }

        public int delete(string action,Dictionary<string,string> Data,string conditions)
        {
            throw new System.NotImplementedException();
        }
    }
}