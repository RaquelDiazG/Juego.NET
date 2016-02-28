namespace Juego
{
    partial class Inicio
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
            this.btn_medio = new System.Windows.Forms.Button();
            this.btn_dificil = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_facil = new System.Windows.Forms.Button();
            this.btn_puntuaciones = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRE JUEGO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_medio
            // 
            this.btn_medio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_medio.Image = global::JuegoCartas.Properties.Resources.estrella2;
            this.btn_medio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_medio.Location = new System.Drawing.Point(89, 3);
            this.btn_medio.Name = "btn_medio";
            this.btn_medio.Size = new System.Drawing.Size(80, 70);
            this.btn_medio.TabIndex = 2;
            this.btn_medio.Text = "Medio";
            this.btn_medio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_medio.UseVisualStyleBackColor = true;
            this.btn_medio.Click += new System.EventHandler(this.btn_medio_Click);
            // 
            // btn_dificil
            // 
            this.btn_dificil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dificil.Image = global::JuegoCartas.Properties.Resources.estrella3;
            this.btn_dificil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_dificil.Location = new System.Drawing.Point(175, 3);
            this.btn_dificil.Name = "btn_dificil";
            this.btn_dificil.Size = new System.Drawing.Size(80, 70);
            this.btn_dificil.TabIndex = 3;
            this.btn_dificil.Text = "Difícil";
            this.btn_dificil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_dificil.UseVisualStyleBackColor = true;
            this.btn_dificil.Click += new System.EventHandler(this.btn_dificil_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.btn_medio, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_facil, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_dificil, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 67);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(260, 76);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btn_facil
            // 
            this.btn_facil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_facil.Image = global::JuegoCartas.Properties.Resources.estrella1;
            this.btn_facil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_facil.Location = new System.Drawing.Point(3, 3);
            this.btn_facil.Name = "btn_facil";
            this.btn_facil.Size = new System.Drawing.Size(80, 70);
            this.btn_facil.TabIndex = 1;
            this.btn_facil.Text = "Fácil";
            this.btn_facil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_facil.UseVisualStyleBackColor = true;
            this.btn_facil.Click += new System.EventHandler(this.btn_facil_Click);
            // 
            // btn_puntuaciones
            // 
            this.btn_puntuaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_puntuaciones.Image = global::JuegoCartas.Properties.Resources.medalla;
            this.btn_puntuaciones.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_puntuaciones.Location = new System.Drawing.Point(96, 175);
            this.btn_puntuaciones.Name = "btn_puntuaciones";
            this.btn_puntuaciones.Size = new System.Drawing.Size(103, 74);
            this.btn_puntuaciones.TabIndex = 5;
            this.btn_puntuaciones.Text = "Puntuaciones";
            this.btn_puntuaciones.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_puntuaciones.UseVisualStyleBackColor = true;
            this.btn_puntuaciones.Click += new System.EventHandler(this.btn_puntuaciones_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_puntuaciones);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_facil;
        private System.Windows.Forms.Button btn_medio;
        private System.Windows.Forms.Button btn_dificil;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_puntuaciones;
    }
}