namespace WindowsFormsApp1
{
	partial class ucAddStatus
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
			this.btnDetectCode = new System.Windows.Forms.Button();
			this.txtState = new System.Windows.Forms.TextBox();
			this.txtCode = new System.Windows.Forms.TextBox();
			this.lblCode = new System.Windows.Forms.Label();
			this.lblState = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnDetectCode
			// 
			this.btnDetectCode.Location = new System.Drawing.Point(215, 21);
			this.btnDetectCode.Name = "btnDetectCode";
			this.btnDetectCode.Size = new System.Drawing.Size(151, 23);
			this.btnDetectCode.TabIndex = 0;
			this.btnDetectCode.Text = "Detect Code";
			this.btnDetectCode.UseVisualStyleBackColor = true;
			this.btnDetectCode.Click += new System.EventHandler(this.btnDetectCode_Click);
			// 
			// txtState
			// 
			this.txtState.Location = new System.Drawing.Point(3, 22);
			this.txtState.Name = "txtState";
			this.txtState.Size = new System.Drawing.Size(100, 20);
			this.txtState.TabIndex = 1;
			// 
			// txtCode
			// 
			this.txtCode.Location = new System.Drawing.Point(109, 22);
			this.txtCode.Name = "txtCode";
			this.txtCode.Size = new System.Drawing.Size(100, 20);
			this.txtCode.TabIndex = 2;
			// 
			// lblCode
			// 
			this.lblCode.AutoSize = true;
			this.lblCode.Location = new System.Drawing.Point(109, 3);
			this.lblCode.Margin = new System.Windows.Forms.Padding(3);
			this.lblCode.Name = "lblCode";
			this.lblCode.Size = new System.Drawing.Size(32, 13);
			this.lblCode.TabIndex = 5;
			this.lblCode.Text = "Code";
			// 
			// lblState
			// 
			this.lblState.AutoSize = true;
			this.lblState.Location = new System.Drawing.Point(3, 3);
			this.lblState.Margin = new System.Windows.Forms.Padding(3);
			this.lblState.Name = "lblState";
			this.lblState.Size = new System.Drawing.Size(32, 13);
			this.lblState.TabIndex = 7;
			this.lblState.Text = "State";
			// 
			// ucAddStatus
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lblState);
			this.Controls.Add(this.lblCode);
			this.Controls.Add(this.txtCode);
			this.Controls.Add(this.txtState);
			this.Controls.Add(this.btnDetectCode);
			this.Name = "ucAddStatus";
			this.Size = new System.Drawing.Size(371, 49);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnDetectCode;
		private System.Windows.Forms.TextBox txtState;
		private System.Windows.Forms.TextBox txtCode;
		private System.Windows.Forms.Label lblCode;
		private System.Windows.Forms.Label lblState;
	}
}
