using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projetofinal
{
    public partial class FormPrincipal : Form
    {
        public static Form2 F2 = new Form2();
        public static Form1 F1 = new Form1();
        public static Form4 F4 = new Form4();
        public static Form3 F3 = new Form3(F4);
        
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void pessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {//CADASTRAR >> ALUNO
            F1.ShowDialog();
        }

        private void professorToolStripMenuItem_Click(object sender, EventArgs e)
        {//CADASTRAR >> PROFESSOR
            F3.ShowDialog();
        }

        private void pessoasToolStripMenuItem1_Click(object sender, EventArgs e)
        {//VISUALIZAR >> ALUNOS
            F2.ShowDialog();
        }
        private void professoresToolStripMenuItem_Click(object sender, EventArgs e)
        {//VISUALIZAR >> PROFESSORES
            F4.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {//SAIR
            if (MessageBox.Show("Deseja mesmo finalizar o programa?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void visualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
