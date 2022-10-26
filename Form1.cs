using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UdvGomb_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(nevmez.Text))
            {

                MessageBox.Show("Nincsen a név megadva!", "Hiányzó adat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (Szulmez.Text == "")
            {

                MessageBox.Show("Nincsen a születési dátum megadva!", "Hiányzó adat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (string.IsNullOrEmpty(Varosmez.Text))
            {

                MessageBox.Show("Nincsen a város megadva!", "Hiányzó adat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (azonmez.Value == 0)
            {

                MessageBox.Show("Nincsen a azonosító megadva!", "Hiányzó adat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (!angolgom.Checked && !nemegomb.Checked && !franciagomb.Checked && !olaszgomb.Checked)
            {

                MessageBox.Show("Nincsen a nyelv megadva!", "Hiányzó adat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            else
            {

                MessageBox.Show("Minden adatot megadott!", "Adat", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            
        }
    }
}
