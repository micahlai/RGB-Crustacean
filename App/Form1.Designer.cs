﻿
/*
By Anonymous Shrimp
https://youtube.com/channel/UCs2Sz1gPlWAdET5qcLcZCJw
https://github.com/Anonymous-Shrimp 
*/


namespace RGB_Crustacean
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.refresh = new System.Windows.Forms.Button();
            this.dataPathText = new System.Windows.Forms.Label();
            this.browseData = new System.Windows.Forms.Button();
            this.serialButton3 = new System.Windows.Forms.Button();
            this.serialLabel3 = new System.Windows.Forms.Label();
            this.serialLabel1 = new System.Windows.Forms.Label();
            this.serialLabel2 = new System.Windows.Forms.Label();
            this.serialButton2 = new System.Windows.Forms.Button();
            this.serialButton1 = new System.Windows.Forms.Button();
            this.serialText3 = new System.Windows.Forms.TextBox();
            this.serialText2 = new System.Windows.Forms.TextBox();
            this.serialText1 = new System.Windows.Forms.TextBox();
            this.errorText = new System.Windows.Forms.Label();
            this.serial3 = new System.Windows.Forms.ComboBox();
            this.serial2 = new System.Windows.Forms.ComboBox();
            this.serial1 = new System.Windows.Forms.ComboBox();
            this.GradientBox = new System.Windows.Forms.Panel();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.resetGradientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.process1 = new System.Diagnostics.Process();
            this.r = new System.Windows.Forms.TrackBar();
            this.g = new System.Windows.Forms.TrackBar();
            this.b = new System.Windows.Forms.TrackBar();
            this.dataPath = new System.Windows.Forms.FolderBrowserDialog();
            this.BottomPanel.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.r)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b)).BeginInit();
            this.SuspendLayout();
            // 
            // BottomPanel
            // 
            this.BottomPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BottomPanel.Controls.Add(this.refresh);
            this.BottomPanel.Controls.Add(this.dataPathText);
            this.BottomPanel.Controls.Add(this.browseData);
            this.BottomPanel.Controls.Add(this.serialButton3);
            this.BottomPanel.Controls.Add(this.serialLabel3);
            this.BottomPanel.Controls.Add(this.serialLabel1);
            this.BottomPanel.Controls.Add(this.serialLabel2);
            this.BottomPanel.Controls.Add(this.serialButton2);
            this.BottomPanel.Controls.Add(this.serialButton1);
            this.BottomPanel.Controls.Add(this.serialText3);
            this.BottomPanel.Controls.Add(this.serialText2);
            this.BottomPanel.Controls.Add(this.serialText1);
            this.BottomPanel.Controls.Add(this.errorText);
            this.BottomPanel.Controls.Add(this.serial3);
            this.BottomPanel.Controls.Add(this.serial2);
            this.BottomPanel.Controls.Add(this.serial1);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 302);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(800, 148);
            this.BottomPanel.TabIndex = 1;
            this.BottomPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BottomPanel_MouseMove);
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.Transparent;
            this.refresh.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.Location = new System.Drawing.Point(614, 17);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(124, 29);
            this.refresh.TabIndex = 16;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // dataPathText
            // 
            this.dataPathText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataPathText.AutoSize = true;
            this.dataPathText.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataPathText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(100)))), ((int)(((byte)(117)))));
            this.dataPathText.Location = new System.Drawing.Point(439, 103);
            this.dataPathText.Name = "dataPathText";
            this.dataPathText.Size = new System.Drawing.Size(117, 21);
            this.dataPathText.TabIndex = 15;
            this.dataPathText.Text = "dataPathText";
            this.dataPathText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // browseData
            // 
            this.browseData.BackColor = System.Drawing.Color.Transparent;
            this.browseData.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseData.Location = new System.Drawing.Point(614, 59);
            this.browseData.Name = "browseData";
            this.browseData.Size = new System.Drawing.Size(124, 29);
            this.browseData.TabIndex = 14;
            this.browseData.Text = "Data Path";
            this.browseData.UseVisualStyleBackColor = false;
            this.browseData.Click += new System.EventHandler(this.browseData_Click);
            // 
            // serialButton3
            // 
            this.serialButton3.BackColor = System.Drawing.Color.Transparent;
            this.serialButton3.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialButton3.Location = new System.Drawing.Point(296, 84);
            this.serialButton3.Name = "serialButton3";
            this.serialButton3.Size = new System.Drawing.Size(106, 29);
            this.serialButton3.TabIndex = 10;
            this.serialButton3.Text = "button3";
            this.serialButton3.UseVisualStyleBackColor = false;
            this.serialButton3.Click += new System.EventHandler(this.serialButton3_Click);
            // 
            // serialLabel3
            // 
            this.serialLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serialLabel3.AutoSize = true;
            this.serialLabel3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.serialLabel3.Location = new System.Drawing.Point(36, 87);
            this.serialLabel3.Name = "serialLabel3";
            this.serialLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.serialLabel3.Size = new System.Drawing.Size(95, 34);
            this.serialLabel3.TabIndex = 12;
            this.serialLabel3.Text = "label3";
            this.serialLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.serialLabel3.Visible = false;
            this.serialLabel3.Click += new System.EventHandler(this.serialLabel3_Click);
            // 
            // serialLabel1
            // 
            this.serialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serialLabel1.AutoSize = true;
            this.serialLabel1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.serialLabel1.Location = new System.Drawing.Point(36, 11);
            this.serialLabel1.Name = "serialLabel1";
            this.serialLabel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.serialLabel1.Size = new System.Drawing.Size(95, 34);
            this.serialLabel1.TabIndex = 2;
            this.serialLabel1.Text = "label1";
            this.serialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.serialLabel1.Click += new System.EventHandler(this.serialLabel1_Click);
            // 
            // serialLabel2
            // 
            this.serialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serialLabel2.AutoSize = true;
            this.serialLabel2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.serialLabel2.Location = new System.Drawing.Point(36, 49);
            this.serialLabel2.Name = "serialLabel2";
            this.serialLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.serialLabel2.Size = new System.Drawing.Size(95, 34);
            this.serialLabel2.TabIndex = 11;
            this.serialLabel2.Text = "label2";
            this.serialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.serialLabel2.Click += new System.EventHandler(this.serialLabel2_Click);
            // 
            // serialButton2
            // 
            this.serialButton2.BackColor = System.Drawing.Color.Transparent;
            this.serialButton2.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialButton2.Location = new System.Drawing.Point(296, 46);
            this.serialButton2.Name = "serialButton2";
            this.serialButton2.Size = new System.Drawing.Size(106, 29);
            this.serialButton2.TabIndex = 9;
            this.serialButton2.Text = "button2";
            this.serialButton2.UseVisualStyleBackColor = false;
            this.serialButton2.Click += new System.EventHandler(this.serialButton2_Click);
            // 
            // serialButton1
            // 
            this.serialButton1.BackColor = System.Drawing.Color.Transparent;
            this.serialButton1.Font = new System.Drawing.Font("Ubuntu", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialButton1.Location = new System.Drawing.Point(296, 8);
            this.serialButton1.Name = "serialButton1";
            this.serialButton1.Size = new System.Drawing.Size(106, 29);
            this.serialButton1.TabIndex = 8;
            this.serialButton1.Text = "button1";
            this.serialButton1.UseVisualStyleBackColor = false;
            this.serialButton1.Click += new System.EventHandler(this.serialButton1_Click);
            // 
            // serialText3
            // 
            this.serialText3.Location = new System.Drawing.Point(19, 84);
            this.serialText3.MaxLength = 10;
            this.serialText3.Name = "serialText3";
            this.serialText3.Size = new System.Drawing.Size(100, 40);
            this.serialText3.TabIndex = 7;
            this.serialText3.Text = "Device3";
            this.serialText3.TextChanged += new System.EventHandler(this.serialText3_TextChanged);
            // 
            // serialText2
            // 
            this.serialText2.Location = new System.Drawing.Point(19, 46);
            this.serialText2.MaxLength = 10;
            this.serialText2.Name = "serialText2";
            this.serialText2.Size = new System.Drawing.Size(100, 40);
            this.serialText2.TabIndex = 6;
            this.serialText2.Text = "Device2";
            this.serialText2.TextChanged += new System.EventHandler(this.serialText2_TextChanged);
            // 
            // serialText1
            // 
            this.serialText1.Location = new System.Drawing.Point(19, 8);
            this.serialText1.MaxLength = 10;
            this.serialText1.Name = "serialText1";
            this.serialText1.Size = new System.Drawing.Size(100, 40);
            this.serialText1.TabIndex = 5;
            this.serialText1.Text = "Device1";
            this.serialText1.TextChanged += new System.EventHandler(this.serialText1_TextChanged);
            // 
            // errorText
            // 
            this.errorText.AutoSize = true;
            this.errorText.Font = new System.Drawing.Font("Ubuntu", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorText.ForeColor = System.Drawing.Color.Red;
            this.errorText.Location = new System.Drawing.Point(165, 123);
            this.errorText.Name = "errorText";
            this.errorText.Size = new System.Drawing.Size(58, 21);
            this.errorText.TabIndex = 4;
            this.errorText.Text = "label2";
            this.errorText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.errorText.Click += new System.EventHandler(this.errorText_Click);
            // 
            // serial3
            // 
            this.serial3.FormattingEnabled = true;
            this.serial3.Location = new System.Drawing.Point(169, 84);
            this.serial3.Name = "serial3";
            this.serial3.Size = new System.Drawing.Size(121, 42);
            this.serial3.TabIndex = 2;
            this.serial3.SelectedIndexChanged += new System.EventHandler(this.serial3_SelectedIndexChanged);
            // 
            // serial2
            // 
            this.serial2.FormattingEnabled = true;
            this.serial2.Location = new System.Drawing.Point(169, 46);
            this.serial2.Name = "serial2";
            this.serial2.Size = new System.Drawing.Size(121, 42);
            this.serial2.TabIndex = 1;
            this.serial2.SelectedIndexChanged += new System.EventHandler(this.serial2_SelectedIndexChanged);
            // 
            // serial1
            // 
            this.serial1.FormattingEnabled = true;
            this.serial1.Location = new System.Drawing.Point(169, 8);
            this.serial1.Name = "serial1";
            this.serial1.Size = new System.Drawing.Size(121, 42);
            this.serial1.TabIndex = 0;
            this.serial1.SelectedIndexChanged += new System.EventHandler(this.serial1_SelectedIndexChanged);
            // 
            // GradientBox
            // 
            this.GradientBox.ContextMenuStrip = this.contextMenuStrip;
            this.GradientBox.Location = new System.Drawing.Point(12, 12);
            this.GradientBox.Name = "GradientBox";
            this.GradientBox.Size = new System.Drawing.Size(776, 100);
            this.GradientBox.TabIndex = 2;
            this.GradientBox.Paint += new System.Windows.Forms.PaintEventHandler(this.GradientBox_Paint);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetGradientToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(199, 36);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // resetGradientToolStripMenuItem
            // 
            this.resetGradientToolStripMenuItem.Name = "resetGradientToolStripMenuItem";
            this.resetGradientToolStripMenuItem.Size = new System.Drawing.Size(198, 32);
            this.resetGradientToolStripMenuItem.Text = "Reset Gradient";
            this.resetGradientToolStripMenuItem.Click += new System.EventHandler(this.resetGradientToolStripMenuItem_Click);
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // r
            // 
            this.r.Location = new System.Drawing.Point(641, 118);
            this.r.Maximum = 255;
            this.r.Name = "r";
            this.r.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.r.Size = new System.Drawing.Size(69, 174);
            this.r.TabIndex = 14;
            this.r.TickFrequency = 5;
            this.r.Scroll += new System.EventHandler(this.r_Scroll);
            // 
            // g
            // 
            this.g.Location = new System.Drawing.Point(692, 118);
            this.g.Maximum = 255;
            this.g.Name = "g";
            this.g.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.g.Size = new System.Drawing.Size(69, 174);
            this.g.TabIndex = 15;
            this.g.TickFrequency = 5;
            this.g.Scroll += new System.EventHandler(this.g_Scroll);
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(743, 118);
            this.b.Maximum = 255;
            this.b.Name = "b";
            this.b.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.b.Size = new System.Drawing.Size(69, 174);
            this.b.TabIndex = 16;
            this.b.TickFrequency = 5;
            this.b.Scroll += new System.EventHandler(this.b_Scroll);
            // 
            // dataPath
            // 
            this.dataPath.Description = "The folder in which the device and gradient data is stored";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.b);
            this.Controls.Add(this.g);
            this.Controls.Add(this.r);
            this.Controls.Add(this.GradientBox);
            this.Controls.Add(this.BottomPanel);
            this.Font = new System.Drawing.Font("Ubuntu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(100)))), ((int)(((byte)(117)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form";
            this.Text = "RGB Crustacean";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.MouseHover += new System.EventHandler(this.Form_MouseHover);
            this.BottomPanel.ResumeLayout(false);
            this.BottomPanel.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.r)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.ComboBox serial3;
        private System.Windows.Forms.ComboBox serial2;
        private System.Windows.Forms.ComboBox serial1;
        private System.Windows.Forms.Label errorText;
        private System.Windows.Forms.TextBox serialText3;
        private System.Windows.Forms.TextBox serialText2;
        private System.Windows.Forms.TextBox serialText1;
        private System.Windows.Forms.Button serialButton3;
        private System.Windows.Forms.Button serialButton2;
        private System.Windows.Forms.Button serialButton1;
        private System.Windows.Forms.Label serialLabel1;
        private System.Windows.Forms.Label serialLabel2;
        private System.Windows.Forms.Label serialLabel3;
        private System.Windows.Forms.Panel GradientBox;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.TrackBar b;
        private System.Windows.Forms.TrackBar g;
        private System.Windows.Forms.TrackBar r;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem resetGradientToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog dataPath;
        private System.Windows.Forms.Button browseData;
        private System.Windows.Forms.Label dataPathText;
        private System.Windows.Forms.Button refresh;
    }
}

