﻿/*
 * Created by SharpDevelop.
 * User: jerome.i
 * Date: 09/12/2015
 * Time: 14:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace IWM2_Serial_Devices
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.msiShowDebug = new System.Windows.Forms.ToolStripMenuItem();
			this.msiShowFrames = new System.Windows.Forms.ToolStripMenuItem();
			this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.imgHeader = new System.Windows.Forms.PictureBox();
			this.btPlus = new System.Windows.Forms.Button();
			this.pBottom = new System.Windows.Forms.Panel();
			this.flpMiddle = new System.Windows.Forms.FlowLayoutPanel();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgHeader)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fileToolStripMenuItem,
									this.aboutToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1025, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.msiShowDebug,
									this.msiShowFrames,
									this.toolStripSeparator1,
									this.quitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// msiShowDebug
			// 
			this.msiShowDebug.CheckOnClick = true;
			this.msiShowDebug.Name = "msiShowDebug";
			this.msiShowDebug.Size = new System.Drawing.Size(238, 22);
			this.msiShowDebug.Text = "Show debug console";
			this.msiShowDebug.CheckedChanged += new System.EventHandler(this.MsiShowDebugCheckedChanged);
			// 
			// msiShowFrames
			// 
			this.msiShowFrames.CheckOnClick = true;
			this.msiShowFrames.Name = "msiShowFrames";
			this.msiShowFrames.Size = new System.Drawing.Size(238, 22);
			this.msiShowFrames.Text = "In debug console: show frames";
			this.msiShowFrames.CheckedChanged += new System.EventHandler(this.MsiShowFramesCheckedChanged);
			// 
			// quitToolStripMenuItem
			// 
			this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
			this.quitToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
			this.quitToolStripMenuItem.Text = "Quit";
			this.quitToolStripMenuItem.Click += new System.EventHandler(this.QuitToolStripMenuItemClick);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.aboutToolStripMenuItem1});
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.aboutToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem1
			// 
			this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
			this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
			this.aboutToolStripMenuItem1.Text = "About";
			this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.AboutToolStripMenuItem1Click);
			// 
			// imgHeader
			// 
			this.imgHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.imgHeader.Image = ((System.Drawing.Image)(resources.GetObject("imgHeader.Image")));
			this.imgHeader.Location = new System.Drawing.Point(0, 24);
			this.imgHeader.Name = "imgHeader";
			this.imgHeader.Size = new System.Drawing.Size(1025, 65);
			this.imgHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imgHeader.TabIndex = 30;
			this.imgHeader.TabStop = false;
			// 
			// btPlus
			// 
			this.btPlus.BackColor = System.Drawing.Color.Transparent;
			this.btPlus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btPlus.BackgroundImage")));
			this.btPlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btPlus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btPlus.Location = new System.Drawing.Point(0, 27);
			this.btPlus.Name = "btPlus";
			this.btPlus.Size = new System.Drawing.Size(66, 62);
			this.btPlus.TabIndex = 31;
			this.btPlus.UseVisualStyleBackColor = false;
			this.btPlus.Click += new System.EventHandler(this.BtPlusClick);
			// 
			// pBottom
			// 
			this.pBottom.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.pBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pBottom.Location = new System.Drawing.Point(0, 534);
			this.pBottom.Name = "pBottom";
			this.pBottom.Size = new System.Drawing.Size(1025, 50);
			this.pBottom.TabIndex = 32;
			// 
			// flpMiddle
			// 
			this.flpMiddle.AutoScroll = true;
			this.flpMiddle.BackColor = System.Drawing.Color.White;
			this.flpMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flpMiddle.Location = new System.Drawing.Point(0, 89);
			this.flpMiddle.Name = "flpMiddle";
			this.flpMiddle.Size = new System.Drawing.Size(1025, 445);
			this.flpMiddle.TabIndex = 33;
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(235, 6);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1025, 584);
			this.Controls.Add(this.flpMiddle);
			this.Controls.Add(this.pBottom);
			this.Controls.Add(this.btPlus);
			this.Controls.Add(this.imgHeader);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Serial Devices (MK2 protocol)";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgHeader)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem msiShowFrames;
		private System.Windows.Forms.FlowLayoutPanel flpMiddle;
		private System.Windows.Forms.Panel pBottom;
		private System.Windows.Forms.Button btPlus;
		private System.Windows.Forms.PictureBox imgHeader;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem msiShowDebug;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}
