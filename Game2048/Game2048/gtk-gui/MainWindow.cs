
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;
	
	private global::Gtk.Action _2048Action;
	
	private global::Gtk.Action NewGameAction;
	
	private global::Gtk.VBox vbox;
	
	private global::Gtk.MenuBar menubar;
	
	private global::Gtk.Table table;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager ();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
		this._2048Action = new global::Gtk.Action ("_2048Action", global::Mono.Unix.Catalog.GetString ("2048"), null, null);
		this._2048Action.ShortLabel = global::Mono.Unix.Catalog.GetString ("2048");
		w1.Add (this._2048Action, null);
		this.NewGameAction = new global::Gtk.Action ("NewGameAction", global::Mono.Unix.Catalog.GetString ("New Game"), null, null);
		this.NewGameAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("New Game");
		w1.Add (this.NewGameAction, null);
		this.UIManager.InsertActionGroup (w1, 0);
		this.AddAccelGroup (this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("2048");
		this.Icon = new global::Gdk.Pixbuf (global::System.IO.Path.Combine (global::System.AppDomain.CurrentDomain.BaseDirectory, "./icon.png"));
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox = new global::Gtk.VBox ();
		this.vbox.Name = "vbox";
		this.vbox.Spacing = 6;
		// Container child vbox.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString ("<ui><menubar name='menubar'><menu name='_2048Action' action='_2048Action'><menuitem name='NewGameAction' action='NewGameAction'/></menu></menubar></ui>");
		this.menubar = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/menubar")));
		this.menubar.Name = "menubar";
		this.vbox.Add (this.menubar);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox [this.menubar]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox.Gtk.Box+BoxChild
		this.table = new global::Gtk.Table (((uint)(4)), ((uint)(4)), false);
		this.table.Name = "table";
		this.table.RowSpacing = ((uint)(6));
		this.table.ColumnSpacing = ((uint)(6));
		this.vbox.Add (this.table);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox [this.table]));
		w3.Position = 1;
		this.Add (this.vbox);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 400;
		this.DefaultHeight = 300;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
	}
}
