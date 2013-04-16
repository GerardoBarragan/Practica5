using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnSumarClicked (object sender, EventArgs e)
	{ 
		int a = int.Parse(this.texto1.Text);
		int b = int.Parse(this.texto2.Text);
		int res = a+b;
		this.resultado.Text=res.ToString();
	   

	}

	protected void OnRestarClicked (object sender, EventArgs e)
	{
		int a = int.Parse(this.texto1.Text);
		int b = int.Parse(this.texto2.Text);
		int res = a-b;
		this.resultado.Text=res.ToString();




	}

	protected void OnMultiplicarClicked (object sender, EventArgs e)
	{
		int a = int.Parse(this.texto1.Text);
		int b = int.Parse(this.texto2.Text);
		int res = a*b;
		this.resultado.Text=res.ToString();

	}

	protected void OnDividirClicked (object sender, EventArgs e)
	{
		int a = int.Parse(this.texto1.Text);
		int b = int.Parse(this.texto2.Text);
		int res = a/b;
		this.resultado.Text=res.ToString();

	}
}
