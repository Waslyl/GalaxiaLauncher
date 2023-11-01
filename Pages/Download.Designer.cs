namespace UIKitTutorials.Pages
{
    partial class Download
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
            this.lblfilename = new System.Windows.Forms.Label();
            this.lbldownloaded = new System.Windows.Forms.Label();
            this.txtpercent = new System.Windows.Forms.Label();
            this.btndownload = new System.Windows.Forms.Button();
            this.btnbrowse = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txturl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblfilename
            // 
            this.lblfilename.AutoSize = true;
            this.lblfilename.Location = new System.Drawing.Point(76, 210);
            this.lblfilename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfilename.Name = "lblfilename";
            this.lblfilename.Size = new System.Drawing.Size(75, 16);
            this.lblfilename.TabIndex = 21;
            this.lblfilename.Text = "File Name: ";
            // 
            // lbldownloaded
            // 
            this.lbldownloaded.AutoSize = true;
            this.lbldownloaded.Location = new System.Drawing.Point(76, 184);
            this.lbldownloaded.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldownloaded.Name = "lbldownloaded";
            this.lbldownloaded.Size = new System.Drawing.Size(90, 16);
            this.lbldownloaded.TabIndex = 20;
            this.lbldownloaded.Text = "Downloaded: ";
            // 
            // txtpercent
            // 
            this.txtpercent.AutoSize = true;
            this.txtpercent.Location = new System.Drawing.Point(301, 154);
            this.txtpercent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtpercent.Name = "txtpercent";
            this.txtpercent.Size = new System.Drawing.Size(53, 16);
            this.txtpercent.TabIndex = 19;
            this.txtpercent.Text = "Percent";
            // 
            // btndownload
            // 
            this.btndownload.Location = new System.Drawing.Point(315, 216);
            this.btndownload.Margin = new System.Windows.Forms.Padding(4);
            this.btndownload.Name = "btndownload";
            this.btndownload.Size = new System.Drawing.Size(176, 28);
            this.btndownload.TabIndex = 18;
            this.btndownload.Text = "Download";
            this.btndownload.UseVisualStyleBackColor = true;
            this.btndownload.Click += new System.EventHandler(this.btndownload_Click);
            // 
            // btnbrowse
            // 
            this.btnbrowse.Location = new System.Drawing.Point(391, 112);
            this.btnbrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(100, 28);
            this.btnbrowse.TabIndex = 17;
            this.btnbrowse.Text = "Browse";
            this.btnbrowse.UseVisualStyleBackColor = true;
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(177, 148);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(315, 28);
            this.progressBar.TabIndex = 16;
            this.progressBar.Click += new System.EventHandler(this.progressBar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Progress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Save To: ";
            // 
            // txtpath
            // 
            this.txtpath.Enabled = false;
            this.txtpath.Location = new System.Drawing.Point(177, 82);
            this.txtpath.Margin = new System.Windows.Forms.Padding(4);
            this.txtpath.Name = "txtpath";
            this.txtpath.Size = new System.Drawing.Size(313, 22);
            this.txtpath.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Link: ";
            // 
            // txturl
            // 
            this.txturl.Location = new System.Drawing.Point(177, 50);
            this.txturl.Margin = new System.Windows.Forms.Padding(4);
            this.txturl.Name = "txturl";
            this.txturl.Size = new System.Drawing.Size(313, 22);
            this.txturl.TabIndex = 11;
            this.txturl.Text = "https://cdn.blksservers.com/7.20.rar";
            // 
            // Download
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 316);
            this.Controls.Add(this.lblfilename);
            this.Controls.Add(this.lbldownloaded);
            this.Controls.Add(this.txtpercent);
            this.Controls.Add(this.btndownload);
            this.Controls.Add(this.btnbrowse);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtpath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txturl);
            this.Name = "Download";
            this.Text = "GalaxiaDownload";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfilename;
        private System.Windows.Forms.Label lbldownloaded;
        private System.Windows.Forms.Label txtpercent;
        private System.Windows.Forms.Button btndownload;
        private System.Windows.Forms.Button btnbrowse;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txturl;
    }
}