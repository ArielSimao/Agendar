using Agendar.Model;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Agendar.User_Control
{
    /// <summary>
    /// Interação lógica para UserControlUsuario.xam
    /// </summary>
    public partial class UserControlUsuario : UserControl
    {
        User user = new User();
        Conexao conexao = new Conexao();
        private List<User> listaUser = new List<User>();


        public UserControlUsuario()
        {
            InitializeComponent();
            carregarGrid();
        }

        private void carregarGrid() {
            listaUser = conexao.User.ToList();
            DgUsuarios.ItemsSource = null;
            DgUsuarios.ItemsSource = listaUser.OrderBy(x => x.nome);
        }

        public void limparCampos()
        {
            TxtBairroUsuario.Clear();
            TxtCidadeeUsuario.Clear();
            TxtCodigoUsuario.Clear();
            TxtCPFUsuario.Clear();
            TxtEndUsuario.Clear();
            TxtEstadoUsuario.Clear();
            TxtNomeUsuario.Clear();
            TxtNumeroUsuario.Clear();
            TxtSenhaUsuario.Clear();
            iTxtTelefoneUsuario.Clear();
            CbTipoUsuario.Text = "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                user.nome = TxtNomeUsuario.Text;
                user.bairro = TxtBairroUsuario.Text;
                user.password = TxtSenhaUsuario.Password;
                user.tipo = CbTipoUsuario.Text;
                user.endereco = TxtEndUsuario.Text;
                user.bairro = TxtBairroUsuario.Text;
                user.numero = int.Parse(TxtNumeroUsuario.Text);
                user.estado = TxtEstadoUsuario.Text;
                user.cidade = TxtCidadeeUsuario.Text;
                user.cpf = int.Parse(TxtCPFUsuario.Text);
                user.telefone = int.Parse(iTxtTelefoneUsuario.Text);

                conexao.User.Add(user);
                conexao.SaveChanges();

                TxtCodigoUsuario.Text = user.codigo.ToString();

                carregarGrid();
            }

            catch(Exception a)
            {
                MessageBox.Show("Erro ao Salvar");
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TxtNomeUsuario.Focus();
            limparCampos();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            limparCampos();
        }
    }
}
