﻿namespace CSharpFundamentos.Capitulo04.Frete
{
    partial class FreteForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.clienteTextBox = new System.Windows.Forms.TextBox();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.freteTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.ufComboBox = new System.Windows.Forms.ComboBox();
            this.limparButton = new System.Windows.Forms.Button();
            this.calcularButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "UF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Frete";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total";
            // 
            // clienteTextBox
            // 
            this.clienteTextBox.Location = new System.Drawing.Point(57, 6);
            this.clienteTextBox.Name = "clienteTextBox";
            this.clienteTextBox.Size = new System.Drawing.Size(223, 20);
            this.clienteTextBox.TabIndex = 1;
            // 
            // valorTextBox
            // 
            this.valorTextBox.Location = new System.Drawing.Point(57, 39);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(121, 20);
            this.valorTextBox.TabIndex = 3;
            // 
            // freteTextBox
            // 
            this.freteTextBox.Location = new System.Drawing.Point(57, 105);
            this.freteTextBox.Name = "freteTextBox";
            this.freteTextBox.ReadOnly = true;
            this.freteTextBox.Size = new System.Drawing.Size(121, 20);
            this.freteTextBox.TabIndex = 7;
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(57, 138);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(121, 20);
            this.totalTextBox.TabIndex = 9;
            // 
            // ufComboBox
            // 
            this.ufComboBox.FormattingEnabled = true;
            this.ufComboBox.Items.AddRange(new object[] {
            "SP",
            "RJ",
            "MG",
            "AM",
            "Outros"});
            this.ufComboBox.Location = new System.Drawing.Point(57, 72);
            this.ufComboBox.Name = "ufComboBox";
            this.ufComboBox.Size = new System.Drawing.Size(121, 21);
            this.ufComboBox.TabIndex = 5;
            // 
            // limparButton
            // 
            this.limparButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.limparButton.Location = new System.Drawing.Point(205, 238);
            this.limparButton.Name = "limparButton";
            this.limparButton.Size = new System.Drawing.Size(75, 23);
            this.limparButton.TabIndex = 11;
            this.limparButton.Text = "Limpar";
            this.limparButton.UseVisualStyleBackColor = true;
            this.limparButton.Click += new System.EventHandler(this.limparButton_Click);
            // 
            // calcularButton
            // 
            this.calcularButton.Location = new System.Drawing.Point(205, 209);
            this.calcularButton.Name = "calcularButton";
            this.calcularButton.Size = new System.Drawing.Size(75, 23);
            this.calcularButton.TabIndex = 10;
            this.calcularButton.Text = "Cacular";
            this.calcularButton.UseVisualStyleBackColor = true;
            this.calcularButton.Click += new System.EventHandler(this.calcularButton_Click);
            // 
            // FreteForm
            // 
            this.AcceptButton = this.calcularButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.limparButton;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.calcularButton);
            this.Controls.Add(this.limparButton);
            this.Controls.Add(this.ufComboBox);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.freteTextBox);
            this.Controls.Add(this.valorTextBox);
            this.Controls.Add(this.clienteTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FreteForm";
            this.Text = "Frete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox clienteTextBox;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.TextBox freteTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.ComboBox ufComboBox;
        private System.Windows.Forms.Button limparButton;
        private System.Windows.Forms.Button calcularButton;
    }
}

