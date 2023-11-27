namespace WindowsFormsApp1
{
	partial class AddNewItem
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
			this.btnAddNewState = new System.Windows.Forms.Button();
			this.lblDeviceName = new System.Windows.Forms.Label();
			this.flpStates = new System.Windows.Forms.FlowLayoutPanel();
			this.btnSave = new System.Windows.Forms.Button();
			this.txtDeviceName = new System.Windows.Forms.TextBox();
			this.txtDeviceType = new System.Windows.Forms.TextBox();
			this.lblDeviceType = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnAddNewState
			// 
			this.btnAddNewState.Location = new System.Drawing.Point(212, 478);
			this.btnAddNewState.Name = "btnAddNewState";
			this.btnAddNewState.Size = new System.Drawing.Size(110, 23);
			this.btnAddNewState.TabIndex = 0;
			this.btnAddNewState.Text = "Add new state";
			this.btnAddNewState.UseVisualStyleBackColor = true;
			this.btnAddNewState.Click += new System.EventHandler(this.btnAddNewState_Click);
			// 
			// lblDeviceName
			// 
			this.lblDeviceName.AutoSize = true;
			this.lblDeviceName.Location = new System.Drawing.Point(12, 9);
			this.lblDeviceName.Name = "lblDeviceName";
			this.lblDeviceName.Size = new System.Drawing.Size(70, 13);
			this.lblDeviceName.TabIndex = 2;
			this.lblDeviceName.Text = "Device name";
			// 
			// flpStates
			// 
			this.flpStates.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flpStates.Location = new System.Drawing.Point(12, 32);
			this.flpStates.Name = "flpStates";
			this.flpStates.Padding = new System.Windows.Forms.Padding(5);
			this.flpStates.Size = new System.Drawing.Size(391, 440);
			this.flpStates.TabIndex = 3;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(328, 478);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 4;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// txtDeviceName
			// 
			this.txtDeviceName.Location = new System.Drawing.Point(88, 6);
			this.txtDeviceName.Name = "txtDeviceName";
			this.txtDeviceName.Size = new System.Drawing.Size(100, 20);
			this.txtDeviceName.TabIndex = 5;
			// 
			// txtDeviceType
			// 
			this.txtDeviceType.Location = new System.Drawing.Point(264, 6);
			this.txtDeviceType.Name = "txtDeviceType";
			this.txtDeviceType.Size = new System.Drawing.Size(100, 20);
			this.txtDeviceType.TabIndex = 7;
			// 
			// lblDeviceType
			// 
			this.lblDeviceType.AutoSize = true;
			this.lblDeviceType.Location = new System.Drawing.Point(194, 9);
			this.lblDeviceType.Name = "lblDeviceType";
			this.lblDeviceType.Size = new System.Drawing.Size(64, 13);
			this.lblDeviceType.TabIndex = 6;
			this.lblDeviceType.Text = "Device type";
			// 
			// AddNewItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(415, 513);
			this.Controls.Add(this.txtDeviceType);
			this.Controls.Add(this.lblDeviceType);
			this.Controls.Add(this.txtDeviceName);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.flpStates);
			this.Controls.Add(this.lblDeviceName);
			this.Controls.Add(this.btnAddNewState);
			this.Name = "AddNewItem";
			this.Text = "AddNewItem";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnAddNewState;
		private System.Windows.Forms.Label lblDeviceName;
		private System.Windows.Forms.FlowLayoutPanel flpStates;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.TextBox txtDeviceName;
		private System.Windows.Forms.TextBox txtDeviceType;
		private System.Windows.Forms.Label lblDeviceType;
	}
}