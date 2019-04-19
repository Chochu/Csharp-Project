namespace AnimeDownloader
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lasteptexBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.firsteptexBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.labelPercentage = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.urlTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.logTextbox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.SaveLocationtexBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SaveLocationtexBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lasteptexBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.firsteptexBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.StartButton);
            this.panel1.Controls.Add(this.labelPercentage);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.urlTextbox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 160);
            this.panel1.TabIndex = 0;
            // 
            // lasteptexBox
            // 
            this.lasteptexBox.Location = new System.Drawing.Point(108, 64);
            this.lasteptexBox.Name = "lasteptexBox";
            this.lasteptexBox.Size = new System.Drawing.Size(149, 20);
            this.lasteptexBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Last Ep";
            // 
            // firsteptexBox
            // 
            this.firsteptexBox.Location = new System.Drawing.Point(108, 38);
            this.firsteptexBox.Name = "firsteptexBox";
            this.firsteptexBox.Size = new System.Drawing.Size(149, 20);
            this.firsteptexBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Starting Ep";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(16, 131);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // labelPercentage
            // 
            this.labelPercentage.AutoSize = true;
            this.labelPercentage.Location = new System.Drawing.Point(13, 105);
            this.labelPercentage.Name = "labelPercentage";
            this.labelPercentage.Size = new System.Drawing.Size(54, 13);
            this.labelPercentage.TabIndex = 3;
            this.labelPercentage.Text = "Progress: ";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(246, 95);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(544, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // urlTextbox
            // 
            this.urlTextbox.Location = new System.Drawing.Point(108, 9);
            this.urlTextbox.Name = "urlTextbox";
            this.urlTextbox.Size = new System.Drawing.Size(682, 20);
            this.urlTextbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 178);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(793, 246);
            this.webBrowser1.TabIndex = 7;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // logTextbox
            // 
            this.logTextbox.Location = new System.Drawing.Point(12, 430);
            this.logTextbox.Multiline = true;
            this.logTextbox.Name = "logTextbox";
            this.logTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTextbox.Size = new System.Drawing.Size(793, 171);
            this.logTextbox.TabIndex = 1;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Save location";
            // 
            // SaveLocationtexBox
            // 
            this.SaveLocationtexBox.Location = new System.Drawing.Point(341, 38);
            this.SaveLocationtexBox.Name = "SaveLocationtexBox";
            this.SaveLocationtexBox.Size = new System.Drawing.Size(449, 20);
            this.SaveLocationtexBox.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 613);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.logTextbox);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Video Downloader";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelPercentage;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox urlTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox logTextbox;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox firsteptexBox;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox lasteptexBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SaveLocationtexBox;
        private System.Windows.Forms.Label label4;
    }
}

