namespace ProjetoDA_2020
{
    partial class FormArrendamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormArrendamentos));
            this.label1 = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.label_Local_Rua_Num_Andar = new System.Windows.Forms.Label();
            this.label_Cliente_Nif = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_Remover = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUp_Duracao = new System.Windows.Forms.NumericUpDown();
            this.checkBox_Renovavel = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_Arrendatario = new System.Windows.Forms.ComboBox();
            this.btn_Inserir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUp_Duracao)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Casa:";
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(62, 21);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(18, 13);
            this.label_ID.TabIndex = 1;
            this.label_ID.Text = "ID";
            // 
            // label_Local_Rua_Num_Andar
            // 
            this.label_Local_Rua_Num_Andar.AutoSize = true;
            this.label_Local_Rua_Num_Andar.Location = new System.Drawing.Point(62, 50);
            this.label_Local_Rua_Num_Andar.Name = "label_Local_Rua_Num_Andar";
            this.label_Local_Rua_Num_Andar.Size = new System.Drawing.Size(171, 13);
            this.label_Local_Rua_Num_Andar.TabIndex = 2;
            this.label_Local_Rua_Num_Andar.Text = "Localidade - Rua - Numero - Andar";
            // 
            // label_Cliente_Nif
            // 
            this.label_Cliente_Nif.AutoSize = true;
            this.label_Cliente_Nif.Location = new System.Drawing.Point(62, 83);
            this.label_Cliente_Nif.Name = "label_Cliente_Nif";
            this.label_Cliente_Nif.Size = new System.Drawing.Size(65, 13);
            this.label_Cliente_Nif.TabIndex = 3;
            this.label_Cliente_Nif.Text = "Cliente (NIF)";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(7, 117);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(412, 290);
            this.listBox1.TabIndex = 4;
            // 
            // btn_Remover
            // 
            this.btn_Remover.Location = new System.Drawing.Point(7, 415);
            this.btn_Remover.Name = "btn_Remover";
            this.btn_Remover.Size = new System.Drawing.Size(412, 23);
            this.btn_Remover.TabIndex = 5;
            this.btn_Remover.Text = "Remover";
            this.btn_Remover.UseVisualStyleBackColor = true;
            this.btn_Remover.Click += new System.EventHandler(this.btn_Remover_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(478, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Inicio de contrato:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(481, 156);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(478, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Duração (meses):";
            // 
            // numericUp_Duracao
            // 
            this.numericUp_Duracao.Location = new System.Drawing.Point(481, 231);
            this.numericUp_Duracao.Name = "numericUp_Duracao";
            this.numericUp_Duracao.Size = new System.Drawing.Size(200, 20);
            this.numericUp_Duracao.TabIndex = 9;
            // 
            // checkBox_Renovavel
            // 
            this.checkBox_Renovavel.AutoSize = true;
            this.checkBox_Renovavel.Location = new System.Drawing.Point(481, 274);
            this.checkBox_Renovavel.Name = "checkBox_Renovavel";
            this.checkBox_Renovavel.Size = new System.Drawing.Size(78, 17);
            this.checkBox_Renovavel.TabIndex = 10;
            this.checkBox_Renovavel.Text = "Renovável";
            this.checkBox_Renovavel.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(478, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Arrendatário:";
            // 
            // comboBox_Arrendatario
            // 
            this.comboBox_Arrendatario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Arrendatario.FormattingEnabled = true;
            this.comboBox_Arrendatario.Location = new System.Drawing.Point(481, 344);
            this.comboBox_Arrendatario.Name = "comboBox_Arrendatario";
            this.comboBox_Arrendatario.Size = new System.Drawing.Size(200, 21);
            this.comboBox_Arrendatario.TabIndex = 12;
            this.comboBox_Arrendatario.SelectedIndexChanged += new System.EventHandler(this.comboBox_Arrendatario_SelectedIndexChanged);
            // 
            // btn_Inserir
            // 
            this.btn_Inserir.Location = new System.Drawing.Point(481, 395);
            this.btn_Inserir.Name = "btn_Inserir";
            this.btn_Inserir.Size = new System.Drawing.Size(200, 23);
            this.btn_Inserir.TabIndex = 13;
            this.btn_Inserir.Text = "Inserir";
            this.btn_Inserir.UseVisualStyleBackColor = true;
            this.btn_Inserir.Click += new System.EventHandler(this.btn_Inserir_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.BackgroundImage = global::ProjetoDA_2020.Properties.Resources.rent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(558, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 91);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FormArrendamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Inserir);
            this.Controls.Add(this.comboBox_Arrendatario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkBox_Renovavel);
            this.Controls.Add(this.numericUp_Duracao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Remover);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label_Cliente_Nif);
            this.Controls.Add(this.label_Local_Rua_Num_Andar);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormArrendamentos";
            this.Text = "Arrendamentos";
            ((System.ComponentModel.ISupportInitialize)(this.numericUp_Duracao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label_Local_Rua_Num_Andar;
        private System.Windows.Forms.Label label_Cliente_Nif;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_Remover;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUp_Duracao;
        private System.Windows.Forms.CheckBox checkBox_Renovavel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_Arrendatario;
        private System.Windows.Forms.Button btn_Inserir;
        private System.Windows.Forms.Button button1;
    }
}