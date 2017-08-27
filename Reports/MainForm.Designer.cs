namespace Reports
{
    partial class MainForm
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
            this.BtnPrinte = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // BtnPrinte
            // 
            this.BtnPrinte.Location = new System.Drawing.Point(116, 160);
            this.BtnPrinte.Name = "BtnPrinte";
            this.BtnPrinte.Size = new System.Drawing.Size(75, 23);
            this.BtnPrinte.TabIndex = 0;
            this.BtnPrinte.Text = "打印";
            this.BtnPrinte.Click += new System.EventHandler(this.BtnPrinte_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 231);
            this.Controls.Add(this.BtnPrinte);
            this.Name = "MainForm";
            this.Text = "主界面";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BtnPrinte;
    }
}

