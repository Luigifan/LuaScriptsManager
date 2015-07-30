
// This file has been generated by the GUI designer. Do not modify.
namespace Gtktester
{
	public partial class SettingsUI
	{
		private global::Gtk.Notebook notebook1;
		
		private global::Gtk.VBox vbox2;
		
		private global::Gtk.HBox hbox1;
		
		private global::Gtk.Label label3;
		
		private global::Gtk.Entry lunaLuaDirEntry;
		
		private global::Gtk.Button button41;
		
		private global::Gtk.Label lblLunaLuaVersion;
		
		private global::Gtk.HBox hbox2;
		
		private global::Gtk.Label label4;
		
		private global::Gtk.Entry databaseLocationEntry;
		
		private global::Gtk.HBox hbox3;
		
		private global::Gtk.CheckButton startAppMaximizedCheck;
		
		private global::Gtk.CheckButton enableSilentBugReporting;
		
		private global::Gtk.Button resetDatabaseBtn;
		
		private global::Gtk.Button button21;
		
		private global::Gtk.Label label1;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Gtktester.SettingsUI
			this.Name = "Gtktester.SettingsUI";
			this.Title = "LunaLua Module Manager - Settings";
			this.Icon = global::Gdk.Pixbuf.LoadFromResource ("Gtktester.Icons.PNG.32.png");
			this.TypeHint = ((global::Gdk.WindowTypeHint)(1));
			this.WindowPosition = ((global::Gtk.WindowPosition)(1));
			this.Modal = true;
			this.Resizable = false;
			this.AllowGrow = false;
			// Container child Gtktester.SettingsUI.Gtk.Container+ContainerChild
			this.notebook1 = new global::Gtk.Notebook ();
			this.notebook1.CanFocus = true;
			this.notebook1.Name = "notebook1";
			this.notebook1.CurrentPage = 0;
			this.notebook1.BorderWidth = ((uint)(6));
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			this.vbox2.BorderWidth = ((uint)(3));
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label ();
			this.label3.HeightRequest = 70;
			this.label3.Name = "label3";
			this.label3.LabelProp = "LunaLua Directory:";
			this.hbox1.Add (this.label3);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.label3]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.lunaLuaDirEntry = new global::Gtk.Entry ();
			this.lunaLuaDirEntry.WidthRequest = 450;
			this.lunaLuaDirEntry.CanFocus = true;
			this.lunaLuaDirEntry.Name = "lunaLuaDirEntry";
			this.lunaLuaDirEntry.IsEditable = true;
			this.lunaLuaDirEntry.InvisibleChar = '●';
			this.hbox1.Add (this.lunaLuaDirEntry);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.lunaLuaDirEntry]));
			w2.Position = 1;
			// Container child hbox1.Gtk.Box+BoxChild
			this.button41 = new global::Gtk.Button ();
			this.button41.CanFocus = true;
			this.button41.Name = "button41";
			this.button41.UseUnderline = true;
			this.button41.Label = "Browse";
			global::Gtk.Image w3 = new global::Gtk.Image ();
			w3.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-directory", global::Gtk.IconSize.Menu);
			this.button41.Image = w3;
			this.hbox1.Add (this.button41);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.button41]));
			w4.Position = 2;
			w4.Expand = false;
			w4.Fill = false;
			this.vbox2.Add (this.hbox1);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox1]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.lblLunaLuaVersion = new global::Gtk.Label ();
			this.lblLunaLuaVersion.Name = "lblLunaLuaVersion";
			this.lblLunaLuaVersion.LabelProp = "LunaLua Version: ";
			this.vbox2.Add (this.lblLunaLuaVersion);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.lblLunaLuaVersion]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label4 = new global::Gtk.Label ();
			this.label4.HeightRequest = 91;
			this.label4.Name = "label4";
			this.label4.LabelProp = "Database Location:";
			this.hbox2.Add (this.label4);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.label4]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.databaseLocationEntry = new global::Gtk.Entry ();
			this.databaseLocationEntry.WidthRequest = 450;
			this.databaseLocationEntry.CanFocus = true;
			this.databaseLocationEntry.Name = "databaseLocationEntry";
			this.databaseLocationEntry.IsEditable = true;
			this.databaseLocationEntry.InvisibleChar = '●';
			this.hbox2.Add (this.databaseLocationEntry);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.databaseLocationEntry]));
			w8.Position = 1;
			this.vbox2.Add (this.hbox2);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox2]));
			w9.Position = 2;
			w9.Expand = false;
			w9.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.startAppMaximizedCheck = new global::Gtk.CheckButton ();
			this.startAppMaximizedCheck.CanFocus = true;
			this.startAppMaximizedCheck.Name = "startAppMaximizedCheck";
			this.startAppMaximizedCheck.Label = "Start Application Maximized";
			this.startAppMaximizedCheck.DrawIndicator = true;
			this.startAppMaximizedCheck.UseUnderline = true;
			this.hbox3.Add (this.startAppMaximizedCheck);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.startAppMaximizedCheck]));
			w10.Position = 0;
			// Container child hbox3.Gtk.Box+BoxChild
			this.enableSilentBugReporting = new global::Gtk.CheckButton ();
			this.enableSilentBugReporting.TooltipMarkup = @"On error, the LunaLua Module Manager will automatically collect and send data to our servers at
mrmiketheripper.x10.mx.

The collected data includes
-Mono version
-Running on Mono/Compiled on Mono
-OS name/version
-64 bit

In addition, a stack trace and error message will be sent. This is done automatically and silently if this option is enabled.";
			this.enableSilentBugReporting.CanFocus = true;
			this.enableSilentBugReporting.Name = "enableSilentBugReporting";
			this.enableSilentBugReporting.Label = "Enable Silent Bug Reporting";
			this.enableSilentBugReporting.DrawIndicator = true;
			this.enableSilentBugReporting.UseUnderline = true;
			this.hbox3.Add (this.enableSilentBugReporting);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.enableSilentBugReporting]));
			w11.Position = 1;
			// Container child hbox3.Gtk.Box+BoxChild
			this.resetDatabaseBtn = new global::Gtk.Button ();
			this.resetDatabaseBtn.CanFocus = true;
			this.resetDatabaseBtn.Name = "resetDatabaseBtn";
			this.resetDatabaseBtn.UseUnderline = true;
			this.resetDatabaseBtn.Label = "Reset Database";
			global::Gtk.Image w12 = new global::Gtk.Image ();
			w12.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-undo", global::Gtk.IconSize.Menu);
			this.resetDatabaseBtn.Image = w12;
			this.hbox3.Add (this.resetDatabaseBtn);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.resetDatabaseBtn]));
			w13.Position = 2;
			w13.Expand = false;
			w13.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.button21 = new global::Gtk.Button ();
			this.button21.CanFocus = true;
			this.button21.Name = "button21";
			this.button21.UseUnderline = true;
			this.button21.Label = "Save Settings";
			global::Gtk.Image w14 = new global::Gtk.Image ();
			w14.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-save", global::Gtk.IconSize.Menu);
			this.button21.Image = w14;
			this.hbox3.Add (this.button21);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.button21]));
			w15.Position = 3;
			w15.Expand = false;
			w15.Fill = false;
			this.vbox2.Add (this.hbox3);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox3]));
			w16.Position = 3;
			w16.Expand = false;
			w16.Fill = false;
			this.notebook1.Add (this.vbox2);
			// Notebook tab
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = "Settings";
			this.notebook1.SetTabLabel (this.vbox2, this.label1);
			this.label1.ShowAll ();
			this.Add (this.notebook1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 646;
			this.DefaultHeight = 318;
			this.Show ();
			this.lunaLuaDirEntry.Changed += new global::System.EventHandler (this.OnLunaLuaDirEntryChanged);
			this.button41.Clicked += new global::System.EventHandler (this.OnButton41Clicked);
			this.resetDatabaseBtn.Clicked += new global::System.EventHandler (this.OnResetDatabaseBtnClicked);
			this.button21.Clicked += new global::System.EventHandler (this.OnButton21Clicked);
		}
	}
}
