namespace RenameFiles
{
    partial class FrmRenameFiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRenameFiles));
            this.fbdSelecionarPasta = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSelecionarPasta = new System.Windows.Forms.Button();
            this.lblPastaSelecionada = new System.Windows.Forms.Label();
            this.lstArquivosRenomear = new System.Windows.Forms.ListBox();
            this.lblTextoRemover = new System.Windows.Forms.Label();
            this.txtTextoRemover = new System.Windows.Forms.TextBox();
            this.btnRenomearArquivos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSelecionarPasta
            // 
            this.btnSelecionarPasta.Location = new System.Drawing.Point(12, 12);
            this.btnSelecionarPasta.Name = "btnSelecionarPasta";
            this.btnSelecionarPasta.Size = new System.Drawing.Size(148, 30);
            this.btnSelecionarPasta.TabIndex = 0;
            this.btnSelecionarPasta.Text = "Selecionar pasta";
            this.btnSelecionarPasta.UseVisualStyleBackColor = true;
            this.btnSelecionarPasta.Click += new System.EventHandler(this.BtnSelecionarPasta_Click);
            // 
            // lblPastaSelecionada
            // 
            this.lblPastaSelecionada.AutoSize = true;
            this.lblPastaSelecionada.Location = new System.Drawing.Point(12, 45);
            this.lblPastaSelecionada.Name = "lblPastaSelecionada";
            this.lblPastaSelecionada.Size = new System.Drawing.Size(159, 15);
            this.lblPastaSelecionada.TabIndex = 1;
            this.lblPastaSelecionada.Text = "Nenhuma pasta selecionada.";
            // 
            // lstArquivosRenomear
            // 
            this.lstArquivosRenomear.FormattingEnabled = true;
            this.lstArquivosRenomear.ItemHeight = 15;
            this.lstArquivosRenomear.Location = new System.Drawing.Point(12, 72);
            this.lstArquivosRenomear.Name = "lstArquivosRenomear";
            this.lstArquivosRenomear.Size = new System.Drawing.Size(776, 319);
            this.lstArquivosRenomear.TabIndex = 2;
            this.lstArquivosRenomear.SelectedIndexChanged += new System.EventHandler(this.LstArquivosRenomear_SelectedIndexChanged);
            // 
            // lblTextoRemover
            // 
            this.lblTextoRemover.AutoSize = true;
            this.lblTextoRemover.Location = new System.Drawing.Point(12, 410);
            this.lblTextoRemover.Name = "lblTextoRemover";
            this.lblTextoRemover.Size = new System.Drawing.Size(240, 15);
            this.lblTextoRemover.TabIndex = 3;
            this.lblTextoRemover.Text = "Texto a ser removido do nome dos arquivos:";
            // 
            // txtTextoRemover
            // 
            this.txtTextoRemover.Location = new System.Drawing.Point(258, 407);
            this.txtTextoRemover.Name = "txtTextoRemover";
            this.txtTextoRemover.Size = new System.Drawing.Size(530, 23);
            this.txtTextoRemover.TabIndex = 4;
            // 
            // btnRenomearArquivos
            // 
            this.btnRenomearArquivos.Location = new System.Drawing.Point(630, 436);
            this.btnRenomearArquivos.Name = "btnRenomearArquivos";
            this.btnRenomearArquivos.Size = new System.Drawing.Size(158, 33);
            this.btnRenomearArquivos.TabIndex = 5;
            this.btnRenomearArquivos.Text = "Renomear arquivos";
            this.btnRenomearArquivos.UseVisualStyleBackColor = true;
            this.btnRenomearArquivos.Click += new System.EventHandler(this.BtnRenomearArquivos_Click);
            // 
            // FrmRenameFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.btnRenomearArquivos);
            this.Controls.Add(this.txtTextoRemover);
            this.Controls.Add(this.lblTextoRemover);
            this.Controls.Add(this.lstArquivosRenomear);
            this.Controls.Add(this.lblPastaSelecionada);
            this.Controls.Add(this.btnSelecionarPasta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRenameFiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rename files";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FolderBrowserDialog fbdSelecionarPasta;
        private Button btnSelecionarPasta;
        private Label lblPastaSelecionada;
        private ListBox lstArquivosRenomear;
        private Label lblTextoRemover;
        private Button btnRenomearArquivos;
        private TextBox txtTextoRemover;
    }
}