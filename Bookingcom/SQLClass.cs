using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookingcom
{
    public static class SQLClass
    {
        public const string CONNECTION_STRING =
            "SslMode=none; Server=localhost; Database=booking2; port=3306; Uid=root;";

        public static MySqlConnection conn;

        /// <summary>
        /// Функция SELECT-запроса
        /// </summary>
        public static List<string> MySelect(string cmdText)
        {
            List<string> list = new List<string>();

            MySqlCommand cmd = new MySqlCommand(cmdText, conn);
            DbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    list.Add(reader.GetString(i));
                }
            }
            reader.Close();

            return list;
        }

        /// <summary>
        /// Функция INSERT-запроса
        /// </summary>
        public static void MyUpDate(string cmdText)
        {
            MySqlCommand cmd = new MySqlCommand(cmdText, conn);
            DbDataReader reader = cmd.ExecuteReader();
            reader.Close();
        }
    }
}
