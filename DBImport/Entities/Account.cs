using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBImport.Entities
{
    public class Account : IEntity
    {
        public string Id { get; private set; }
        public string CisDivision { get; private set; }
        public string BillCycCd { get; private set; }
        public DateTime EffDt { get; private set; }
        public string MailPremId { get; private set; }

        public void Read(string line)
        {
            string[] list = line.Split(';');
            Id = ClearString(list[0]);
            BillCycCd = ClearString(list[1]);
            EffDt = Convert.ToDateTime(ClearString(list[2]));
            CisDivision = ClearString(list[3]);
            MailPremId = ClearString(list[4]);
        }

        public string GetInsertSql()
        {
            string sql = "insert into account(id, cis_division, bill_cyc_cd, setup_dt, mail_prem_id)";
            sql += " values(";
            sql += "'" + Id + "', ";
            sql += "'" + CisDivision + "', ";
            sql += "'" + BillCycCd + "', ";
            sql += "'" + EffDt.ToShortDateString() + "', ";
            sql += "'" + MailPremId + "')";

            return sql;
        }

        private string ClearString(string str)
        {
            return str.Replace('"', ' ').Trim();
        }

    }
}
