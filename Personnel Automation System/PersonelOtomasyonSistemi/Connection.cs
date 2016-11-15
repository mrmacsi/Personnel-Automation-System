using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;

namespace PersonelOtomasyonSistemi
{
    class Connection
    {
        public SqlCommand cmd = new SqlCommand();
        public SqlConnection con;
        public Connection()
        {
            con = new SqlConnection("Server=DESKTOP-N56SGEO\\SQLEXPRESS; Initial Catalog=PersonelDB;Integrated Security=SSPI");
            
        }
       
        
        public void insertTable(string sqlQuery)
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sqlQuery;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void updateTable(string sqlQuery)
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sqlQuery;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public ArrayList selectTable(string sqlQuery)
        {
            int count = 0;
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = sqlQuery;
            SqlDataReader dr = cmd.ExecuteReader();

            ArrayList Isimler = new ArrayList();

            while (dr.Read())
            {
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    Isimler.Add(dr[i]);
                }
                count++;
            }
            dr.Close();
            con.Close();
            return Isimler;
        }
    }
}
