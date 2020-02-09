using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControleTemperatura.ControleTemperatura
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TelaInicio : TabbedPage
    {
        public int temperaturaD = 25;
        public TelaInicio()
        {
            InitializeComponent();
            temperatura.Text = temperaturaD + " °C";
        }

        public void aumentar(object sender, EventArgs args)
        {
            temperaturaD++;
            if(temperaturaD > 35)
            {
                DisplayAlert("Atenção", "Temperatura Máxima Atingida.", "Ok");
                temperaturaD--;
                return;
            }
            temperatura.Text = temperaturaD + " °C";
        }

        public void diminuir(object sender, EventArgs args)
        {
            temperaturaD--;
            if(temperaturaD < 16)
            {
                DisplayAlert("Atenção", "Temperatura Mínima Atingida.", "Ok");
                temperaturaD++;
                return;
            }
            temperatura.Text = temperaturaD + " °C";
        }
    }
}