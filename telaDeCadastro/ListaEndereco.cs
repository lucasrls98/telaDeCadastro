using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace telaDeCadastro
{
    public class ListaEndereco : INotifyPropertyChanged
    {
        string endereco;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Endereco
        {
            get => endereco;
            set
            {
                if (endereco != value)
                {
                    endereco= value;
                    NotifyPropertyChanged();
                    
                }
            }

        }
        public void NotifyPropertyChanged([CallerMemberName] string propName = null)
            //pega o nome da propriedade e coloca no parâmetro propName
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
