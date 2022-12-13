namespace ProyectoFinalPG
{
    partial class Animacion
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtidASA = new System.Windows.Forms.TextBox();
            this.txtFechaEntrega = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dGVAnimacion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGVAnimacion)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "idAsistente de Animacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Fecha de Entrega";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Nombre";
            // 
            // txtidASA
            // 
            this.txtidASA.Location = new System.Drawing.Point(306, 28);
            this.txtidASA.Name = "txtidASA";
            this.txtidASA.Size = new System.Drawing.Size(100, 20);
            this.txtidASA.TabIndex = 36;
            // 
            // txtFechaEntrega
            // 
            this.txtFechaEntrega.Location = new System.Drawing.Point(160, 28);
            this.txtFechaEntrega.Name = "txtFechaEntrega";
            this.txtFechaEntrega.Size = new System.Drawing.Size(100, 20);
            this.txtFechaEntrega.TabIndex = 35;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(12, 28);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 34;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(707, 360);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 40);
            this.button4.TabIndex = 33;
            this.button4.Text = "REGRESAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(599, 51);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(102, 40);
            this.btnEliminar.TabIndex = 32;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(707, 51);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(102, 40);
            this.btnModificar.TabIndex = 31;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(491, 51);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(102, 40);
            this.btnAgregar.TabIndex = 30;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dGVAnimacion
            // 
            this.dGVAnimacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVAnimacion.Location = new System.Drawing.Point(12, 106);
            this.dGVAnimacion.Name = "dGVAnimacion";
            this.dGVAnimacion.Size = new System.Drawing.Size(797, 248);
            this.dGVAnimacion.TabIndex = 29;
            // 
            // Animacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 430);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtidASA);
            this.Controls.Add(this.txtFechaEntrega);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dGVAnimacion);
            this.Name = "Animacion";
            this.Text = "Animacion";
            this.Load += new System.EventHandler(this.Animacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVAnimacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtidASA;
        private System.Windows.Forms.TextBox txtFechaEntrega;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dGVAnimacion;
    }
}