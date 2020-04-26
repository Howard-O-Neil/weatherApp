namespace weatherAPP.notepad
{
	partial class note
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.addNote = new System.Windows.Forms.Button();
			this.label = new System.Windows.Forms.Label();
			this.mainPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.SuspendLayout();
			// 
			// addNote
			// 
			this.addNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addNote.Location = new System.Drawing.Point(1196, 12);
			this.addNote.Name = "addNote";
			this.addNote.Size = new System.Drawing.Size(191, 53);
			this.addNote.TabIndex = 13;
			this.addNote.Text = "Add Note";
			this.addNote.UseVisualStyleBackColor = true;
			this.addNote.Click += new System.EventHandler(this.addNote_Click);
			// 
			// label
			// 
			this.label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
			this.label.Dock = System.Windows.Forms.DockStyle.Top;
			this.label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label.Font = new System.Drawing.Font("Elephant", 36F, System.Drawing.FontStyle.Bold);
			this.label.ForeColor = System.Drawing.Color.White;
			this.label.Location = new System.Drawing.Point(0, 0);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(1469, 82);
			this.label.TabIndex = 12;
			this.label.Text = "Notepad\r\n";
			// 
			// mainPanel
			// 
			this.mainPanel.AllowDrop = true;
			this.mainPanel.AutoScroll = true;
			this.mainPanel.BackColor = System.Drawing.Color.White;
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 82);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(1469, 818);
			this.mainPanel.TabIndex = 14;
			// 
			// note
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.mainPanel);
			this.Controls.Add(this.addNote);
			this.Controls.Add(this.label);
			this.Name = "note";
			this.Size = new System.Drawing.Size(1469, 900);
			this.Load += new System.EventHandler(this.note_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button addNote;
		private System.Windows.Forms.Label label;
		private System.Windows.Forms.FlowLayoutPanel mainPanel;
	}
}
