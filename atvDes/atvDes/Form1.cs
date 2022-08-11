using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atvDes
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            
        }
        private void wordOpt_Click(object sender, EventArgs e)
        {
            Process prcExecutor = new Process();
            prcExecutor.StartInfo.FileName = "C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\Word 2016";
            prcExecutor.Start();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Process prcExecutor = new Process();
            prcExecutor.StartInfo.FileName = "Calc.Exe";
            prcExecutor.Start();
        }

        private void itemProgramasCadastrar_Click(object sender, EventArgs e)
        {
            Process prcExecutor = new Process();
            prcExecutor.StartInfo.FileName = "C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\Word 2016";
            prcExecutor.Start();
        }

        private void statusStripMsg_Click(object sender, EventArgs e)
        {

        }

        private void sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //excelOPT
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Process prcExecutor = new Process();
            prcExecutor.StartInfo.FileName = "C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\Excel 2016";
            prcExecutor.Start();
        }

        //blocoDeNotasOpt
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Process prcExecutor = new Process();
            prcExecutor.StartInfo.FileName = "C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\Accessories\\Paint";
            prcExecutor.Start();
        }

        private void printOpt_Click(object sender, EventArgs e)
        {
            Process prcExecutor = new Process();
            prcExecutor.StartInfo.FileName = "C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\Accessories\\WordPad";
            prcExecutor.Start();
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process prcExecutor = new Process();
            prcExecutor.StartInfo.FileName = "C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\Excel 2016";
            prcExecutor.Start();
        }

        private void blocoDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process prcExecutor = new Process();
            prcExecutor.StartInfo.FileName = "C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\Accessories\\Paint";
            prcExecutor.Start();
        }

        private void ferramentaDeCapturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process prcExecutor = new Process();
            prcExecutor.StartInfo.FileName = "C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\Accessories\\WordPad";
            prcExecutor.Start();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process prcExecutor = new Process();
            prcExecutor.StartInfo.FileName = "Calc.Exe";
            prcExecutor.Start();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cadastrar var = new cadastrar();
            var.ShowDialog();
        }

        private void exibirRodapé_Click(object sender, EventArgs e)
        {
            exibirRodapé.Text = "Atualizar rodapé";
            statusStripMsg.Text = "Bem vindo ao útil";
            strData.Text = DateTime.Now.ToString("dd/MMM/yyyy");
            strHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
