using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace LogonViaAD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Importação da DLL
        [DllImport("advapi32.dll")]
        //Parametros para Logar no AD 
        public static extern bool LogonUser(string nome, string domain, string pass, int logType, int logpv, ref IntPtr pht);

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IntPtr th = IntPtr.Zero;
            bool log = LogonUser(TXTBuser.Text, "semed-ni.intra", TXTBpass.Text, 2, 0, ref th);
            if (log)
            {
                MessageBox.Show("Olá no AD!");
            }
            else
            {
                MessageBox.Show("Senha ou Usuário errado");
            }
        }
    }
}
