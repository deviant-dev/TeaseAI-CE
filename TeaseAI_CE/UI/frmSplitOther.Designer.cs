﻿namespace TeaseAI_CE.UI
{
	partial class frmSplitOther
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
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.Glitter = new TeaseAI_CE.UI.Glitter();
			this.Chat = new TeaseAI_CE.UI.Chat();
			this.header1 = new TeaseAI_CE.UI.Header();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 24);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.Glitter);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.Chat);
			this.splitContainer1.Size = new System.Drawing.Size(753, 316);
			this.splitContainer1.SplitterDistance = 251;
			this.splitContainer1.TabIndex = 0;
			// 
			// Glitter
			// 
			this.Glitter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Glitter.Location = new System.Drawing.Point(0, 0);
			this.Glitter.Name = "Glitter";
			this.Glitter.Size = new System.Drawing.Size(251, 316);
			this.Glitter.TabIndex = 1;
			// 
			// Chat
			// 
			this.Chat.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Chat.Location = new System.Drawing.Point(0, 0);
			this.Chat.Name = "Chat";
			this.Chat.Size = new System.Drawing.Size(498, 316);
			this.Chat.TabIndex = 0;
			// 
			// header1
			// 
			this.header1.AutoSize = true;
			this.header1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.header1.Dock = System.Windows.Forms.DockStyle.Top;
			this.header1.Location = new System.Drawing.Point(0, 0);
			this.header1.MinimumSize = new System.Drawing.Size(512, 24);
			this.header1.Name = "header1";
			this.header1.Size = new System.Drawing.Size(753, 24);
			this.header1.TabIndex = 2;
			// 
			// frmSplitOther
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(753, 340);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.header1);
			this.Name = "frmSplitOther";
			this.Text = "TeaseAI CE";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		internal Glitter Glitter;
		internal Chat Chat;
		private Header header1;
	}
}