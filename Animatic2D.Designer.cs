namespace ProyectoFinalPG
{
    partial class Animatic2D
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
            this.button4 = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPersonaje = new System.Windows.Forms.TextBox();
            this.txtfechaEntrega = new System.Windows.Forms.TextBox();
            this.dGridVAnimatic2D = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGridVAnimatic2D)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(527, 422);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 40);
            this.button4.TabIndex = 17;
            this.button4.Text = "REGRESAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(419, 79);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(102, 40);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(527, 79);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(102, 40);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(311, 79);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(102, 40);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Personaje";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Fecha de Entrega";
            // 
            // txtPersonaje
            // 
            this.txtPersonaje.Location = new System.Drawing.Point(12, 65);
            this.txtPersonaje.Name = "txtPersonaje";
            this.txtPersonaje.Size = new System.Drawing.Size(142, 20);
            this.txtPersonaje.TabIndex = 11;
            // 
            // txtfechaEntrega
            // 
            this.txtfechaEntrega.Location = new System.Drawing.Point(12, 12);
            this.txtfechaEntrega.Name = "txtfechaEntrega";
            this.txtfechaEntrega.Size = new System.Drawing.Size(142, 20);
            this.txtfechaEntrega.TabIndex = 10;
            // 
            // dGridVAnimatic2D
            // 
            this.dGridVAnimatic2D.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridVAnimatic2D.Location = new System.Drawing.Point(12, 125);
            this.dGridVAnimatic2D.Name = "dGridVAnimatic2D";
            this.dGridVAnimatic2D.Size = new System.Drawing.Size(617, 291);
            this.dGridVAnimatic2D.TabIndex = 9;
            // 
            // Animatic2D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 474);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPersonaje);
            this.Controls.Add(this.txtfechaEntrega);
            this.Controls.Add(this.dGridVAnimatic2D);
            this.Name = "Animatic2D";
            this.Text = "Animatic2D";
            this.Load += new System.EventHandler(this.Animatic2D_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGridVAnimatic2D)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPersonaje;
        private System.Windows.Forms.TextBox txtfechaEntrega;
        private System.Windows.Forms.DataGridView dGridVAnimatic2D;
    }
}