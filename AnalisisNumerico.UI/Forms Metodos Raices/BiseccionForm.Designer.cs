namespace AnalisisNumerico.UI
{
    partial class BiseccionForm
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
            this.FuncionTextBox = new System.Windows.Forms.TextBox();
            this.CalcularButton = new System.Windows.Forms.Button();
            this.XiTextBox = new System.Windows.Forms.TextBox();
            this.XdTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ToleranciatextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.IteracionestextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RaiztextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Errorlabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ItetextBox = new System.Windows.Forms.TextBox();
            this.ErrortextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FuncionTextBox
            // 
            this.FuncionTextBox.Location = new System.Drawing.Point(12, 25);
            this.FuncionTextBox.Name = "FuncionTextBox";
            this.FuncionTextBox.Size = new System.Drawing.Size(100, 20);
            this.FuncionTextBox.TabIndex = 0;
            this.FuncionTextBox.Text = "f(x)=";
            // 
            // CalcularButton
            // 
            this.CalcularButton.Location = new System.Drawing.Point(192, 112);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(75, 23);
            this.CalcularButton.TabIndex = 3;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // XiTextBox
            // 
            this.XiTextBox.Location = new System.Drawing.Point(15, 82);
            this.XiTextBox.Name = "XiTextBox";
            this.XiTextBox.Size = new System.Drawing.Size(100, 20);
            this.XiTextBox.TabIndex = 1;
            // 
            // XdTextBox
            // 
            this.XdTextBox.Location = new System.Drawing.Point(15, 149);
            this.XdTextBox.Name = "XdTextBox";
            this.XdTextBox.Size = new System.Drawing.Size(100, 20);
            this.XdTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Xi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Función";
            // 
            // ToleranciatextBox
            // 
            this.ToleranciatextBox.Location = new System.Drawing.Point(153, 24);
            this.ToleranciatextBox.Name = "ToleranciatextBox";
            this.ToleranciatextBox.Size = new System.Drawing.Size(100, 20);
            this.ToleranciatextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tolerancia";
            // 
            // IteracionestextBox
            // 
            this.IteracionestextBox.Location = new System.Drawing.Point(310, 25);
            this.IteracionestextBox.Name = "IteracionestextBox";
            this.IteracionestextBox.Size = new System.Drawing.Size(100, 20);
            this.IteracionestextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(307, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Iteraciones";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(273, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Raiz:";
            // 
            // RaiztextBox
            // 
            this.RaiztextBox.Location = new System.Drawing.Point(344, 112);
            this.RaiztextBox.Name = "RaiztextBox";
            this.RaiztextBox.Size = new System.Drawing.Size(100, 20);
            this.RaiztextBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Xd";
            // 
            // Errorlabel
            // 
            this.Errorlabel.AutoSize = true;
            this.Errorlabel.Location = new System.Drawing.Point(44, 117);
            this.Errorlabel.Name = "Errorlabel";
            this.Errorlabel.Size = new System.Drawing.Size(142, 13);
            this.Errorlabel.TabIndex = 14;
            this.Errorlabel.Text = "Vuelva a ingresar los valores";
            this.Errorlabel.Click += new System.EventHandler(this.Errorlabel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(276, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Iteraciones:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(276, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Error Relativo";
            // 
            // ItetextBox
            // 
            this.ItetextBox.Location = new System.Drawing.Point(344, 142);
            this.ItetextBox.Name = "ItetextBox";
            this.ItetextBox.Size = new System.Drawing.Size(100, 20);
            this.ItetextBox.TabIndex = 17;
            // 
            // ErrortextBox
            // 
            this.ErrortextBox.Location = new System.Drawing.Point(344, 174);
            this.ErrortextBox.Name = "ErrortextBox";
            this.ErrortextBox.Size = new System.Drawing.Size(100, 20);
            this.ErrortextBox.TabIndex = 18;
            // 
            // BiseccionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 202);
            this.Controls.Add(this.ErrortextBox);
            this.Controls.Add(this.ItetextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Errorlabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RaiztextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.IteracionestextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ToleranciatextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.XdTextBox);
            this.Controls.Add(this.XiTextBox);
            this.Controls.Add(this.CalcularButton);
            this.Controls.Add(this.FuncionTextBox);
            this.Name = "BiseccionForm";
            this.Text = "Biseccion";
            this.Load += new System.EventHandler(this.BiseccionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FuncionTextBox;
        private System.Windows.Forms.Button CalcularButton;
        private System.Windows.Forms.TextBox XiTextBox;
        private System.Windows.Forms.TextBox XdTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ToleranciatextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IteracionestextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox RaiztextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Errorlabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ItetextBox;
        private System.Windows.Forms.TextBox ErrortextBox;
    }
}

