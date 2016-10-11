using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBImport
{
    public partial class ShowProcessView : Form
    {
        public ShowProcessView()
        {
            InitializeComponent();

        }

        public void Execute()
        {
            impProcessor = new ImpProcessor();
            impProcessor.processRow = ProcessRow;
            impProcessor.Execute();
        }

        private void ProcessRow(string objName, int n)
        {
            if ((n % 100) == 0)
            {
                lbCopyFileName.Text = objName;
                lbProcess.Text = n.ToString();
                Application.DoEvents();
            }
        }

        private ImpProcessor impProcessor;

    }
}
