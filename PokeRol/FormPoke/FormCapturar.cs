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
    public partial class FormCapturar : Form
    {
        List<Pokemon> listaPokemon;
        List<Entrenador> listEntrenadores;
        public FormCapturar()
        {
            listaPokemon = new List<Pokemon>();
            InitializeComponent();
        }

        private void FormCapturar_Load(object sender, EventArgs e)
        {
            try
            {
                listaPokemon = SerializarJson.Deserializar<List<Pokemon>>("Pokemon.json");
                foreach (Pokemon item in listaPokemon)
                {
                    this.lstPokemon.Items.Add(item.Nombre);

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                listEntrenadores = SerializarJson.Deserializar<List<Entrenador>>("Entrenadores.json");
                foreach (Entrenador item in listEntrenadores)
                {
                    this.lstEntrenadores.Items.Add(item.Nombre);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void btnCapturar_Click(object sender, EventArgs e)
        {
            Entrenador aux = BuscarEntrenador();
            foreach (Pokemon pokemon in listaPokemon)
            {
                if (pokemon.Nombre == this.lstPokemon.SelectedItem.ToString())
                {
                    try
                    {
                        for (int i = 0; i <= listaPokemon.Count; i++)
                        {
                            if (pokemon == listaPokemon[i])
                            {
                                aux += listaPokemon[i];
                                MessageBox.Show("Capturado");
                                MessageBox.Show(aux.EntrenadorDatos());
                                SerializarJson.Serializar($"Entrenador{aux.Nombre}.json", aux);
                                break;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        private void lstPokemon_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.lstPokemon.SelectedItem)
            {
                case "Bulbasaur":
                    pbPokemon.Image = FormPoke.Properties.Resources.Bulbasaur;
                    break;
                case "Venusaur":
                    pbPokemon.Image = FormPoke.Properties.Resources.Venusaur;
                    break;
                case "Ivysaur":
                    pbPokemon.Image = FormPoke.Properties.Resources.Ivysaur;
                    break;
                case "Charmander":
                    pbPokemon.Image = FormPoke.Properties.Resources.Charmander;
                    break;
                case "Charmeleon":
                    pbPokemon.Image = FormPoke.Properties.Resources.Charmeleon;
                    break;
                case "Charizard":
                    pbPokemon.Image = FormPoke.Properties.Resources.Charizard;
                    break;
                case "Squirtle":
                    pbPokemon.Image = FormPoke.Properties.Resources.Squirtle;
                    break;
                case "Wartortle":
                    pbPokemon.Image = FormPoke.Properties.Resources.Wartortle;
                    break;
                case "Blastoise":
                    pbPokemon.Image = FormPoke.Properties.Resources.Blastoise;
                    break;

            }
        }
       private void lstEntrenadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            Entrenador aux = BuscarEntrenador();
            switch (aux.Genero)
            {
                case Genero.Femenino:
                        pbPersonaje.Image = FormPoke.Properties.Resources.Chica;
                    break;
                case Genero.Masculino:
                    pbPersonaje.Image = FormPoke.Properties.Resources.Chico;
                    break;
                case Genero.NoBinario:
                    pbPersonaje.Image = FormPoke.Properties.Resources.No_Binario;
                    break;
            }
        }
        private Entrenador BuscarEntrenador()
        {
            Entrenador retorno = null;
            foreach (Entrenador entrenador in listEntrenadores)
            {
                if (entrenador.Nombre == this.lstEntrenadores.SelectedItem.ToString())
                {
                    for (int i = 0; i <= listEntrenadores.Count; i++)
                    {
                        if (entrenador == listEntrenadores[i])
                        {
                            retorno = listEntrenadores[i];
                            break;
                        }
                    }
                }
            }
            return retorno;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            SerializarJson.Serializar("ListaActualizada.json",listEntrenadores);
            this.Close();
        }
    }
}
