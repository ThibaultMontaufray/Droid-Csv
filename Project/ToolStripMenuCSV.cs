/*
 * Created by SharpDevelop.
 * User: C357555
 * Date: 05/10/2011
 * Time: 14:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Diagnostics.SymbolStore;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Threading;
using System.Collections.Generic;
using Tools4Libraries;

namespace Assistant
{
	public class ToolStripMenuCSV : RibbonTab
	{
		#region Attributes
		private GUI gui;
        private Panel _currentTabPage;
        private RibbonButton rb_addrow;
        private RibbonButton rb_addcolumn;
        private RibbonButton rb_rmrow;
        private RibbonButton rb_rmcolumn;
        private RibbonButton rb_switchMode;
        private RibbonButton rb_changeCarac;
        private RibbonLabel rb_CaracLabel;
        private RibbonPanel panelTools;
		private bool modeGrid;
		#endregion
		
		#region Properties
		public bool ModeGrid
		{
			get { return modeGrid; }
            set { modeGrid = value; }
		}
		public RibbonLabel RB_CaracLabel
		{
			get { return rb_CaracLabel; }
			set { rb_CaracLabel = value; }
		}
		public RibbonButton RB_ChangeCarac
		{
			get { return rb_changeCarac; }
			set { rb_changeCarac = value; }
		}
		public RibbonButton RB_SwitchMode
		{
			get { return rb_switchMode; }
			set { rb_switchMode = value; }
		}
        public RibbonButton RB_AddRow
		{
			get { return rb_addrow; }
			set { rb_addrow = value; }
		}
		public RibbonButton RB_AddColumn
		{
			get { return rb_addcolumn; }
			set { rb_addcolumn = value; }
		}
        public RibbonButton RB_RmRow
		{
			get { return rb_rmrow; }
			set { rb_rmrow = value; }
		}
        public RibbonButton RB_RmColumn
		{
			get { return rb_rmcolumn; }
			set { rb_rmcolumn = value; }
		}
        public Panel CurrentTabPage
        {
            get { return _currentTabPage; }
            set { _currentTabPage = value; }
        }
        #endregion

        #region Constructor
        public ToolStripMenuCSV(List<string> theList)
		{
			gui = new GUI();

            rb_addrow = new RibbonButton("Add row");
            rb_addrow.Click += new EventHandler(tsb_addrow_Click);
            rb_addrow.Image = gui.imageListManager32.Images[gui.imageListManager32.Images.IndexOfKey("addrow")];

            rb_addcolumn = new RibbonButton("Add column");
            rb_addcolumn.Click += new EventHandler(tsb_addcolumn_Click);
            rb_addcolumn.Image = gui.imageListManager32.Images[gui.imageListManager32.Images.IndexOfKey("addcolumn")];

            rb_rmrow = new RibbonButton("Del row");
            rb_rmrow.Click += new EventHandler(tsb_rmrow_Click);
            rb_rmrow.Image = gui.imageListManager32.Images[gui.imageListManager32.Images.IndexOfKey("rmrow")];

            rb_rmcolumn = new RibbonButton("Del column");
            rb_rmcolumn.Click += new EventHandler(tsb_rmcolumn_Click);
            rb_rmcolumn.Image = gui.imageListManager32.Images[gui.imageListManager32.Images.IndexOfKey("rmcolumn")];

            rb_switchMode = new RibbonButton("Switch mode");
            rb_switchMode.MinSizeMode = RibbonElementSizeMode.DropDown;
            rb_switchMode.Click += new EventHandler(tsb_switchmode_Click);
            rb_switchMode.SmallImage = gui.imageListManager.Images[gui.imageListManager.Images.IndexOfKey("SwitchModeTb")];
			modeGrid = false;

            rb_changeCarac = new RibbonButton("Change carac");
            rb_changeCarac.MinSizeMode = RibbonElementSizeMode.DropDown;
            rb_changeCarac.Click += new EventHandler(tsb_changecarac_Click);
            rb_changeCarac.SmallImage = gui.imageListManager.Images[gui.imageListManager.Images.IndexOfKey("ChangeCarac")];
			
			rb_CaracLabel = new RibbonLabel();
			rb_CaracLabel.Text = "Separation : \";\"";

            panelTools = new System.Windows.Forms.RibbonPanel();
            panelTools.Text = "Table tools";
            panelTools.Items.Add(rb_addcolumn);
            panelTools.Items.Add(rb_addrow);
            panelTools.Items.Add(rb_rmcolumn);
            panelTools.Items.Add(rb_rmrow);
            panelTools.Items.Add(rb_switchMode);
            panelTools.Items.Add(rb_CaracLabel);
            panelTools.Items.Add(rb_changeCarac);
            this.Panels.Add(panelTools);

//			this.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
//			                    	this.ts_addrow,
//			                    	this.ts_rmrow,
//			                    	this.ts_addcolumn,
//			                    	this.ts_rmcolumn,
//			                    	tsp1,
//			                    	this.ts_switchMode,
//			                    	tsp2,
//			                    	this.ts_changeCarac,
//			                    	this.ts_CaracLabel});
//			this.Location = new System.Drawing.Point(320, 0);
//			this.Name = "manager_csv";
			this.Text = "CSV";
			
			initToolScriptMenu();
		}
		#endregion
		
		#region Methods
		private void initToolScriptMenu()
		{
			RB_AddColumn.Enabled = false;
			RB_AddRow.Enabled = false;
			RB_RmColumn.Enabled = false;
			RB_RmRow.Enabled = false;
		}
		
		public void RefreshComponent(List<string> ListComponents)
		{
			// nothing to do for this kind of file
			// everything is allow always
		}
		
		public void Dispose(List<string> theList)
		{
			this.Dispose();
			//theList.Remove("manager_csv_" + CurrentTabPage.Text);
		}
		#endregion
		
		#region Events
		public event EventHandlerAction ActionAppened;
		
		public void tsb_switchmode_Click(object sender, EventArgs e)
		{
			modeGrid = !modeGrid;
			if (modeGrid) rb_switchMode.Image = gui.imageListManager.Images[gui.imageListManager.Images.IndexOfKey("SwitchModeTx")];
			else rb_switchMode.Image = gui.imageListManager.Images[gui.imageListManager.Images.IndexOfKey("SwitchModeTb")];
			
			ToolBarEventArgs action = new ToolBarEventArgs("SwitchMode");
			OnAction(action);
		}
		
		public void tsb_changecarac_Click(object sender, EventArgs e)
		{
			ToolBarEventArgs action = new ToolBarEventArgs("ChangeCarac");
			OnAction(action);
		}
		
		public void tsb_addrow_Click(object sender, EventArgs e)
		{
			ToolBarEventArgs action = new ToolBarEventArgs("AddRow");
			OnAction(action);
		}
		
		public void tsb_rmrow_Click(object sender, EventArgs e)
		{
			ToolBarEventArgs action = new ToolBarEventArgs("RmRow");
			OnAction(action);
		}
		
		public void tsb_addcolumn_Click(object sender, EventArgs e)
		{
			ToolBarEventArgs action = new ToolBarEventArgs("AddColumn");
			OnAction(action);
		}
		
		public void tsb_rmcolumn_Click(object sender, EventArgs e)
		{
			ToolBarEventArgs action = new ToolBarEventArgs("RmColumn");
			OnAction(action);
		}
		
		public void OnAction(EventArgs e)
		{
			if (ActionAppened != null) ActionAppened(this, e);
		}
		#endregion
	}
}
