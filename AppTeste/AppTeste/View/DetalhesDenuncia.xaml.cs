using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppTeste.Modelos;
using AppTeste.Controles;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTeste.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetalhesDenuncia : ContentPage
	{
		public DetalhesDenuncia (Denuncia denuncia)
		{
			InitializeComponent ();
            this.BindingContext = new DetalhesDenunciaControle(denuncia);
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }
    }
}