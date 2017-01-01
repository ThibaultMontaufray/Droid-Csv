// Log code 16
namespace Droid_csv_files
{
    using System;
    using System.IO;
    using System.Windows.Forms;
    using System.Collections.Generic;
    using Tools4Libraries;
    using Assistant;

    /// <summary>
    /// Interface for Tobi Assistant application : take care, some french word here to allow Tobi to speak with natural langage.
    /// </summary>            
    public class Interface_csv : GPInterface
	{
		#region Attributes
		private ToolStripMenuCSV tsm;
		private List<String> listToolStrip;
		private Stream stream;
		private bool openned;
		private string FileText;
		private string displayMode;
		private PanelTextBox panelTB;
		private PanelGridView panelGV;
		private char separationChar;
		#endregion
		
		#region Properties
		public char SeparationChar
		{
			get { return separationChar; }
			set { separationChar = value; }
		}
		public string DisplayMode
		{
			get { return displayMode; }
			set 
			{ 
				displayMode = value;
				LoadDisplay();
			}
		}
		public RibbonTab Tsm
		{
			get { return tsm; }
			set { tsm = value as ToolStripMenuCSV; }
		}
		
		public override bool Openned
		{
			get { return openned; }
		}
		#endregion
		
		#region Constructor
		public Interface_csv(List<String> lts)
		{
			separationChar = ';';
			displayMode = "textbox";
			openned = false;
			listToolStrip = lts;
		}
		#endregion
		
		#region Methods Public
		public override bool Open(object o)
		{
			stream = (Stream) o;
			openned = LoadData();
			return true;
		}
		
		public override void Print()
		{
			
		}
		
		public override void Close()
		{
			try 
			{
				stream.Close();
			}
			catch
			{
				
			}
		}
		
		public override bool Save()
		{
			return false;
		}
		
		public override void ZoomIn()
		{
			
		}
		
		public override void ZoomOut()
		{
			
		}
		
		public override void Copy()
		{
			
		}
		
		public override void Cut()
		{
			
		}
		
		public override void Paste()
		{
			
		}
		
		public override void Resize()
		{
			if (panelTB != null) { panelTB.Refresh(); }
			if (panelGV != null) { panelGV.Refresh(); }
		}
		
		public override void GlobalAction(object sender, EventArgs e)
		{
			ToolBarEventArgs tbea = e as ToolBarEventArgs;
			string action = tbea.EventText;
			switch (action)
			{
				case "ChangeCarac":
					LaunchChangeCarac();
					break;
				case "SwitchMode":
					LaunchSwitchMode();
					break;
				case "AddRow":
					LaunchAddRow();
					break;
				case "RmRow":
					LaunchRmRow();
					break;
				case "AddColunm":
					LaunchAddColunm();
					break;
				case "RmColumn":
					LaunchRmColumn();
					break;
			}
		}
		
		public System.Windows.Forms.RibbonTab BuildToolBar()
		{
			Assistant.ToolStripMenuCSV ts = new Assistant.ToolStripMenuCSV(listToolStrip);
			return ts;
		}
		#endregion
		
		#region Methods Launcher
		private void LaunchChangeCarac()
		{
			Conversion c = new Conversion(this);
            tsm.ModeGrid = true;
            if (panelTB != null) panelTB.Visible = false;
            LoadGridView();
		}
		private void LaunchSwitchMode()
		{
			if (tsm.ModeGrid)
			{
				if (panelTB != null) panelTB.Visible = false;
				LoadGridView();
			}
			else
			{
				if (panelGV != null) panelGV.Visible = false;
				LoadTextBox();
			}
		}
		private void LaunchAddRow()
		{
			
		}
		private void LaunchRmRow()
		{
			
		}
		private void LaunchAddColunm()
		{
			
		}
		private void LaunchRmColumn()
		{
			
		}
		#endregion
		
		#region Methods	private
		private bool LoadData()
		{
			try 
			{
				if (stream != null)
				{
					StreamReader monStreamReader = new StreamReader(stream);
					FileText = "";
					string ligne = monStreamReader.ReadLine();
					
					while (ligne != null)
					{
						FileText += ligne + "\r\n";
						ligne = monStreamReader.ReadLine();
					}
					monStreamReader.Close();
				}
				LoadDisplay();
				return true;
			} 
			catch (Exception exp1400) 
			{
				Log.write("[ ERR : 1400 ] Error when openning file.\n" + exp1400.Message);
				return false;
			}
		}
		private void LoadDisplay()
		{
			switch (displayMode) 
			{
				case "textbox" :
					LoadTextBox();
					break;
				case "gridview" :
					LoadGridView();
					break;
				default :
					Log.write("[ DEB : 1401 ] error when on the choise of the display mode of CSV file");
					break;
			}
		}
		private void LoadTextBox()
		{
			if (panelGV != null) FileText = panelGV.FileText;
			if (panelTB == null)
			{
				panelTB = new PanelTextBox(tsm, FileText);
				tsm.CurrentTabPage.Controls.Add(panelTB);
			}
			panelTB.loadData();
			panelTB.Visible = true;
		}
		private void LoadGridView()
		{
			if (panelTB != null) FileText = panelTB.FileText;
			if(panelGV == null)
			{
				panelGV = new PanelGridView(tsm, FileText);
				tsm.CurrentTabPage.Controls.Add(panelGV);
			}
			panelGV.Carac = separationChar;
			tsm.RB_CaracLabel.Text = "Separation : \"" + separationChar + "\"";
			panelGV.loadData(FileText);
			panelGV.Visible = true;
		}
		#endregion
		
		#region Event
		#endregion
	}
}
