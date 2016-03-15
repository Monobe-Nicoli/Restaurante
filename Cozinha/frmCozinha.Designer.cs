namespace Cozinha
{
    partial class frmCozinha
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
            this.listaPedidos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listaPedidos
            // 
            this.listaPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listaPedidos.FormattingEnabled = true;
            this.listaPedidos.Location = new System.Drawing.Point(0, 0);
            this.listaPedidos.Margin = new System.Windows.Forms.Padding(0);
            this.listaPedidos.Name = "listaPedidos";
            this.listaPedidos.Size = new System.Drawing.Size(284, 261);
            this.listaPedidos.TabIndex = 0;
            this.listaPedidos.SelectedIndexChanged += new System.EventHandler(this.listaPedidos_SelectedIndexChanged);
            // 
            // frmCozinha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.listaPedidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCozinha";
            this.Text = "Cozinha";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCozinha_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listaPedidos;
    }
}

