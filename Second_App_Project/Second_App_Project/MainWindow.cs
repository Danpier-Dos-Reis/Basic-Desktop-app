using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnButtonEventClicked(object sender, EventArgs e)
    {
        MessageDialog md = new MessageDialog(null,DialogFlags.Modal,MessageType.Info,ButtonsType.Ok, $"KLK Chamo {txt_message.Text}");
        md.Run();
        md.Destroy();
    }
}
