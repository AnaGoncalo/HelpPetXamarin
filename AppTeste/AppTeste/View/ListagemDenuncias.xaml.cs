using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppTeste.Controles;
using AppTeste.Modelos;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTeste.View
{
	//[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListagemDenuncias : ContentPage
	{
        ListagemDenunciasControle Controle { get; set; }

		public ListagemDenuncias ()
		{
			InitializeComponent();
            this.Controle = new ListagemDenunciasControle();
            this.BindingContext = this.Controle;
		}

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Subscribe<Denuncia>(this, "DenunciaSelecionada",
                (denuncia) =>
                {
                    Navigation.PushAsync(new DetalhesDenuncia(denuncia));
                    //DisplayAlert(veiculo.Nome, veiculo.PrecoFormatado, "OK");
                });
            await this.Controle.GetDenuncias();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Unsubscribe<Denuncia>(this, "DenunciaSelecionada");
        }
    }
}