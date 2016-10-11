using DBImport.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBImport
{
    public delegate void CurrentRow(int rownum);
    /// <summary>
    /// Выполняет импорт отдельной таблицы
    /// </summary>
    internal class ItemImporter
    {
        internal ItemImporter(string fileName)
        {
            this.fileName = fileName;
            conn = new DBConnection();
        }

        internal void Execute(IEntity entity)
        {
            using(StreamReader reader = new StreamReader(fileName))
            {
                int n = 0;
                conn.Open();
                reader.ReadLine();
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    entity.Read(line);
                    conn.InsertData(entity);
                    n++;

                    if (currentRow != null)
                    {
                        currentRow(n);
                    }
                }
                conn.Close();
            }
        }

        internal CurrentRow currentRow;

        private string fileName;
        private DBConnection conn;
    }
}
