namespace pryBlaiottaEtapa3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblNombreVehiculo = new Label();
            lblTipoVehiculo = new Label();
            label4 = new Label();
            btnCrearVehiculo = new Button();
            pctVehiculo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pctVehiculo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(152, 258);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // lblNombreVehiculo
            // 
            lblNombreVehiculo.BorderStyle = BorderStyle.Fixed3D;
            lblNombreVehiculo.Location = new Point(260, 258);
            lblNombreVehiculo.Name = "lblNombreVehiculo";
            lblNombreVehiculo.Size = new Size(134, 22);
            lblNombreVehiculo.TabIndex = 1;
            // 
            // lblTipoVehiculo
            // 
            lblTipoVehiculo.BorderStyle = BorderStyle.Fixed3D;
            lblTipoVehiculo.Location = new Point(260, 293);
            lblTipoVehiculo.Name = "lblTipoVehiculo";
            lblTipoVehiculo.Size = new Size(134, 23);
            lblTipoVehiculo.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(152, 293);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 3;
            label4.Text = "Tipo";
            // 
            // btnCrearVehiculo
            // 
            btnCrearVehiculo.Location = new Point(152, 337);
            btnCrearVehiculo.Name = "btnCrearVehiculo";
            btnCrearVehiculo.Size = new Size(148, 23);
            btnCrearVehiculo.TabIndex = 4;
            btnCrearVehiculo.Text = "Crear vehiculo";
            btnCrearVehiculo.UseVisualStyleBackColor = true;
            btnCrearVehiculo.Click += btnCrearVehiculo_Click;
            // 
            // pctVehiculo
            // 
            pctVehiculo.Location = new Point(110, 60);
            pctVehiculo.Name = "pctVehiculo";
            pctVehiculo.Size = new Size(297, 181);
            pctVehiculo.TabIndex = 5;
            pctVehiculo.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 413);
            Controls.Add(pctVehiculo);
            Controls.Add(btnCrearVehiculo);
            Controls.Add(label4);
            Controls.Add(lblTipoVehiculo);
            Controls.Add(lblNombreVehiculo);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pctVehiculo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblNombreVehiculo;
        private Label lblTipoVehiculo;
        private Label label4;
        private Button btnCrearVehiculo;
        private PictureBox pctVehiculo;
    }
}