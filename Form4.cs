using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projetofinal
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public void insereDados2(string nome, string cpf, int idade, string endereco, string celular, string email, string aula)
        {
            DataGridViewRow linha = (DataGridViewRow)dgProfessores.Rows[0].Clone();
            linha.Cells[0].Value = nome;
            linha.Cells[1].Value = cpf;
            linha.Cells[2].Value = idade;
            linha.Cells[3].Value = endereco;
            linha.Cells[4].Value = celular;
            linha.Cells[5].Value = email;
            linha.Cells[6].Value = aula;
            dgProfessores.Rows.Add(linha);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
