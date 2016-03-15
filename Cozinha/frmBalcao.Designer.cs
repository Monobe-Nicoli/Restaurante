namespace Cozinha
{
    partial class frmBalcao
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
            this.lstBalcao = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstBalcao
            // 
            this.lstBalcao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstBalcao.FormattingEnabled = true;
            this.lstBalcao.Location = new System.Drawing.Point(0, 0);
            this.lstBalcao.Name = "lstBalcao";
            this.lstBalcao.Size = new System.Drawing.Size(284, 261);
            this.lstBalcao.TabIndex = 0;
            this.lstBalcao.SelectedIndexChanged += new System.EventHandler(this.lstBalcao_SelectedIndexChanged);
            // 
            // frmBalcao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lstBalcao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBalcao";
            this.Text = "Balcao";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBalcao_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstBalcao;
    }
}