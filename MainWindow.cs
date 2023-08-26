using System;
using Gtk;
using UI = Gtk.Builder.ObjectAttribute;
using System.Diagnostics;
using Appbatroz;
namespace Appbatroz
{
    class MainWindow : Window
    {
     
       [UI] private Button _button1 = null;
      [UI] private Button _sl = null;
      [UI] private Button _bm = null;
      [UI] private Button _search = null;
      [UI] private Button _nb = null;
      [UI] private Button _tutorial = null;
        

        public MainWindow() : this(new Builder("MainWindow.glade")) { }

        private MainWindow(Builder builder) : base(builder.GetRawOwnedObject("MainWindow"))
        {
            builder.Autoconnect(this);
     
            DeleteEvent += Window_DeleteEvent;
            _button1.Clicked += Button1_Clicked;
            _sl.Clicked += set_Clicked;
            _bm.Clicked += bookmark_Clicked;
            _search.Clicked += search_Clicked;
            _nb.Clicked += Button2_Clicked;
            _tutorial.Clicked += tutorial_Clicked;
        }

        private void Window_DeleteEvent(object sender, DeleteEventArgs a)
        {
            Application.Quit();
        }
        private void Button1_Clicked(object sender, EventArgs a)
        {
      
       
                multilaunch mt = new multilaunch();
        mt.Show();
        }
     private void Button2_Clicked(object sender, EventArgs a)
        {
      
           nbookmark nb = new nbookmark();
           nb.Show();
       
        }
         private void search_Clicked(object sender, EventArgs a)
        {
       
          searchwindow sw = new searchwindow();
          
           sw.Show();
       
        }
        
          private void bookmark_Clicked(object sender, EventArgs a)
        {
       try{
           bookmark bm = new bookmark();
           bm.Show();
       }
       catch(Exception ex){
          MessageDialog md = new MessageDialog(null, DialogFlags.Modal, MessageType.Other, ButtonsType.Ok, ex.Message);
            md.Run();
            md.Destroy();
       }
        }
         private void set_Clicked(object sender, EventArgs a)
        {
       
           timerwindow tw = new timerwindow();
           tw.Show();
       
        }
         private void tutorial_Clicked(object sender, EventArgs a)
        {
               string fileName = "tutorial.pdf";
               string command = Environment.CurrentDirectory +"\\"+fileName;
              
                Process proc = new System.Diagnostics.Process();
                proc.StartInfo.FileName = "cmd.exe";
                proc.StartInfo.Arguments = "/C"+" start \"\" \"" + command +"\"";
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.RedirectStandardOutput = true;
                proc.Start();
                proc.Close();
       
        }
    }
}
