/*
 * User: Thibault MONTAUFRAY
 * Date: 24/01/2013
 * Time: 12:10
 */
namespace Assistant
{
	partial class Conversion
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
			this.buttonValidation = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.labelInformation = new System.Windows.Forms.Label();
			this.textBoxOther = new System.Windows.Forms.TextBox();
			this.radioButtonPV = new System.Windows.Forms.RadioButton();
			this.radioButtonV = new System.Windows.Forms.RadioButton();
			this.radioButtonOther = new System.Windows.Forms.RadioButton();
			this.radioButtonTab = new System.Windows.Forms.RadioButton();
			this.radioButtonSpace = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// buttonValidation
			// 
			this.buttonValidation.Location = new System.Drawing.Point(146, 131);
			this.buttonValidation.Name = "buttonValidation";
			this.buttonValidation.Size = new System.Drawing.Size(75, 23);
			this.buttonValidation.TabIndex = 1;
			this.buttonValidation.Text = "OK";
			this.buttonValidation.UseVisualStyleBackColor = true;
			this.buttonValidation.Click += new System.EventHandler(this.ButtonValidationClick);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(65, 131);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 2;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.ButtonCancelClick);
			// 
			// labelInformation
			// 
			this.labelInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelInformation.Location = new System.Drawing.Point(13, 9);
			this.labelInformation.Name = "labelInformation";
			this.labelInformation.Size = new System.Drawing.Size(210, 32);
			this.labelInformation.TabIndex = 3;
			this.labelInformation.Text = "Choisissez le caractère de séparation :";
			// 
			// textBoxOther
			// 
			this.textBoxOther.Location = new System.Drawing.Point(106, 105);
			this.textBoxOther.Name = "textBoxOther";
			this.textBoxOther.Size = new System.Drawing.Size(116, 20);
			this.textBoxOther.TabIndex = 9;
			// 
			// radioButtonPV
			// 
			this.radioButtonPV.Location = new System.Drawing.Point(13, 46);
			this.radioButtonPV.Name = "radioButtonPV";
			this.radioButtonPV.Size = new System.Drawing.Size(90, 24);
			this.radioButtonPV.TabIndex = 10;
			this.radioButtonPV.TabStop = true;
			this.radioButtonPV.Text = "Point-Virgule";
			this.radioButtonPV.UseVisualStyleBackColor = true;
			// 
			// radioButtonV
			// 
			this.radioButtonV.Location = new System.Drawing.Point(13, 73);
			this.radioButtonV.Name = "radioButtonV";
			this.radioButtonV.Size = new System.Drawing.Size(90, 24);
			this.radioButtonV.TabIndex = 11;
			this.radioButtonV.TabStop = true;
			this.radioButtonV.Text = "Virgule";
			this.radioButtonV.UseVisualStyleBackColor = true;
			// 
			// radioButtonOther
			// 
			this.radioButtonOther.Location = new System.Drawing.Point(13, 101);
			this.radioButtonOther.Name = "radioButtonOther";
			this.radioButtonOther.Size = new System.Drawing.Size(90, 24);
			this.radioButtonOther.TabIndex = 12;
			this.radioButtonOther.TabStop = true;
			this.radioButtonOther.Text = "Autre";
			this.radioButtonOther.UseVisualStyleBackColor = true;
			// 
			// radioButtonTab
			// 
			this.radioButtonTab.Location = new System.Drawing.Point(109, 46);
			this.radioButtonTab.Name = "radioButtonTab";
			this.radioButtonTab.Size = new System.Drawing.Size(90, 24);
			this.radioButtonTab.TabIndex = 13;
			this.radioButtonTab.TabStop = true;
			this.radioButtonTab.Text = "Tabulation";
			this.radioButtonTab.UseVisualStyleBackColor = true;
			// 
			// radioButtonSpace
			// 
			this.radioButtonSpace.Location = new System.Drawing.Point(109, 73);
			this.radioButtonSpace.Name = "radioButtonSpace";
			this.radioButtonSpace.Size = new System.Drawing.Size(90, 24);
			this.radioButtonSpace.TabIndex = 14;
			this.radioButtonSpace.TabStop = true;
			this.radioButtonSpace.Text = "Espace";
			this.radioButtonSpace.UseVisualStyleBackColor = true;
			// 
			// Conversion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(233, 161);
			this.Controls.Add(this.radioButtonSpace);
			this.Controls.Add(this.radioButtonTab);
			this.Controls.Add(this.radioButtonOther);
			this.Controls.Add(this.radioButtonV);
			this.Controls.Add(this.radioButtonPV);
			this.Controls.Add(this.textBoxOther);
			this.Controls.Add(this.labelInformation);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonValidation);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Conversion";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Conversion";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.RadioButton radioButtonTab;
		private System.Windows.Forms.RadioButton radioButtonSpace;
		private System.Windows.Forms.RadioButton radioButtonOther;
		private System.Windows.Forms.RadioButton radioButtonV;
		private System.Windows.Forms.RadioButton radioButtonPV;
		private System.Windows.Forms.TextBox textBoxOther;
		private System.Windows.Forms.Label labelInformation;
		private System.Windows.Forms.Button buttonValidation;
	}
}
