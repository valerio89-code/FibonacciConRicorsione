using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int numeroIterazioni = 2;
        private void btn_mostra_Click(object sender, EventArgs e)
        {
            lvw_fibonacci.Items.Clear();
            numeroIterazioni = 2;
            int.TryParse(tbx_numeriDaMostrare.Text, out int numeroElementiDaMostrare);
            lvw_fibonacci.Items.Add("0");
            lvw_fibonacci.Items.Add("1");
            MostraNumeriNellaView(0, 1, numeroElementiDaMostrare);
        }

        private void MostraNumeriNellaView(int f1, int f2, int numeroElementiDaMostrare)
        {
            if (numeroIterazioni < numeroElementiDaMostrare)
            {
                numeroIterazioni++;
                var somma = f1 + f2;
                lvw_fibonacci.Items.Add(somma.ToString());
                MostraNumeriNellaView(f2, somma, numeroElementiDaMostrare);
            }
        }

        private void btn_verificaNumero_Click(object sender, EventArgs e)
        {
            int.TryParse(tbx_numeroDaVerificare.Text, out int numeroDaVerificare);
            VerificaPresenzaNumero(numeroDaVerificare, 0, 1);
        }

        private void VerificaPresenzaNumero(int numeroDaVerificare, int f1, int f2)
        {
            var somma = f1 + f2;
            if (somma == numeroDaVerificare || numeroDaVerificare == 0)
            {
                MessageBox.Show("Il numero è presente nella sequenza");
                return;
            }
            if (somma <= numeroDaVerificare)
            {
                VerificaPresenzaNumero(numeroDaVerificare, f2, somma);
            }
            else
            {
                MessageBox.Show("In numero non è presente nella sequenza");
            }
        }
    }
}
