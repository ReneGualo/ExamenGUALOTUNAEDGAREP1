﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ExamenGUALOTUNAEDGAREP1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void btnLogin_Clicked(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;

            if (string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPass.Text))
                DisplayAlert ("Sin Datos", "Ingrese usuario y contraseña", "OK");
            else
            {
                if (txtUser.Text == "estudiante2021" && txtPass.Text == "uisrael2021")
                {
                    DisplayAlert ("Ingreso existoso", "", "OK");
                    await Navigation.PushAsync(new Registro(user, pass));
                }
                else
                    DisplayAlert ("Ingreso Fallido", "Ingrese correctamente los datos", "OK");
            }
        }
    }
}