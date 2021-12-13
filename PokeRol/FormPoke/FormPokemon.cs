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
    public partial class FormPokemon : Form
    {
        Pokemon pokemon;
        private short id = 1;
        List<Pokemon> lista;
        public FormPokemon()
        {
            lista = new List<Pokemon>();
            InitializeComponent();
        }

        private void FormPokemon_Load(object sender, EventArgs e)
        {
            this.cmbSubTipo.Visible = false;
            this.pbSubTipo.Visible = false;
            this.lblSubTipo.Visible = false;
            this.cmbTipo.DataSource = Enum.GetValues(typeof(Tipo));
            this.cmbSubTipo.DataSource = Enum.GetValues(typeof(Tipo));
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.cmbTipo.SelectedItem)
            {
                case Tipo.Agua:
                    this.pbTipo.Image = FormPoke.Properties.Resources.Agua;
                    break;
                case Tipo.Bicho:
                    this.pbTipo.Image = FormPoke.Properties.Resources.Bicho;
                    break;
                case Tipo.Dragon:
                    this.pbTipo.Image = FormPoke.Properties.Resources.Dragon;
                    break;
                case Tipo.Electrico:
                    this.pbTipo.Image = FormPoke.Properties.Resources.Electrico;
                    break;
                case Tipo.Fantasma:
                    this.pbTipo.Image = FormPoke.Properties.Resources.Dragon;
                    break;
                case Tipo.Fuego:
                    this.pbTipo.Image = FormPoke.Properties.Resources.Fuego;
                    break;
                case Tipo.Hielo:
                    this.pbTipo.Image = FormPoke.Properties.Resources.Hielo;
                    break;
                case Tipo.Psiquico:
                    this.pbTipo.Image = FormPoke.Properties.Resources.Psiquico;
                    break;
                case Tipo.Roca:
                    this.pbTipo.Image = FormPoke.Properties.Resources.Roca;
                    break;
                case Tipo.Tierra:
                    this.pbTipo.Image = FormPoke.Properties.Resources.Tierra;
                    break;
                case Tipo.Normal:
                    this.pbTipo.Image = FormPoke.Properties.Resources.Normal;
                    break;
                case Tipo.Planta:
                    this.pbTipo.Image = FormPoke.Properties.Resources.Planta;
                    break;
                case Tipo.Hada:
                    this.pbTipo.Image = FormPoke.Properties.Resources.Hada;
                    break;
                case Tipo.Lucha:
                    this.pbTipo.Image = FormPoke.Properties.Resources.Lucha;
                    break;
                case Tipo.Acero:
                    this.pbTipo.Image = FormPoke.Properties.Resources.Acero;
                    break;
                case Tipo.Siniestro:
                    this.pbTipo.Image = FormPoke.Properties.Resources.Siniestro;
                    break;
                case Tipo.Volador:
                    this.pbTipo.Image = FormPoke.Properties.Resources.Volador; 
                    break;

            }
        }

        private void btnPokemon_Click(object sender, EventArgs e)
        {
            pokemon = new Pokemon(this.SubTipo(), (Tipo)cmbTipo.SelectedItem, txtNombre.Text, id++);
            lista.Add(pokemon);
            try
            {
                SerializarJson.Serializar("Pokemon.json", lista);
                MessageBox.Show("Pokemon generado");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbTipo_CheckedChanged(object sender, EventArgs e)
        {
            this.cmbSubTipo.Visible = true;
            this.pbSubTipo.Visible = true;
            this.lblSubTipo.Visible = true;
            if (this.cbTipo.Checked is false)
            {
                this.cmbSubTipo.Visible = false;
                this.pbSubTipo.Visible = false;
                this.lblSubTipo.Visible = false;
            }
        }
        private Tipo SubTipo()
        {
            Tipo retorno = Tipo.Ninguno;
            if (this.cbTipo.Checked is true)
            {
                retorno = (Tipo)cmbSubTipo.SelectedItem;
            }
            return retorno;
        }
        private void cmbSubTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.cmbSubTipo.SelectedItem)
            {
                case Tipo.Agua:
                    this.pbSubTipo.Image = FormPoke.Properties.Resources.Agua;
                    break;
                case Tipo.Bicho:
                    this.pbSubTipo.Image = FormPoke.Properties.Resources.Bicho;
                    break;
                case Tipo.Dragon:
                    this.pbSubTipo.Image = FormPoke.Properties.Resources.Dragon;
                    break;
                case Tipo.Electrico:
                    this.pbSubTipo.Image = FormPoke.Properties.Resources.Electrico;
                    break;
                case Tipo.Fantasma:
                    this.pbSubTipo.Image = FormPoke.Properties.Resources.Dragon;
                    break;
                case Tipo.Fuego:
                    this.pbSubTipo.Image = FormPoke.Properties.Resources.Fuego;
                    break;
                case Tipo.Hielo:
                    this.pbSubTipo.Image = FormPoke.Properties.Resources.Hielo;
                    break;
                case Tipo.Psiquico:
                    this.pbSubTipo.Image = FormPoke.Properties.Resources.Psiquico;
                    break;
                case Tipo.Roca:
                    this.pbSubTipo.Image = FormPoke.Properties.Resources.Roca;
                    break;
                case Tipo.Tierra:
                    this.pbSubTipo.Image = FormPoke.Properties.Resources.Tierra;
                    break;
                case Tipo.Normal:
                    this.pbSubTipo.Image = FormPoke.Properties.Resources.Normal;
                    break;
                case Tipo.Planta:
                    this.pbSubTipo.Image = FormPoke.Properties.Resources.Planta;
                    break;
                case Tipo.Hada:
                    this.pbSubTipo.Image = FormPoke.Properties.Resources.Hada;
                    break;
                case Tipo.Lucha:
                    this.pbSubTipo.Image = FormPoke.Properties.Resources.Lucha;
                    break;
                case Tipo.Acero:
                    this.pbSubTipo.Image = FormPoke.Properties.Resources.Acero;
                    break;
                case Tipo.Siniestro:
                    this.pbSubTipo.Image = FormPoke.Properties.Resources.Siniestro;
                    break;
                case Tipo.Volador:
                    this.pbSubTipo.Image = FormPoke.Properties.Resources.Volador;
                    break;

            }
        }
    }
}
