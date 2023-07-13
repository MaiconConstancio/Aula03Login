using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula03Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void CaixaDoLogin_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void CaixaDaSenha_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Conectar_Click(object sender, EventArgs e)
        {
            string nome;
            string senha;
            nome = CaixaDoLogin.Text;
            senha = CaixaDaSenha.Text;

            if ( nome == "Mike" && senha == "123")
            {
                //MessageBox.Show($"Seja bem-vindo {nome}! :D");
                MessageBox.Show("Você conectou!");
                this.Size = new Size(481, 270);
                TITULO.Location = new Point(167, 20);
                panelSaldo.Show();
            }
            else
            {
                MessageBox.Show("Login ou Senha incorreto!");

            }

            /////////////////////////////
            //DEIXAR O PAINEL VISIVEL

            //(Minha variavel painel se achama "painelSaldo")
            //panelSaldo.Show();
            //panelSaldo.Hide(); //ESCONDE DNV
            //ou
            //painelSaldo.Visible = true;



        }

        private void TITULO_Click(object sender, EventArgs e)
        {

        }
    }
}
