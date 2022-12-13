namespace ProyectoFinalPG
{
    partial class ActorGrabacionVoz
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
            this.txtNumIn = new System.Windows.Forms.TextBox();
            this.txtIDGV = new System.Windows.Forms.TextBox();
            this.txtIDA = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dGVAGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGVAGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 98;
            this.label3.Text = "Numero de Integrantes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 97;
            this.label2.Text = "idGrabacionVoz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 96;
            this.label1.Text = "idActor";
            // 
            // txtNumIn
            // 
            this.txtNumIn.Location = new System.Drawing.Point(324, 52);
            this.txtNumIn.Name = "txtNumIn";
            this.txtNumIn.Size = new System.Drawing.Size(100, 20);
            this.txtNumIn.TabIndex = 95;
            // 
            // txtIDGV
            // 
            this.txtIDGV.Location = new System.Drawing.Point(181, 52);
            this.txtIDGV.Name = "txtIDGV";
            this.txtIDGV.Size = new System.Drawing.Size(100, 20);
            this.txtIDGV.TabIndex = 94;
            // 
            // txtIDA
            // 
            this.txtIDA.Location = new System.Drawing.Point(27, 52);
            this.txtIDA.Name = "txtIDA";
            this.txtIDA.Size = new System.Drawing.Size(100, 20);
            this.txtIDA.TabIndex = 93;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(581, 402);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 40);
            this.button4.TabIndex = 92;
            this.button4.Text = "REGRESAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(584, 52);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(102, 40);
            this.btnEliminar.TabIndex = 91;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(584, 98);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(102, 40);
            this.btnModificar.TabIndex = 90;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(584, 6);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(102, 40);
            this.btnAgregar.TabIndex = 89;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dGVAGV
            // 
            this.dGVAGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVAGV.Location = new System.Drawing.Point(12, 148);
            this.dGVAGV.Name = "dGVAGV";
            this.dGVAGV.Size = new System.Drawing.Size(671, 248);
            this.dGVAGV.TabIndex = 88;
            // 
            // ActorGrabacionVoz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumIn);
            this.Controls.Add(this.txtIDGV);
            this.Controls.Add(this.txtIDA);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dGVAGV);
            this.Name = "ActorGrabacionVoz";
            this.Text = "ActorGrabacionVoz";
            this.Load += new System.EventHandler(this.ActorGrabacionVoz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVAGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumIn;
        private System.Windows.Forms.TextBox txtIDGV;
        private System.Windows.Forms.TextBox txtIDA;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dGVAGV;
    }
}