namespace PresentationLayerWinform
{
    partial class SelectAccess
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnServicios = new System.Windows.Forms.Button();
            this.btnDatos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿Como desea ejecutar la aplicaccion?";
            // 
            // btnServicios
            // 
            this.btnServicios.Location = new System.Drawing.Point(166, 61);
            this.btnServicios.Name = "btnServicios";
            this.btnServicios.Size = new System.Drawing.Size(126, 38);
            this.btnServicios.TabIndex = 1;
            this.btnServicios.Text = "Servicios";
            this.btnServicios.UseVisualStyleBackColor = true;
            // 
            // btnDatos
            // 
            this.btnDatos.Location = new System.Drawing.Point(21, 61);
            this.btnDatos.Name = "btnDatos";
            this.btnDatos.Size = new System.Drawing.Size(126, 38);
            this.btnDatos.TabIndex = 2;
            this.btnDatos.Text = "Acceso a datos";
            this.btnDatos.UseVisualStyleBackColor = true;
            this.btnDatos.Click += new System.EventHandler(this.btnDatos_Click);
            // 
            // SelectAccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 122);
            this.Controls.Add(this.btnDatos);
            this.Controls.Add(this.btnServicios);
            this.Controls.Add(this.label1);
            this.Name = "SelectAccess";
            this.Text = "Seleccionar acceso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnServicios;
        private System.Windows.Forms.Button btnDatos;
    }
}