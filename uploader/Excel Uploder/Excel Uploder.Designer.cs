namespace Excel_Uploder
{
    partial class Excel_Uploder
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
            this.components = new System.ComponentModel.Container();
            this.TabNocApplication = new System.Windows.Forms.TabControl();
            this.tabMobileImport = new System.Windows.Forms.TabPage();
            this.lblMobImportHeader = new System.Windows.Forms.Label();
            this.btnMobImportUpload = new System.Windows.Forms.Button();
            this.btnMobImportBrowse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMobImportPath = new System.Windows.Forms.TextBox();
            this.tabModelAnalysis = new System.Windows.Forms.TabPage();
            this.lblModAnalysisHeader = new System.Windows.Forms.Label();
            this.btnModAnalysisUpload = new System.Windows.Forms.Button();
            this.btnModAnalysisBrowse = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtModAnalysisPath = new System.Windows.Forms.TextBox();
            this.tabApplicationNoc = new System.Windows.Forms.TabPage();
            this.lblNocHeader = new System.Windows.Forms.Label();
            this.btnNocUpload = new System.Windows.Forms.Button();
            this.btnNocBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNocPath = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imeiBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.TabNocApplication.SuspendLayout();
            this.tabMobileImport.SuspendLayout();
            this.tabModelAnalysis.SuspendLayout();
            this.tabApplicationNoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabNocApplication
            // 
            this.TabNocApplication.Controls.Add(this.tabMobileImport);
            this.TabNocApplication.Controls.Add(this.tabModelAnalysis);
            this.TabNocApplication.Controls.Add(this.tabApplicationNoc);
            this.TabNocApplication.Location = new System.Drawing.Point(3, 1);
            this.TabNocApplication.Name = "TabNocApplication";
            this.TabNocApplication.SelectedIndex = 0;
            this.TabNocApplication.Size = new System.Drawing.Size(556, 243);
            this.TabNocApplication.TabIndex = 0;
            // 
            // tabMobileImport
            // 
            this.tabMobileImport.BackColor = System.Drawing.Color.Linen;
            this.tabMobileImport.Controls.Add(this.lblMobImportHeader);
            this.tabMobileImport.Controls.Add(this.btnMobImportUpload);
            this.tabMobileImport.Controls.Add(this.btnMobImportBrowse);
            this.tabMobileImport.Controls.Add(this.label3);
            this.tabMobileImport.Controls.Add(this.txtMobImportPath);
            this.tabMobileImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabMobileImport.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMobileImport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabMobileImport.Location = new System.Drawing.Point(4, 22);
            this.tabMobileImport.Name = "tabMobileImport";
            this.tabMobileImport.Padding = new System.Windows.Forms.Padding(3);
            this.tabMobileImport.Size = new System.Drawing.Size(548, 217);
            this.tabMobileImport.TabIndex = 1;
            this.tabMobileImport.Text = "Mobile Import";
            // 
            // lblMobImportHeader
            // 
            this.lblMobImportHeader.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobImportHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMobImportHeader.Location = new System.Drawing.Point(52, 16);
            this.lblMobImportHeader.Name = "lblMobImportHeader";
            this.lblMobImportHeader.Size = new System.Drawing.Size(451, 33);
            this.lblMobImportHeader.TabIndex = 9;
            this.lblMobImportHeader.Text = "Upload Mobile Import Excel File";
            this.lblMobImportHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMobImportUpload
            // 
            this.btnMobImportUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMobImportUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMobImportUpload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMobImportUpload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMobImportUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMobImportUpload.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMobImportUpload.Location = new System.Drawing.Point(426, 110);
            this.btnMobImportUpload.Name = "btnMobImportUpload";
            this.btnMobImportUpload.Size = new System.Drawing.Size(102, 35);
            this.btnMobImportUpload.TabIndex = 8;
            this.btnMobImportUpload.Text = "Upload";
            this.btnMobImportUpload.UseVisualStyleBackColor = false;
            this.btnMobImportUpload.Visible = false;
            this.btnMobImportUpload.Click += new System.EventHandler(this.btnMobImportUpload_Click);
            // 
            // btnMobImportBrowse
            // 
            this.btnMobImportBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMobImportBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMobImportBrowse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMobImportBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMobImportBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMobImportBrowse.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMobImportBrowse.Location = new System.Drawing.Point(426, 71);
            this.btnMobImportBrowse.Name = "btnMobImportBrowse";
            this.btnMobImportBrowse.Size = new System.Drawing.Size(102, 37);
            this.btnMobImportBrowse.TabIndex = 7;
            this.btnMobImportBrowse.Text = "Browse";
            this.btnMobImportBrowse.UseVisualStyleBackColor = false;
            this.btnMobImportBrowse.Click += new System.EventHandler(this.btnMobImportBrowse_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "File Path:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMobImportPath
            // 
            this.txtMobImportPath.Location = new System.Drawing.Point(103, 71);
            this.txtMobImportPath.Multiline = true;
            this.txtMobImportPath.Name = "txtMobImportPath";
            this.txtMobImportPath.Size = new System.Drawing.Size(317, 73);
            this.txtMobImportPath.TabIndex = 5;
            // 
            // tabModelAnalysis
            // 
            this.tabModelAnalysis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tabModelAnalysis.Controls.Add(this.lblModAnalysisHeader);
            this.tabModelAnalysis.Controls.Add(this.btnModAnalysisUpload);
            this.tabModelAnalysis.Controls.Add(this.btnModAnalysisBrowse);
            this.tabModelAnalysis.Controls.Add(this.label4);
            this.tabModelAnalysis.Controls.Add(this.txtModAnalysisPath);
            this.tabModelAnalysis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabModelAnalysis.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabModelAnalysis.Location = new System.Drawing.Point(4, 22);
            this.tabModelAnalysis.Name = "tabModelAnalysis";
            this.tabModelAnalysis.Padding = new System.Windows.Forms.Padding(3);
            this.tabModelAnalysis.Size = new System.Drawing.Size(548, 217);
            this.tabModelAnalysis.TabIndex = 2;
            this.tabModelAnalysis.Text = "Model Analysis";
            // 
            // lblModAnalysisHeader
            // 
            this.lblModAnalysisHeader.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModAnalysisHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblModAnalysisHeader.Location = new System.Drawing.Point(52, 20);
            this.lblModAnalysisHeader.Name = "lblModAnalysisHeader";
            this.lblModAnalysisHeader.Size = new System.Drawing.Size(451, 33);
            this.lblModAnalysisHeader.TabIndex = 14;
            this.lblModAnalysisHeader.Text = "Upload Model Analysis Excel File";
            this.lblModAnalysisHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnModAnalysisUpload
            // 
            this.btnModAnalysisUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnModAnalysisUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModAnalysisUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModAnalysisUpload.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModAnalysisUpload.Location = new System.Drawing.Point(426, 114);
            this.btnModAnalysisUpload.Name = "btnModAnalysisUpload";
            this.btnModAnalysisUpload.Size = new System.Drawing.Size(102, 35);
            this.btnModAnalysisUpload.TabIndex = 13;
            this.btnModAnalysisUpload.Text = "Upload";
            this.btnModAnalysisUpload.UseVisualStyleBackColor = false;
            this.btnModAnalysisUpload.Visible = false;
            // 
            // btnModAnalysisBrowse
            // 
            this.btnModAnalysisBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnModAnalysisBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModAnalysisBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModAnalysisBrowse.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModAnalysisBrowse.Location = new System.Drawing.Point(426, 75);
            this.btnModAnalysisBrowse.Name = "btnModAnalysisBrowse";
            this.btnModAnalysisBrowse.Size = new System.Drawing.Size(102, 37);
            this.btnModAnalysisBrowse.TabIndex = 12;
            this.btnModAnalysisBrowse.Text = "Browse";
            this.btnModAnalysisBrowse.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "File Path:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtModAnalysisPath
            // 
            this.txtModAnalysisPath.Location = new System.Drawing.Point(103, 75);
            this.txtModAnalysisPath.Multiline = true;
            this.txtModAnalysisPath.Name = "txtModAnalysisPath";
            this.txtModAnalysisPath.Size = new System.Drawing.Size(317, 73);
            this.txtModAnalysisPath.TabIndex = 10;
            // 
            // tabApplicationNoc
            // 
            this.tabApplicationNoc.BackColor = System.Drawing.Color.LightGray;
            this.tabApplicationNoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabApplicationNoc.Controls.Add(this.lblNocHeader);
            this.tabApplicationNoc.Controls.Add(this.btnNocUpload);
            this.tabApplicationNoc.Controls.Add(this.btnNocBrowse);
            this.tabApplicationNoc.Controls.Add(this.label1);
            this.tabApplicationNoc.Controls.Add(this.txtNocPath);
            this.tabApplicationNoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabApplicationNoc.Location = new System.Drawing.Point(4, 22);
            this.tabApplicationNoc.Name = "tabApplicationNoc";
            this.tabApplicationNoc.Padding = new System.Windows.Forms.Padding(3);
            this.tabApplicationNoc.Size = new System.Drawing.Size(548, 217);
            this.tabApplicationNoc.TabIndex = 3;
            this.tabApplicationNoc.Text = "Application For Noc";
            // 
            // lblNocHeader
            // 
            this.lblNocHeader.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNocHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNocHeader.Location = new System.Drawing.Point(42, 12);
            this.lblNocHeader.Name = "lblNocHeader";
            this.lblNocHeader.Size = new System.Drawing.Size(451, 33);
            this.lblNocHeader.TabIndex = 4;
            this.lblNocHeader.Text = "Upload Application For Noc Excel File";
            this.lblNocHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNocUpload
            // 
            this.btnNocUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnNocUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNocUpload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNocUpload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnNocUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNocUpload.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNocUpload.Location = new System.Drawing.Point(416, 106);
            this.btnNocUpload.Name = "btnNocUpload";
            this.btnNocUpload.Size = new System.Drawing.Size(102, 35);
            this.btnNocUpload.TabIndex = 3;
            this.btnNocUpload.Text = "Upload";
            this.btnNocUpload.UseVisualStyleBackColor = false;
            this.btnNocUpload.Visible = false;
            // 
            // btnNocBrowse
            // 
            this.btnNocBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNocBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNocBrowse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNocBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnNocBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNocBrowse.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNocBrowse.Location = new System.Drawing.Point(416, 67);
            this.btnNocBrowse.Name = "btnNocBrowse";
            this.btnNocBrowse.Size = new System.Drawing.Size(102, 37);
            this.btnNocBrowse.TabIndex = 2;
            this.btnNocBrowse.Text = "Browse";
            this.btnNocBrowse.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(4, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "File Path:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNocPath
            // 
            this.txtNocPath.Location = new System.Drawing.Point(93, 67);
            this.txtNocPath.Multiline = true;
            this.txtNocPath.Name = "txtNocPath";
            this.txtNocPath.Size = new System.Drawing.Size(317, 73);
            this.txtNocPath.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imeiBackgroundWorker
            // 
            this.imeiBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.imeiBackgroundWorker_DoWork);
            // 
            // Excel_Uploder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(560, 244);
            this.Controls.Add(this.TabNocApplication);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Excel_Uploder";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excel Uploder";
            this.Load += new System.EventHandler(this.Excel_Uploder_Load);
            this.TabNocApplication.ResumeLayout(false);
            this.tabMobileImport.ResumeLayout(false);
            this.tabMobileImport.PerformLayout();
            this.tabModelAnalysis.ResumeLayout(false);
            this.tabModelAnalysis.PerformLayout();
            this.tabApplicationNoc.ResumeLayout(false);
            this.tabApplicationNoc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabNocApplication;
        private System.Windows.Forms.TabPage tabMobileImport;
        private System.Windows.Forms.TabPage tabModelAnalysis;
        private System.Windows.Forms.TabPage tabApplicationNoc;
        private System.Windows.Forms.Label lblNocHeader;
        private System.Windows.Forms.Button btnNocUpload;
        private System.Windows.Forms.Button btnNocBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNocPath;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblMobImportHeader;
        private System.Windows.Forms.Button btnMobImportUpload;
        private System.Windows.Forms.Button btnMobImportBrowse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMobImportPath;
        private System.Windows.Forms.Label lblModAnalysisHeader;
        private System.Windows.Forms.Button btnModAnalysisUpload;
        private System.Windows.Forms.Button btnModAnalysisBrowse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtModAnalysisPath;
        private System.ComponentModel.BackgroundWorker imeiBackgroundWorker;
    }
}