using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPoke
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void btnEntrenador_Click(object sender, EventArgs e)
        {
            FormEntrenador entrenador = new FormEntrenador();
            entrenador.Show();
        }

        private void btnPokemon_Click(object sender, EventArgs e)
        {
            FormPokemon pokemon = new FormPokemon();
            pokemon.Show();
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            FormCapturar capturar = new FormCapturar();
            capturar.Show();
        }

        private void FormInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de querer salir?", "Salir", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
