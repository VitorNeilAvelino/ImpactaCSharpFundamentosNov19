using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpFundamentos.Capitulo03.Troco
{
    public partial class TrocoForm : Form
    {
        public TrocoForm()
        {
            InitializeComponent();
        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            decimal valorCompra = Convert.ToDecimal(valorCompraTextBox.Text);
            var valorPago = Convert.ToDecimal(valorPagoTextBox.Text);
            //var x = decimal.Parse();

            var troco = valorPago - valorCompra;

            trocoTextBox.Text = troco.ToString("C");
            //trocoTextBox.Text = Convert.ToString(troco, );

            // Convert arredonda!
            //int moedas1Real = Convert.ToInt32(troco);

            var moedas = new decimal[] { 1, 0.5m, 0.25m, 0.1m, 0.05m, 0.01m };

            //for (int i = 0; i < moedas.Length; i++)
            //{
            //    moedasListView.Items[i].Text = ((int)(troco / moedas[i])).ToString();
            //    troco %= moedas[i];
            //}

            var j = 0;
            foreach (var moeda in moedas)
            {
                moedasListView.Items[j++].Text = ((int)(troco / moeda)).ToString();
                troco %= moeda;
            }

            //var moedas1Real = (int)(troco / 1);
            //troco %= 1;

            //var moedas50 = (int)(troco / 0.5m);
            //troco %= 0.5M;

            //var moedas25 = (int)(troco / 0.25m);
            //troco %= 0.25m;

            //var moedas10 = (int)(troco / 0.1m);
            //troco %= 0.1m;

            //var moedas5 = (int)(troco / 0.05m);
            //troco %= 0.05m;

            //var moedas1 = (int)(troco / 0.01m);
            //troco %= 0.01m;

            //moedasListView.Items[0].Text = moedas1Real.ToString();
            //moedasListView.Items[1].Text = moedas50.ToString();
            //moedasListView.Items[2].Text = moedas25.ToString();
            //moedasListView.Items[3].Text = moedas10.ToString();
            //moedasListView.Items[4].Text = moedas5.ToString();
            //moedasListView.Items[5].Text = moedas1.ToString();
        }
    }
}
