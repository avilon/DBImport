using DBImport.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBImport
{
    internal delegate void ProcessRow(string objName, int rownum);

    internal class ImpProcessor
    {
        internal ImpProcessor()
        {
        }

        internal string RootFolder { get; set; }

        internal void Execute()
        {
            string file = "E:\\Data\\ci_acct.csv";
            ItemImporter imp = new ItemImporter(file);
            imp.currentRow = LoadingProcess;

            imp.Execute(new Account());
        }
        internal ProcessRow processRow = null;

        private void LoadingProcess(int rownum)
        {
            if (processRow != null)
            {
                processRow("account", rownum);
            }
        }
    }
}
