using AppTeste.Controles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTeste.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Inicial : ContentPage
	{
        public InicialControle Controle { get; set; }
		public Inicial ()
		{
			InitializeComponent ();
            this.Controle = new InicialControle();
            this.BindingContext = this.Controle;
		}

        private async void Btn_ListarDenuncias(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AppTeste.View.ListagemDenuncias(), true);
        }

    }
}