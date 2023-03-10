namespace Formulario.Ej
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
            this.txtNavegar = new System.Windows.Forms.TextBox();
            this.btnNavegar = new System.Windows.Forms.Button();
            this.wbNavegar = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // txtNavegar
            // 
            this.txtNavegar.Location = new System.Drawing.Point(12, 6);
            this.txtNavegar.Name = "txtNavegar";
            this.txtNavegar.Size = new System.Drawing.Size(372, 26);
            this.txtNavegar.TabIndex = 0;
            // 
            // btnNavegar
            // 
            this.btnNavegar.Location = new System.Drawing.Point(655, -1);
            this.btnNavegar.Name = "btnNavegar";
            this.btnNavegar.Size = new System.Drawing.Size(75, 33);
            this.btnNavegar.TabIndex = 1;
            this.btnNavegar.Text = "button1";
            this.btnNavegar.UseVisualStyleBackColor = true;
            this.btnNavegar.Click += new System.EventHandler(this.button1_Click);
            // 
            // wbNavegar
            // 
            this.wbNavegar.Location = new System.Drawing.Point(12, 34);
            this.wbNavegar.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbNavegar.Name = "wbNavegar";
            this.wbNavegar.Size = new System.Drawing.Size(765, 404);
            this.wbNavegar.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wbNavegar);
            this.Controls.Add(this.btnNavegar);
            this.Controls.Add(this.txtNavegar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNavegar;
        private System.Windows.Forms.Button btnNavegar;
        private System.Windows.Forms.WebBrowser wbNavegar;
    }
}

