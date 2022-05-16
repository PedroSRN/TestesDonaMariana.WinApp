namespace TestesDonaMariana.WinApp.ModuloQuestoes
{
    partial class TabelaQuestaoControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Grid_Questao = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Questao)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid_Questao
            // 
            this.Grid_Questao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Questao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid_Questao.Location = new System.Drawing.Point(0, 0);
            this.Grid_Questao.Name = "Grid_Questao";
            this.Grid_Questao.RowTemplate.Height = 25;
            this.Grid_Questao.Size = new System.Drawing.Size(383, 291);
            this.Grid_Questao.TabIndex = 0;
            // 
            // TabelaQuestaoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Grid_Questao);
            this.Name = "TabelaQuestaoControl";
            this.Size = new System.Drawing.Size(383, 291);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Questao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid_Questao;
    }
}
