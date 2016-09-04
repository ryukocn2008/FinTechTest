namespace MyCollectionTest
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
            this.txtStringCollection = new System.Windows.Forms.TextBox();
            this.txtNameValueCollection = new System.Windows.Forms.TextBox();
            this.btnStringCollection = new System.Windows.Forms.Button();
            this.btnNameValueCollection = new System.Windows.Forms.Button();
            this.lstStringCollection = new System.Windows.Forms.ListBox();
            this.lstNameValueCollection = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtStringCollection
            // 
            this.txtStringCollection.Location = new System.Drawing.Point(22, 36);
            this.txtStringCollection.Name = "txtStringCollection";
            this.txtStringCollection.Size = new System.Drawing.Size(151, 20);
            this.txtStringCollection.TabIndex = 0;
            // 
            // txtNameValueCollection
            // 
            this.txtNameValueCollection.Location = new System.Drawing.Point(195, 36);
            this.txtNameValueCollection.Name = "txtNameValueCollection";
            this.txtNameValueCollection.Size = new System.Drawing.Size(151, 20);
            this.txtNameValueCollection.TabIndex = 1;
            // 
            // btnStringCollection
            // 
            this.btnStringCollection.Location = new System.Drawing.Point(62, 62);
            this.btnStringCollection.Name = "btnStringCollection";
            this.btnStringCollection.Size = new System.Drawing.Size(75, 23);
            this.btnStringCollection.TabIndex = 2;
            this.btnStringCollection.Text = "Add";
            this.btnStringCollection.UseVisualStyleBackColor = true;
            this.btnStringCollection.Click += new System.EventHandler(this.btnStringCollection_Click);
            // 
            // btnNameValueCollection
            // 
            this.btnNameValueCollection.Location = new System.Drawing.Point(227, 62);
            this.btnNameValueCollection.Name = "btnNameValueCollection";
            this.btnNameValueCollection.Size = new System.Drawing.Size(75, 23);
            this.btnNameValueCollection.TabIndex = 3;
            this.btnNameValueCollection.Text = "Add";
            this.btnNameValueCollection.UseVisualStyleBackColor = true;
            this.btnNameValueCollection.Click += new System.EventHandler(this.btnNameValueCollection_Click);
            // 
            // lstStringCollection
            // 
            this.lstStringCollection.FormattingEnabled = true;
            this.lstStringCollection.Location = new System.Drawing.Point(22, 107);
            this.lstStringCollection.Name = "lstStringCollection";
            this.lstStringCollection.Size = new System.Drawing.Size(150, 290);
            this.lstStringCollection.TabIndex = 4;
            // 
            // lstNameValueCollection
            // 
            this.lstNameValueCollection.FormattingEnabled = true;
            this.lstNameValueCollection.Location = new System.Drawing.Point(196, 107);
            this.lstNameValueCollection.Name = "lstNameValueCollection";
            this.lstNameValueCollection.Size = new System.Drawing.Size(150, 290);
            this.lstNameValueCollection.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 475);
            this.Controls.Add(this.lstNameValueCollection);
            this.Controls.Add(this.lstStringCollection);
            this.Controls.Add(this.btnNameValueCollection);
            this.Controls.Add(this.btnStringCollection);
            this.Controls.Add(this.txtNameValueCollection);
            this.Controls.Add(this.txtStringCollection);
            this.Name = "MainForm";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStringCollection;
        private System.Windows.Forms.TextBox txtNameValueCollection;
        private System.Windows.Forms.Button btnStringCollection;
        private System.Windows.Forms.Button btnNameValueCollection;
        private System.Windows.Forms.ListBox lstStringCollection;
        private System.Windows.Forms.ListBox lstNameValueCollection;
    }
}

