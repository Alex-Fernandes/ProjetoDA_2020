﻿namespace ProjetoDA_2020
{
    partial class GestaoLimpezas
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
            this.lb_Datas = new System.Windows.Forms.ListBox();
            this.btn_EmitirFaturas = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btn_Criar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_Detalhes = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label_ValorUnitario = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Inserir = new System.Windows.Forms.Button();
            this.numericUp_Quantidade = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_Servicos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUp_Quantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id - Localidade - Rua (casa)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vendável:";
            // 
            // lb_Datas
            // 
            this.lb_Datas.FormattingEnabled = true;
            this.lb_Datas.Location = new System.Drawing.Point(9, 64);
            this.lb_Datas.Name = "lb_Datas";
            this.lb_Datas.Size = new System.Drawing.Size(319, 472);
            this.lb_Datas.TabIndex = 2;
            // 
            // btn_EmitirFaturas
            // 
            this.btn_EmitirFaturas.Location = new System.Drawing.Point(32, 557);
            this.btn_EmitirFaturas.Name = "btn_EmitirFaturas";
            this.btn_EmitirFaturas.Size = new System.Drawing.Size(275, 23);
            this.btn_EmitirFaturas.TabIndex = 3;
            this.btn_EmitirFaturas.Text = "Emitir Faturas";
            this.btn_EmitirFaturas.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(9, 601);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 4;
            // 
            // btn_Criar
            // 
            this.btn_Criar.Location = new System.Drawing.Point(232, 598);
            this.btn_Criar.Name = "btn_Criar";
            this.btn_Criar.Size = new System.Drawing.Size(96, 23);
            this.btn_Criar.TabIndex = 5;
            this.btn_Criar.Text = "Criar";
            this.btn_Criar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_Detalhes);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label_ValorUnitario);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btn_Inserir);
            this.groupBox1.Controls.Add(this.numericUp_Quantidade);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox_Servicos);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(334, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 571);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalhes Limpeza";
            // 
            // lb_Detalhes
            // 
            this.lb_Detalhes.FormattingEnabled = true;
            this.lb_Detalhes.Location = new System.Drawing.Point(6, 123);
            this.lb_Detalhes.Name = "lb_Detalhes";
            this.lb_Detalhes.Size = new System.Drawing.Size(609, 446);
            this.lb_Detalhes.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(155, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "€";
            // 
            // label_ValorUnitario
            // 
            this.label_ValorUnitario.AutoSize = true;
            this.label_ValorUnitario.Location = new System.Drawing.Point(103, 99);
            this.label_ValorUnitario.Name = "label_ValorUnitario";
            this.label_ValorUnitario.Size = new System.Drawing.Size(30, 13);
            this.label_ValorUnitario.TabIndex = 13;
            this.label_ValorUnitario.Text = "valor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Valor Unitario:";
            // 
            // btn_Inserir
            // 
            this.btn_Inserir.Location = new System.Drawing.Point(507, 35);
            this.btn_Inserir.Name = "btn_Inserir";
            this.btn_Inserir.Size = new System.Drawing.Size(96, 23);
            this.btn_Inserir.TabIndex = 8;
            this.btn_Inserir.Text = "Inserir";
            this.btn_Inserir.UseVisualStyleBackColor = true;
            // 
            // numericUp_Quantidade
            // 
            this.numericUp_Quantidade.Location = new System.Drawing.Point(405, 37);
            this.numericUp_Quantidade.Name = "numericUp_Quantidade";
            this.numericUp_Quantidade.Size = new System.Drawing.Size(76, 20);
            this.numericUp_Quantidade.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Quantidade:";
            // 
            // comboBox_Servicos
            // 
            this.comboBox_Servicos.FormattingEnabled = true;
            this.comboBox_Servicos.Location = new System.Drawing.Point(76, 37);
            this.comboBox_Servicos.Name = "comboBox_Servicos";
            this.comboBox_Servicos.Size = new System.Drawing.Size(236, 21);
            this.comboBox_Servicos.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Serviço:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(828, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Decoracao Por escolher";
            // 
            // GestaoLimpezas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 637);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Criar);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.btn_EmitirFaturas);
            this.Controls.Add(this.lb_Datas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GestaoLimpezas";
            this.Text = "Limpezas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUp_Quantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lb_Datas;
        private System.Windows.Forms.Button btn_EmitirFaturas;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btn_Criar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Inserir;
        private System.Windows.Forms.NumericUpDown numericUp_Quantidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_Servicos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_ValorUnitario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lb_Detalhes;
        private System.Windows.Forms.Label label6;
    }
}