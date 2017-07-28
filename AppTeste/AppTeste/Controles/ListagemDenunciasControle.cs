using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using AppTeste.Modelos;
using Xamarin.Forms;

namespace AppTeste.Controles
{
    public class ListagemDenunciasControle
    {
        const string URL_GET_DENUNCIAS = "http://helppettads-appnerd.rhcloud.com/HelpPetMaven/rest/denuncia";

        public ObservableCollection<Denuncia> Denuncias { get; set; }

        private Denuncia denunciaSelecionada;
        public Denuncia DenunciaSelecionada
        {
            get
            {
                return denunciaSelecionada;
            }
            set
            {
                denunciaSelecionada = value;
                if (value != null)
                    MessagingCenter.Send<Denuncia>(value, "DenunciaSelecionada");
            }
        }
        
        /*
        private bool aguarde;
        public bool Aguarde
        {
            get { return aguarde; }
            set
            {
                aguarde = value;
                OnPropertyChanged();
            }
        }
        */

        public ListagemDenunciasControle()
        {
            this.Denuncias = new ObservableCollection<Denuncia>();
        }

        public async Task GetDenuncias()
        {
            //Aguarde = true;
            try
            {
                HttpClient cliente = new HttpClient();
                var resultado = await cliente.GetStringAsync(URL_GET_DENUNCIAS);
                var denunciasJson = JsonConvert.DeserializeObject<DenunciaJson[]>(resultado);

                foreach (var denunciaJson in denunciasJson)
                {
                    this.Denuncias.Add(new Denuncia
                    {
                        Titulo = denunciaJson.titulo,
                        Texto = denunciaJson.texto,
                        Data = denunciaJson.data
                    });
                }
            }
            catch (Exception exc)
            {
                MessagingCenter.Send<Exception>(exc, "FalhaListagem");
            }

            //Aguarde = false;
        }
    }

    class DenunciaJson
    {
        public string titulo { get; set; }
        public string texto { get; set; }
        public string data { get; set; }
    }
}

