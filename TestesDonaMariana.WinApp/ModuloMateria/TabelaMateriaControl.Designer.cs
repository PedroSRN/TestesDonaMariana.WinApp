namespace TestesDonaMariana.WinApp.ModuloMateria
{
    partial class TabelaMateriaControl
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
            this.Grid_Materias = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Materias)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid_Materias
            // 
            this.Grid_Materias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Materias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid_Materias.Location = new System.Drawing.Point(0, 0);
            this.Grid_Materias.Name = "Grid_Materias";
            this.Grid_Materias.RowTemplate.Height = 25;
            this.Grid_Materias.Size = new System.Drawing.Size(349, 280);
            this.Grid_Materias.TabIndex = 0;
            // 
            // TabelaMateriaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.Grid_Materias);
            this.Name = "TabelaMateriaControl";
            this.Size = new System.Drawing.Size(349, 280);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Materias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid_Materias;
    }
}
