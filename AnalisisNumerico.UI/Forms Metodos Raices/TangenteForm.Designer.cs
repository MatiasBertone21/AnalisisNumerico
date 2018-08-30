namespace AnalisisNumerico.UI
{
    partial class TangenteForm
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
            this.ErrortextBox = new System.Windows.Forms.TextBox();
            this.ItetextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Errorlabel = new System.Windows.Forms.Label();
            this.RaiztextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.IteracionestextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ToleranciatextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CalcularButton = new System.Windows.Forms.Button();
            this.FuncionTextBox = new System.Windows.Forms.TextBox();
            this.PuntoIniciodaLabel = new System.Windows.Forms.Label();
            this.PuntoInicioTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ErrortextBox
            // 
            this.ErrortextBox.Location = new System.Drawing.Point(288, 216);
            this.ErrortextBox.Name = "ErrortextBox";
            this.ErrortextBox.Size = new System.Drawing.Size(100, 20);
            this.ErrortextBox.TabIndex = 36;
            // 
            // ItetextBox
            // 
            this.ItetextBox.Location = new System.Drawing.Point(288, 182);
            this.ItetextBox.Name = "ItetextBox";
            this.ItetextBox.Size = new System.Drawing.Size(100, 20);
            this.ItetextBox.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(197, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Error Relativo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(197, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Iteraciones:";
            // 
            // Errorlabel
            // 
            this.Errorlabel.AutoSize = true;
            this.Errorlabel.Location = new System.Drawing.Point(12, 115);
            this.Errorlabel.Name = "Errorlabel";
            this.Errorlabel.Size = new System.Drawing.Size(142, 13);
            this.Errorlabel.TabIndex = 32;
            this.Errorlabel.Text = "Vuelva a ingresar los valores";
            this.Errorlabel.Click += new System.EventHandler(this.Errorlabel_Click);
            // 
            // RaiztextBox
            // 
            this.RaiztextBox.Location = new System.Drawing.Point(288, 152);
            this.RaiztextBox.Name = "RaiztextBox";
            this.RaiztextBox.Size = new System.Drawing.Size(100, 20);
            this.RaiztextBox.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(197, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Raiz:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Iteraciones";
            // 
            // IteracionestextBox
            // 
            this.IteracionestextBox.Location = new System.Drawing.Point(288, 73);
            this.IteracionestextBox.Name = "IteracionestextBox";
            this.IteracionestextBox.Size = new System.Drawing.Size(100, 20);
            this.IteracionestextBox.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Tolerancia";
            // 
            // ToleranciatextBox
            // 
            this.ToleranciatextBox.Location = new System.Drawing.Point(12, 73);
            this.ToleranciatextBox.Name = "ToleranciatextBox";
            this.ToleranciatextBox.Size = new System.Drawing.Size(100, 20);
            this.ToleranciatextBox.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Función";
            // 
            // CalcularButton
            // 
            this.CalcularButton.Location = new System.Drawing.Point(48, 179);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(75, 23);
            this.CalcularButton.TabIndex = 22;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // FuncionTextBox
            // 
            this.FuncionTextBox.Location = new System.Drawing.Point(12, 25);
            this.FuncionTextBox.Name = "FuncionTextBox";
            this.FuncionTextBox.Size = new System.Drawing.Size(100, 20);
            this.FuncionTextBox.TabIndex = 19;
            this.FuncionTextBox.Text = "f(x)=";
            // 
            // PuntoIniciodaLabel
            // 
            this.PuntoIniciodaLabel.AutoSize = true;
            this.PuntoIniciodaLabel.Location = new System.Drawing.Point(288, 9);
            this.PuntoIniciodaLabel.Name = "PuntoIniciodaLabel";
            this.PuntoIniciodaLabel.Size = new System.Drawing.Size(20, 13);
            this.PuntoIniciodaLabel.TabIndex = 38;
            this.PuntoIniciodaLabel.Text = "Xo";
            // 
            // PuntoInicioTextBox
            // 
            this.PuntoInicioTextBox.Location = new System.Drawing.Point(288, 25);
            this.PuntoInicioTextBox.Name = "PuntoInicioTextBox";
            this.PuntoInicioTextBox.Size = new System.Drawing.Size(100, 20);
            this.PuntoInicioTextBox.TabIndex = 37;
            // 
            // TangenteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 254);
            this.Controls.Add(this.PuntoIniciodaLabel);
            this.Controls.Add(this.PuntoInicioTextBox);
            this.Controls.Add(this.ErrortextBox);
            this.Controls.Add(this.ItetextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Errorlabel);
            this.Controls.Add(this.RaiztextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.IteracionestextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ToleranciatextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CalcularButton);
            this.Controls.Add(this.FuncionTextBox);
            this.Name = "TangenteForm";
            this.Text = "Newton-Raphson (Tangente)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ErrortextBox;
        private System.Windows.Forms.TextBox ItetextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Errorlabel;
        private System.Windows.Forms.TextBox RaiztextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IteracionestextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ToleranciatextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CalcularButton;
        private System.Windows.Forms.TextBox FuncionTextBox;
        private System.Windows.Forms.Label PuntoIniciodaLabel;
        private System.Windows.Forms.TextBox PuntoInicioTextBox;
    }
}