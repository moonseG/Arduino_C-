namespace Arduino_C_
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
            this.Bencender = new System.Windows.Forms.Button();
            this.Bapagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bencender
            // 
            this.Bencender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Bencender.Location = new System.Drawing.Point(74, 57);
            this.Bencender.Name = "Bencender";
            this.Bencender.Size = new System.Drawing.Size(126, 65);
            this.Bencender.TabIndex = 0;
            this.Bencender.Text = "ENCENDER";
            this.Bencender.UseVisualStyleBackColor = false;
            this.Bencender.Click += new System.EventHandler(this.Bencender_Click);
            // 
            // Bapagar
            // 
            this.Bapagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Bapagar.Location = new System.Drawing.Point(74, 179);
            this.Bapagar.Name = "Bapagar";
            this.Bapagar.Size = new System.Drawing.Size(126, 66);
            this.Bapagar.TabIndex = 1;
            this.Bapagar.Text = "APAGAR";
            this.Bapagar.UseVisualStyleBackColor = false;
            this.Bapagar.Click += new System.EventHandler(this.Bapagar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(293, 319);
            this.Controls.Add(this.Bapagar);
            this.Controls.Add(this.Bencender);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CerrandoForm1);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bencender;
        private System.Windows.Forms.Button Bapagar;
    }
}

