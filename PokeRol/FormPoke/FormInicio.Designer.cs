
namespace FormPoke
{
    partial class FormInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            this.pbPokemon = new System.Windows.Forms.PictureBox();
            this.btnEntrenador = new System.Windows.Forms.Button();
            this.btnPokemon = new System.Windows.Forms.Button();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPokemon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbPokemon
            // 
            this.pbPokemon.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbPokemon.Image = global::FormPoke.Properties.Resources.Pokemon;
            this.pbPokemon.Location = new System.Drawing.Point(76, -2);
            this.pbPokemon.Name = "pbPokemon";
            this.pbPokemon.Size = new System.Drawing.Size(630, 355);
            this.pbPokemon.TabIndex = 0;
            this.pbPokemon.TabStop = false;
            // 
            // btnEntrenador
            // 
            this.btnEntrenador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEntrenador.Location = new System.Drawing.Point(31, 22);
            this.btnEntrenador.Name = "btnEntrenador";
            this.btnEntrenador.Size = new System.Drawing.Size(169, 64);
            this.btnEntrenador.TabIndex = 1;
            this.btnEntrenador.Text = "Crear Entrenador";
            this.btnEntrenador.UseVisualStyleBackColor = true;
            this.btnEntrenador.Click += new System.EventHandler(this.btnEntrenador_Click);
            // 
            // btnPokemon
            // 
            this.btnPokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPokemon.Location = new System.Drawing.Point(264, 22);
            this.btnPokemon.Name = "btnPokemon";
            this.btnPokemon.Size = new System.Drawing.Size(169, 64);
            this.btnPokemon.TabIndex = 2;
            this.btnPokemon.Text = "Registrar Pokémon";
            this.btnPokemon.UseVisualStyleBackColor = true;
            this.btnPokemon.Click += new System.EventHandler(this.btnPokemon_Click);
            // 
            // btnCapturar
            // 
            this.btnCapturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCapturar.Location = new System.Drawing.Point(498, 22);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(169, 64);
            this.btnCapturar.TabIndex = 3;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnEntrenador);
            this.groupBox1.Controls.Add(this.btnCapturar);
            this.groupBox1.Controls.Add(this.btnPokemon);
            this.groupBox1.Location = new System.Drawing.Point(60, 338);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(694, 189);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menú";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Location = new System.Drawing.Point(498, 108);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(169, 64);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 565);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbPokemon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormInicio_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbPokemon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPokemon;
        private System.Windows.Forms.Button btnEntrenador;
        private System.Windows.Forms.Button btnPokemon;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSalir;
    }
}

