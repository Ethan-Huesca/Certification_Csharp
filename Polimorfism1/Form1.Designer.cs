namespace Polimorfism1
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
            this.Elementlbl = new System.Windows.Forms.Label();
            this.txtBoxElement = new System.Windows.Forms.TextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnGetElement = new System.Windows.Forms.Button();
            this.txtBoxIndex = new System.Windows.Forms.TextBox();
            this.Indexlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Elementlbl
            // 
            this.Elementlbl.AutoSize = true;
            this.Elementlbl.Location = new System.Drawing.Point(34, 25);
            this.Elementlbl.Name = "Elementlbl";
            this.Elementlbl.Size = new System.Drawing.Size(67, 13);
            this.Elementlbl.TabIndex = 0;
            this.Elementlbl.Text = "Add Element";
            // 
            // txtBoxElement
            // 
            this.txtBoxElement.Location = new System.Drawing.Point(107, 22);
            this.txtBoxElement.Name = "txtBoxElement";
            this.txtBoxElement.Size = new System.Drawing.Size(156, 20);
            this.txtBoxElement.TabIndex = 1;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(188, 58);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 2;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnGetElement
            // 
            this.btnGetElement.Location = new System.Drawing.Point(188, 141);
            this.btnGetElement.Name = "btnGetElement";
            this.btnGetElement.Size = new System.Drawing.Size(75, 23);
            this.btnGetElement.TabIndex = 5;
            this.btnGetElement.Text = "Get Element";
            this.btnGetElement.UseVisualStyleBackColor = true;
            this.btnGetElement.Click += new System.EventHandler(this.btnGetElement_Click);
            // 
            // txtBoxIndex
            // 
            this.txtBoxIndex.Location = new System.Drawing.Point(107, 105);
            this.txtBoxIndex.Name = "txtBoxIndex";
            this.txtBoxIndex.Size = new System.Drawing.Size(156, 20);
            this.txtBoxIndex.TabIndex = 4;
            // 
            // Indexlbl
            // 
            this.Indexlbl.AutoSize = true;
            this.Indexlbl.Location = new System.Drawing.Point(68, 108);
            this.Indexlbl.Name = "Indexlbl";
            this.Indexlbl.Size = new System.Drawing.Size(33, 13);
            this.Indexlbl.TabIndex = 3;
            this.Indexlbl.Text = "Index";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 183);
            this.Controls.Add(this.btnGetElement);
            this.Controls.Add(this.txtBoxIndex);
            this.Controls.Add(this.Indexlbl);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.txtBoxElement);
            this.Controls.Add(this.Elementlbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Elementlbl;
        private System.Windows.Forms.TextBox txtBoxElement;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnGetElement;
        private System.Windows.Forms.TextBox txtBoxIndex;
        private System.Windows.Forms.Label Indexlbl;
    }
}

