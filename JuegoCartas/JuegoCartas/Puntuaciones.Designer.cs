﻿namespace JuegoCartas
{
    partial class Puntuaciones
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movimientosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puntuacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDDataSet = new JuegoCartas.BDDataSet();
            this.txt_puntuaciones = new System.Windows.Forms.Label();
            this.btn_volver = new System.Windows.Forms.Button();
            this.puntuacionesTableAdapter = new JuegoCartas.BDDataSetTableAdapters.PuntuacionesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntuacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.movimientosDataGridViewTextBoxColumn,
            this.tiempoDataGridViewTextBoxColumn,
            this.Nivel});
            this.dataGridView1.DataSource = this.puntuacionesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 96);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(446, 210);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // movimientosDataGridViewTextBoxColumn
            // 
            this.movimientosDataGridViewTextBoxColumn.DataPropertyName = "Movimientos";
            this.movimientosDataGridViewTextBoxColumn.HeaderText = "Movimientos";
            this.movimientosDataGridViewTextBoxColumn.Name = "movimientosDataGridViewTextBoxColumn";
            this.movimientosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tiempoDataGridViewTextBoxColumn
            // 
            this.tiempoDataGridViewTextBoxColumn.DataPropertyName = "Tiempo";
            this.tiempoDataGridViewTextBoxColumn.HeaderText = "Tiempo";
            this.tiempoDataGridViewTextBoxColumn.Name = "tiempoDataGridViewTextBoxColumn";
            this.tiempoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Nivel
            // 
            this.Nivel.DataPropertyName = "Nivel";
            this.Nivel.HeaderText = "Nivel";
            this.Nivel.Name = "Nivel";
            this.Nivel.ReadOnly = true;
            // 
            // puntuacionesBindingSource
            // 
            this.puntuacionesBindingSource.DataMember = "Puntuaciones";
            this.puntuacionesBindingSource.DataSource = this.bDDataSet;
            // 
            // bDDataSet
            // 
            this.bDDataSet.DataSetName = "BDDataSet";
            this.bDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_puntuaciones
            // 
            this.txt_puntuaciones.AutoSize = true;
            this.txt_puntuaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_puntuaciones.Location = new System.Drawing.Point(186, 24);
            this.txt_puntuaciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_puntuaciones.Name = "txt_puntuaciones";
            this.txt_puntuaciones.Size = new System.Drawing.Size(143, 25);
            this.txt_puntuaciones.TabIndex = 2;
            this.txt_puntuaciones.Text = "Puntuaciones";
            // 
            // btn_volver
            // 
            this.btn_volver.Image = global::JuegoCartas.Properties.Resources.volver;
            this.btn_volver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_volver.Location = new System.Drawing.Point(43, 16);
            this.btn_volver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(53, 47);
            this.btn_volver.TabIndex = 1;
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // puntuacionesTableAdapter
            // 
            this.puntuacionesTableAdapter.ClearBeforeFill = true;
            // 
            // Puntuaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(479, 321);
            this.Controls.Add(this.txt_puntuaciones);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Puntuaciones";
            this.Text = "Memoria del revés";
            this.Load += new System.EventHandler(this.Puntuaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puntuacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private BDDataSet bDDataSet;
        private System.Windows.Forms.BindingSource puntuacionesBindingSource;
        private BDDataSetTableAdapters.PuntuacionesTableAdapter puntuacionesTableAdapter;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Label txt_puntuaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movimientosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nivel;
    }
}