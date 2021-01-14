using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        

        private void button1_Click(object sender, EventArgs e)
        {
           int ValorA = Convert.ToInt32(TXT_Box_soma_A.Text);
           int ValorB = Convert.ToInt32(TXT_Box_soma_B.Text);
           int ResoltadoSoma = ValorA + ValorB;
           MessageBox.Show(Convert.ToString(ResoltadoSoma));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ValorA = Convert.ToInt32(TXT_Box_soma_A.Text);
            int ValorB = Convert.ToInt32(TXT_Box_soma_B.Text);
            int ResoltadoSub = ValorA - ValorB;
            MessageBox.Show(Convert.ToString(ResoltadoSub));

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
