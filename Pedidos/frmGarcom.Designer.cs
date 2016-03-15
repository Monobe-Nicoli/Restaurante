namespace Pedidos
{
    partial class frmGarcom
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
            this.ddlPrato = new System.Windows.Forms.ComboBox();
            this.ddlMesa = new System.Windows.Forms.ComboBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lblPrato = new System.Windows.Forms.Label();
            this.lblMesa = new System.Windows.Forms.Label();
            this.btnAddPrato = new System.Windows.Forms.Button();
            this.lstPratos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ddlPrato
            // 
            this.ddlPrato.DisplayMember = "value";
            this.ddlPrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlPrato.FormattingEnabled = true;
            this.ddlPrato.Location = new System.Drawing.Point(52, 9);
            this.ddlPrato.Name = "ddlPrato";
            this.ddlPrato.Size = new System.Drawing.Size(121, 21);
            this.ddlPrato.TabIndex = 0;
            this.ddlPrato.ValueMember = "key";
            // 
            // ddlMesa
            // 
            this.ddlMesa.DisplayMember = "value";
            this.ddlMesa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlMesa.FormattingEnabled = true;
            this.ddlMesa.Location = new System.Drawing.Point(47, 230);
            this.ddlMesa.Name = "ddlMesa";
            this.ddlMesa.Size = new System.Drawing.Size(121, 21);
            this.ddlMesa.TabIndex = 1;
            this.ddlMesa.ValueMember = "key";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(188, 228);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(84, 23);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar pedido";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPrato
            // 
            this.lblPrato.AutoSize = true;
            this.lblPrato.Location = new System.Drawing.Point(10, 12);
            this.lblPrato.Name = "lblPrato";
            this.lblPrato.Size = new System.Drawing.Size(32, 13);
            this.lblPrato.TabIndex = 3;
            this.lblPrato.Text = "Prato";
            // 
            // lblMesa
            // 
            this.lblMesa.AutoSize = true;
            this.lblMesa.Location = new System.Drawing.Point(6, 233);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(33, 13);
            this.lblMesa.TabIndex = 4;
            this.lblMesa.Text = "Mesa";
            // 
            // btnAddPrato
            // 
            this.btnAddPrato.Location = new System.Drawing.Point(179, 7);
            this.btnAddPrato.Name = "btnAddPrato";
            this.btnAddPrato.Size = new System.Drawing.Size(93, 23);
            this.btnAddPrato.TabIndex = 5;
            this.btnAddPrato.Text = "Adicionar prato";
            this.btnAddPrato.UseVisualStyleBackColor = true;
            this.btnAddPrato.Click += new System.EventHandler(this.button2_Click);
            // 
            // lstPratos
            // 
            this.lstPratos.FormattingEnabled = true;
            this.lstPratos.Location = new System.Drawing.Point(13, 36);
            this.lstPratos.Name = "lstPratos";
            this.lstPratos.Size = new System.Drawing.Size(259, 186);
            this.lstPratos.TabIndex = 6;
            this.lstPratos.SelectedIndexChanged += new System.EventHandler(this.lstPratos_SelectedIndexChanged);
            // 
            // frmGarcom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lstPratos);
            this.Controls.Add(this.btnAddPrato);
            this.Controls.Add(this.lblMesa);
            this.Controls.Add(this.lblPrato);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.ddlMesa);
            this.Controls.Add(this.ddlPrato);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGarcom";
            this.Text = "Garçom";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ddlPrato;
        private System.Windows.Forms.ComboBox ddlMesa;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label lblPrato;
        private System.Windows.Forms.Label lblMesa;
        private System.Windows.Forms.Button btnAddPrato;
        private System.Windows.Forms.ListBox lstPratos;
    }
}

