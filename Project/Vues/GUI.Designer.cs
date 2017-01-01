/*
 * Created by SharpDevelop.
 * User: C357555
 * Date: 05/10/2011
 * Time: 14:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Assistant
{
	partial class GUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.imageListManager = new System.Windows.Forms.ImageList(this.components);
            this.imageListManager32 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // imageListManager
            // 
            this.imageListManager.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListManager.ImageStream")));
            this.imageListManager.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListManager.Images.SetKeyName(0, "addcolumn");
            this.imageListManager.Images.SetKeyName(1, "rmcolumn");
            this.imageListManager.Images.SetKeyName(2, "addrow");
            this.imageListManager.Images.SetKeyName(3, "rmrow");
            this.imageListManager.Images.SetKeyName(4, "SwitchModeTb");
            this.imageListManager.Images.SetKeyName(5, "SwitchModeTx");
            this.imageListManager.Images.SetKeyName(6, "ChangeCarac");
            // 
            // imageListManager32
            // 
            this.imageListManager32.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListManager32.ImageStream")));
            this.imageListManager32.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListManager32.Images.SetKeyName(0, "rmrow");
            this.imageListManager32.Images.SetKeyName(1, "addrow");
            this.imageListManager32.Images.SetKeyName(2, "rmcolumn");
            this.imageListManager32.Images.SetKeyName(3, "addcolumn");
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Name = "GUI";
            this.Text = "GUI";
            this.ResumeLayout(false);

		}
		public System.Windows.Forms.ImageList imageListManager;
        public System.Windows.Forms.ImageList imageListManager32;
	}
}
