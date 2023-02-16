using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace telaDeCadastro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<ListaEndereco> ListaEnderecos { get; set; }
        //gera evento quando adiciona e quando remove endereco
        
        public MainWindow()
        {
            

            ListaEnderecos = new ObservableCollection<ListaEndereco>();
            ListaEnderecos.Add(new ListaEndereco { Endereco=""});

            InitializeComponent();
        }
    }
}
