using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;


namespace FormPoke
{
    public partial class FormEntrenador : Form
    {
        Entrenador entrenador;
        List<Entrenador> entrenadores;
        private short id = 1;
        public FormEntrenador()
        {
            entrenadores = new List<Entrenador>();
            InitializeComponent();
        }

        private void FormEntrenador_Load(object sender, EventArgs e)
        {
            this.cmbGenero.DataSource = Enum.GetValues(typeof(Genero));
        }

        private void cmbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.cmbGenero.SelectedItem is Genero.Femenino)
            {
                this.pbImagen2.Image = FormPoke.Properties.Resources.Chica;
                this.pbImagen.Image = FormPoke.Properties.Resources.ChicoGris;
            }
            else if(this.cmbGenero.SelectedItem is Genero.Masculino)
            {
                this.pbImagen2.Image = FormPoke.Properties.Resources.ChicaGris;
                this.pbImagen.Image = FormPoke.Properties.Resources.Chico;
            }
            else
            {
                this.pbImagen2.Image = FormPoke.Properties.Resources.Chica;
                this.pbImagen.Image = FormPoke.Properties.Resources.Chico;
            }
        }

        private void btnEntrenador_Click(object sender, EventArgs e)
        {
            
            try
            {
                entrenador = new Entrenador(txtNombre.Text, txtApellido.Text, id++, (short)nudEdad.Value, (Genero)cmbGenero.SelectedItem, 6);
                MessageBox.Show("Entrenador generado");
                entrenadores.Add(entrenador);
                SerializarJson.Serializar("Entrenadores.json", entrenadores);
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se genero el entrenador", ex.Message);
            }
            
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
