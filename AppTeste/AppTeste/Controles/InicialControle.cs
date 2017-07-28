using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppTeste.Controles
{
    public class InicialControle
    {
        public ICommand ListarDenuncias { get; private set; }

        public InicialControle()
        {
            /*ListarDenuncias = new Command(
                () =>
                {
                    Navigation.PushAsync(new AppTeste.View.ListagemDenuncias());
                }
                );
            */
        }
    }
}
