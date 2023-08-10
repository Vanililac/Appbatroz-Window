using System;
using Gtk;
using System.Diagnostics;
using UI = Gtk.Builder.ObjectAttribute;
using Appbatroz;
namespace Appbatroz
{
    class reviewwindow : Window
    {
     
 
       [UI] private Entry entry1 = null;
       [UI] private Entry entry3 = null;
       [UI] private Entry entry2 = null;
       [UI] private TextView textview1 = null;

        private int _counter;
string kk;
bool stat=false;
        public reviewwindow(string ss, bool runs) : this(new Builder("reviewwindow.glade")) {kk=ss;stat=runs;string[] ps2 = kk.Split(new string[] { "{;:}" }, StringSplitOptions.None);

                entry1.Text = ps2[0];
                entry2.Text = ps2[1];
                entry3.Text = ps2[2];
                textview1.Buffer.Text = ps2[3];

            if (stat == true)
            {
                string command = ps2[2];
                Process proc = new System.Diagnostics.Process();
                proc.StartInfo.FileName = "cmd.exe";
                proc.StartInfo.Arguments = "/C"+" start \"\" \"" + command +"\"";
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.RedirectStandardOutput = true;
                proc.Start();
                proc.Close();
            }
 }

        private reviewwindow(Builder builder) : base(builder.GetRawOwnedObject("reviewwindow"))
        {
            
            builder.Autoconnect(this);
 
         //   DeleteEvent += Window_DeleteEvent;
         //   _button1.Clicked += Button1_Clicked;
        }
    
    }
    }