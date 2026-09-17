using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _KonomenovKirillMikhailovich__PR03_GIT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowDateTime_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss"),
                   "Текущая дата и время");
        }
    }
}
