using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario.Ej
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        List<string> Favotitos = new List<string>();


        private void btnIr_Click(object sender, EventArgs e)
        {
            wbNavegador.Navigate(txtBuscar.Text);
        }

        private void txtBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            wbNavegador.GoBack();
        }

        private void btnAdelante_Click(object sender, EventArgs e)
        {
            wbNavegador.GoForward();
        }

        private void btnrefrescar_Click(object sender, EventArgs e)
        {
            wbNavegador.Refresh();  
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
           wbNavegador.GoHome();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            wbNavegador.Stop();
        }

        private void btnFavoritos_Click(object sender, EventArgs e)
        {
            Favotitos.Add(wbNavegador.Url.ToString());
            actualizarComb();
        }
        private void actualizarComb()
        {
            foreach(string direccion in Favotitos)
            {
                cbFavoritos.Items.Add(direccion);
            }
        }

        private void cdFac(object sender, EventArgs e)
        {
            wbNavegador.Navigate(cbFavoritos.SelectedItem.ToString());
        }
    }
}
