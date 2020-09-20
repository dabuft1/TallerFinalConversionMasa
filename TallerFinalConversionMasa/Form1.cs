using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallerFinalConversionMasa
{
    public partial class Form1 : Form
    {
        ConvertirMasa convertirMasa = new ConvertirMasa();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGramo_Click(object sender, EventArgs e)
        {
            convertirMasa.setKilogramo(double.Parse(txtKg.Text));
            lblGr.Visible = true;
            lblGr.Text = Convert.ToString(convertirMasa.ConvertirAGramas());    
        }

        private void btnDecagramo_Click(object sender, EventArgs e)
        {
            convertirMasa.setKilogramo(double.Parse(txtKg.Text));
            lblDg.Visible = true;
            lblDg.Text = Convert.ToString(convertirMasa.CovertirADecagramos());
        }

        private void btnMiligramo_Click(object sender, EventArgs e)
        {
            convertirMasa.setKilogramo(double.Parse(txtKg.Text));
            lblMg.Visible = true;
            lblMg.Text = Convert.ToString(convertirMasa.ConvertirAMiligramos());
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtKg.Text = String.Empty;
            txtKg.Focus();
            lblGr.Visible = false;
            lblDg.Visible = false;
            lblMg.Visible = false;
        }
    }
}
