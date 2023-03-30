using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Drawing.Text;

namespace Login_Senha
{
    public partial class Form1 : Form
    {
        Thread nt;//Criação de thread como 'se fosse uma variavel'
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

       

        
        private void Form2(object obj)
        {
            Application.Run(new Form2());
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtBoxLogin.Text == "Admin" && txtBoxSenha.Text == "12345")
            {
                //MessageBox.Show("Bem-Vindo ao sistema!", "Acesso ao sistema liberado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();//Neste caso iremos já fechar o primeiro formulario e iremos já "cadastrado"
                nt = new Thread(Form2);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }
            else
            {
                MessageBox.Show("Você digitou senha ou usuario invalidos, por favor tente novamente", "Erro ao logar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
