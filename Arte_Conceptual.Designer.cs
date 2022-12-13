namespace ProyectoFinalPG
{
    partial class Arte_Conceptual
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConcepto = new System.Windows.Forms.TextBox();
            this.txtFechaEntrega = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dGVArteConceptual = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGVArteConceptual)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Fecha de Entrega";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Concepto";
            // 
            // txtConcepto
            // 
            this.txtConcepto.Location = new System.Drawing.Point(24, 12);
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.Size = new System.Drawing.Size(151, 20);
            this.txtConcepto.TabIndex = 23;
            // 
            // txtFechaEntrega
            // 
            this.txtFechaEntrega.Location = new System.Drawing.Point(25, 56);
            this.txtFechaEntrega.Name = "txtFechaEntrega";
            this.txtFechaEntrega.Size = new System.Drawing.Size(151, 20);
            this.txtFechaEntrega.TabIndex = 22;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(552, 398);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 40);
            this.button4.TabIndex = 21;
            this.button4.Text = "REGRESAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(444, 66);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(102, 40);
            this.btnEliminar.TabIndex = 20;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(552, 66);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(102, 40);
            this.btnModificar.TabIndex = 19;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(336, 66);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(102, 40);
            this.btnAgregar.TabIndex = 18;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dGVArteConceptual
            // 
            this.dGVArteConceptual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVArteConceptual.Location = new System.Drawing.Point(12, 138);
            this.dGVArteConceptual.Name = "dGVArteConceptual";
            this.dGVArteConceptual.Size = new System.Drawing.Size(642, 248);
            this.dGVArteConceptual.TabIndex = 17;
            // 
            // Arte_Conceptual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConcepto);
            this.Controls.Add(this.txtFechaEntrega);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dGVArteConceptual);
            this.Name = "Arte_Conceptual";
            this.Text = "Arte_Conceptual";
            this.Load += new System.EventHandler(this.Arte_Conceptual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVArteConceptual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConcepto;
        private System.Windows.Forms.TextBox txtFechaEntrega;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dGVArteConceptual;
    }
}