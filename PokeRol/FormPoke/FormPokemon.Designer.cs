
namespace FormPoke
{
    partial class FormPokemon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPokemon));
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.pbTipo = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.btnPokemon = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbSubTipo = new System.Windows.Forms.PictureBox();
            this.cmbSubTipo = new System.Windows.Forms.ComboBox();
            this.lblSubTipo = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubTipo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(130, 25);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 1;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(130, 102);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(100, 23);
            this.cmbTipo.TabIndex = 2;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // pbTipo
            // 
            this.pbTipo.Location = new System.Drawing.Point(277, 25);
            this.pbTipo.Name = "pbTipo";
            this.pbTipo.Size = new System.Drawing.Size(145, 120);
            this.pbTipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbTipo.TabIndex = 3;
            this.pbTipo.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Autumn", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(6, 19);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(95, 29);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Autumn", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTipo.Location = new System.Drawing.Point(6, 102);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(57, 29);
            this.lblTipo.TabIndex = 5;
            this.lblTipo.Text = "Tipo";
            // 
            // btnPokemon
            // 
            this.btnPokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPokemon.Location = new System.Drawing.Point(12, 365);
            this.btnPokemon.Name = "btnPokemon";
            this.btnPokemon.Size = new System.Drawing.Size(169, 64);
            this.btnPokemon.TabIndex = 6;
            this.btnPokemon.Text = "Registrar Pokémon";
            this.btnPokemon.UseVisualStyleBackColor = true;
            this.btnPokemon.Click += new System.EventHandler(this.btnPokemon_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAtras.Location = new System.Drawing.Point(663, 365);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(169, 64);
            this.btnAtras.TabIndex = 7;
            this.btnAtras.Text = "Volver Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = global::FormPoke.Properties.Resources.PNG_poke;
            this.pictureBox1.Location = new System.Drawing.Point(663, 205);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbSubTipo);
            this.groupBox1.Controls.Add(this.cmbSubTipo);
            this.groupBox1.Controls.Add(this.lblSubTipo);
            this.groupBox1.Controls.Add(this.cbTipo);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lblTipo);
            this.groupBox1.Controls.Add(this.cmbTipo);
            this.groupBox1.Controls.Add(this.pbTipo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 329);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pokémon";
            // 
            // pbSubTipo
            // 
            this.pbSubTipo.Location = new System.Drawing.Point(277, 183);
            this.pbSubTipo.Name = "pbSubTipo";
            this.pbSubTipo.Size = new System.Drawing.Size(145, 120);
            this.pbSubTipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbSubTipo.TabIndex = 9;
            this.pbSubTipo.TabStop = false;
            // 
            // cmbSubTipo
            // 
            this.cmbSubTipo.FormattingEnabled = true;
            this.cmbSubTipo.Location = new System.Drawing.Point(130, 241);
            this.cmbSubTipo.Name = "cmbSubTipo";
            this.cmbSubTipo.Size = new System.Drawing.Size(100, 23);
            this.cmbSubTipo.TabIndex = 8;
            this.cmbSubTipo.SelectedIndexChanged += new System.EventHandler(this.cmbSubTipo_SelectedIndexChanged);
            // 
            // lblSubTipo
            // 
            this.lblSubTipo.AutoSize = true;
            this.lblSubTipo.Font = new System.Drawing.Font("Autumn", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSubTipo.Location = new System.Drawing.Point(6, 232);
            this.lblSubTipo.Name = "lblSubTipo";
            this.lblSubTipo.Size = new System.Drawing.Size(57, 29);
            this.lblSubTipo.TabIndex = 7;
            this.lblSubTipo.Text = "Tipo";
            // 
            // cbTipo
            // 
            this.cbTipo.AutoSize = true;
            this.cbTipo.Location = new System.Drawing.Point(17, 183);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(117, 19);
            this.cbTipo.TabIndex = 6;
            this.cbTipo.Text = "Agregar otro tipo";
            this.cbTipo.UseVisualStyleBackColor = true;
            this.cbTipo.CheckedChanged += new System.EventHandler(this.cbTipo_CheckedChanged);
            // 
            // FormPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(844, 441);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnPokemon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPokemon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Pokémon";
            this.Load += new System.EventHandler(this.FormPokemon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubTipo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.PictureBox pbTipo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Button btnPokemon;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbTipo;
        private System.Windows.Forms.ComboBox cmbSubTipo;
        private System.Windows.Forms.Label lblSubTipo;
        private System.Windows.Forms.PictureBox pbSubTipo;
    }
}