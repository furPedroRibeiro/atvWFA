using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atvDes
{
    public partial class cadastrar : Form
    {
        public cadastrar()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cadastroBtn_Click(object sender, EventArgs e)
        {
            string rm = TB_rm.Text;
            string nome = TB_nome.Text;
            string telefone = TB_telefone.Text;
            string senha = TB_senha.Text;

            aviso.Text = "Usuário cadastrado";
        }
        private void aviso_Click(object sender, EventArgs e)
        {

        }
    }
}
