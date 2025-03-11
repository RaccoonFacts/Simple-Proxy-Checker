namespace ProxyChecker
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
            this.totalProxyList = new System.Windows.Forms.TextBox();
            this.badProxyList = new System.Windows.Forms.TextBox();
            this.workingProxyList = new System.Windows.Forms.TextBox();
            this.checkBtn = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.TotalListLbl = new System.Windows.Forms.Label();
            this.brokenLbl = new System.Windows.Forms.Label();
            this.workingLst = new System.Windows.Forms.Label();
            this.TimeRemainingLbl = new System.Windows.Forms.Label();
            this.copyBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // totalProxyList
            // 
            this.totalProxyList.Location = new System.Drawing.Point(12, 34);
            this.totalProxyList.Multiline = true;
            this.totalProxyList.Name = "totalProxyList";
            this.totalProxyList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.totalProxyList.Size = new System.Drawing.Size(184, 326);
            this.totalProxyList.TabIndex = 0;
            // 
            // badProxyList
            // 
            this.badProxyList.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.badProxyList.Location = new System.Drawing.Point(202, 34);
            this.badProxyList.Multiline = true;
            this.badProxyList.Name = "badProxyList";
            this.badProxyList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.badProxyList.Size = new System.Drawing.Size(184, 326);
            this.badProxyList.TabIndex = 1;
            // 
            // workingProxyList
            // 
            this.workingProxyList.Location = new System.Drawing.Point(392, 34);
            this.workingProxyList.Multiline = true;
            this.workingProxyList.Name = "workingProxyList";
            this.workingProxyList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.workingProxyList.Size = new System.Drawing.Size(184, 326);
            this.workingProxyList.TabIndex = 2;
            // 
            // checkBtn
            // 
            this.checkBtn.Font = new System.Drawing.Font("OCR A Extended", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBtn.Location = new System.Drawing.Point(14, 366);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(183, 37);
            this.checkBtn.TabIndex = 3;
            this.checkBtn.Text = "Check";
            this.checkBtn.UseVisualStyleBackColor = true;
            this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 433);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(564, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // TotalListLbl
            // 
            this.TotalListLbl.AutoSize = true;
            this.TotalListLbl.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalListLbl.Location = new System.Drawing.Point(12, 19);
            this.TotalListLbl.Name = "TotalListLbl";
            this.TotalListLbl.Size = new System.Drawing.Size(159, 12);
            this.TotalListLbl.TabIndex = 5;
            this.TotalListLbl.Text = "Paste Proxy List Here:";
            // 
            // brokenLbl
            // 
            this.brokenLbl.AutoSize = true;
            this.brokenLbl.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brokenLbl.Location = new System.Drawing.Point(200, 19);
            this.brokenLbl.Name = "brokenLbl";
            this.brokenLbl.Size = new System.Drawing.Size(110, 12);
            this.brokenLbl.TabIndex = 6;
            this.brokenLbl.Text = "Broken Proxies:";
            // 
            // workingLst
            // 
            this.workingLst.AutoSize = true;
            this.workingLst.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workingLst.Location = new System.Drawing.Point(390, 19);
            this.workingLst.Name = "workingLst";
            this.workingLst.Size = new System.Drawing.Size(117, 12);
            this.workingLst.TabIndex = 7;
            this.workingLst.Text = "Working Proxies:";
            // 
            // TimeRemainingLbl
            // 
            this.TimeRemainingLbl.AutoSize = true;
            this.TimeRemainingLbl.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeRemainingLbl.Location = new System.Drawing.Point(10, 418);
            this.TimeRemainingLbl.Name = "TimeRemainingLbl";
            this.TimeRemainingLbl.Size = new System.Drawing.Size(117, 12);
            this.TimeRemainingLbl.TabIndex = 8;
            this.TimeRemainingLbl.Text = "Time Remaining: ";
            // 
            // copyBtn
            // 
            this.copyBtn.Font = new System.Drawing.Font("OCR A Extended", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyBtn.Location = new System.Drawing.Point(393, 366);
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Size = new System.Drawing.Size(183, 37);
            this.copyBtn.TabIndex = 9;
            this.copyBtn.Text = "Copy Above";
            this.copyBtn.UseVisualStyleBackColor = true;
            this.copyBtn.Click += new System.EventHandler(this.copyBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 470);
            this.Controls.Add(this.copyBtn);
            this.Controls.Add(this.TimeRemainingLbl);
            this.Controls.Add(this.workingLst);
            this.Controls.Add(this.brokenLbl);
            this.Controls.Add(this.TotalListLbl);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.checkBtn);
            this.Controls.Add(this.workingProxyList);
            this.Controls.Add(this.badProxyList);
            this.Controls.Add(this.totalProxyList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Simple Proxy Checker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox totalProxyList;
        private System.Windows.Forms.TextBox badProxyList;
        private System.Windows.Forms.TextBox workingProxyList;
        private System.Windows.Forms.Button checkBtn;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label TotalListLbl;
        private System.Windows.Forms.Label brokenLbl;
        private System.Windows.Forms.Label workingLst;
        private System.Windows.Forms.Label TimeRemainingLbl;
        private System.Windows.Forms.Button copyBtn;
    }
}

