using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBImport.Entities
{
    public interface IEntity
    {
        void Read(string line);
        string GetInsertSql();
    }
}
