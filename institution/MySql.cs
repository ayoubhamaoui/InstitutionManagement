using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace institution
{
    public abstract class MySql
    {
        private MySqlConnection con;
        private MySqlDataReader rs;
        private MySqlCommand st;
        private string BD;
        private string User;
        private string Server;
        private string Port;
        private string Pass;

        protected MySql(string BD,string Pass,string User,string Server,string Port)
        {
            this.BD = BD;
            this.Pass = Pass;
            this.User = User;
            this.Port = Port;
            this.Server = Server;
            con = new MySqlConnection("server="+Server+";user="+User+";" +
                "database="+BD+";port="+Port+";password="+Pass);

        }

        public List<Dictionary<string, string>> Get(string sql)
        {
            throw new System.NotImplementedException();
        }

        public int Up(string sql)
        {
            int resultat = 0;
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                con.Open();

                //Création de la commande MySQL
                st = new MySqlCommand(sql, con);

                //Exécution de la requête
                resultat = st.ExecuteNonQuery();


                //fermer la connexion
                con.Close();
            }
            catch (MySqlException ex)
            {
                con = null;
                Console.WriteLine(ex.ToString());
            }
            return resultat;
        }
    }
}