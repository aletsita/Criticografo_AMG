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

            // Método para actualizar los atributos según el género seleccionado
            private void OnGenderSelectionChanged(object sender, CheckedChangedEventArgs e)
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

            // Método que se ejecuta al presionar el botón "¡Hacer Crítica!"
            private void OnCritiqueButtonClicked(object sender, EventArgs e)
            {
                // Recolectar el nombre
                string nombre = NombreEntry.Text;
                if (string.IsNullOrWhiteSpace(nombre))
                {
                    ResultadoLabel.Text = "Por favor ingresa un nombre.";
                    return;
                }

                // Recolectar el género
                string genero = "";
                if (HombreRadio.IsChecked)
                    genero = "Hombre";
                else if (MujerRadio.IsChecked)
                    genero = "Mujer";
                else
                {
                    ResultadoLabel.Text = "Por favor selecciona un género.";
                    return;
                }

                // Recolectar atributos seleccionados
                List<string> atributos = new List<string>();
                if (AltoCheckBox.IsChecked) atributos.Add(AltoLabel.Text);
                if (FeoCheckBox.IsChecked) atributos.Add(FeoLabel.Text);
                if (ListoCheckBox.IsChecked) atributos.Add(ListoLabel.Text);
                if (ExtravaganteCheckBox.IsChecked) atributos.Add(ExtravaganteLabel.Text);
                if (RaroCheckBox.IsChecked) atributos.Add(RaroLabel.Text);
                if (GrandeCheckBox.IsChecked) atributos.Add(GrandeLabel.Text);

                if (atributos.Count == 0)
                {
                    ResultadoLabel.Text = "Por favor selecciona al menos un atributo.";
                    return;
                }

                // Mostrar la crítica en la etiqueta de resultado
                string mensaje = $"Nombre: {nombre}\nGénero: {genero}\nAtributos: {string.Join(", ", atributos)}";
                ResultadoLabel.Text = mensaje;
            }
        }
    }
