
namespace projetofinal
{
    partial class Form3
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
            this.btsair = new System.Windows.Forms.Button();
            this.btbuscar = new System.Windows.Forms.Button();
            this.btlimpar = new System.Windows.Forms.Button();
            this.btsalvar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.mtbcpf = new System.Windows.Forms.MaskedTextBox();
            this.tbidade = new System.Windows.Forms.TextBox();
            this.tbnome = new System.Windows.Forms.TextBox();
            this.lbidade = new System.Windows.Forms.Label();
            this.lbcpf = new System.Windows.Forms.Label();
            this.lbnome = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.mtbcelular = new System.Windows.Forms.MaskedTextBox();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.tbendereco = new System.Windows.Forms.TextBox();
            this.lbemail = new System.Windows.Forms.Label();
            this.lbcelular = new System.Windows.Forms.Label();
            this.lbendereco = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cbaula = new System.Windows.Forms.ComboBox();
            this.lbaula = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btsair
            // 
            this.btsair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsair.Location = new System.Drawing.Point(367, 204);
            this.btsair.Name = "btsair";
            this.btsair.Size = new System.Drawing.Size(83, 22);
            this.btsair.TabIndex = 18;
            this.btsair.Text = "SAIR";
            this.btsair.UseVisualStyleBackColor = false;
            this.btsair.Click += new System.EventHandler(this.btsair_Click);
            // 
            // btbuscar
            // 
            this.btbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbuscar.Location = new System.Drawing.Point(278, 204);
            this.btbuscar.Name = "btbuscar";
            this.btbuscar.Size = new System.Drawing.Size(83, 22);
            this.btbuscar.TabIndex = 17;
            this.btbuscar.Text = "BUSCAR";
            this.btbuscar.UseVisualStyleBackColor = false;
            this.btbuscar.Click += new System.EventHandler(this.btbuscar_Click);
            // 
            // btlimpar
            // 
            this.btlimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btlimpar.Location = new System.Drawing.Point(189, 204);
            this.btlimpar.Name = "btlimpar";
            this.btlimpar.Size = new System.Drawing.Size(83, 22);
            this.btlimpar.TabIndex = 16;
            this.btlimpar.Text = "LIMPAR";
            this.btlimpar.UseVisualStyleBackColor = false;
            this.btlimpar.Click += new System.EventHandler(this.btlimpar_Click);
            // 
            // btsalvar
            // 
            this.btsalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsalvar.Location = new System.Drawing.Point(100, 204);
            this.btsalvar.Name = "btsalvar";
            this.btsalvar.Size = new System.Drawing.Size(83, 22);
            this.btsalvar.TabIndex = 15;
            this.btsalvar.Text = "SALVAR";
            this.btsalvar.UseVisualStyleBackColor = false;
            this.btsalvar.Click += new System.EventHandler(this.btsalvar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(27, 39);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(489, 160);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.mtbcpf);
            this.tabPage1.Controls.Add(this.tbidade);
            this.tabPage1.Controls.Add(this.tbnome);
            this.tabPage1.Controls.Add(this.lbidade);
            this.tabPage1.Controls.Add(this.lbcpf);
            this.tabPage1.Controls.Add(this.lbnome);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(481, 132);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados Pessoais";
            // 
            // mtbcpf
            // 
            this.mtbcpf.Location = new System.Drawing.Point(126, 54);
            this.mtbcpf.Mask = "000,000,000-00";
            this.mtbcpf.Name = "mtbcpf";
            this.mtbcpf.Size = new System.Drawing.Size(318, 23);
            this.mtbcpf.TabIndex = 2;
            // 
            // tbidade
            // 
            this.tbidade.Location = new System.Drawing.Point(126, 86);
            this.tbidade.Name = "tbidade";
            this.tbidade.Size = new System.Drawing.Size(318, 23);
            this.tbidade.TabIndex = 3;
            // 
            // tbnome
            // 
            this.tbnome.Location = new System.Drawing.Point(126, 24);
            this.tbnome.Name = "tbnome";
            this.tbnome.Size = new System.Drawing.Size(318, 23);
            this.tbnome.TabIndex = 1;
            // 
            // lbidade
            // 
            this.lbidade.AutoSize = true;
            this.lbidade.Location = new System.Drawing.Point(39, 91);
            this.lbidade.Name = "lbidade";
            this.lbidade.Size = new System.Drawing.Size(40, 15);
            this.lbidade.TabIndex = 2;
            this.lbidade.Text = "IDADE";
            // 
            // lbcpf
            // 
            this.lbcpf.AutoSize = true;
            this.lbcpf.Location = new System.Drawing.Point(39, 59);
            this.lbcpf.Name = "lbcpf";
            this.lbcpf.Size = new System.Drawing.Size(28, 15);
            this.lbcpf.TabIndex = 1;
            this.lbcpf.Text = "CPF";
            // 
            // lbnome
            // 
            this.lbnome.AutoSize = true;
            this.lbnome.Location = new System.Drawing.Point(39, 29);
            this.lbnome.Name = "lbnome";
            this.lbnome.Size = new System.Drawing.Size(42, 15);
            this.lbnome.TabIndex = 0;
            this.lbnome.Text = "NOME";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.mtbcelular);
            this.tabPage2.Controls.Add(this.tbemail);
            this.tabPage2.Controls.Add(this.tbendereco);
            this.tabPage2.Controls.Add(this.lbemail);
            this.tabPage2.Controls.Add(this.lbcelular);
            this.tabPage2.Controls.Add(this.lbendereco);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(481, 132);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Contato";
            // 
            // mtbcelular
            // 
            this.mtbcelular.Location = new System.Drawing.Point(125, 55);
            this.mtbcelular.Mask = "(99) 00000-0000";
            this.mtbcelular.Name = "mtbcelular";
            this.mtbcelular.Size = new System.Drawing.Size(318, 23);
            this.mtbcelular.TabIndex = 10;
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(125, 86);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(318, 23);
            this.tbemail.TabIndex = 11;
            // 
            // tbendereco
            // 
            this.tbendereco.Location = new System.Drawing.Point(125, 24);
            this.tbendereco.Name = "tbendereco";
            this.tbendereco.Size = new System.Drawing.Size(318, 23);
            this.tbendereco.TabIndex = 9;
            // 
            // lbemail
            // 
            this.lbemail.AutoSize = true;
            this.lbemail.Location = new System.Drawing.Point(38, 92);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(46, 15);
            this.lbemail.TabIndex = 9;
            this.lbemail.Text = "E-MAIL";
            // 
            // lbcelular
            // 
            this.lbcelular.AutoSize = true;
            this.lbcelular.Location = new System.Drawing.Point(38, 64);
            this.lbcelular.Name = "lbcelular";
            this.lbcelular.Size = new System.Drawing.Size(56, 15);
            this.lbcelular.TabIndex = 8;
            this.lbcelular.Text = "CELULAR";
            // 
            // lbendereco
            // 
            this.lbendereco.AutoSize = true;
            this.lbendereco.Location = new System.Drawing.Point(38, 30);
            this.lbendereco.Name = "lbendereco";
            this.lbendereco.Size = new System.Drawing.Size(66, 15);
            this.lbendereco.TabIndex = 7;
            this.lbendereco.Text = "ENDEREÇO";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.cbaula);
            this.tabPage3.Controls.Add(this.lbaula);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(481, 132);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Aulas";
            // 
            // cbaula
            // 
            this.cbaula.FormattingEnabled = true;
            this.cbaula.Items.AddRange(new object[] {
            "Selecione",
            "Personal",
            "Box",
            "Jiu-Jitsu",
            "Karatê",
            "Funcional",
            "Dança"});
            this.cbaula.Location = new System.Drawing.Point(152, 20);
            this.cbaula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbaula.Name = "cbaula";
            this.cbaula.Size = new System.Drawing.Size(252, 23);
            this.cbaula.TabIndex = 13;
            // 
            // lbaula
            // 
            this.lbaula.AutoSize = true;
            this.lbaula.Location = new System.Drawing.Point(74, 22);
            this.lbaula.Name = "lbaula";
            this.lbaula.Size = new System.Drawing.Size(37, 15);
            this.lbaula.TabIndex = 12;
            this.lbaula.Text = "AULA";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 266);
            this.Controls.Add(this.btsair);
            this.Controls.Add(this.btbuscar);
            this.Controls.Add(this.btlimpar);
            this.Controls.Add(this.btsalvar);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.Text = "CADASTRO DE PROFESSOR";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btsair;
        private System.Windows.Forms.Button btbuscar;
        private System.Windows.Forms.Button btlimpar;
        private System.Windows.Forms.Button btsalvar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.MaskedTextBox mtbcpf;
        private System.Windows.Forms.TextBox tbidade;
        private System.Windows.Forms.TextBox tbnome;
        private System.Windows.Forms.Label lbidade;
        private System.Windows.Forms.Label lbcpf;
        private System.Windows.Forms.Label lbnome;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MaskedTextBox mtbcelular;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.TextBox tbendereco;
        private System.Windows.Forms.Label lbemail;
        private System.Windows.Forms.Label lbcelular;
        private System.Windows.Forms.Label lbendereco;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox cbaula;
        private System.Windows.Forms.Label lbaula;
    }
}