using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoGeradorSenhaDesktop
{
    public partial class Form2 : Form
    {

        public Form2()
        {
          InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
          Form3 informacao = new Form3();
          this.Hide();
          informacao.ShowDialog();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
          richTextBox1.ReadOnly = true;
            
          this.button1.Enabled = true;

          this.button2.Enabled = true;

          this.button3.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          label4.Visible = false;

          var senhaGerada = new GeradorSenha();
          richTextBox1.Text = senhaGerada.GerarSenha();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          richTextBox1.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(richTextBox1.Text))
            {
                label4.Visible = true;
                return;
            }
            Clipboard.SetText(richTextBox1.Text);
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
