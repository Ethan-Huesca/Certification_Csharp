namespace Presentation
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
            this.lstClasses = new System.Windows.Forms.ListBox();
            this.lstAttributes = new System.Windows.Forms.ListBox();
            this.lstMethods = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstClasses
            // 
            this.lstClasses.FormattingEnabled = true;
            this.lstClasses.Location = new System.Drawing.Point(13, 25);
            this.lstClasses.Name = "lstClasses";
            this.lstClasses.Size = new System.Drawing.Size(120, 147);
            this.lstClasses.TabIndex = 0;
            // 
            // lstAttributes
            // 
            this.lstAttributes.FormattingEnabled = true;
            this.lstAttributes.Location = new System.Drawing.Point(151, 25);
            this.lstAttributes.Name = "lstAttributes";
            this.lstAttributes.Size = new System.Drawing.Size(120, 147);
            this.lstAttributes.TabIndex = 1;
            // 
            // lstMethods
            // 
            this.lstMethods.FormattingEnabled = true;
            this.lstMethods.Location = new System.Drawing.Point(292, 25);
            this.lstMethods.Name = "lstMethods";
            this.lstMethods.Size = new System.Drawing.Size(120, 147);
            this.lstMethods.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 342);
            this.Controls.Add(this.lstMethods);
            this.Controls.Add(this.lstAttributes);
            this.Controls.Add(this.lstClasses);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstClasses;
        private System.Windows.Forms.ListBox lstAttributes;
        private System.Windows.Forms.ListBox lstMethods;
    }
}

