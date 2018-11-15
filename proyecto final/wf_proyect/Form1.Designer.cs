namespace wf_proyect
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnEstado = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.cbxEstudiante = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Estudio = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.TextBox();
            this.lbl_nacimiento = new System.Windows.Forms.TextBox();
            this.lbl_validez = new System.Windows.Forms.TextBox();
            this.pkfoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pkfoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEstado
            // 
            this.btnEstado.Location = new System.Drawing.Point(9, 79);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(75, 23);
            this.btnEstado.TabIndex = 0;
            this.btnEstado.Text = "Estado";
            this.btnEstado.UseVisualStyleBackColor = true;
            this.btnEstado.Click += new System.EventHandler(this.btnEstado_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Pump Demi Bold LET", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(25, 140);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 32);
            this.lblResultado.TabIndex = 1;
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // cbxEstudiante
            // 
            this.cbxEstudiante.FormattingEnabled = true;
            this.cbxEstudiante.Location = new System.Drawing.Point(9, 42);
            this.cbxEstudiante.Name = "cbxEstudiante";
            this.cbxEstudiante.Size = new System.Drawing.Size(154, 21);
            this.cbxEstudiante.TabIndex = 4;
            this.cbxEstudiante.SelectedIndexChanged += new System.EventHandler(this.cbxEstudiante_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(220, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 310);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Estudio
            // 
            this.lbl_Estudio.Location = new System.Drawing.Point(243, 176);
            this.lbl_Estudio.Name = "lbl_Estudio";
            this.lbl_Estudio.Size = new System.Drawing.Size(220, 20);
            this.lbl_Estudio.TabIndex = 6;
            this.lbl_Estudio.TextChanged += new System.EventHandler(this.lbl_Estudio_TextChanged);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.Location = new System.Drawing.Point(243, 212);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(220, 20);
            this.lbl_nombre.TabIndex = 7;
            // 
            // lbl_nacimiento
            // 
            this.lbl_nacimiento.Location = new System.Drawing.Point(243, 248);
            this.lbl_nacimiento.Name = "lbl_nacimiento";
            this.lbl_nacimiento.Size = new System.Drawing.Size(220, 20);
            this.lbl_nacimiento.TabIndex = 8;
            // 
            // lbl_validez
            // 
            this.lbl_validez.Location = new System.Drawing.Point(243, 284);
            this.lbl_validez.Name = "lbl_validez";
            this.lbl_validez.Size = new System.Drawing.Size(220, 20);
            this.lbl_validez.TabIndex = 9;
            // 
            // pkfoto
            // 
            this.pkfoto.Location = new System.Drawing.Point(529, 42);
            this.pkfoto.Name = "pkfoto";
            this.pkfoto.Size = new System.Drawing.Size(147, 179);
            this.pkfoto.TabIndex = 10;
            this.pkfoto.TabStop = false;
            this.pkfoto.Click += new System.EventHandler(this.pkfoto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(712, 334);
            this.Controls.Add(this.pkfoto);
            this.Controls.Add(this.lbl_validez);
            this.Controls.Add(this.lbl_nacimiento);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.lbl_Estudio);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbxEstudiante);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnEstado);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pkfoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEstado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.ComboBox cbxEstudiante;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox lbl_Estudio;
        private System.Windows.Forms.TextBox lbl_nombre;
        private System.Windows.Forms.TextBox lbl_nacimiento;
        private System.Windows.Forms.TextBox lbl_validez;
        private System.Windows.Forms.PictureBox pkfoto;
    }
}

