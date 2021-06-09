
namespace ProjectBackend
{
    partial class frmLanden
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLanden));
            this.lbLanden = new System.Windows.Forms.ListBox();
            this.txtLand = new System.Windows.Forms.TextBox();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbLanden
            // 
            this.lbLanden.FormattingEnabled = true;
            this.lbLanden.Location = new System.Drawing.Point(222, 26);
            this.lbLanden.Name = "lbLanden";
            this.lbLanden.Size = new System.Drawing.Size(161, 290);
            this.lbLanden.TabIndex = 0;
            // 
            // txtLand
            // 
            this.txtLand.Location = new System.Drawing.Point(12, 26);
            this.txtLand.Name = "txtLand";
            this.txtLand.Size = new System.Drawing.Size(154, 20);
            this.txtLand.TabIndex = 1;
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(12, 52);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(154, 23);
            this.btnToevoegen.TabIndex = 2;
            this.btnToevoegen.Text = "toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Location = new System.Drawing.Point(12, 81);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(154, 23);
            this.btnVerwijder.TabIndex = 3;
            this.btnVerwijder.Text = "Verwijder";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            this.btnVerwijder.Click += new System.EventHandler(this.btnVerwijder_Click);
            // 
            // frmLanden
            // 
            this.AcceptButton = this.btnToevoegen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 341);
            this.Controls.Add(this.btnVerwijder);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.txtLand);
            this.Controls.Add(this.lbLanden);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLanden";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Landen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLanden_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbLanden;
        private System.Windows.Forms.TextBox txtLand;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.Button btnVerwijder;
    }
}