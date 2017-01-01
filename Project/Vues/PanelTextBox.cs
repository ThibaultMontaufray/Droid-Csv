using System;
using System.Drawing;
using System.Windows.Forms;

namespace Assistant
{
	public class PanelTextBox : System.Windows.Forms.Panel
	{
		#region Attribute
		private ToolStripMenuCSV tsm;
		private TextBox tb;
		private string fileText;
		#endregion
		
		#region Properties
		public string FileText
		{
			get { return fileText; }
			set { fileText = value; }
		}
		#endregion
		
		#region Constructor
		public PanelTextBox(ToolStripMenuCSV my_tsm, string data_to_load)
		{
			fileText = data_to_load;
			tsm = my_tsm;
			buildComponent();
		}
		#endregion
				
		#region Methods	Public
		public override void Refresh()
		{
			this.Width = tsm.CurrentTabPage.Width;
			this.Height = tsm.CurrentTabPage.Height;
			loadData();
		}
		
		public void loadData()
		{
			tb.Text = fileText;	
		}
		#endregion
		
		#region Methods Private
		private void buildComponent()
		{
			tb = new TextBox();
			tb.Multiline = true;
			tb.Dock = DockStyle.Fill;
			
			this.Dock = DockStyle.Fill;
			this.BackColor = Color.LightGray;
			this.Width = tsm.CurrentTabPage.Width;
			this.Height = tsm.CurrentTabPage.Height;
			this.Controls.Add(tb);
		}
		#endregion
	}
}
