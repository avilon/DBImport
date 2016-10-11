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
    public delegate void ChangeDataFolder(string newFolder);

    public partial class LoadParamsView : Form
    {
        public LoadParamsView()
        {
            InitializeComponent();
        }

        public ChangeDataFolder changeDataFolder;

        private void bbChoice_Click(object sender, EventArgs e)
        {
            if (fbDialog.ShowDialog() == DialogResult.OK)
            {
                tbDataFolder.Text = fbDialog.SelectedPath;
                if (changeDataFolder != null)
                {

                }
            }
        }
    }
}
