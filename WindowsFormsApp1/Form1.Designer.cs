namespace WindowsFormsApp1
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
			this.components = new System.ComponentModel.Container();
			this.lvDevices = new System.Windows.Forms.ListView();
			this.lvName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lvStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lvType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnAddDevice = new System.Windows.Forms.Button();
			this.btnSelectReceiver = new System.Windows.Forms.Button();
			this.lvNotification = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lvContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmiToggleNotifications = new System.Windows.Forms.ToolStripMenuItem();
			this.lvContextMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// lvDevices
			// 
			this.lvDevices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lvDevices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvName,
            this.lvStatus,
            this.lvType,
            this.lvNotification});
			this.lvDevices.ContextMenuStrip = this.lvContextMenuStrip;
			this.lvDevices.HideSelection = false;
			this.lvDevices.Location = new System.Drawing.Point(12, 12);
			this.lvDevices.Name = "lvDevices";
			this.lvDevices.Size = new System.Drawing.Size(776, 548);
			this.lvDevices.TabIndex = 0;
			this.lvDevices.UseCompatibleStateImageBehavior = false;
			this.lvDevices.View = System.Windows.Forms.View.Details;
			// 
			// lvName
			// 
			this.lvName.Text = "Name";
			this.lvName.Width = 200;
			// 
			// lvStatus
			// 
			this.lvStatus.Text = "Status";
			this.lvStatus.Width = 200;
			// 
			// lvType
			// 
			this.lvType.Text = "Type";
			this.lvType.Width = 200;
			// 
			// btnAddDevice
			// 
			this.btnAddDevice.Location = new System.Drawing.Point(617, 566);
			this.btnAddDevice.Name = "btnAddDevice";
			this.btnAddDevice.Size = new System.Drawing.Size(171, 23);
			this.btnAddDevice.TabIndex = 1;
			this.btnAddDevice.Text = "Add";
			this.btnAddDevice.UseVisualStyleBackColor = true;
			this.btnAddDevice.Click += new System.EventHandler(this.btnAddDevice_Click);
			// 
			// btnSelectReceiver
			// 
			this.btnSelectReceiver.Location = new System.Drawing.Point(12, 566);
			this.btnSelectReceiver.Name = "btnSelectReceiver";
			this.btnSelectReceiver.Size = new System.Drawing.Size(105, 23);
			this.btnSelectReceiver.TabIndex = 2;
			this.btnSelectReceiver.Text = "Select receiver";
			this.btnSelectReceiver.UseVisualStyleBackColor = true;
			this.btnSelectReceiver.Click += new System.EventHandler(this.btnSelectReceiver_Click);
			// 
			// lvNotification
			// 
			this.lvNotification.Text = "Notifications";
			this.lvNotification.Width = 130;
			// 
			// lvContextMenuStrip
			// 
			this.lvContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiToggleNotifications});
			this.lvContextMenuStrip.Name = "lvContextMenuStrip";
			this.lvContextMenuStrip.Size = new System.Drawing.Size(181, 26);
			// 
			// tsmiToggleNotifications
			// 
			this.tsmiToggleNotifications.Name = "tsmiToggleNotifications";
			this.tsmiToggleNotifications.Size = new System.Drawing.Size(180, 22);
			this.tsmiToggleNotifications.Text = "Toggle Notifications";
			this.tsmiToggleNotifications.Click += new System.EventHandler(this.tsmiToggleNotifications_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 601);
			this.Controls.Add(this.btnSelectReceiver);
			this.Controls.Add(this.btnAddDevice);
			this.Controls.Add(this.lvDevices);
			this.Name = "Form1";
			this.Text = "Form1";
			this.lvContextMenuStrip.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView lvDevices;
		private System.Windows.Forms.ColumnHeader lvName;
		private System.Windows.Forms.ColumnHeader lvStatus;
		private System.Windows.Forms.ColumnHeader lvType;
		private System.Windows.Forms.Button btnAddDevice;
		private System.Windows.Forms.Button btnSelectReceiver;
		private System.Windows.Forms.ColumnHeader lvNotification;
		private System.Windows.Forms.ContextMenuStrip lvContextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem tsmiToggleNotifications;
	}
}

