using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButtonKontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butOdabir_Click(object sender, EventArgs e)
        {
            ispis.Clear();
            ispis.AppendText("Odabrali ste: \r\n");
            if (avion.Checked)
            {
                ispis.AppendText("Avion \r\n");
            }
            if (autobus.Checked)
            {
                ispis.AppendText("Autobus \r\n");
            }
            if (auto.Checked)
            {
                ispis.AppendText("Vlastiti automobil \r\n");
            }
        }
    }
}
