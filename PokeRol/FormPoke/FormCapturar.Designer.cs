
namespace FormPoke
{
    partial class FormCapturar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCapturar));
            this.lstEntrenadores = new System.Windows.Forms.ListBox();
            this.lstPokemon = new System.Windows.Forms.ListBox();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.pbPokemon = new System.Windows.Forms.PictureBox();
            this.pbPersonaje = new System.Windows.Forms.PictureBox();
            this.btnAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonaje)).BeginInit();
            this.SuspendLayout();
            // 
            // lstEntrenadores
            // 
            this.lstEntrenadores.FormattingEnabled = true;
            this.lstEntrenadores.ItemHeight = 15;
            this.lstEntrenadores.Location = new System.Drawing.Point(12, 24);
            this.lstEntrenadores.Name = "lstEntrenadores";
            this.lstEntrenadores.Size = new System.Drawing.Size(175, 349);
            this.lstEntrenadores.TabIndex = 0;
            // 
            // lstPokemon
            // 
            this.lstPokemon.FormattingEnabled = true;
            this.lstPokemon.ItemHeight = 15;
            this.lstPokemon.Location = new System.Drawing.Point(383, 24);
            this.lstPokemon.Name = "lstPokemon";
            this.lstPokemon.Size = new System.Drawing.Size(197, 349);
            this.lstPokemon.TabIndex = 1;
            this.lstPokemon.SelectedIndexChanged += new System.EventHandler(this.lstPokemon_SelectedIndexChanged);
            // 
            // btnCapturar
            // 
            this.btnCapturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCapturar.Location = new System.Drawing.Point(608, 379);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(169, 64);
            this.btnCapturar.TabIndex = 7;
            this.btnCapturar.Text = "Capturar Pokémon";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // pbPokemon
            // 
            this.pbPokemon.Location = new System.Drawing.Point(635, 24);
            this.pbPokemon.Name = "pbPokemon";
            this.pbPokemon.Size = new System.Drawing.Size(97, 108);
            this.pbPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPokemon.TabIndex = 8;
            this.pbPokemon.TabStop = false;
            // 
            // pbPersonaje
            // 
            this.pbPersonaje.Location = new System.Drawing.Point(203, 24);
            this.pbPersonaje.Name = "pbPersonaje";
            this.pbPersonaje.Size = new System.Drawing.Size(97, 108);
            this.pbPersonaje.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPersonaje.TabIndex = 9;
            this.pbPersonaje.TabStop = false;
            // 
            // btnAtras
            // 
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAtras.Location = new System.Drawing.Point(608, 466);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(169, 64);
            this.btnAtras.TabIndex = 10;
            this.btnAtras.Text = "Volver Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // FormCapturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 542);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.pbPersonaje);
            this.Controls.Add(this.pbPokemon);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.lstPokemon);
            this.Controls.Add(this.lstEntrenadores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCapturar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capturar Pokemon";
            this.Load += new System.EventHandler(this.FormCapturar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonaje)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstEntrenadores;
        private System.Windows.Forms.ListBox lstPokemon;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.PictureBox pbPokemon;
        private System.Windows.Forms.PictureBox pbPersonaje;
        private System.Windows.Forms.Button btnAtras;
    }
}