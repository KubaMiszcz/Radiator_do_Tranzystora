using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadiatorDoTranzystora
{
    public partial class Form111 : Form
    {
        float Tjmax, Tamb, U, J, P, Rthjc, Rthcs, Rthsa, Rth, Tj;

        public Form111()
        {
            InitializeComponent();

        }

        private void tbJ_TextChanged(object sender, EventArgs e)
        {
            obliczP();
            obliczRth();
        }

        private void tbU_TextChanged(object sender, EventArgs e)
        {
            obliczP();
            obliczRth();
        }

        private void tbRthjc_TextChanged(object sender, EventArgs e)
        {
            obliczP();
            obliczRth();
        }

        private void tbRthcs_TextChanged(object sender, EventArgs e)
        {
            obliczP();
            obliczRth();
        }

        private void tbRthsa_TextChanged(object sender, EventArgs e)
        {
            obliczP();
            obliczRth();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HelpForm frm = new HelpForm();
            frm.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.kubamiszcz.hekko24.pl/joomla35/index.php");
        }

        private void linkmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //System.Diagnostics.Process proc = new System.Diagnostics.Process();
            //proc.StartInfo.FileName = "mailto:zielonyeufor@gmail.com?subject='mail-Radiator Do Tranzystora'&body='wysłano z programu Radiator do Tranzystora'";
            //proc.Start();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tbP_TextChanged(object sender, EventArgs e)
        {
            obliczP();
            obliczRth();
        }

        private void tbTamb_TextChanged(object sender, EventArgs e)
        {
            obliczP();
            obliczRth();
        }

        private void tbRth_TextChanged(object sender, EventArgs e)
        {
            obliczP();
            obliczRth();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            obliczP();
            obliczRth();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            toolTip1.SetToolTip(tbTamb, "max przewidywana Temp otoczenia");
            toolTip1.SetToolTip(tbU, "napiecie");
            toolTip1.SetToolTip(tbJ, "prad");
            toolTip1.SetToolTip(tbP, "wpisz U i J i samo sie obliczy");
            toolTip1.SetToolTip(tbTjmax, "max Temp złącza");
            toolTip1.SetToolTip(tbRthjc, "Rth miedzy zlaczem a obudowa\n(ta mniejsza wartość z datasheet");
            toolTip1.SetToolTip(tbRthcs, "Rth przekladki (polaczenia miedzy obudowa a radiatorem)\n1 - 2 st/W bez niczego, sam styk,\n0.1 - 0.5 st/W ze smarem pasta itp.");
            toolTip1.SetToolTip(tbRthsa, "Rth radiatora, z katalogu albo na stronie sklepu znajdz poodbny i odczytaj");
            toolTip1.SetToolTip(tbRth, "Rth calkowite");
            toolTip1.SetToolTip(tbTj, "wyliczona Temp złącza");

            toolTip1.SetToolTip(label2, "max przewidywana Temp otoczenia");
            toolTip1.SetToolTip(label5, "napiecie");
            toolTip1.SetToolTip(label4, "prad");
            toolTip1.SetToolTip(label3, "wpisz U i J i samo sie obliczy");
            toolTip1.SetToolTip(label1, "max Temp złącza");
            toolTip1.SetToolTip(label10, "Rth miedzy zlaczem a obudowa\n(ta mniejsza wartość z datasheet");
            toolTip1.SetToolTip(label7, "Rth przekladki (polaczenia miedzy obudowa a radiatorem)\n1 - 2 st/W bez niczego, sam styk,\n0.1 - 0.5 st/W ze smarem pasta itp.");
            toolTip1.SetToolTip(label6, "Rth radiatora, z katalogu albo na stronie sklepu znajdz poodbny i odczytaj");
            toolTip1.SetToolTip(label8, "Rth calkowite");
            toolTip1.SetToolTip(label9, "wyliczona Temp złącza");
            tb2val();
            P = U * J;
            val2tb();

        }

        private void obliczP()
        {
            tb2val();
            P = U * J;
            val2tb();
        }

        private void obliczRth()
        {
            tb2val();
            Rth = Rthjc + Rthcs + Rthsa;
            Tj = Tamb+ P * Rth;
            if (Tj < Tjmax)
            {
                pictureBox1.Image = RadiatorDoTranzystora.Properties.Resources.ok;
                tbTj.BackColor = Color.PeachPuff;
            }
            else
            {
                pictureBox1.Image = RadiatorDoTranzystora.Properties.Resources.error;
                tbTj.BackColor = Color.Red;
            }
            val2tb();
        }


        void tb2val()
        {
            Tjmax = float.Parse(tbTjmax.Text, System.Globalization.CultureInfo.InvariantCulture);
            Tamb = float.Parse(tbTamb.Text, System.Globalization.CultureInfo.InvariantCulture);
            U = float.Parse(tbU.Text, System.Globalization.CultureInfo.InvariantCulture);
            J = 0.001f * float.Parse(tbJ.Text, System.Globalization.CultureInfo.InvariantCulture);
            //P = float.Parse(tbP.Text);
            Rthjc = float.Parse(tbRthjc.Text, System.Globalization.CultureInfo.InvariantCulture);
            Rthcs = float.Parse(tbRthcs.Text, System.Globalization.CultureInfo.InvariantCulture);
            Rthsa = float.Parse(tbRthsa.Text, System.Globalization.CultureInfo.InvariantCulture);
            //Rth = float.Parse(tbRth.Text);
        }

        void val2tb()
        {
            tbP.Text = P.ToString(System.Globalization.CultureInfo.InvariantCulture);
            tbRth.Text = Rth.ToString(System.Globalization.CultureInfo.InvariantCulture);
            tbTj.Text = Tj.ToString(System.Globalization.CultureInfo.InvariantCulture);
        }
    }
}
