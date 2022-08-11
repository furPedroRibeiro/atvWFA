namespace atvDes
{
    partial class cadastrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_rm = new System.Windows.Forms.TextBox();
            this.TB_telefone = new System.Windows.Forms.TextBox();
            this.TB_senha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_nome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cadastroBtn = new System.Windows.Forms.Button();
            this.aviso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(216, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRO DE USUÁRIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(283, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "RM:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TB_rm
            // 
            this.TB_rm.Location = new System.Drawing.Point(286, 133);
            this.TB_rm.Name = "TB_rm";
            this.TB_rm.Size = new System.Drawing.Size(204, 20);
            this.TB_rm.TabIndex = 2;
            // 
            // TB_telefone
            // 
            this.TB_telefone.Location = new System.Drawing.Point(286, 231);
            this.TB_telefone.Name = "TB_telefone";
            this.TB_telefone.Size = new System.Drawing.Size(204, 20);
            this.TB_telefone.TabIndex = 4;
            // 
            // TB_senha
            // 
            this.TB_senha.Location = new System.Drawing.Point(286, 283);
            this.TB_senha.Name = "TB_senha";
            this.TB_senha.Size = new System.Drawing.Size(204, 20);
            this.TB_senha.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(283, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Senha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(283, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Telefone:";
            // 
            // TB_nome
            // 
            this.TB_nome.Location = new System.Drawing.Point(286, 182);
            this.TB_nome.Name = "TB_nome";
            this.TB_nome.Size = new System.Drawing.Size(204, 20);
            this.TB_nome.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(283, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nome:";
            // 
            // cadastroBtn
            // 
            this.cadastroBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cadastroBtn.Location = new System.Drawing.Point(286, 340);
            this.cadastroBtn.Name = "cadastroBtn";
            this.cadastroBtn.Size = new System.Drawing.Size(204, 49);
            this.cadastroBtn.TabIndex = 11;
            this.cadastroBtn.Text = "Cadastrar";
            this.cadastroBtn.UseVisualStyleBackColor = false;
            this.cadastroBtn.Click += new System.EventHandler(this.cadastroBtn_Click);
            // 
            // aviso
            // 
            this.aviso.AutoSize = true;
            this.aviso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.aviso.Location = new System.Drawing.Point(283, 315);
            this.aviso.Name = "aviso";
            this.aviso.Size = new System.Drawing.Size(111, 13);
            this.aviso.TabIndex = 12;
            this.aviso.Text = "Ainda não cadastrado";
            this.aviso.Click += new System.EventHandler(this.aviso_Click);
            // 
            // cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.aviso);
            this.Controls.Add(this.cadastroBtn);
            this.Controls.Add(this.TB_nome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_senha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_telefone);
            this.Controls.Add(this.TB_rm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "cadastrar";
            this.Text = "cadastrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_rm;
        private System.Windows.Forms.TextBox TB_telefone;
        private System.Windows.Forms.TextBox TB_senha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_nome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cadastroBtn;
        private System.Windows.Forms.Label aviso;
    }
}