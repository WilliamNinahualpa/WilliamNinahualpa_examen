using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WilliamNinahualpa_examen
{
    public partial class MainPage : ContentPage
    {
        public MainPage(String usuario)
        {
            InitializeComponent();
            lblUser.Text = usuario;
        }

        private async void Calcular_Clicked(object sender, EventArgs e)
        {
            double total = 1800;
            double monto = Convert.ToDouble(txtmonto.Text);
           
                if (0 < monto && monto < 1800)
                {
                    double faltante = total - monto;
                    double cuotas = faltante / 3;
                    double totalinteres = total * 0.05;
                    double final = 3 * (cuotas + totalinteres);
                txtpagomensual.Text = final.ToString();
                }
                else if (monto > 1800)
                {
                    await DisplayAlert("Alerta", "El monto no puede superar los 1800", "OK");
                txtpagomensual.Text = "";
                }
                else if (monto == 1800)
                {
                txtpagomensual.Text = "0";
                }
                else if (monto < 0 || monto == 0)
                {
                    await DisplayAlert("Alerta", "El monto debe ser mayor a 0", "OK");
                txtpagomensual.Text = "";
                }
            
        }

        private async void Guardar_Clicked(object sender, EventArgs e)
        {
            if (!lblUser.Text.Equals("") && !txtnombre.Text.Equals("") && !txtpagomensual.Text.Equals(""))
            {
                await Navigation.PushAsync(new Resumen(lblUser.Text, txtnombre.Text, txtpagomensual.Text));
            }
            else {
                await DisplayAlert("Alerta", "  Todos los campos deben de estar llenos", "OK");
            }
        }
    }
}
