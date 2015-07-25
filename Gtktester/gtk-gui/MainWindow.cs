
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;
	
	private global::Gtk.Action LunaLuaModuleManagerAction;
	
	private global::Gtk.Action dialogInfoAction;
	
	private global::Gtk.Action preferencesAction;
	
	private global::Gtk.Action quitAction;
	
	private global::Gtk.VBox vbox1;
	
	private global::Gtk.MenuBar menubar1;
	
	private global::Gtk.HPaned hpaned2;
	
	private global::Gtk.ScrolledWindow GtkScrolledWindow;
	
	private global::Gtk.TreeView treeview1;
	
	private global::Gtktester.InformationView informationview1;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager ();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
		this.LunaLuaModuleManagerAction = new global::Gtk.Action ("LunaLuaModuleManagerAction", global::Mono.Unix.Catalog.GetString ("LunaLua Module Manager"), null, null);
		this.LunaLuaModuleManagerAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("LunaLua Module Manager");
		w1.Add (this.LunaLuaModuleManagerAction, null);
		this.dialogInfoAction = new global::Gtk.Action ("dialogInfoAction", global::Mono.Unix.Catalog.GetString ("About"), null, "gtk-dialog-info");
		this.dialogInfoAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("About");
		w1.Add (this.dialogInfoAction, null);
		this.preferencesAction = new global::Gtk.Action ("preferencesAction", global::Mono.Unix.Catalog.GetString ("Settings"), null, "gtk-preferences");
		this.preferencesAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Settings");
		w1.Add (this.preferencesAction, null);
		this.quitAction = new global::Gtk.Action ("quitAction", global::Mono.Unix.Catalog.GetString ("_Close"), null, "gtk-quit");
		this.quitAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("_Close");
		w1.Add (this.quitAction, null);
		this.UIManager.InsertActionGroup (w1, 0);
		this.AddAccelGroup (this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("Lua Module Manager - v0.0.0.0");
		this.Icon = global::Gdk.Pixbuf.LoadFromResource ("Gtktester.Icons.PNG.32.png");
		this.WindowPosition = ((global::Gtk.WindowPosition)(1));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString (@"<ui><menubar name='menubar1'><menu name='LunaLuaModuleManagerAction' action='LunaLuaModuleManagerAction'><menuitem name='dialogInfoAction' action='dialogInfoAction'/><menuitem name='preferencesAction' action='preferencesAction'/><menuitem name='quitAction' action='quitAction'/></menu></menubar></ui>");
		this.menubar1 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/menubar1")));
		this.menubar1.Name = "menubar1";
		this.vbox1.Add (this.menubar1);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.menubar1]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hpaned2 = new global::Gtk.HPaned ();
		this.hpaned2.CanFocus = true;
		this.hpaned2.Name = "hpaned2";
		this.hpaned2.Position = 159;
		// Container child hpaned2.Gtk.Paned+PanedChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow.WidthRequest = 250;
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.treeview1 = new global::Gtk.TreeView ();
		this.treeview1.WidthRequest = 250;
		this.treeview1.CanFocus = true;
		this.treeview1.Name = "treeview1";
		this.GtkScrolledWindow.Add (this.treeview1);
		this.hpaned2.Add (this.GtkScrolledWindow);
		global::Gtk.Paned.PanedChild w4 = ((global::Gtk.Paned.PanedChild)(this.hpaned2 [this.GtkScrolledWindow]));
		w4.Resize = false;
		// Container child hpaned2.Gtk.Paned+PanedChild
		this.informationview1 = new global::Gtktester.InformationView ();
		this.informationview1.Events = ((global::Gdk.EventMask)(256));
		this.informationview1.Name = "informationview1";
		this.hpaned2.Add (this.informationview1);
		this.vbox1.Add (this.hpaned2);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hpaned2]));
		w6.Position = 1;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 717;
		this.DefaultHeight = 427;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.dialogInfoAction.Activated += new global::System.EventHandler (this.OnAbout);
		this.preferencesAction.Activated += new global::System.EventHandler (this.OnPreferencesActionActivated);
		this.quitAction.Activated += new global::System.EventHandler (this.OnClosed);
		this.treeview1.CursorChanged += new global::System.EventHandler (this.treeview_SelectionChanged);
	}
}
