using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;

namespace atv02.Views
{
    /// <summary>
    /// Lógica interna para EscolaFormWindow.xaml
    /// </summary>
    public partial class EscolaFormWindow : Window
    {
        public EscolaFormWindow()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, RoutedEventArgs e)
        {
            string nome= txtNome.Text;
            string razaosocial = txtrazao.Text;
            string CNPJ = txtcnpj.Text;
            string inscricao = txtinscricao.Text;

            string tipo = "Pública";
            if (rdtipo.IsChecked == true)
            {
                tipo = "Privada";
            }

            var datacriacao = dataCri.SelectedDate?.ToString("yyyy-MM-dd");
            string nome2 = txtNom.Text;
            string contato = txtTel.Text;
            string telefone = txtTelefone.Text;
            string email = txtEmail.Text;
            string rua = txtRua.Text;
            string numero = txtNumero.Text;
            string bairro = txtBairro.Text;
            string complemento = txtComplemento.Text;
            string cep = txtCep.Text;
            string cidade = txtCidade.Text;
            string estado = cboxEstado.Text;

            var conexao = new MySqlConnection("server=localhost;database=bd_escolajoao;port=3360;user=root;password=root");

            try
            {
                conexao.Open();
                var comando = conexao.CreateCommand();

                comando.CommandText = "INSERT INTO escola values (null, @nome,@razao,@cnpj,@inscEst,@tipo,@dtCriacao,@responsavel,@responsavelTelefone,@email,@telefone,@rua,@numero,@bairro,@complemento,@cep,@cidade,@estado); ";
                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@razao", razaosocial);
                comando.Parameters.AddWithValue("@cnpj", CNPJ);
                comando.Parameters.AddWithValue("@inscEst", inscricao);
                comando.Parameters.AddWithValue("@tipo", tipo);
                comando.Parameters.AddWithValue("@dtCriacao", datacriacao);
                comando.Parameters.AddWithValue("@responsavel", nome2);
                comando.Parameters.AddWithValue("@responsavelTelefone", contato);
                comando.Parameters.AddWithValue("@email", email);
                comando.Parameters.AddWithValue("@telefone", telefone);
                comando.Parameters.AddWithValue("@rua", rua);
                comando.Parameters.AddWithValue("@numero", numero); 
                comando.Parameters.AddWithValue("@bairro", bairro);
                comando.Parameters.AddWithValue("@complemento", complemento);
                comando.Parameters.AddWithValue("@cep", cep);
                comando.Parameters.AddWithValue("@cidade", cidade);
                comando.Parameters.AddWithValue("@estado", estado);

                var resultado = comando.ExecuteNonQuery();

                if (resultado > 0)
                {
                    MessageBox.Show("Registro salvo com Sucesso!");
                }
            }
         
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
