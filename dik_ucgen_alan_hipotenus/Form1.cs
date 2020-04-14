using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dik_ucgen_alan_hipotenus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hesaplaBtn_Click(object sender, EventArgs e)
        {
            Ucgen dikUcgen = new Ucgen();
            dikUcgen.ilkKenar = Convert.ToDouble(txtIlkKenar.Text);
            dikUcgen.ikinciKenar = Convert.ToDouble(txtIkinciKenar.Text);
            lblAlan.Text = "Alan = " + dikUcgen.Alan();
            lblHipotenus.Text = "Hipotenüs = " + dikUcgen.Hipotenus();
        }
    }

    class Ucgen
    {
        double IlkKenar;
        public double ilkKenar
        {
            get { return IlkKenar; }
            set
            {
                if (value <= 0)
                    IlkKenar = 1;
                else
                    IlkKenar = value;
            }
        }
        double IkinciKenar;
        public double ikinciKenar
        {
            get { return IkinciKenar; }
            set
            {
                if (value <= 0)
                    IkinciKenar = 1;
                else
                    IkinciKenar = value;
            }
        }
        public double Alan()
        {
            double ucgenAlan = 0;
            ucgenAlan = (IlkKenar * IkinciKenar) / 2;
            return ucgenAlan;
        }

        public double Hipotenus()
        {
            double ucgenHipotenus = 0;
            ucgenHipotenus = Math.Sqrt((Math.Pow(IlkKenar, 2) + Math.Pow(IkinciKenar, 2)));
            return ucgenHipotenus;
        }
    }
}
