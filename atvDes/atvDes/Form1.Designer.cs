namespace atvDes
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sair = new System.Windows.Forms.ToolStripMenuItem();
            this.wordOptMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.strData = new System.Windows.Forms.ToolStripStatusLabel();
            this.strHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blocoDeNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ferramentaDeCapturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirRodapé = new System.Windows.Forms.ToolStripStatusLabel();
            this.wordOpt = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.printOpt = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(163, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(498, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "SEJA BEM VINDO AO ÚTIL!!!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(111, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(588, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aqui você vai encontrar algumas funções que podem ser úteis para o seu dia a dia";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem1,
            this.cadastrarToolStripMenuItem,
            this.sair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordOptMenu,
            this.excelToolStripMenuItem,
            this.blocoDeNotasToolStripMenuItem,
            this.ferramentaDeCapturaToolStripMenuItem,
            this.calculadoraToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.cadastrarToolStripMenuItem.Text = "Programas";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordOpt,
            this.toolStripButton2,
            this.toolStripButton1,
            this.toolStripButton3,
            this.printOpt});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibirRodapé,
            this.statusStripMsg,
            this.strData,
            this.strHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 26);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sair
            // 
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(38, 20);
            this.sair.Text = "Sair";
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // wordOptMenu
            // 
            this.wordOptMenu.Name = "wordOptMenu";
            this.wordOptMenu.Size = new System.Drawing.Size(193, 22);
            this.wordOptMenu.Text = "Word";
            this.wordOptMenu.Click += new System.EventHandler(this.itemProgramasCadastrar_Click);
            // 
            // statusStripMsg
            // 
            this.statusStripMsg.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.statusStripMsg.Name = "statusStripMsg";
            this.statusStripMsg.Size = new System.Drawing.Size(244, 21);
            this.statusStripMsg.Text = "Aqui sera exibida uma mensagem";
            this.statusStripMsg.Click += new System.EventHandler(this.statusStripMsg_Click);
            // 
            // strData
            // 
            this.strData.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.strData.Name = "strData";
            this.strData.Size = new System.Drawing.Size(42, 21);
            this.strData.Text = "Data";
            // 
            // strHora
            // 
            this.strHora.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.strHora.Name = "strHora";
            this.strHora.Size = new System.Drawing.Size(44, 21);
            this.strHora.Text = "Hora";
            // 
            // excelToolStripMenuItem
            // 
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            this.excelToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.excelToolStripMenuItem.Text = "Excel";
            this.excelToolStripMenuItem.Click += new System.EventHandler(this.excelToolStripMenuItem_Click);
            // 
            // blocoDeNotasToolStripMenuItem
            // 
            this.blocoDeNotasToolStripMenuItem.Name = "blocoDeNotasToolStripMenuItem";
            this.blocoDeNotasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.blocoDeNotasToolStripMenuItem.Text = "Paint";
            this.blocoDeNotasToolStripMenuItem.Click += new System.EventHandler(this.blocoDeNotasToolStripMenuItem_Click);
            // 
            // ferramentaDeCapturaToolStripMenuItem
            // 
            this.ferramentaDeCapturaToolStripMenuItem.Name = "ferramentaDeCapturaToolStripMenuItem";
            this.ferramentaDeCapturaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ferramentaDeCapturaToolStripMenuItem.Text = "WordPad";
            this.ferramentaDeCapturaToolStripMenuItem.Click += new System.EventHandler(this.ferramentaDeCapturaToolStripMenuItem_Click);
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.calculadoraToolStripMenuItem_Click);
            // 
            // cadastrarToolStripMenuItem1
            // 
            this.cadastrarToolStripMenuItem1.Name = "cadastrarToolStripMenuItem1";
            this.cadastrarToolStripMenuItem1.Size = new System.Drawing.Size(69, 20);
            this.cadastrarToolStripMenuItem1.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem1.Click += new System.EventHandler(this.cadastrarToolStripMenuItem1_Click);
            // 
            // exibirRodapé
            // 
            this.exibirRodapé.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.exibirRodapé.Name = "exibirRodapé";
            this.exibirRodapé.Size = new System.Drawing.Size(101, 21);
            this.exibirRodapé.Text = "Exibir rodapé";
            this.exibirRodapé.Click += new System.EventHandler(this.exibirRodapé_Click);
            // 
            // wordOpt
            // 
            this.wordOpt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.wordOpt.Image = global::atvDes.Properties.Resources.word;
            this.wordOpt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.wordOpt.Name = "wordOpt";
            this.wordOpt.Size = new System.Drawing.Size(23, 22);
            this.wordOpt.Text = "toolStripButton1";
            this.wordOpt.Click += new System.EventHandler(this.wordOpt_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::atvDes.Properties.Resources.excel;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "excelOpt";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::atvDes.Properties.Resources.calc;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "calcOpt";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::atvDes.Properties.Resources.paint;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "blocoDeNotasOpt";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // printOpt
            // 
            this.printOpt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printOpt.Image = global::atvDes.Properties.Resources.wordPad;
            this.printOpt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printOpt.Name = "printOpt";
            this.printOpt.Size = new System.Drawing.Size(23, 22);
            this.printOpt.Text = "toolStripButton4";
            this.printOpt.Click += new System.EventHandler(this.printOpt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton wordOpt;
        private System.Windows.Forms.ToolStripMenuItem sair;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem wordOptMenu;
        private System.Windows.Forms.ToolStripStatusLabel statusStripMsg;
        private System.Windows.Forms.ToolStripStatusLabel strData;
        private System.Windows.Forms.ToolStripStatusLabel strHora;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton printOpt;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blocoDeNotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ferramentaDeCapturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripStatusLabel exibirRodapé;
    }
}

