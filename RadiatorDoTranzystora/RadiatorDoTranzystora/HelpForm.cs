using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RadiatorDoTranzystora;

namespace RadiatorDoTranzystora
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
            Form111 frm = new Form111();
            this.Text = frm.Text+" - Pomoc";

        }
    }
}
