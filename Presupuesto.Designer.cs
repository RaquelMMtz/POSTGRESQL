namespace ProyectoFinalPG
{
    partial class Presupuesto
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
            this.txtDes = new System.Windows.Forms.TextBox();
            this.txtAT = new System.Windows.Forms.TextBox();
            this.txtAA = new System.Windows.Forms.TextBox();
            this.txtM = new System.Windows.Forms.TextBox();
            this.txtIDG = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dGVPre = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPre)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(144, 15);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(100, 20);
            this.txtDes.TabIndex = 96;
            // 
            // txtAT
            // 
            this.txtAT.Location = new System.Drawing.Point(97, 61);
            this.txtAT.Name = "txtAT";
            this.txtAT.Size = new System.Drawing.Size(100, 20);
            this.txtAT.TabIndex = 95;
            // 
            // txtAA
            // 
            this.txtAA.Location = new System.Drawing.Point(97, 107);
            this.txtAA.Name = "txtAA";
            this.txtAA.Size = new System.Drawing.Size(100, 20);
            this.txtAA.TabIndex = 94;
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(324, 33);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(100, 20);
            this.txtM.TabIndex = 93;
            // 
            // txtIDG
            // 
            this.txtIDG.Location = new System.Drawing.Point(324, 85);
            this.txtIDG.Name = "txtIDG";
            this.txtIDG.Size = new System.Drawing.Size(100, 20);
            this.txtIDG.TabIndex = 92;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 91;
            this.label5.Text = "Desarrollo e Investigacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 90;
            this.label4.Text = "Area Tecnica";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 89;
            this.label3.Text = "Area Artistica";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 88;
            this.label2.Text = "Marketing";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 87;
            this.label1.Text = "idGerente";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(630, 396);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 40);
            this.button4.TabIndex = 86;
            this.button4.Text = "REGRESAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(630, 50);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(102, 40);
            this.btnEliminar.TabIndex = 85;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(630, 96);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(102, 40);
            this.btnModificar.TabIndex = 84;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(630, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(102, 40);
            this.btnAgregar.TabIndex = 83;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dGVPre
            // 
            this.dGVPre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVPre.Location = new System.Drawing.Point(12, 142);
            this.dGVPre.Name = "dGVPre";
            this.dGVPre.Size = new System.Drawing.Size(720, 248);
            this.dGVPre.TabIndex = 82;
            // 
            // Presupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 440);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.txtAT);
            this.Controls.Add(this.txtAA);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.txtIDG);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dGVPre);
            this.Name = "Presupuesto";
            this.Text = "Presupuesto";
            this.Load += new System.EventHandler(this.Presupuesto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVPre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.TextBox txtAT;
        private System.Windows.Forms.TextBox txtAA;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.TextBox txtIDG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dGVPre;
    }
}