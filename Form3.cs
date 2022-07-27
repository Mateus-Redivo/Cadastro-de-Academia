using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projetofinal
{
    public partial class Form3 : Form
    {
        int x = 0;
        Professor[] professores = new Professor[20];
        Form4 F4 = new Form4();
        public Form3()
        {
            InitializeComponent();
            F4 = FormPrincipal.F4;
        }
        public Form3(Form4 f)
        {
            InitializeComponent();
            F4 = f;
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void btsalvar_Click(object sender, EventArgs e)
        {//SALVAR
         if (tbnome.Text == "" || mtbcpf.Text == "   .   .   -" || tbidade.Text == "" || tbendereco.Text == "" || mtbcelular.Text == "(  )      -" || tbemail.Text == "" || cbaula.Text == "Selecione")
         MessageBox.Show("Preencha os campos vazios!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
         else
         {
            professores[x] = new Professor(tbnome.Text, mtbcpf.Text, tbendereco.Text, mtbcelular.Text, tbemail.Text, int.Parse(tbidade.Text), cbaula.Text);
            x++;
            F4.insereDados2(tbnome.Text, mtbcpf.Text, int.Parse(tbidade.Text), mtbcelular.Text, tbemail.Text, tbendereco.Text, cbaula.Text);
                MessageBox.Show("Cadastro efetuado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
        }
        private void btlimpar_Click(object sender, EventArgs e)
        {//LIMPAR
            tbnome.Clear();
            mtbcpf.Clear();
            tbidade.Clear();
            tbendereco.Clear();
            mtbcelular.Clear();
            tbemail.Clear();
            cbaula.SelectedIndex = 0;
            MessageBox.Show("Todos os campos foram limpos!", "Limpar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btsair_Click(object sender, EventArgs e)
        {//SAIR
            if (MessageBox.Show("Deseja mesmo finalizar o programa?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();
        }

        private void btbuscar_Click(object sender, EventArgs e)
        {//BUSCAR
            string nome = tbnome.Text;
            bool achou = false;
            if (tbnome.Text == "")
                MessageBox.Show("Nenhum nome foi digitado para a busca!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                for (int i = 0; i < x; i++)
                {
                    if (professores[i].nome == nome)
                    {
                        tbnome.Text = professores[i].nome;
                        mtbcpf.Text = professores[i].cpf;
                        tbidade.Text = professores[i].idade.ToString();
                        tbendereco.Text = professores[i].endereco;
                        mtbcelular.Text = professores[i].celular;
                        tbemail.Text = professores[i].email;
                        cbaula.Text = professores[i].aula;
                        achou = true;
                        MessageBox.Show("Cadastro localizado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (!achou)
                    MessageBox.Show("Pessoa não cadastrada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
