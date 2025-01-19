namespace ejercicioTelegrama
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblTexto = new System.Windows.Forms.Label();
            this.txtTelegrama = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnUrgente = new System.Windows.Forms.RadioButton();
            this.rbtnOrdinario = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(203, 171);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(128, 44);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(13, 13);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(41, 16);
            this.lblTexto.TabIndex = 1;
            this.lblTexto.Text = "Texto";
            // 
            // txtTelegrama
            // 
            this.txtTelegrama.Location = new System.Drawing.Point(16, 33);
            this.txtTelegrama.Multiline = true;
            this.txtTelegrama.Name = "txtTelegrama";
            this.txtTelegrama.Size = new System.Drawing.Size(341, 115);
            this.txtTelegrama.TabIndex = 2;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(67, 196);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 22);
            this.txtPrecio.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Coste:";
            // 
            // rbtnUrgente
            // 
            this.rbtnUrgente.AutoSize = true;
            this.rbtnUrgente.Location = new System.Drawing.Point(16, 171);
            this.rbtnUrgente.Name = "rbtnUrgente";
            this.rbtnUrgente.Size = new System.Drawing.Size(76, 20);
            this.rbtnUrgente.TabIndex = 6;
            this.rbtnUrgente.TabStop = true;
            this.rbtnUrgente.Text = "Urgente";
            this.rbtnUrgente.UseVisualStyleBackColor = true;
            // 
            // rbtnOrdinario
            // 
            this.rbtnOrdinario.AutoSize = true;
            this.rbtnOrdinario.Location = new System.Drawing.Point(98, 171);
            this.rbtnOrdinario.Name = "rbtnOrdinario";
            this.rbtnOrdinario.Size = new System.Drawing.Size(83, 20);
            this.rbtnOrdinario.TabIndex = 7;
            this.rbtnOrdinario.TabStop = true;
            this.rbtnOrdinario.Text = "Ordinario";
            this.rbtnOrdinario.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 236);
            this.Controls.Add(this.rbtnOrdinario);
            this.Controls.Add(this.rbtnUrgente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtTelegrama);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.TextBox txtTelegrama;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnUrgente;
        private System.Windows.Forms.RadioButton rbtnOrdinario;
    }
}

