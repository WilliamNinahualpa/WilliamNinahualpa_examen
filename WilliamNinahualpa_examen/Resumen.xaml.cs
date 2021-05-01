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
    public partial class Resumen : ContentPage
    {
        public Resumen(String usuario, String nombre, String total)
        {
            InitializeComponent();
            txtusuario.Text = usuario;
            txtnombre.Text = nombre;
            txttotal.Text = total;
        }
    }
}