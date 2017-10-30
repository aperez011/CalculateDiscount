using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Caculator.Entities;
using Caculator;

namespace UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCalular_Click(object sender, EventArgs e)
        {
            SalarioDesc result = DiscountCalculator.Current.GetDiscounts(double.Parse(txtSalario.Text));

            lbSalarioMensual.Text = double.Parse(txtSalario.Text).ToString("C2");

            #region [ First Quincena ]

            lbQ1.Text = decimal.Round(decimal.Parse(result.SalarioQuicenal.ToString()), 2).ToString("C2");

            lbArs1.Text = decimal.Round(decimal.Parse(result.ArsQuincenal.ToString()), 2).ToString("C2");

            lbAfp1.Text = decimal.Round(decimal.Parse(result.AfpQuincenal.ToString()), 2).ToString("C2");

            lbTD1.Text = decimal.Round(decimal.Parse((result.ArsQuincenal + result.AfpQuincenal).ToString()), 2).ToString("C2");

            lbIRS1.Text = decimal.Round(decimal.Parse(result.IrsQuincenal.ToString()), 2).ToString("C2");

            lbTotalD1.Text = decimal.Round(decimal.Parse((result.IrsQuincenal + result.ArsQuincenal + result.AfpQuincenal).ToString()), 2).ToString("C2");

            lbTotal.Text = decimal.Round(decimal.Parse(((result.SalarioBruto / 2) - (result.IrsQuincenal + result.ArsQuincenal + result.AfpQuincenal)).ToString()), 2).ToString("C2");

            #endregion

            #region [ First Quincena ]

            lbQ2.Text = decimal.Round(decimal.Parse(result.SalarioQuicenal.ToString()), 2).ToString("C2");

            lbArs2.Text = decimal.Round(decimal.Parse(result.ArsQuincenal.ToString()), 2).ToString("C2");

            lbAfp2.Text = decimal.Round(decimal.Parse(result.AfpQuincenal.ToString()), 2).ToString("C2");

            lbTD2.Text = decimal.Round(decimal.Parse((result.ArsQuincenal + result.AfpQuincenal).ToString()), 2).ToString("C2");

            lbIRS2.Text = decimal.Round(decimal.Parse(result.IrsQuincenal.ToString()), 2).ToString("C2");

            lbTotalD2.Text = decimal.Round(decimal.Parse((result.IrsQuincenal + result.ArsQuincenal + result.AfpQuincenal).ToString()), 2).ToString("C2");

            lbTotal2.Text = decimal.Round(decimal.Parse(((result.SalarioBruto / 2) - (result.IrsQuincenal + result.ArsQuincenal + result.AfpQuincenal)).ToString()), 2).ToString("C2");

            #endregion
        }

        private void Clear()
        {
            #region [ First Quincena ]

            lbQ1.Text = "-";

            lbArs1.Text = "-";

            lbAfp1.Text = "-";

            lbTD1.Text = "-";

            lbIRS1.Text = "-";

            lbTotalD1.Text = "-";

            lbTotal.Text = "-";

            #endregion

            #region [ First Quincena ]

            lbQ2.Text = "-";

            lbArs2.Text = "-";

            lbAfp2.Text = "-";

            lbTD2.Text = "-";

            lbIRS2.Text = "-";

            lbTotalD2.Text = "-";

            lbTotal2.Text = "-";

            #endregion
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtSalario.Clear();

            this.Clear();

            txtSalario.Focus();
        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
