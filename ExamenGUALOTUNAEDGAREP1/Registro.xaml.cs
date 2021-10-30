using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExamenGUALOTUNAEDGAREP1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        private string user;
        private string pass;

        public Registro(string user, string pass)
        {
            InitializeComponent();
            string usuario = lblUser.Text;
            lblUser.Text = usuario + user;
        }

        private async void btnCalcular_Clicked(object sender, EventArgs e)
        {

            string alumno = txtEstudiante.Text;
            double abono = Convert.ToDouble(txtAbono.Text);
            double saldo = Convert.ToDouble(txtSaldoPendiente.Text);
            double mensualidades = Convert.ToDouble(txtMensualidades.Text);
            double total = Convert.ToDouble(txtTotal.Text);

            double promabono = 1800 - abono;
            txtSaldoPendiente.Text = promabono.ToString();

            double prommensualidad = (promabono / 3) * 0.05 + (promabono / 3);
            txtMensualidades.Text = prommensualidad.ToString();

            double pagoTotal = (prommensualidad * 3) + abono;
            txtTotal.Text = pagoTotal.ToString();

            DisplayAlert("Ingreso Correcto", "Almacenado Correctamente", "OK");

        }

        private async void btnImprimir_Clicked(object sender, EventArgs e)
        {
            string nombre = txtEstudiante.Text;
            string tot = txtTotal.Text;
            string userlogin = lblUser.Text;
            lblUser.Text = userlogin + user;

            await Navigation.PushAsync(new Resumen(userlogin, nombre, tot));
        }
    }
}