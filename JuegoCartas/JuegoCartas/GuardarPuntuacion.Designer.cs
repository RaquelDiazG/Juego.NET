namespace JuegoCartas
{
    partial class GuardarPuntuacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_guardar_puntuacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "¡Has ganado!";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(104, 87);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(100, 20);
            this.nombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // btn_guardar_puntuacion
            // 
            this.btn_guardar_puntuacion.Image = global::JuegoCartas.Properties.Resources.ok;
            this.btn_guardar_puntuacion.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_guardar_puntuacion.Location = new System.Drawing.Point(98, 159);
            this.btn_guardar_puntuacion.Name = "btn_guardar_puntuacion";
            this.btn_guardar_puntuacion.Size = new System.Drawing.Size(75, 66);
            this.btn_guardar_puntuacion.TabIndex = 3;
            this.btn_guardar_puntuacion.Text = "Guardar";
            this.btn_guardar_puntuacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_guardar_puntuacion.UseVisualStyleBackColor = true;
            this.btn_guardar_puntuacion.Click += new System.EventHandler(this.btn_guardar_puntuacion_Click);
            // 
            // GuardarPuntuacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_guardar_puntuacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label1);
            this.Name = "GuardarPuntuacion";
            this.Text = "Memoria del revés";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Button btn_guardar_puntuacion;
        private System.Windows.Forms.Label label2;
    }
}