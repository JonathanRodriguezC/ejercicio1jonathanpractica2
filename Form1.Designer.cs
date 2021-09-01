
namespace ejercicio1jonathanpractica2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtsalariobruto = new System.Windows.Forms.TextBox();
            this.rbtngerente = new System.Windows.Forms.RadioButton();
            this.rbtnsubgerente = new System.Windows.Forms.RadioButton();
            this.rbtnsecretaria = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(348, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descuentos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Salario bruto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Monto de descuento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "salario neto";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(215, 83);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 6;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(502, 83);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(100, 20);
            this.txtapellido.TabIndex = 7;
            // 
            // txtsalariobruto
            // 
            this.txtsalariobruto.Location = new System.Drawing.Point(352, 157);
            this.txtsalariobruto.Name = "txtsalariobruto";
            this.txtsalariobruto.Size = new System.Drawing.Size(100, 20);
            this.txtsalariobruto.TabIndex = 8;
            // 
            // rbtngerente
            // 
            this.rbtngerente.AutoSize = true;
            this.rbtngerente.Location = new System.Drawing.Point(523, 157);
            this.rbtngerente.Name = "rbtngerente";
            this.rbtngerente.Size = new System.Drawing.Size(61, 17);
            this.rbtngerente.TabIndex = 9;
            this.rbtngerente.TabStop = true;
            this.rbtngerente.Text = "gerente";
            this.rbtngerente.UseVisualStyleBackColor = true;
            // 
            // rbtnsubgerente
            // 
            this.rbtnsubgerente.AutoSize = true;
            this.rbtnsubgerente.Location = new System.Drawing.Point(523, 192);
            this.rbtnsubgerente.Name = "rbtnsubgerente";
            this.rbtnsubgerente.Size = new System.Drawing.Size(78, 17);
            this.rbtnsubgerente.TabIndex = 10;
            this.rbtnsubgerente.TabStop = true;
            this.rbtnsubgerente.Text = "subgerente";
            this.rbtnsubgerente.UseVisualStyleBackColor = true;
            // 
            // rbtnsecretaria
            // 
            this.rbtnsecretaria.AutoSize = true;
            this.rbtnsecretaria.Location = new System.Drawing.Point(523, 226);
            this.rbtnsecretaria.Name = "rbtnsecretaria";
            this.rbtnsecretaria.Size = new System.Drawing.Size(71, 17);
            this.rbtnsecretaria.TabIndex = 11;
            this.rbtnsecretaria.TabStop = true;
            this.rbtnsecretaria.Text = "secretaria";
            this.rbtnsecretaria.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbtnsecretaria);
            this.Controls.Add(this.rbtnsubgerente);
            this.Controls.Add(this.rbtngerente);
            this.Controls.Add(this.txtsalariobruto);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "desc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtsalariobruto;
        private System.Windows.Forms.RadioButton rbtngerente;
        private System.Windows.Forms.RadioButton rbtnsubgerente;
        private System.Windows.Forms.RadioButton rbtnsecretaria;
    }
}

