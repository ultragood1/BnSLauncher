﻿namespace BnS_TwLauncher
{
    partial class Settings
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
            this.SettingsTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.radioButton_KR_TEST = new System.Windows.Forms.RadioButton();
            this.gBox_Arc = new System.Windows.Forms.GroupBox();
            this.x64_Rb = new System.Windows.Forms.RadioButton();
            this.x86_rB = new System.Windows.Forms.RadioButton();
            this.groupBox_west_lang = new System.Windows.Forms.GroupBox();
            this.radioButton_Fre = new System.Windows.Forms.RadioButton();
            this.radioButton_Ger = new System.Windows.Forms.RadioButton();
            this.radioButton_Eng = new System.Windows.Forms.RadioButton();
            this.radioButton_EN = new System.Windows.Forms.RadioButton();
            this.radioButton_KR = new System.Windows.Forms.RadioButton();
            this.radioButton_TW = new System.Windows.Forms.RadioButton();
            this.radioButton_JP = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_zoom = new System.Windows.Forms.TextBox();
            this.cbx_disableImg = new System.Windows.Forms.CheckBox();
            this.cBallCores = new System.Windows.Forms.CheckBox();
            this.cBmsBox = new System.Windows.Forms.CheckBox();
            this.cBtextureStr = new System.Windows.Forms.CheckBox();
            this.sts_ = new System.Windows.Forms.StatusStrip();
            this.Sts_Label = new System.Windows.Forms.ToolStripStatusLabel();
            this.SettingsTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gBox_Arc.SuspendLayout();
            this.groupBox_west_lang.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.sts_.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingsTab
            // 
            this.SettingsTab.AccessibleName = "SettingsTab";
            this.SettingsTab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsTab.Controls.Add(this.tabPage1);
            this.SettingsTab.Controls.Add(this.tabPage2);
            this.SettingsTab.Location = new System.Drawing.Point(7, 7);
            this.SettingsTab.Name = "SettingsTab";
            this.SettingsTab.SelectedIndex = 0;
            this.SettingsTab.Size = new System.Drawing.Size(225, 173);
            this.SettingsTab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.radioButton_KR_TEST);
            this.tabPage1.Controls.Add(this.gBox_Arc);
            this.tabPage1.Controls.Add(this.groupBox_west_lang);
            this.tabPage1.Controls.Add(this.radioButton_EN);
            this.tabPage1.Controls.Add(this.radioButton_KR);
            this.tabPage1.Controls.Add(this.radioButton_TW);
            this.tabPage1.Controls.Add(this.radioButton_JP);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(217, 147);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Region";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // radioButton_KR_TEST
            // 
            this.radioButton_KR_TEST.AutoSize = true;
            this.radioButton_KR_TEST.Location = new System.Drawing.Point(72, 35);
            this.radioButton_KR_TEST.Name = "radioButton_KR_TEST";
            this.radioButton_KR_TEST.Size = new System.Drawing.Size(117, 17);
            this.radioButton_KR_TEST.TabIndex = 16;
            this.radioButton_KR_TEST.Text = "Korean Test Server";
            this.radioButton_KR_TEST.UseVisualStyleBackColor = true;
            this.radioButton_KR_TEST.CheckedChanged += new System.EventHandler(this.radioButton_KR_TEST_CheckedChanged);
            // 
            // gBox_Arc
            // 
            this.gBox_Arc.Controls.Add(this.x64_Rb);
            this.gBox_Arc.Controls.Add(this.x86_rB);
            this.gBox_Arc.Location = new System.Drawing.Point(6, 58);
            this.gBox_Arc.Name = "gBox_Arc";
            this.gBox_Arc.Size = new System.Drawing.Size(98, 40);
            this.gBox_Arc.TabIndex = 15;
            this.gBox_Arc.TabStop = false;
            this.gBox_Arc.Text = "Architecture";
            // 
            // x64_Rb
            // 
            this.x64_Rb.AutoSize = true;
            this.x64_Rb.Location = new System.Drawing.Point(51, 15);
            this.x64_Rb.Name = "x64_Rb";
            this.x64_Rb.Size = new System.Drawing.Size(42, 17);
            this.x64_Rb.TabIndex = 1;
            this.x64_Rb.TabStop = true;
            this.x64_Rb.Text = "x64";
            this.x64_Rb.UseVisualStyleBackColor = true;
            this.x64_Rb.CheckedChanged += new System.EventHandler(this.x64_Rb_CheckedChanged);
            // 
            // x86_rB
            // 
            this.x86_rB.AutoSize = true;
            this.x86_rB.Location = new System.Drawing.Point(7, 16);
            this.x86_rB.Name = "x86_rB";
            this.x86_rB.Size = new System.Drawing.Size(42, 17);
            this.x86_rB.TabIndex = 0;
            this.x86_rB.TabStop = true;
            this.x86_rB.Text = "x86";
            this.x86_rB.UseVisualStyleBackColor = true;
            this.x86_rB.CheckedChanged += new System.EventHandler(this.x86_rB_CheckedChanged);
            // 
            // groupBox_west_lang
            // 
            this.groupBox_west_lang.Controls.Add(this.radioButton_Fre);
            this.groupBox_west_lang.Controls.Add(this.radioButton_Ger);
            this.groupBox_west_lang.Controls.Add(this.radioButton_Eng);
            this.groupBox_west_lang.Location = new System.Drawing.Point(6, 101);
            this.groupBox_west_lang.Name = "groupBox_west_lang";
            this.groupBox_west_lang.Size = new System.Drawing.Size(205, 41);
            this.groupBox_west_lang.TabIndex = 14;
            this.groupBox_west_lang.TabStop = false;
            this.groupBox_west_lang.Text = "West Language";
            // 
            // radioButton_Fre
            // 
            this.radioButton_Fre.AutoSize = true;
            this.radioButton_Fre.Location = new System.Drawing.Point(141, 16);
            this.radioButton_Fre.Name = "radioButton_Fre";
            this.radioButton_Fre.Size = new System.Drawing.Size(58, 17);
            this.radioButton_Fre.TabIndex = 2;
            this.radioButton_Fre.TabStop = true;
            this.radioButton_Fre.Text = "French";
            this.radioButton_Fre.UseVisualStyleBackColor = true;
            this.radioButton_Fre.CheckedChanged += new System.EventHandler(this.radioButton_Fre_CheckedChanged);
            // 
            // radioButton_Ger
            // 
            this.radioButton_Ger.AutoSize = true;
            this.radioButton_Ger.Location = new System.Drawing.Point(72, 16);
            this.radioButton_Ger.Name = "radioButton_Ger";
            this.radioButton_Ger.Size = new System.Drawing.Size(62, 17);
            this.radioButton_Ger.TabIndex = 1;
            this.radioButton_Ger.TabStop = true;
            this.radioButton_Ger.Text = "German";
            this.radioButton_Ger.UseVisualStyleBackColor = true;
            this.radioButton_Ger.CheckedChanged += new System.EventHandler(this.radioButton_Ger_CheckedChanged);
            // 
            // radioButton_Eng
            // 
            this.radioButton_Eng.AutoSize = true;
            this.radioButton_Eng.Location = new System.Drawing.Point(6, 16);
            this.radioButton_Eng.Name = "radioButton_Eng";
            this.radioButton_Eng.Size = new System.Drawing.Size(59, 17);
            this.radioButton_Eng.TabIndex = 0;
            this.radioButton_Eng.TabStop = true;
            this.radioButton_Eng.Text = "English";
            this.radioButton_Eng.UseVisualStyleBackColor = true;
            this.radioButton_Eng.CheckedChanged += new System.EventHandler(this.radioButton_Eng_CheckedChanged);
            // 
            // radioButton_EN
            // 
            this.radioButton_EN.AutoSize = true;
            this.radioButton_EN.Location = new System.Drawing.Point(12, 35);
            this.radioButton_EN.Name = "radioButton_EN";
            this.radioButton_EN.Size = new System.Drawing.Size(50, 17);
            this.radioButton_EN.TabIndex = 7;
            this.radioButton_EN.Text = "West";
            this.radioButton_EN.UseVisualStyleBackColor = true;
            this.radioButton_EN.CheckedChanged += new System.EventHandler(this.radioButton_EN_CheckedChanged);
            // 
            // radioButton_KR
            // 
            this.radioButton_KR.AutoSize = true;
            this.radioButton_KR.Location = new System.Drawing.Point(138, 12);
            this.radioButton_KR.Name = "radioButton_KR";
            this.radioButton_KR.Size = new System.Drawing.Size(59, 17);
            this.radioButton_KR.TabIndex = 6;
            this.radioButton_KR.Text = "Korean";
            this.radioButton_KR.UseVisualStyleBackColor = true;
            this.radioButton_KR.CheckedChanged += new System.EventHandler(this.radioButton_KR_CheckedChanged);
            // 
            // radioButton_TW
            // 
            this.radioButton_TW.AutoSize = true;
            this.radioButton_TW.Location = new System.Drawing.Point(72, 12);
            this.radioButton_TW.Name = "radioButton_TW";
            this.radioButton_TW.Size = new System.Drawing.Size(60, 17);
            this.radioButton_TW.TabIndex = 5;
            this.radioButton_TW.Text = "Taiwan";
            this.radioButton_TW.UseVisualStyleBackColor = true;
            this.radioButton_TW.CheckedChanged += new System.EventHandler(this.radioButton_TW_CheckedChanged);
            // 
            // radioButton_JP
            // 
            this.radioButton_JP.AutoSize = true;
            this.radioButton_JP.Checked = true;
            this.radioButton_JP.Location = new System.Drawing.Point(12, 12);
            this.radioButton_JP.Name = "radioButton_JP";
            this.radioButton_JP.Size = new System.Drawing.Size(54, 17);
            this.radioButton_JP.TabIndex = 4;
            this.radioButton_JP.TabStop = true;
            this.radioButton_JP.Text = "Japan";
            this.radioButton_JP.UseVisualStyleBackColor = true;
            this.radioButton_JP.CheckedChanged += new System.EventHandler(this.radioButton_JP_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txb_zoom);
            this.tabPage2.Controls.Add(this.cbx_disableImg);
            this.tabPage2.Controls.Add(this.cBallCores);
            this.tabPage2.Controls.Add(this.cBmsBox);
            this.tabPage2.Controls.Add(this.cBtextureStr);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(217, 147);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Others";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Zoom-out";
            // 
            // txb_zoom
            // 
            this.txb_zoom.Location = new System.Drawing.Point(66, 110);
            this.txb_zoom.Name = "txb_zoom";
            this.txb_zoom.Size = new System.Drawing.Size(100, 20);
            this.txb_zoom.TabIndex = 8;
            // 
            // cbx_disableImg
            // 
            this.cbx_disableImg.AutoSize = true;
            this.cbx_disableImg.Location = new System.Drawing.Point(11, 60);
            this.cbx_disableImg.Name = "cbx_disableImg";
            this.cbx_disableImg.Size = new System.Drawing.Size(134, 17);
            this.cbx_disableImg.TabIndex = 7;
            this.cbx_disableImg.Text = "Disable loading images";
            this.cbx_disableImg.UseVisualStyleBackColor = true;
            this.cbx_disableImg.CheckedChanged += new System.EventHandler(this.cbx_disableImg_CheckedChanged);
            // 
            // cBallCores
            // 
            this.cBallCores.AutoSize = true;
            this.cBallCores.Location = new System.Drawing.Point(11, 83);
            this.cBallCores.Name = "cBallCores";
            this.cBallCores.Size = new System.Drawing.Size(89, 17);
            this.cBallCores.TabIndex = 4;
            this.cBallCores.Text = "Use All Cores";
            this.cBallCores.UseVisualStyleBackColor = true;
            this.cBallCores.CheckedChanged += new System.EventHandler(this.checkBox_AllCores_CheckedChanged);
            // 
            // cBmsBox
            // 
            this.cBmsBox.AutoSize = true;
            this.cBmsBox.Location = new System.Drawing.Point(11, 37);
            this.cBmsBox.Name = "cBmsBox";
            this.cBmsBox.Size = new System.Drawing.Size(139, 17);
            this.cBmsBox.TabIndex = 3;
            this.cBmsBox.Text = "Disable Message Boxes";
            this.cBmsBox.UseVisualStyleBackColor = true;
            this.cBmsBox.CheckedChanged += new System.EventHandler(this.cBmsBox_CheckedChanged);
            // 
            // cBtextureStr
            // 
            this.cBtextureStr.AutoSize = true;
            this.cBtextureStr.Location = new System.Drawing.Point(11, 14);
            this.cBtextureStr.Name = "cBtextureStr";
            this.cBtextureStr.Size = new System.Drawing.Size(150, 17);
            this.cBtextureStr.TabIndex = 2;
            this.cBtextureStr.Text = "Disable Texture Streaming";
            this.cBtextureStr.UseVisualStyleBackColor = true;
            this.cBtextureStr.CheckedChanged += new System.EventHandler(this.cBtextureStr_CheckedChanged);
            // 
            // sts_
            // 
            this.sts_.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Sts_Label});
            this.sts_.Location = new System.Drawing.Point(0, 185);
            this.sts_.Name = "sts_";
            this.sts_.Size = new System.Drawing.Size(238, 22);
            this.sts_.TabIndex = 1;
            this.sts_.Text = "statusStrip1";
            // 
            // Sts_Label
            // 
            this.Sts_Label.Name = "Sts_Label";
            this.Sts_Label.Size = new System.Drawing.Size(0, 17);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 207);
            this.Controls.Add(this.sts_);
            this.Controls.Add(this.SettingsTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Settings";
            this.ShowInTaskbar = false;
            this.Text = "Settings";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FomrSettings_FormClosing);
            this.Load += new System.EventHandler(this.FomrSettings_Load);
            this.SettingsTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gBox_Arc.ResumeLayout(false);
            this.gBox_Arc.PerformLayout();
            this.groupBox_west_lang.ResumeLayout(false);
            this.groupBox_west_lang.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.sts_.ResumeLayout(false);
            this.sts_.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox cBtextureStr;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox cBmsBox;
        private System.Windows.Forms.RadioButton radioButton_TW;
        private System.Windows.Forms.RadioButton radioButton_JP;
        private System.Windows.Forms.RadioButton radioButton_KR;
        private System.Windows.Forms.RadioButton radioButton_EN;
        private System.Windows.Forms.CheckBox cBallCores;
        private System.Windows.Forms.GroupBox groupBox_west_lang;
        private System.Windows.Forms.RadioButton radioButton_Fre;
        private System.Windows.Forms.RadioButton radioButton_Ger;
        private System.Windows.Forms.RadioButton radioButton_Eng;
        private System.Windows.Forms.GroupBox gBox_Arc;
        private System.Windows.Forms.RadioButton x64_Rb;
        private System.Windows.Forms.RadioButton x86_rB;
        private System.Windows.Forms.TabControl SettingsTab;
        private System.Windows.Forms.RadioButton radioButton_KR_TEST;
        private System.Windows.Forms.CheckBox cbx_disableImg;
        private System.Windows.Forms.StatusStrip sts_;
        private System.Windows.Forms.ToolStripStatusLabel Sts_Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_zoom;
    }
}