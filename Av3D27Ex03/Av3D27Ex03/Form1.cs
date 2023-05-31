using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Av3D27Ex03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int anos = 0, meses = 0, dias = 0, diasano = 0, diasmes = 0;

            anos = int.Parse(txtanos.Text);
            meses = int.Parse(txtmeses.Text);
            dias = int.Parse(txtdias.Text);

            diasano = anos * 365;
            diasmes = meses * 30;

            dias = dias + diasano + diasmes;

            lblresult.Text = dias.ToString();

        }
    }
}
