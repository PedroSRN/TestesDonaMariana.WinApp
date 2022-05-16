namespace TestesDonaMariana.WinApp
{
    partial class TelaPrincipalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.diciplinasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiasMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.testeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questoesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbox = new System.Windows.Forms.ToolStrip();
            this.btn_Inserir = new System.Windows.Forms.ToolStripButton();
            this.btn_Editar = new System.Windows.Forms.ToolStripButton();
            this.btn_Excluir = new System.Windows.Forms.ToolStripButton();
            this.btn_GerarPDF = new System.Windows.Forms.ToolStripButton();
            this.labelTipoCadastro = new System.Windows.Forms.ToolStripLabel();
            this.StripSatus_rodape = new System.Windows.Forms.StatusStrip();
            this.label_Rodape = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel_Registros = new System.Windows.Forms.Panel();
            this.menuStrip.SuspendLayout();
            this.toolbox.SuspendLayout();
            this.StripSatus_rodape.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diciplinasToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(560, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // diciplinasToolStripMenuItem
            // 
            this.diciplinasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.materiasMenuItem1,
            this.testeMenuItem,
            this.questoesMenuItem});
            this.diciplinasToolStripMenuItem.Name = "diciplinasToolStripMenuItem";
            this.diciplinasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.diciplinasToolStripMenuItem.Text = "Cadastros";
            // 
            // materiasMenuItem1
            // 
            this.materiasMenuItem1.Name = "materiasMenuItem1";
            this.materiasMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.materiasMenuItem1.Text = "Matérias";
            this.materiasMenuItem1.Click += new System.EventHandler(this.materiasMenuItem_Click);
            // 
            // testeMenuItem
            // 
            this.testeMenuItem.Name = "testeMenuItem";
            this.testeMenuItem.Size = new System.Drawing.Size(123, 22);
            this.testeMenuItem.Text = "Teste";
            this.testeMenuItem.Click += new System.EventHandler(this.testeMenuItem_Click);
            // 
            // questoesMenuItem
            // 
            this.questoesMenuItem.Name = "questoesMenuItem";
            this.questoesMenuItem.Size = new System.Drawing.Size(123, 22);
            this.questoesMenuItem.Text = "Questões";
            this.questoesMenuItem.Click += new System.EventHandler(this.questoesMenuItem_Click);
            // 
            // toolbox
            // 
            this.toolbox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Inserir,
            this.btn_Editar,
            this.btn_Excluir,
            this.btn_GerarPDF,
            this.labelTipoCadastro});
            this.toolbox.Location = new System.Drawing.Point(0, 24);
            this.toolbox.Name = "toolbox";
            this.toolbox.Size = new System.Drawing.Size(560, 43);
            this.toolbox.TabIndex = 1;
            this.toolbox.Text = "toolStrip1";
            // 
            // btn_Inserir
            // 
            this.btn_Inserir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Inserir.Enabled = false;
            this.btn_Inserir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Inserir.Image = global::TestesDonaMariana.WinApp.Properties.Resources.inserir__1_;
            this.btn_Inserir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Inserir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Inserir.Name = "btn_Inserir";
            this.btn_Inserir.Padding = new System.Windows.Forms.Padding(2);
            this.btn_Inserir.Size = new System.Drawing.Size(40, 40);
            this.btn_Inserir.Text = "toolStripButton1";
            this.btn_Inserir.Click += new System.EventHandler(this.btn_Inserir_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Editar.Enabled = false;
            this.btn_Editar.Image = global::TestesDonaMariana.WinApp.Properties.Resources.editar_arquivo__1_;
            this.btn_Editar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Editar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Padding = new System.Windows.Forms.Padding(2);
            this.btn_Editar.Size = new System.Drawing.Size(40, 40);
            this.btn_Editar.Text = "toolStripButton2";
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Excluir.Enabled = false;
            this.btn_Excluir.Image = global::TestesDonaMariana.WinApp.Properties.Resources.excluir__1_;
            this.btn_Excluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Excluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Padding = new System.Windows.Forms.Padding(2);
            this.btn_Excluir.Size = new System.Drawing.Size(40, 40);
            this.btn_Excluir.Text = "toolStripButton3";
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_GerarPDF
            // 
            this.btn_GerarPDF.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_GerarPDF.Enabled = false;
            this.btn_GerarPDF.Image = global::TestesDonaMariana.WinApp.Properties.Resources.simbolo_de_formato_de_arquivo_pdf;
            this.btn_GerarPDF.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_GerarPDF.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_GerarPDF.Name = "btn_GerarPDF";
            this.btn_GerarPDF.Padding = new System.Windows.Forms.Padding(2);
            this.btn_GerarPDF.Size = new System.Drawing.Size(40, 40);
            this.btn_GerarPDF.Text = "toolStripButton4";
            // 
            // labelTipoCadastro
            // 
            this.labelTipoCadastro.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelTipoCadastro.Name = "labelTipoCadastro";
            this.labelTipoCadastro.Size = new System.Drawing.Size(90, 40);
            this.labelTipoCadastro.Text = "[tipoCadastro]";
            // 
            // StripSatus_rodape
            // 
            this.StripSatus_rodape.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.label_Rodape});
            this.StripSatus_rodape.Location = new System.Drawing.Point(0, 358);
            this.StripSatus_rodape.Name = "StripSatus_rodape";
            this.StripSatus_rodape.Size = new System.Drawing.Size(560, 22);
            this.StripSatus_rodape.TabIndex = 2;
            this.StripSatus_rodape.Text = "statusStrip1";
            // 
            // label_Rodape
            // 
            this.label_Rodape.Name = "label_Rodape";
            this.label_Rodape.Size = new System.Drawing.Size(118, 17);
            this.label_Rodape.Text = "toolStripStatusLabel1";
            // 
            // panel_Registros
            // 
            this.panel_Registros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Registros.Location = new System.Drawing.Point(0, 67);
            this.panel_Registros.Name = "panel_Registros";
            this.panel_Registros.Size = new System.Drawing.Size(560, 291);
            this.panel_Registros.TabIndex = 3;
            // 
            // TelaPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 380);
            this.Controls.Add(this.panel_Registros);
            this.Controls.Add(this.StripSatus_rodape);
            this.Controls.Add(this.toolbox);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "TelaPrincipalForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Testes da Dona Mariana";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolbox.ResumeLayout(false);
            this.toolbox.PerformLayout();
            this.StripSatus_rodape.ResumeLayout(false);
            this.StripSatus_rodape.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem diciplinasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiasMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem testeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem questoesMenuItem;
        private System.Windows.Forms.ToolStrip toolbox;
        private System.Windows.Forms.StatusStrip StripSatus_rodape;
        private System.Windows.Forms.Panel panel_Registros;
        private System.Windows.Forms.ToolStripButton btn_Inserir;
        private System.Windows.Forms.ToolStripButton btn_Editar;
        private System.Windows.Forms.ToolStripButton btn_Excluir;
        private System.Windows.Forms.ToolStripButton btn_GerarPDF;
        private System.Windows.Forms.ToolStripStatusLabel label_Rodape;
        private System.Windows.Forms.ToolStripLabel labelTipoCadastro;
    }
}
