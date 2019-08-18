using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBebidas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategoria.SelectedItem.ToString() == "Refrigerantes") 
            {
                chkRetornável.Enabled = true;
                txtSabor.Enabled = false;
                txtSafra.Enabled = false;
                txtTipo.Enabled = false;
            }
            else if (cmbCategoria.SelectedItem.ToString() == "Suco") 
            {
                chkRetornável.Enabled = false;
                txtSabor.Enabled = true;
                txtSafra.Enabled = false;
                txtTipo.Enabled = false;
            }
            else if (cmbCategoria.SelectedItem.ToString() == "Vinho") 
            {
                chkRetornável.Enabled = false;
                txtSabor.Enabled = false;
                txtSafra.Enabled = true;
                txtTipo.Enabled = true;
            }
        }
    }
}
