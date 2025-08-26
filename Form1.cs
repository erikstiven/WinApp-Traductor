using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppTraductor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            abrirPanel(new FormPrincipal());
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            //panel_Submenu.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Subpanel1.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnIalE_Click(object sender, EventArgs e)
        {
            abrirPanel(new WinAppIngEsp.btn_Cerrar());

        }


        public void abrirPanel( object FormHija)
        {
            if (panel2.Controls.Count > 0)
            {
                panel2.Controls.RemoveAt(0);
            }
            Form x = FormHija as Form;
            x.TopLevel = false;
            x.Dock = DockStyle.Fill;
            panel2.Controls.Add(x);
            panel2.Tag = x;
            x.Show();
        }

        private void btnEalI_Click(object sender, EventArgs e)
        {
            abrirPanel(new WinAppEspIngles.Form1());
        }

        private void btnQalE_Click(object sender, EventArgs e)
        {
            abrirPanel(new WinAppQuiEsp.Form1());
        }

        private void btnEsalQ_Click(object sender, EventArgs e)
        {
            abrirPanel(new winAppEspQui.Form1());
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            abrirPanel(new FormPrincipal());
        }
    }
}
