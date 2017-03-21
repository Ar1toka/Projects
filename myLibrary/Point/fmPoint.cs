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

namespace Point
{
    public partial class fmPoint : Form
    {
        public fmPoint()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsPoint2D a = new clsPoint2D();

            clsPoint3D b = new clsPoint3D();

            string c;

            a.x = 10;

            a.y = 20;

            b.z = 30;

            c = ("Длина равна: "+ b.length().ToString());

            MessageBox.Show(c);

        }
    }
}
