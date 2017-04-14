namespace PresentationLayerWinform
{
    partial class EmployeeAddEdit
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
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.chkPart = new System.Windows.Forms.CheckBox();
            this.chkFull = new System.Windows.Forms.CheckBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.tpContratado = new System.Windows.Forms.DateTimePicker();
            this.lblContratado = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(118, 141);
            this.txtSalario.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(221, 22);
            this.txtSalario.TabIndex = 19;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSalario.Location = new System.Drawing.Point(44, 143);
            this.lblSalario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(66, 20);
            this.lblSalario.TabIndex = 18;
            this.lblSalario.Text = "Salario:";
            // 
            // chkPart
            // 
            this.chkPart.AutoSize = true;
            this.chkPart.Location = new System.Drawing.Point(204, 103);
            this.chkPart.Margin = new System.Windows.Forms.Padding(4);
            this.chkPart.Name = "chkPart";
            this.chkPart.Size = new System.Drawing.Size(86, 21);
            this.chkPart.TabIndex = 17;
            this.chkPart.Text = "Part time";
            this.chkPart.UseVisualStyleBackColor = true;
            this.chkPart.Click += new System.EventHandler(this.chkPart_Click);
            // 
            // chkFull
            // 
            this.chkFull.AutoSize = true;
            this.chkFull.Checked = true;
            this.chkFull.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFull.Location = new System.Drawing.Point(118, 103);
            this.chkFull.Margin = new System.Windows.Forms.Padding(4);
            this.chkFull.Name = "chkFull";
            this.chkFull.Size = new System.Drawing.Size(82, 21);
            this.chkFull.TabIndex = 16;
            this.chkFull.Text = "Full time";
            this.chkFull.UseVisualStyleBackColor = true;
            this.chkFull.Click += new System.EventHandler(this.chkFull_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTipo.Location = new System.Drawing.Point(64, 101);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(46, 20);
            this.lblTipo.TabIndex = 15;
            this.lblTipo.Text = "Tipo:";
            // 
            // tpContratado
            // 
            this.tpContratado.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tpContratado.Location = new System.Drawing.Point(120, 61);
            this.tpContratado.Margin = new System.Windows.Forms.Padding(4);
            this.tpContratado.Name = "tpContratado";
            this.tpContratado.Size = new System.Drawing.Size(128, 22);
            this.tpContratado.TabIndex = 14;
            // 
            // lblContratado
            // 
            this.lblContratado.AutoSize = true;
            this.lblContratado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblContratado.Location = new System.Drawing.Point(16, 63);
            this.lblContratado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContratado.Name = "lblContratado";
            this.lblContratado.Size = new System.Drawing.Size(96, 20);
            this.lblContratado.TabIndex = 13;
            this.lblContratado.Text = "Contratado:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(118, 23);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.MaxLength = 25;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(221, 22);
            this.txtNombre.TabIndex = 12;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNombre.Location = new System.Drawing.Point(37, 23);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 20);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Nombre:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(118, 180);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 28);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(239, 180);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // EmployeeAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 227);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.chkPart);
            this.Controls.Add(this.chkFull);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.tpContratado);
            this.Controls.Add(this.lblContratado);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnAgregar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeeAddEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nuevo empleado";
            this.Load += new System.EventHandler(this.EmployeeAddEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.CheckBox chkPart;
        private System.Windows.Forms.CheckBox chkFull;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.DateTimePicker tpContratado;
        private System.Windows.Forms.Label lblContratado;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
    }
}