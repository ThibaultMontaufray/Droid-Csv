// Log code 15

using Tools4Libraries;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Assistant
{
	public class PanelGridView : Panel
	{
		#region Attribute
		private ToolStripMenuCSV tsm;
		private DataGridView dgv;
		private string fileText;
		private char carac;
		#endregion
		
		#region Properties
		public string FileText
		{
			get { return fileText; }
			set { fileText = value; }
		}
		
		public char Carac
		{
			get { return carac; }
			set { carac = value; }
		}
		#endregion
		
		#region Constructor
		public PanelGridView(ToolStripMenuCSV my_tsm, string val)
		{
			fileText = val;
			tsm = my_tsm;
			dgv = new DataGridView();
			
			buildComponent();
			loadData(val);
		}
		#endregion
			
		#region Methods Public
		public override void Refresh()
		{
			this.Width = tsm.CurrentTabPage.Width;
			this.Height = tsm.CurrentTabPage.Height;
			loadData(fileText);
		}

		public void loadData(string val)
		{
			fileText = val;
			CleanDGV();
			buildTable();
		}
		#endregion

		#region Methods Private
		private void CleanDGV()
		{
			while (dgv.Columns.Count > 0) 
			{
				dgv.Columns.RemoveAt(0);
			}
			dgv.Columns.Add("0", "0");
			dgv.Columns[0].ReadOnly = true;
		}
		
		private void buildTable()
		{
			int indexC = 0;
			int indexR = 0;
			string[] valTab = fileText.Split('\n');
			string[] valCell;
			
			foreach (string s in valTab) 
			{
				valCell = s.Split(carac);
				indexC = 0;
				
				dgv.Rows.Add();
				foreach (string sb  in valCell)
				{
					if (indexC >= dgv.Columns.Count)
					{
						dgv.Columns.Add(indexC.ToString(), indexC.ToString());
						dgv.Columns[indexC].ReadOnly = true;
					}
					dgv.Rows[indexR].Cells[indexC].Value = sb;
					indexC ++;	
				}
				indexR ++;
			}
		}
		
		private void buildComponent()
		{
			this.Dock = DockStyle.Fill;
			this.BackColor = Color.LightGray;
			this.Width = tsm.CurrentTabPage.Width;
			this.Height = tsm.CurrentTabPage.Height;
			this.Paint += new PaintEventHandler(PanelGridView_Paint);
			this.Controls.Add(dgv);
			
			dgv.Location = new System.Drawing.Point(1, 1);
			dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None; 
			dgv.ColumnHeadersVisible = true;
			dgv.RowHeadersVisible = false;
			dgv.AllowUserToResizeColumns = true;
			dgv.AllowUserToResizeRows = true;
			dgv.AllowUserToOrderColumns = false;
			dgv.AllowUserToDeleteRows = false;
			dgv.AllowUserToAddRows = false;
			dgv.SelectionChanged += new EventHandler(dgv_SelectionChanged);
			dgv.Dock = DockStyle.Fill;
		}
		#endregion
		
		#region Event
		private void PanelGridView_Paint(object sender, PaintEventArgs e)
		{
			try
			{
				this.Width = tsm.CurrentTabPage.Width;
				this.Height = tsm.CurrentTabPage.Height;
			} catch (Exception exp1500) {
				Log.write(" [ ERR : 1500 ] Error during the construction of the interface : \n" + exp1500.Message);
			}
		}

		private void dgv_SelectionChanged(object sender, EventArgs e)
		{
			try 
			{
				if (dgv.SelectedCells[0].Value != null && dgv.SelectedCells.Count == 1)
				{
					dgv.SelectedCells[0].Style.SelectionBackColor = Color.DarkGreen;
					dgv.SelectedCells[0].Style.SelectionForeColor = Color.GreenYellow;
					string val = dgv.SelectedCells[0].Value.ToString();
					foreach (DataGridViewRow row in dgv.Rows) 
					{
						for (int i=0 ; i<dgv.Columns.Count-2 ; i++)
						{
							if (row.Cells[i].Value != null)
							{
								if (row.Cells[i].Value.Equals(val))row.Cells[i].Style.BackColor = Color.GreenYellow;
								else row.Cells[i].Style.BackColor = Color.White;
							}
						}
					}
				}				
			} 
			catch (Exception exp1501) 
			{
				Log.write("[ WRN : 1501 ] error in coloration of the hexa table.\n" + exp1501.Message);
			}
		}
		#endregion
	}
}
