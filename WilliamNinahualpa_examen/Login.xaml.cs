using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WilliamNinahualpa_examen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnLogin1_Clicked(object sender, EventArgs e)
        {
            String usuario = txtUsuario.Text;
            String clave = txtClave.Text;
            if (usuario.Equals("estudiante2021") && clave.Equals("uisrael2021"))
            {
                await Navigation.PushAsync(new MainPage(usuario));
            }
            else
            {
                await DisplayAlert("Alerta", "Clave o usuario incorrectos", "OK");
            }
        }
    }
}