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
                case "Caterpie":
                    pbPokemon.Image = FormPoke.Properties.Resources.Caterpie;
                    break;
                case "Metapod":
                    pbPokemon.Image = FormPoke.Properties.Resources.Metapod;
                    break;
                case "Butterfree":
                    pbPokemon.Image = FormPoke.Properties.Resources.Butterfree;
                    break;
                case "Weedle":
                    pbPokemon.Image = FormPoke.Properties.Resources.Weedle;
                    break;
                case "Kakuna":
                    pbPokemon.Image = FormPoke.Properties.Resources.Kakuna;
                    break;
                case "Beedrill":
                    pbPokemon.Image = FormPoke.Properties.Resources.Beedrill;
                    break;
                case "Pidgey":
                    pbPokemon.Image = FormPoke.Properties.Resources.Pidgey;
                    break;
                case "Pidgeotto":
                    pbPokemon.Image = FormPoke.Properties.Resources.Pidgeotto;
                    break;
                case "Pidgeot":
                    pbPokemon.Image = FormPoke.Properties.Resources.Pidgeot;
                    break;
                case "Rattata":
                    pbPokemon.Image = FormPoke.Properties.Resources.Rattata;
                    break;
                case "Raticate":
                    pbPokemon.Image = FormPoke.Properties.Resources.Raticate;
                    break;
                case "Spearow":
                    pbPokemon.Image = FormPoke.Properties.Resources.Spearow;
                    break;
                case "Fearow":
                    pbPokemon.Image = FormPoke.Properties.Resources.Fearow;
                    break;
                case "Ekans":
                    pbPokemon.Image = FormPoke.Properties.Resources.Ekans;
                    break;
                case "Arbok":
                    pbPokemon.Image = FormPoke.Properties.Resources.Arbok;
                    break;
                case "Pikachu":
                    pbPokemon.Image = FormPoke.Properties.Resources.Pikachu;
                    break;
                case "Raichu":
                    pbPokemon.Image = FormPoke.Properties.Resources.Raichu;
                    break;
                case "Sandshrew":
                    pbPokemon.Image = FormPoke.Properties.Resources.Sandshrew;
                    break;
                case "Sandslash":
                    pbPokemon.Image = FormPoke.Properties.Resources.Sandslash;
                    break;
                case "Nidoran♀":
                    pbPokemon.Image = FormPoke.Properties.Resources.Nidorina1;
                    break;
                case "Nidorina":
                    pbPokemon.Image = FormPoke.Properties.Resources.Nidorina;
                    break;
                case "Nidoqueen":
                    pbPokemon.Image = FormPoke.Properties.Resources.Nidoqueen;
                    break;
                case "Nidoran♂":
                    break;
/*Nidorino
Nidoking
Clefairy
Clefable
37  Vulpix
37.1    Vulpix de Alola
38  Ninetales
38.1    Ninetales de Alola
39  Jigglypuff
40  Wigglytuff
41  Zubat
42  Golbat
43  Oddish
44  Gloom
45  Vileplume
46  Paras
47  Parasect
48  Venonat
49  Venomoth
50  Diglett
50.1    Diglett de Alola
51  Dugtrio
51.1    Dugtrio de Alola
52  Meowth
52.1    Meowth de Alola
52.2    Meowth de Galar
53  Persian
53.1    Persian de Alola
54  Psyduck
55  Golduck
56  Mankey
57  Primeape
58  Growlithe
59  Arcanine
60  Poliwag
61  Poliwhirl
62  Poliwrath
63  Abra
64  Kadabra
65  Alakazam
66  Machop
67  Machoke
68  Machamp
69  Bellsprout
70  Weepinbell
71  Victreebel
72  Tentacool
73  Tentacruel
74  Geodude
74.1    Geodude de Alola
75  Graveler
75.1    Graveler de Alola
76  Golem
76.1    Golem de Alola
77  Ponyta
77.1    Ponyta de Galar
78  Rapidash
78.1    Rapidash de Galar
79  Slowpoke
79.1    Slowpoke de Galar
80  Slowbro
80.1    Slowbro de Galar
81  Magnemite
82  Magneton
83  Farfetch’d
83.1    Farfetch'd de Galar
84  Doduo
85  Dodrio
86  Seel
87  Dewgong
88  Grimer
88.1    Grimer de Alola
89  Muk
89.1    Muk de Alola
90  Shellder
91  Cloyster
92  Gastly
93  Haunter
94  Gengar
95  Onix
96  Drowzee
97  Hypno
98  Krabby
99  Kingler
100 Voltorb
101 Electrode
102 Exeggcute
103 Exeggutor
103.1   Exeggutor de Alola
104 Cubone
105 Marowak
105.1   Marowak de Alola
106 Hitmonlee
107 Hitmonchan
108 Lickitung
109 Koffing
110 Weezing
110.1   Weezing de Galar
111 Rhyhorn
112 Rhydon
113 Chansey
114 Tangela
115 Kangaskhan
116 Horsea
117 Seadra
118 Goldeen
119 Seaking
120 Staryu
121 Starmie
122 Mr.Mime
122.1   Mr.Mime de Galar
123 Scyther
124 Jynx
125 Electabuzz
126 Magmar
127 Pinsir
128 Tauros
129 Magikarp
130 Gyarados
131 Lapras
132 Ditto
133 Eevee
134 Vaporeon
135 Jolteon
136 Flareon
137 Porygon
138 Omanyte
139 Omastar
140 Kabuto
141 Kabutops
142 Aerodactyl
143 Snorlax
144 Articuno
144.1   Articuno de Galar
145 Zapdos
145.1   Zapdos de Galar
146 Moltres
146.1   Moltres de Galar
147 Dratini
148 Dragonair
149 Dragonite
150 Mewtwo
151 Mew*/


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
