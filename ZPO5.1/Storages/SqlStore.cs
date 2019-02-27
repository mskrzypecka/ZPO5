using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPO5.Interfaces;

namespace ZPO5
{
    public class SqlStore : IStore
    {
        string connection;

        public SqlStore(string connection)
        {
            this.connection = connection;
        }

        public string Read(string id)
        {
            using (var db = new SqlConnection(connection))
            {
                SqlCommand command = db.CreateCommand();
                command.CommandText = $"SELECT {id} FROM some_table";
                SqlDataReader reader = command.ExecuteReader();

                return reader.GetString(0);
            }
        }

        public bool Save(string id, string message)
        {
            using (var db = new SqlConnection(connection))
            {
                SqlCommand command = db.CreateCommand();
                command.CommandText = $"INSERT INTO some_table ({id}) VALUES ({message})";
                SqlDataReader reader = command.ExecuteReader();

                return true;
            }
        }

        public FileInfo GetFileInfo(string name)
        {
            throw new NotImplementedException();
        }
    }
}
