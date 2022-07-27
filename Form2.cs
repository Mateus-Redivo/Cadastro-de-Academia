using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projetofinal
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void insereDados(string nome, string cpf, int idade, string endereco, string celular, string email, float peso, float altura)
        {
            DataGridViewRow linha = (DataGridViewRow)dgpessoas.Rows[0].Clone();
            linha.Cells[0].Value = nome;
            linha.Cells[1].Value = cpf;
            linha.Cells[2].Value = idade;
            linha.Cells[3].Value = endereco;
            linha.Cells[4].Value = celular;
            linha.Cells[5].Value = email;
            linha.Cells[6].Value = peso;
            linha.Cells[7].Value = altura;
            dgpessoas.Rows.Add(linha);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dgpessoas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
