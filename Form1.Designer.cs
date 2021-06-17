
namespace AULA8
{
    partial class Form1
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
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.CheckPlanoSaude = new System.Windows.Forms.CheckBox();
            this.txtSalFolha = new System.Windows.Forms.TextBox();
            this.lbl_SalarioFolha = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtImpostoRenda = new System.Windows.Forms.TextBox();
            this.lbl_percentagem = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSalLiquido = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_ClubeLazer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salário :";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(50, 92);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(163, 20);
            this.txtSalario.TabIndex = 1;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(50, 251);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(85, 31);
            this.btn_Calcular.TabIndex = 2;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // CheckPlanoSaude
            // 
            this.CheckPlanoSaude.AutoSize = true;
            this.CheckPlanoSaude.Location = new System.Drawing.Point(50, 119);
            this.CheckPlanoSaude.Name = "CheckPlanoSaude";
            this.CheckPlanoSaude.Size = new System.Drawing.Size(102, 17);
            this.CheckPlanoSaude.TabIndex = 3;
            this.CheckPlanoSaude.Text = "Plano de Saúde";
            this.CheckPlanoSaude.UseVisualStyleBackColor = true;
            // 
            // txtSalFolha
            // 
            this.txtSalFolha.Location = new System.Drawing.Point(372, 92);
            this.txtSalFolha.Name = "txtSalFolha";
            this.txtSalFolha.Size = new System.Drawing.Size(124, 20);
            this.txtSalFolha.TabIndex = 4;
            // 
            // lbl_SalarioFolha
            // 
            this.lbl_SalarioFolha.AutoSize = true;
            this.lbl_SalarioFolha.Location = new System.Drawing.Point(266, 95);
            this.lbl_SalarioFolha.Name = "lbl_SalarioFolha";
            this.lbl_SalarioFolha.Size = new System.Drawing.Size(74, 13);
            this.lbl_SalarioFolha.TabIndex = 5;
            this.lbl_SalarioFolha.Text = "Salário Folha :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(144, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Imposto de Renda :";
            // 
            // txtImpostoRenda
            // 
            this.txtImpostoRenda.Location = new System.Drawing.Point(372, 135);
            this.txtImpostoRenda.Name = "txtImpostoRenda";
            this.txtImpostoRenda.Size = new System.Drawing.Size(124, 20);
            this.txtImpostoRenda.TabIndex = 7;
            // 
            // lbl_percentagem
            // 
            this.lbl_percentagem.AutoSize = true;
            this.lbl_percentagem.Location = new System.Drawing.Point(503, 141);
            this.lbl_percentagem.Name = "lbl_percentagem";
            this.lbl_percentagem.Size = new System.Drawing.Size(15, 13);
            this.lbl_percentagem.TabIndex = 9;
            this.lbl_percentagem.Text = "%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Salário Líquido :";
            // 
            // txtSalLiquido
            // 
            this.txtSalLiquido.Location = new System.Drawing.Point(372, 176);
            this.txtSalLiquido.Name = "txtSalLiquido";
            this.txtSalLiquido.Size = new System.Drawing.Size(124, 20);
            this.txtSalLiquido.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Clube A",
            "Clube B",
            "Clube C"});
            this.comboBox1.Location = new System.Drawing.Point(50, 195);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // lbl_ClubeLazer
            // 
            this.lbl_ClubeLazer.AutoSize = true;
            this.lbl_ClubeLazer.Location = new System.Drawing.Point(50, 176);
            this.lbl_ClubeLazer.Name = "lbl_ClubeLazer";
            this.lbl_ClubeLazer.Size = new System.Drawing.Size(78, 13);
            this.lbl_ClubeLazer.TabIndex = 13;
            this.lbl_ClubeLazer.Text = "Clube de Lazer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(538, 314);
            this.Controls.Add(this.lbl_ClubeLazer);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSalLiquido);
            this.Controls.Add(this.lbl_percentagem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtImpostoRenda);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbl_SalarioFolha);
            this.Controls.Add(this.txtSalFolha);
            this.Controls.Add(this.CheckPlanoSaude);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.CheckBox CheckPlanoSaude;
        private System.Windows.Forms.TextBox txtSalFolha;
        private System.Windows.Forms.Label lbl_SalarioFolha;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtImpostoRenda;
        private System.Windows.Forms.Label lbl_percentagem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSalLiquido;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_ClubeLazer;
    }
}

