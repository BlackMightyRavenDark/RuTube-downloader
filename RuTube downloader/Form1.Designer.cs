﻿namespace RuTube_downloader
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDownloadingDirPath = new System.Windows.Forms.TextBox();
            this.textBoxFileNameFormat = new System.Windows.Forms.TextBox();
            this.btnBrowseDownloadingDirPath = new System.Windows.Forms.Button();
            this.btnSetDefaultFileNameFormat = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.tabPageSearch = new System.Windows.Forms.TabPage();
            this.panelVideoBkg = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUrlOrId = new System.Windows.Forms.TextBox();
            this.btnSearchByUrlOrId = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            this.tabPageSearch.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Папка для скачивания:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Формат имени файла:";
            // 
            // textBoxDownloadingDirPath
            // 
            this.textBoxDownloadingDirPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDownloadingDirPath.Location = new System.Drawing.Point(137, 19);
            this.textBoxDownloadingDirPath.Name = "textBoxDownloadingDirPath";
            this.textBoxDownloadingDirPath.Size = new System.Drawing.Size(467, 20);
            this.textBoxDownloadingDirPath.TabIndex = 2;
            this.textBoxDownloadingDirPath.Leave += new System.EventHandler(this.textBoxDownloadingDirPath_Leave);
            // 
            // textBoxFileNameFormat
            // 
            this.textBoxFileNameFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFileNameFormat.Location = new System.Drawing.Point(137, 45);
            this.textBoxFileNameFormat.Name = "textBoxFileNameFormat";
            this.textBoxFileNameFormat.Size = new System.Drawing.Size(382, 20);
            this.textBoxFileNameFormat.TabIndex = 3;
            this.textBoxFileNameFormat.Leave += new System.EventHandler(this.textBoxFileNameFormat_Leave);
            // 
            // btnBrowseDownloadingDirPath
            // 
            this.btnBrowseDownloadingDirPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseDownloadingDirPath.Location = new System.Drawing.Point(610, 17);
            this.btnBrowseDownloadingDirPath.Name = "btnBrowseDownloadingDirPath";
            this.btnBrowseDownloadingDirPath.Size = new System.Drawing.Size(35, 23);
            this.btnBrowseDownloadingDirPath.TabIndex = 4;
            this.btnBrowseDownloadingDirPath.Text = "...";
            this.btnBrowseDownloadingDirPath.UseVisualStyleBackColor = true;
            this.btnBrowseDownloadingDirPath.Click += new System.EventHandler(this.btnBrowseDownloadingDirPath_Click);
            // 
            // btnSetDefaultFileNameFormat
            // 
            this.btnSetDefaultFileNameFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetDefaultFileNameFormat.Location = new System.Drawing.Point(525, 43);
            this.btnSetDefaultFileNameFormat.Name = "btnSetDefaultFileNameFormat";
            this.btnSetDefaultFileNameFormat.Size = new System.Drawing.Size(120, 23);
            this.btnSetDefaultFileNameFormat.TabIndex = 5;
            this.btnSetDefaultFileNameFormat.Text = "Вернуть как было";
            this.btnSetDefaultFileNameFormat.UseVisualStyleBackColor = true;
            this.btnSetDefaultFileNameFormat.Click += new System.EventHandler(this.btnSetDefaultFileNameFormat_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageSettings);
            this.tabControl1.Controls.Add(this.tabPageSearch);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(659, 412);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPageSettings.Controls.Add(this.label2);
            this.tabPageSettings.Controls.Add(this.btnSetDefaultFileNameFormat);
            this.tabPageSettings.Controls.Add(this.label1);
            this.tabPageSettings.Controls.Add(this.btnBrowseDownloadingDirPath);
            this.tabPageSettings.Controls.Add(this.textBoxDownloadingDirPath);
            this.tabPageSettings.Controls.Add(this.textBoxFileNameFormat);
            this.tabPageSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSettings.Size = new System.Drawing.Size(651, 386);
            this.tabPageSettings.TabIndex = 0;
            this.tabPageSettings.Text = "Настройки";
            // 
            // tabPageSearch
            // 
            this.tabPageSearch.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPageSearch.Controls.Add(this.panelVideoBkg);
            this.tabPageSearch.Controls.Add(this.groupBox1);
            this.tabPageSearch.Location = new System.Drawing.Point(4, 22);
            this.tabPageSearch.Name = "tabPageSearch";
            this.tabPageSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearch.Size = new System.Drawing.Size(651, 386);
            this.tabPageSearch.TabIndex = 1;
            this.tabPageSearch.Text = "Поиск";
            // 
            // panelVideoBkg
            // 
            this.panelVideoBkg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelVideoBkg.BackColor = System.Drawing.Color.Black;
            this.panelVideoBkg.Location = new System.Drawing.Point(6, 114);
            this.panelVideoBkg.Name = "panelVideoBkg";
            this.panelVideoBkg.Size = new System.Drawing.Size(633, 266);
            this.panelVideoBkg.TabIndex = 3;
            this.panelVideoBkg.Resize += new System.EventHandler(this.panelVideoBkg_Resize);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxUrlOrId);
            this.groupBox1.Controls.Add(this.btnSearchByUrlOrId);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 102);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск видео по ссылке или ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Введите ссылку на видео или его ID:";
            // 
            // textBoxUrlOrId
            // 
            this.textBoxUrlOrId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUrlOrId.Location = new System.Drawing.Point(19, 42);
            this.textBoxUrlOrId.Name = "textBoxUrlOrId";
            this.textBoxUrlOrId.Size = new System.Drawing.Size(614, 20);
            this.textBoxUrlOrId.TabIndex = 0;
            // 
            // btnSearchByUrlOrId
            // 
            this.btnSearchByUrlOrId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchByUrlOrId.Location = new System.Drawing.Point(558, 73);
            this.btnSearchByUrlOrId.Name = "btnSearchByUrlOrId";
            this.btnSearchByUrlOrId.Size = new System.Drawing.Size(75, 23);
            this.btnSearchByUrlOrId.TabIndex = 1;
            this.btnSearchByUrlOrId.Text = "Искать";
            this.btnSearchByUrlOrId.UseVisualStyleBackColor = true;
            this.btnSearchByUrlOrId.Click += new System.EventHandler(this.btnSearchByUrlOrId_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 429);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 378);
            this.Name = "Form1";
            this.Text = "Скачивалка с рутуба";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageSettings.ResumeLayout(false);
            this.tabPageSettings.PerformLayout();
            this.tabPageSearch.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDownloadingDirPath;
        private System.Windows.Forms.TextBox textBoxFileNameFormat;
        private System.Windows.Forms.Button btnBrowseDownloadingDirPath;
        private System.Windows.Forms.Button btnSetDefaultFileNameFormat;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.TabPage tabPageSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUrlOrId;
        private System.Windows.Forms.Button btnSearchByUrlOrId;
        private System.Windows.Forms.Panel panelVideoBkg;
    }
}
