namespace AnalisisNumerico.UI.Forms_Sistemas_Ecuaciones
{
    partial class GaussJordanForm
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
            this.IngresoDatosMatriz = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.IncognitasTextBox = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.CalcularButton = new System.Windows.Forms.Button();
            this.ResultadoMatriz = new System.Windows.Forms.DataGridView();
            this.MensajeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IngresoDatosMatriz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultadoMatriz)).BeginInit();
            this.SuspendLayout();
            // 
            // IngresoDatosMatriz
            // 
            this.IngresoDatosMatriz.AllowUserToAddRows = false;
            this.IngresoDatosMatriz.AllowUserToDeleteRows = false;
            this.IngresoDatosMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IngresoDatosMatriz.Location = new System.Drawing.Point(12, 32);
            this.IngresoDatosMatriz.Name = "IngresoDatosMatriz";
            this.IngresoDatosMatriz.Size = new System.Drawing.Size(633, 165);
            this.IngresoDatosMatriz.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ingrese numero de incognitas:";
            // 
            // IncognitasTextBox
            // 
            this.IncognitasTextBox.Location = new System.Drawing.Point(167, 6);
            this.IncognitasTextBox.Name = "IncognitasTextBox";
            this.IncognitasTextBox.Size = new System.Drawing.Size(47, 20);
            this.IncognitasTextBox.TabIndex = 8;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(220, 4);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(37, 23);
            this.OkButton.TabIndex = 9;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CalcularButton
            // 
            this.CalcularButton.Location = new System.Drawing.Point(291, 203);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(75, 23);
            this.CalcularButton.TabIndex = 10;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // ResultadoMatriz
            // 
            this.ResultadoMatriz.AllowUserToAddRows = false;
            this.ResultadoMatriz.AllowUserToDeleteRows = false;
            this.ResultadoMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultadoMatriz.Location = new System.Drawing.Point(12, 233);
            this.ResultadoMatriz.Name = "ResultadoMatriz";
            this.ResultadoMatriz.Size = new System.Drawing.Size(633, 160);
            this.ResultadoMatriz.TabIndex = 11;
            // 
            // MensajeLabel
            // 
            this.MensajeLabel.AutoSize = true;
            this.MensajeLabel.Location = new System.Drawing.Point(246, 380);
            this.MensajeLabel.Name = "MensajeLabel";
            this.MensajeLabel.Size = new System.Drawing.Size(0, 13);
            this.MensajeLabel.TabIndex = 15;
            // 
            // GaussJordanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 402);
            this.Controls.Add(this.MensajeLabel);
            this.Controls.Add(this.ResultadoMatriz);
            this.Controls.Add(this.CalcularButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.IncognitasTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IngresoDatosMatriz);
            this.Name = "GaussJordanForm";
            this.Text = "GaussJordanForm";
            ((System.ComponentModel.ISupportInitialize)(this.IngresoDatosMatriz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultadoMatriz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView IngresoDatosMatriz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IncognitasTextBox;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CalcularButton;
        private System.Windows.Forms.DataGridView ResultadoMatriz;
        private System.Windows.Forms.Label MensajeLabel;
    }
}