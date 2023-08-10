using System;
using Gtk;
using System.Collections.Generic;
using UI = Gtk.Builder.ObjectAttribute;
using Appbatroz;
namespace Appbatroz
{
    class searchwindow : Window
    {
     
          [UI] private Entry entry1 = null;
        [UI] private TextView textview1 = null;

        private int _counter;
        string[] listexe;
        public searchwindow() : this(new Builder("searchwindow.glade")) { }

        private searchwindow(Builder builder) : base(builder.GetRawOwnedObject("searchwindow"))
        {
            string a = "";
            builder.Autoconnect(this);
foreach (string ln in ExecuteCommand())
            {

                a += ln+"\n";

            }
            textview1.Buffer.Text = a;
            listexe = ExecuteCommand();           
          //  DeleteEvent += Window_DeleteEvent;
         //   _button1.Clicked += Button1_Clicked;
        }
        
        public static string[] ExecuteCommand()
        {

            string[] ss ;
            string command = "where *.exe &&cd c:\\Program Files && dir  /s /b *.exe | findstr /v .exe. && cd c:\\Program Files (x86) && dir  /s /b *.exe | findstr /v .exe.";
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C " + command;
            process.StartInfo = startInfo;
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();

            List<string> list = new List<string>();
            //awk '/^Exec=/ {sub("^Exec=", ""); gsub(" ?%[cDdFfikmNnUuv]", ""); exit system($0)}' /usr/share/applications/libreoffice-calc.desktop
            //(grep '^Exec' filename.desktop | tail -1 | sed 's/^Exec=//' \| sed 's/%.//' | sed 's/^"//g' | sed 's/" *$//g')
            while (!process.StandardOutput.EndOfStream)
            {
                list.Add(process.StandardOutput.ReadLine());
              
                
               
            }
             process.Close();
            ss = list.ToArray();
           
            return ss;
        }
       
        protected void OnTextview1Shown(object sender, EventArgs e)
        {
        }

        protected void OnEntry1KeyReleaseEvent(object o, KeyReleaseEventArgs args)
        {

            string a = "";
            List<string> list = new List<string>();
            foreach (string ms in listexe)
            {
                if (ms.ToLower().Contains(entry1.Text.ToLower()))
                {
                    list.Add(ms);
                }

             
            }
            foreach (string ln in list.ToArray())
            {

                a += ln + "\n";

            }
            textview1.Buffer.Text = a;
           
         }
    }
    }