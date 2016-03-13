using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JTTT_1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxIF.Items.Add("Sprawdz opis obrazka na stronie");
            comboBoxIF.Items.Add(" ");

            comboBoxTHEN.Items.Add("Wyślij wiadomość email");
            comboBoxTHEN.Items.Add("Wyślij wiadomość SMS");
        }

      


        private void comboBoxTHEN_SelectedIndexChanged(object sender, EventArgs e)
        {
          

        }

        private void comboBoxIF_SelectedIndexChanged(object sender, EventArgs e)
        {
            htmlService.Visible = (comboBoxIF.Text == "Sprawdz opis obrazka na stronie");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
