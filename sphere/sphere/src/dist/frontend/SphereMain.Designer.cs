namespace sphere
{
    partial class SphereMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginpage = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.loginpage)).BeginInit();
            this.SuspendLayout();
            // 
            // loginpage
            // 
            this.loginpage.AllowExternalDrop = true;
            this.loginpage.CreationProperties = null;
            this.loginpage.DefaultBackgroundColor = System.Drawing.Color.White;
            this.loginpage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginpage.Location = new System.Drawing.Point(0, 0);
            this.loginpage.Name = "loginpage";
            this.loginpage.Size = new System.Drawing.Size(1020, 554);
            this.loginpage.TabIndex = 0;
            this.loginpage.ZoomFactor = 1D;
            this.loginpage.Click += new System.EventHandler(this.loginpage_Click);
            // 
            // SphereMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 554);
            this.Controls.Add(this.loginpage);
            this.Name = "SphereMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sphere";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SphereMain_FormClosing);
            this.Load += new System.EventHandler(this.SphereMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginpage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 loginpage;
    }
}

