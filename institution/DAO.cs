using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace institution
{
    public class DAO : MySql
    {
        public static string[] param_co;
        private string Table;

        public DAO(string BD, string Pass, string User, string Server, string Port, string Table) : base(BD, Pass, User, Server,Port)
        {
            this.Table = Table;
            param_co = new string[5];
            param_co[0] = BD;
            param_co[1] = Pass;
            param_co[2] = User;
            param_co[3] = Server;
            param_co[4] = Port;
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