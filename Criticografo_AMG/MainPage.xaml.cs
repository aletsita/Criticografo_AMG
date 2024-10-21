using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Criticografo_AMG
{

    
        public partial class MainPage : ContentPage
        {
            public MainPage()
            {
                InitializeComponent();
            }

            private void SeleccionGenero(object sender, CheckedChangedEventArgs e)
            {
                if (HombreRadio.IsChecked)
                {
                    AltoLabel.Text = "Alto";
                    FeoLabel.Text = "Feo";
                    ListoLabel.Text = "Listo";
                    ExtravaganteLabel.Text = "Extravagante";
                    RaroLabel.Text = "Raro";
                    GrandeLabel.Text = "Grande";
                }
                else if (MujerRadio.IsChecked)
                {
                    AltoLabel.Text = "Alta";
                    FeoLabel.Text = "Fea";
                    ListoLabel.Text = "Lista";
                    ExtravaganteLabel.Text = "Extravagante";
                    RaroLabel.Text = "Rara";
                    GrandeLabel.Text = "Grande";
                }
            }

            private void SeleccionAtributos(object sender, EventArgs e)
            {
                string Nombre = NombreEntry.Text;
                if (string.IsNullOrWhiteSpace(Nombre))
                {
                    ResultadoLabel.Text = "Ingresa un nombre válido.";
                    return;
                }

                string Genero = "";
                if (HombreRadio.IsChecked)
                    Genero = "Hombre";
                else if (MujerRadio.IsChecked)
                Genero = "Mujer";
                else
                {
                    ResultadoLabel.Text = "Selecciona un género.";
                    return;
                }

                List<string> Atributos = new List<string>();
                if (AltoCheckBox.IsChecked) Atributos.Add(AltoLabel.Text);
                if (FeoCheckBox.IsChecked) Atributos.Add(FeoLabel.Text);
                if (ListoCheckBox.IsChecked) Atributos.Add(ListoLabel.Text);
                if (ExtravaganteCheckBox.IsChecked) Atributos.Add(ExtravaganteLabel.Text);
                if (RaroCheckBox.IsChecked) Atributos.Add(RaroLabel.Text);
                if (GrandeCheckBox.IsChecked) Atributos.Add(GrandeLabel.Text);

                if (Atributos.Count == 0)
                {
                    ResultadoLabel.Text = "Selecciona al menos un atributo.";
                    return;
                }

                string mensaje = $"Nombre: {Nombre}\nGénero: {Genero}\nAtributos: {string.Join(", ", Atributos)}";
                ResultadoLabel.Text = mensaje;
            }
        }
    }
