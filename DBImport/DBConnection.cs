using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Npgsql;
using DBImport.Entities;

namespace DBImport
{
    public class DBConnection
    {
        public DBConnection()
        {
            conn = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=DBPartizan;Database=postgres;");
            command = new NpgsqlCommand("", conn);
        }

        public void Open()
        {
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Error :S");
            }
        }

        public void Close()
        {
            try
            {
                conn.Close();
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Error :S");
            }
        }

        public void InsertData(IEntity entity)
        {
            string sql = entity.GetInsertSql();
            command.CommandText = sql;
            command.ExecuteNonQuery();
        }

        NpgsqlCommand command;
        NpgsqlConnection conn;
    }
}
