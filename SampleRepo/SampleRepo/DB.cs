using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SampleRepo
{
    public static class DB
    {        
        private static string conn_string = "Server=localhost;Database=samplerepo;Uid=samplerepo_user;Pwd=pass;";
        private static MySQLDatabase db = new MySQLDatabase(conn_string);

        public static int Execute(string sql, Dictionary<string, object> parameters) => db.Execute(sql, parameters);

        public static List<Dictionary<string, string>> GetAllUsers() => db.Query("select * from users", null);

        public static Dictionary<string, string> GetUserById(int id)
        {
            return db.Query("select * from users where id=@id",
                new Dictionary<string, object>()
                {
                    { "@id" , id }
                }).FirstOrDefault();
        }

        //public static List<List<object>> Select(string table, string cols = "*", string where = "")
        //{
        //    List<List<object>> rows;

        //    using (MySqlConnection conn = new MySqlConnection(conn_string))
        //    {
        //        conn.Open();
        //        MySqlCommand cmd = conn.CreateCommand();
        //        string sql = "select " + cols + " from " + table;
        //        if (!String.IsNullOrEmpty(where))
        //        {
        //            sql += where;
        //        }
        //        cmd.CommandText = sql;
        //        MySqlDataReader reader = cmd.ExecuteReader();
        //        rows = new List<List<object>>();
        //        while (reader.Read())
        //        {
        //            List<object> row = new List<object>();
        //            for (int i = 0; i < reader.FieldCount; i++)
        //            {
        //                row.Add(reader[i]);
        //            }
        //            rows.Add(row);
        //        }
        //        conn.Close();
        //    }
        //    return rows;
        //}
        //public static List<List<object>> GetUsers()
        //{
        //    return Select("users");
        //}
        //public static List<object> GetUserById(object id)
        //{
        //    return Select("users", where: "id=" + id).FirstOrDefault();
        //}
        //public static List<object> GetUserByEmail(string email)
        //{
        //    List<List<object>> list = Select("users", where: "where email=" + email);
        //    return list.FirstOrDefault();
        //}
        //public static object GetUserPassword(object id)
        //{
        //    GetUserById(id)
        //}
    }
}