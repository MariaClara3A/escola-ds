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
using ProjetoEscola.Views;

namespace ProjetoEscola.Views
{
    /// <summary>
    /// Lógica interna para MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            InitializeComponent();
        }

        private void bt_cadescola_Click(object sender, RoutedEventArgs e)
        {
            var window = new EscolaFormWindow();
            window.ShowDialog();
        }

        private void bt_escolalist_Click(object sender, RoutedEventArgs e)
        {
            var window = new EscolaListWindow();
            window.ShowDialog();
        }

        private void bt_cadcurso_Click(object sender, RoutedEventArgs e)
        {
            var window = new CursoFormWindow();
            window.ShowDialog();
        }

        private void bt_cursolist_Click(object sender, RoutedEventArgs e)
        {
            var window = new CursoListWindow();
            window.ShowDialog();
        }
    }
}
