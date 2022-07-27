
namespace projetofinal
{
    partial class Form2
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
            this.dgpessoas = new System.Windows.Forms.DataGridView();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.altura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbcadastrados = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgpessoas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgpessoas
            // 
            this.dgpessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgpessoas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.cpf,
            this.idade,
            this.endereco,
            this.celular,
            this.email,
            this.peso,
            this.altura});
            this.dgpessoas.Location = new System.Drawing.Point(29, 83);
            this.dgpessoas.Name = "dgpessoas";
            this.dgpessoas.RowHeadersWidth = 45;
            this.dgpessoas.RowTemplate.Height = 25;
            this.dgpessoas.Size = new System.Drawing.Size(999, 416);
            this.dgpessoas.TabIndex = 2;
            this.dgpessoas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgpessoas_CellContentClick);
            // 
            // nome
            // 
            this.nome.FillWeight = 200F;
            this.nome.HeaderText = "Nome";
            this.nome.MinimumWidth = 6;
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 200;
            // 
            // cpf
            // 
            this.cpf.HeaderText = "CPF";
            this.cpf.MinimumWidth = 6;
            this.cpf.Name = "cpf";
            this.cpf.ReadOnly = true;
            this.cpf.Width = 110;
            // 
            // idade
            // 
            this.idade.FillWeight = 50F;
            this.idade.HeaderText = "Idade";
            this.idade.MinimumWidth = 6;
            this.idade.Name = "idade";
            this.idade.ReadOnly = true;
            this.idade.Width = 50;
            // 
            // endereco
            // 
            this.endereco.HeaderText = "Endereço";
            this.endereco.MinimumWidth = 6;
            this.endereco.Name = "endereco";
            this.endereco.ReadOnly = true;
            this.endereco.Width = 125;
            // 
            // celular
            // 
            this.celular.HeaderText = "Celular";
            this.celular.MinimumWidth = 6;
            this.celular.Name = "celular";
            this.celular.ReadOnly = true;
            this.celular.Width = 125;
            // 
            // email
            // 
            this.email.HeaderText = "E-mail";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 150;
            // 
            // peso
            // 
            this.peso.HeaderText = "Peso";
            this.peso.MinimumWidth = 6;
            this.peso.Name = "peso";
            this.peso.ReadOnly = true;
            this.peso.Width = 50;
            // 
            // altura
            // 
            this.altura.HeaderText = "Altura";
            this.altura.MinimumWidth = 6;
            this.altura.Name = "altura";
            this.altura.ReadOnly = true;
            this.altura.Width = 50;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1071, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // lbcadastrados
            // 
            this.lbcadastrados.Font = new System.Drawing.Font("Segoe UI Semibold", 18.33962F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbcadastrados.Location = new System.Drawing.Point(278, 31);
            this.lbcadastrados.Name = "lbcadastrados";
            this.lbcadastrados.Size = new System.Drawing.Size(322, 39);
            this.lbcadastrados.TabIndex = 4;
            this.lbcadastrados.Text = "ALUNOS CADASTRADOS";
            this.lbcadastrados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 530);
            this.Controls.Add(this.lbcadastrados);
            this.Controls.Add(this.dgpessoas);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VISUALIZAR ALUNOS";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgpessoas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgpessoas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Label lbcadastrados;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn idade;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn altura;
    }
}