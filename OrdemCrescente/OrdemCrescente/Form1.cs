using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdemCrescente
{
    public partial class frmOrdemCrescente : Form
    {
        public frmOrdemCrescente()
        {
            InitializeComponent();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txtNum1.Text);
            int n2 = int.Parse(txtNum2.Text);
            int n3 = int.Parse(txtNum3.Text);

            if (n1 == n2 || n1 == n3 || n2 == n3)
            {
                MessageBox.Show("ATENÇÃO. Os número devem ser distintos.");
            }
            else if (n1 < n2 && n2 < n3)
            {
                MessageBox.Show(n1 + " - " + n2 + " - " + n3);
            }
            else if (n1 < n3 && n3 < n2)
            {
                MessageBox.Show(n1 + " - " + n3 + " - " + n2);
            }
            else if (n2 < n1 && n1 < n3)
            {
                MessageBox.Show(n2 + " - " + n1 + " - " + n3);
            }
            else if (n2 < n3 && n3 < n1)
            {
                MessageBox.Show(n2 + " - " + n3 + " - " + n1);
            }
            else if (n3 < n1 && n1 < n2)
            {
                MessageBox.Show(n3 + " - " + n1 + " - " + n2);
            }
            else if (n3 < n2 && n2 < n1)
            {
                MessageBox.Show(n3 + " - " + n2 + " - " + n1);
            }
        }
    }
}
