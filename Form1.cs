using System;
using System.Windows.Forms;

namespace projetofinal
{
    public partial class Form1 : Form
    {
        int p = 0;
        Aluno[] alunos = new Aluno[20];
        Form2 F2 = new Form2();
        public Form1()
        {
            InitializeComponent();
            F2 = FormPrincipal.F2;
        }
        public Form1(Form2 f)
        {
            InitializeComponent();
            F2 = f;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btsalvar_Click(object sender, EventArgs e)
        {//SALVAR
            if (tbnome.Text == "" || mtbcpf.Text == "   .   .   -" || tbidade.Text == "" || tbendereco.Text == "" || mtbcelular.Text == "(  )      -" || tbemail.Text == "" || tbpeso.Text == "" || tbaltura.Text == "")
                MessageBox.Show("Preencha os campos vazios!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                alunos[p] = new Aluno(tbnome.Text, mtbcpf.Text, tbendereco.Text, mtbcelular.Text, tbemail.Text, int.Parse(tbidade.Text), float.Parse(tbpeso.Text), float.Parse(tbaltura.Text));
                p++;
                F2.insereDados(tbnome.Text, mtbcpf.Text, int.Parse(tbidade.Text), mtbcelular.Text, tbemail.Text, tbendereco.Text, float.Parse(tbpeso.Text), float.Parse(tbaltura.Text));
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
            tbpeso.Clear();
            tbaltura.Clear();
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
                for (int i = 0; i < p; i++)
                {
                    if (alunos[i].nome == nome)
                    {
                        tbnome.Text = alunos[i].nome;
                        mtbcpf.Text = alunos[i].cpf;
                        tbidade.Text = alunos[i].idade.ToString();
                        tbendereco.Text = alunos[i].endereco;
                        mtbcelular.Text = alunos[i].celular;
                        tbemail.Text = alunos[i].email;
                        tbpeso.Text = alunos[i].peso.ToString();
                        tbaltura.Text = alunos[i].altura.ToString();
                        achou = true;
                        MessageBox.Show("Cadastro localizado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (!achou)
                    MessageBox.Show("Pessoa não cadastrada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
