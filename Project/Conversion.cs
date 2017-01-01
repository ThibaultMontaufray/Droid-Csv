using Droid_csv_files;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Assistant
{
	public partial class Conversion : Form
	{
		#region Attribute
		private Interface_csv icsv;
		#endregion
		
		#region Constructor
		public Conversion(Interface_csv the_icsv)
		{
			icsv = the_icsv;
			InitializeComponent();
			InitSepVal();
			this.ShowDialog();
		}
		#endregion
		
		#region Methods
		private void InitSepVal()
		{
			switch (icsv.SeparationChar) 
			{
				case ';' : radioButtonPV.Checked = true; break;
				case ',' :  radioButtonV.Checked = true; break;
				case '\t' : radioButtonTab.Checked = true; break;
				case ' ' :  radioButtonSpace.Checked = true; break;
				default : radioButtonOther.Checked = true; textBoxOther.Text = icsv.SeparationChar.ToString(); break;
			}
		}
		#endregion
		
		#region Event
		private void ButtonCancelClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		private void ButtonValidationClick(object sender, EventArgs e)
		{
			if (this.radioButtonPV.Checked)	icsv.SeparationChar = ';';
			if (this.radioButtonV.Checked)	icsv.SeparationChar = ',';
			if (this.radioButtonTab.Checked)	icsv.SeparationChar = '\t';
			if (this.radioButtonSpace.Checked)	icsv.SeparationChar = ' ';
			if (this.radioButtonOther.Checked)	icsv.SeparationChar = char.Parse(this.textBoxOther.Text);
			
			this.Close();
		}
		#endregion
		
	}
}
