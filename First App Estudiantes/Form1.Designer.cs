namespace First_App_Estudiantes
{
    public partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.buttonEnviar = new System.Windows.Forms.Button();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pictureBoxImagen = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::First_App_Estudiantes.Properties.Resources.mover_a_la_carpeta;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Name = "label1";
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.BackColor = System.Drawing.Color.Azure;
            this.groupBox2.Controls.Add(this.buttonCancelar);
            this.groupBox2.Controls.Add(this.buttonBorrar);
            this.groupBox2.Controls.Add(this.buttonEnviar);
            this.groupBox2.Controls.Add(this.labelEmail);
            this.groupBox2.Controls.Add(this.labelApellido);
            this.groupBox2.Controls.Add(this.labelNombre);
            this.groupBox2.Controls.Add(this.labelId);
            this.groupBox2.Controls.Add(this.textBoxEmail);
            this.groupBox2.Controls.Add(this.textBoxApellido);
            this.groupBox2.Controls.Add(this.textBoxNombre);
            this.groupBox2.Controls.Add(this.textBoxId);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancelar.FlatAppearance.BorderSize = 0;
            this.buttonCancelar.Image = global::First_App_Estudiantes.Properties.Resources.circulo_cruzado;
            resources.ApplyResources(this.buttonCancelar, "buttonCancelar");
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBorrar.FlatAppearance.BorderSize = 0;
            this.buttonBorrar.Image = global::First_App_Estudiantes.Properties.Resources.borrar;
            resources.ApplyResources(this.buttonBorrar, "buttonBorrar");
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.UseVisualStyleBackColor = true;
            // 
            // buttonEnviar
            // 
            this.buttonEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEnviar.FlatAppearance.BorderSize = 0;
            this.buttonEnviar.Image = global::First_App_Estudiantes.Properties.Resources.avion_de_papel1;
            resources.ApplyResources(this.buttonEnviar, "buttonEnviar");
            this.buttonEnviar.Name = "buttonEnviar";
            this.buttonEnviar.UseVisualStyleBackColor = true;
            this.buttonEnviar.Click += new System.EventHandler(this.buttonEnviar_Click);
            // 
            // labelEmail
            // 
            resources.ApplyResources(this.labelEmail, "labelEmail");
            this.labelEmail.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelEmail.Name = "labelEmail";
            // 
            // labelApellido
            // 
            resources.ApplyResources(this.labelApellido, "labelApellido");
            this.labelApellido.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelApellido.Name = "labelApellido";
            // 
            // labelNombre
            // 
            resources.ApplyResources(this.labelNombre, "labelNombre");
            this.labelNombre.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelNombre.Name = "labelNombre";
            // 
            // labelId
            // 
            resources.ApplyResources(this.labelId, "labelId");
            this.labelId.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelId.Name = "labelId";
            // 
            // textBoxEmail
            // 
            resources.ApplyResources(this.textBoxEmail, "textBoxEmail");
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // textBoxApellido
            // 
            resources.ApplyResources(this.textBoxApellido, "textBoxApellido");
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.TextChanged += new System.EventHandler(this.textBoxApellido_TextChanged);
            this.textBoxApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxApellido_KeyPress);
            // 
            // textBoxNombre
            // 
            resources.ApplyResources(this.textBoxNombre, "textBoxNombre");
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            this.textBoxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombre_KeyPress);
            // 
            // textBoxId
            // 
            resources.ApplyResources(this.textBoxId, "textBoxId");
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.TextChanged += new System.EventHandler(this.textBoxId_TextChanged);
            this.textBoxId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxId_KeyPress);
            // 
            // groupBox5
            // 
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Controls.Add(this.pictureBoxImagen);
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // pictureBoxImagen
            // 
            this.pictureBoxImagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxImagen.Image = global::First_App_Estudiantes.Properties.Resources.usuario__2_;
            resources.ApplyResources(this.pictureBoxImagen, "pictureBoxImagen");
            this.pictureBoxImagen.Name = "pictureBoxImagen";
            this.pictureBoxImagen.TabStop = false;
            this.pictureBoxImagen.Click += new System.EventHandler(this.pictureBoxImagen_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Name = "label3";
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.BackColor = System.Drawing.Color.Azure;
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Name = "label4";
            // 
            // groupBox4
            // 
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.BackColor = System.Drawing.Color.Azure;
            this.groupBox4.Controls.Add(this.textBoxBuscar);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBoxBuscar, "textBoxBuscar");
            this.textBoxBuscar.Name = "textBoxBuscar";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Name = "label2";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.TransparencyKey = System.Drawing.Color.DimGray;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagen)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Button buttonEnviar;
        private System.Windows.Forms.Button buttonBorrar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.PictureBox pictureBoxImagen;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

