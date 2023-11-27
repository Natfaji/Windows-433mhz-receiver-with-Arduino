namespace WindowsFormsApp1
{
	partial class SelectReceiver
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
			this.btnSave = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtPortName = new System.Windows.Forms.ComboBox();
			this.gbConnection = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtBaudRate = new System.Windows.Forms.ComboBox();
			this.gbConnection.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(19, 125);
			this.btnSave.Margin = new System.Windows.Forms.Padding(10);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(215, 23);
			this.btnSave.TabIndex = 4;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Port Name";
			// 
			// txtPortName
			// 
			this.txtPortName.FormattingEnabled = true;
			this.txtPortName.Location = new System.Drawing.Point(78, 19);
			this.txtPortName.Name = "txtPortName";
			this.txtPortName.Size = new System.Drawing.Size(131, 21);
			this.txtPortName.TabIndex = 3;
			this.txtPortName.DropDown += new System.EventHandler(this.txtportname_DropDown);
			// 
			// gbConnection
			// 
			this.gbConnection.AutoSize = true;
			this.gbConnection.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.gbConnection.Controls.Add(this.label2);
			this.gbConnection.Controls.Add(this.txtBaudRate);
			this.gbConnection.Controls.Add(this.label1);
			this.gbConnection.Controls.Add(this.txtPortName);
			this.gbConnection.Location = new System.Drawing.Point(19, 19);
			this.gbConnection.Margin = new System.Windows.Forms.Padding(10);
			this.gbConnection.Name = "gbConnection";
			this.gbConnection.Size = new System.Drawing.Size(215, 86);
			this.gbConnection.TabIndex = 5;
			this.gbConnection.TabStop = false;
			this.gbConnection.Text = "Connection";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Baud Rate";
			// 
			// txtBaudRate
			// 
			this.txtBaudRate.FormattingEnabled = true;
			this.txtBaudRate.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "31250",
            "38400",
            "57600",
            "115200"});
			this.txtBaudRate.Location = new System.Drawing.Point(78, 46);
			this.txtBaudRate.Name = "txtBaudRate";
			this.txtBaudRate.Size = new System.Drawing.Size(131, 21);
			this.txtBaudRate.TabIndex = 5;
			// 
			// SelectReceiver
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(253, 167);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.gbConnection);
			this.Name = "SelectReceiver";
			this.Text = "SelectReceiver";
			this.gbConnection.ResumeLayout(false);
			this.gbConnection.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox txtPortName;
		private System.Windows.Forms.GroupBox gbConnection;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox txtBaudRate;
	}
}