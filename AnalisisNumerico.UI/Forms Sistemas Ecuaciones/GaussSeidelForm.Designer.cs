namespace AnalisisNumerico.UI.Forms_Sistemas_Ecuaciones
{
    partial class GaussSeidelForm
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
            this.MensajeLabel = new System.Windows.Forms.Label();
            this.ResultadoMatriz = new System.Windows.Forms.DataGridView();
            this.CalcularButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.IncognitasTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IngresoDatosMatriz = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ResultadoMatriz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IngresoDatosMatriz)).BeginInit();
            this.SuspendLayout();
            // 
            // MensajeLabel
            // 
            this.MensajeLabel.AutoSize = true;
            this.MensajeLabel.Location = new System.Drawing.Point(246, 380);
            this.MensajeLabel.Name = "MensajeLabel";
            this.MensajeLabel.Size = new System.Drawing.Size(0, 13);
            this.MensajeLabel.TabIndex = 22;
            // 
            // ResultadoMatriz
            // 
            this.ResultadoMatriz.AllowUserToAddRows = false;
            this.ResultadoMatriz.AllowUserToDeleteRows = false;
            this.ResultadoMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultadoMatriz.Location = new System.Drawing.Point(12, 233);
            this.ResultadoMatriz.Name = "ResultadoMatriz";
            this.ResultadoMatriz.Size = new System.Drawing.Size(315, 160);
            this.ResultadoMatriz.TabIndex = 21;
            // 
            // CalcularButton
            // 
            this.CalcularButton.Location = new System.Drawing.Point(461, 233);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(75, 23);
            this.CalcularButton.TabIndex = 20;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(220, 4);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(37, 23);
            this.OkButton.TabIndex = 19;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // IncognitasTextBox
            // 
            this.IncognitasTextBox.Location = new System.Drawing.Point(167, 6);
            this.IncognitasTextBox.Name = "IncognitasTextBox";
            this.IncognitasTextBox.Size = new System.Drawing.Size(47, 20);
            this.IncognitasTextBox.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ingrese numero de incognitas:";
            // 
            // IngresoDatosMatriz
            // 
            this.IngresoDatosMatriz.AllowUserToAddRows = false;
            this.IngresoDatosMatriz.AllowUserToDeleteRows = false;
            this.IngresoDatosMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IngresoDatosMatriz.Location = new System.Drawing.Point(12, 32);
            this.IngresoDatosMatriz.Name = "IngresoDatosMatriz";
            this.IngresoDatosMatriz.Size = new System.Drawing.Size(633, 165);
            this.IngresoDatosMatriz.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Iteraciones:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(418, 272);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(47, 20);
            this.textBox1.TabIndex = 24;
            // 
            // GaussSeidelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 403);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MensajeLabel);
            this.Controls.Add(this.ResultadoMatriz);
            this.Controls.Add(this.CalcularButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.IncognitasTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IngresoDatosMatriz);
            this.Name = "GaussSeidelForm";
            this.Text = "GaussSeidelForm";
            ((System.ComponentModel.ISupportInitialize)(this.ResultadoMatriz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IngresoDatosMatriz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MensajeLabel;
        private System.Windows.Forms.DataGridView ResultadoMatriz;
        private System.Windows.Forms.Button CalcularButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.TextBox IncognitasTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView IngresoDatosMatriz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}