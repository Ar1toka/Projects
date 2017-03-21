using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using myLibrary;

namespace WindowsFormsApplication1
{
    public partial class fmTestInherit : Form
    {
        public fmTestInherit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClsA a = new ClsA();

            ClsB b = new ClsB();

            string c;

            a.x = 10;

            b.x = 20;

            c = "a= " + a.x + " b= " + b.x;

            MessageBox.Show(c);

        }
    }
}
