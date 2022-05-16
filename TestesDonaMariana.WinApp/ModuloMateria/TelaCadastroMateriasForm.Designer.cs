namespace TestesDonaMariana.WinApp.ModuloMateria
{
    partial class TelaCadastroMateriasForm
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
            this.label_Disciplina = new System.Windows.Forms.Label();
            this.label_NomeMateria = new System.Windows.Forms.Label();
            this.label_Serie = new System.Windows.Forms.Label();
            this.txt_NomeMateria = new System.Windows.Forms.TextBox();
            this.comboBox_Disciplina = new System.Windows.Forms.ComboBox();
            this.comboBox_Serie = new System.Windows.Forms.ComboBox();
            this.btn_Gravar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Disciplina
            // 
            this.label_Disciplina.AutoSize = true;
            this.label_Disciplina.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Disciplina.Location = new System.Drawing.Point(51, 30);
            this.label_Disciplina.Name = "label_Disciplina";
            this.label_Disciplina.Size = new System.Drawing.Size(85, 16);
            this.label_Disciplina.TabIndex = 0;
            this.label_Disciplina.Text = "Diciplina:";
            // 
            // label_NomeMateria
            // 
            this.label_NomeMateria.AutoSize = true;
            this.label_NomeMateria.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_NomeMateria.Location = new System.Drawing.Point(15, 70);
            this.label_NomeMateria.Name = "label_NomeMateria";
            this.label_NomeMateria.Size = new System.Drawing.Size(121, 16);
            this.label_NomeMateria.TabIndex = 1;
            this.label_NomeMateria.Text = "Nome Materia:";
            // 
            // label_Serie
            // 
            this.label_Serie.AutoSize = true;
            this.label_Serie.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Serie.Location = new System.Drawing.Point(86, 111);
            this.label_Serie.Name = "label_Serie";
            this.label_Serie.Size = new System.Drawing.Size(50, 16);
            this.label_Serie.TabIndex = 2;
            this.label_Serie.Text = "Série:";
            // 
            // txt_NomeMateria
            // 
            this.txt_NomeMateria.Location = new System.Drawing.Point(142, 67);
            this.txt_NomeMateria.Name = "txt_NomeMateria";
            this.txt_NomeMateria.Size = new System.Drawing.Size(145, 23);
            this.txt_NomeMateria.TabIndex = 4;
            // 
            // comboBox_Disciplina
            // 
            this.comboBox_Disciplina.FormattingEnabled = true;
            this.comboBox_Disciplina.Location = new System.Drawing.Point(142, 27);
            this.comboBox_Disciplina.Name = "comboBox_Disciplina";
            this.comboBox_Disciplina.Size = new System.Drawing.Size(145, 23);
            this.comboBox_Disciplina.TabIndex = 5;
            // 
            // comboBox_Serie
            // 
            this.comboBox_Serie.FormattingEnabled = true;
            this.comboBox_Serie.Location = new System.Drawing.Point(142, 108);
            this.comboBox_Serie.Name = "comboBox_Serie";
            this.comboBox_Serie.Size = new System.Drawing.Size(145, 23);
            this.comboBox_Serie.TabIndex = 6;
            // 
            // btn_Gravar
            // 
            this.btn_Gravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Gravar.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Gravar.Location = new System.Drawing.Point(300, 27);
            this.btn_Gravar.Name = "btn_Gravar";
            this.btn_Gravar.Size = new System.Drawing.Size(116, 44);
            this.btn_Gravar.TabIndex = 7;
            this.btn_Gravar.Text = "Gravar";
            this.btn_Gravar.UseVisualStyleBackColor = true;
            this.btn_Gravar.Click += new System.EventHandler(this.btn_Gravar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancelar.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Cancelar.Location = new System.Drawing.Point(300, 87);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(116, 44);
            this.btn_Cancelar.TabIndex = 8;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // TelaCadastroMateriasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(442, 150);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Gravar);
            this.Controls.Add(this.comboBox_Serie);
            this.Controls.Add(this.comboBox_Disciplina);
            this.Controls.Add(this.txt_NomeMateria);
            this.Controls.Add(this.label_Serie);
            this.Controls.Add(this.label_NomeMateria);
            this.Controls.Add(this.label_Disciplina);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaCadastroMateriasForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Matérias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Disciplina;
        private System.Windows.Forms.Label label_NomeMateria;
        private System.Windows.Forms.Label label_Serie;
        private System.Windows.Forms.TextBox txt_NomeMateria;
        private System.Windows.Forms.ComboBox comboBox_Disciplina;
        private System.Windows.Forms.ComboBox comboBox_Serie;
        private System.Windows.Forms.Button btn_Gravar;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}