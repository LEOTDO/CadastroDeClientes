using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroDeClientes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPessoaFisica_Click(object sender, EventArgs e)
        {
            painelPessoaFisica.Visible = true; // deixa visivel o painel destinado a pessoa fisica
            painelPessoaJuridica.Visible = false; // deixa invisivel o painel da pessoa juridica
        }

        private void painelPessoaFisica_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPessoaJuridica_Click(object sender, EventArgs e)
        {
            painelPessoaJuridica.Visible = true; // deixa visivel o painel destinado a pessoa juridica
            painelPessoaFisica.Visible = false; // deixa invisivel o painel da pessoa fisica
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (painelPessoaFisica.Visible == true)
            {
                PessoaFisica novaPessoaFisica = new PessoaFisica();

                novaPessoaFisica.propriedadeNome = txtNomePessoaFisica.Text;
                novaPessoaFisica.propriedadeEndereco = txtEnderecoPessoaFisica.Text;
                novaPessoaFisica.propriedadeRg = txtRG.Text;
                novaPessoaFisica.propriedadeCpf = txtCPF.Text;

                txtMostraPessoaFisica.AppendText(novaPessoaFisica.propriedadeNome + "\t");
                txtMostraPessoaFisica.AppendText(novaPessoaFisica.propriedadeEndereco + "\t");
                txtMostraPessoaFisica.AppendText(novaPessoaFisica.propriedadeEndereco + "\t");
                txtMostraPessoaFisica.AppendText(novaPessoaFisica.propriedadeRg + "\t");
                txtMostraPessoaFisica.AppendText(novaPessoaFisica.propriedadeCpf + "\r\n");
                Limpar();
            }
            else
            {
                PessoaJuridica novaPessoaJurisica = new PessoaJuridica(); // instanciando a classe PessoaJuridica
                                                                          // gravar os textos digitados  
                novaPessoaJurisica.propriedadeNome = txtNomePessoaJuridica.Text;
                novaPessoaJurisica.propriedadeEndereco = txtEnderecoPessoaJuridica.Text;
                novaPessoaJurisica.propriedadeCnpj = txtCNPJ.Text;
                novaPessoaJurisica.propriedadeIe = txtIE.Text;
                // exibindo os dados gravados
                txtMostraPessoaJuridica.AppendText(novaPessoaJurisica.propriedadeNome + "\t");
                txtMostraPessoaJuridica.AppendText(novaPessoaJurisica.propriedadeEndereco + "\t");
                txtMostraPessoaJuridica.AppendText(novaPessoaJurisica.propriedadeCnpj + "\t");
                txtMostraPessoaJuridica.AppendText(novaPessoaJurisica.propriedadeIe + "\r\n");
                Limpar();

            }
        }
        public void Limpar() //Metodo Limpar
        {
            if (painelPessoaFisica.Visible == true) // se o painel pessoa fisica estiver visivel
            {
                txtNomePessoaFisica.Text = ""; // deixa a propriedade txt do objeto que recebe o nome igual a vazio
                txtEnderecoPessoaFisica.Text = "";
                txtRG.Text = "";
                txtCPF.Text = "";
            }
            else //senao
            {
                txtNomePessoaJuridica.Text = "";
                txtEnderecoPessoaJuridica.Text = "";
                txtCNPJ.Text = "";
                txtIE.Text = "";
            }
        }
    }

    public class Pessoa
    {
        private string nome; // atributo nome
        private string endereco; // atributo endereço

        public string propriedadeNome
        {
            set { nome = value; } //metodo de acesso de gravação
            get { return nome; }  // metodo de acesso de leitura
        }

        public string propriedadeEndereco
        {
            set { endereco = value; } //metodo de acesso de gravação
            get { return  endereco; } // metodo de acesso de leitura

        }
    }

    public class PessoaFisica : Pessoa
    {
         public string propriedadeRg { set; get; } // propriedade autoimplementada do atributo Rg
         public string propriedadeCpf {  set; get; } //     "           "           "     "     CPF
    }

    public class PessoaJuridica : Pessoa
    {
        public string propriedadeCnpj { set; get; } // propriedade autoimplementada do atributo CNPJ
        public string propriedadeIe { set; get; }
    }

} 
