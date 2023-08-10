using System;
using Gtk;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using UI = Gtk.Builder.ObjectAttribute;
using Appbatroz;
namespace Appbatroz
{
    class nbookmark : Window
    {
             List<string> lists = new List<string>();
             List<string[]> fl = new List<string[]>();
              [UI] private Entry entry1 = null;
              [UI] private Entry entry2 = null;
              [UI] private Entry entry3 = null;
              [UI] private TextView textview1 = null;
       

        private int _counter;

        public nbookmark() : this(new Builder("nbookmark.glade")) { }

        private nbookmark(Builder builder) : base(builder.GetRawOwnedObject("nbookmark"))
        {
            string text;
            string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) ;
            if (File.Exists(folder+ "/appbatrozwin/appbatroztext/" + "bmrk.txt"))
            {
          
            var fileStream = new FileStream(folder+ "/appbatrozwin/appbatroztext/" + "bmrk.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                text = streamReader.ReadToEnd();
            }
                if (text != "") { 
                string[] parts1 = text.Split(new string[] { "{/]'[}" }, StringSplitOptions.None);
            foreach(var i in parts1)
            {
               string[] ps2= i.Split(new string[] { "{;:}" }, StringSplitOptions.None);
                foreach (var s in ps2)
                {
                    lists.Add(s);
                   

                }
                fl.Add(lists.ToArray());
                lists.Clear();
            }
                }

            }

            builder.Autoconnect(this);

           // DeleteEvent += Window_DeleteEvent;
         //   _button1.Clicked += Button1_Clicked;
        }
 protected void save_Clicked(object sender, EventArgs e)
        {


            string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + "/appbatrozwin/appbatroztext/";

            System.IO.FileInfo file = new System.IO.FileInfo(folder);
            file.Directory.Create();
            lists.Add(entry1.Text);
            lists.Add(entry2.Text);
            lists.Add(entry3.Text);
            lists.Add(textview1.Buffer.Text);
            if (fl.ToArray().Length == 0 || fl.ToArray().Length < 1)
            {
                File.WriteAllText(folder + "bmrk.txt", String.Join("{;:}", lists.ToArray()));
                fl.Add(lists.ToArray());
                lists.Clear();
            }
           
            else if (fl.ToArray().Length >= 1)
            {
                fl.Add(lists.ToArray());
                lists.Clear();
                File.WriteAllText(folder + "bmrk.txt", PrettyPrintArrayOfArrays(fl.ToArray()));

            }
          
            MessageDialog md = new MessageDialog(null, DialogFlags.Modal, MessageType.Other, ButtonsType.Ok, "Success");
                md.Run();
                md.Destroy();
            entry1.Text = "";
            entry2.Text = "";
            entry3.Text = "";
            textview1.Buffer.Text = "";



        }

        protected void cancel_Clicked(object sender, EventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }
        public string PrettyPrintArrayOfArrays(string[][] arrayOfArrays)
        {
            if (arrayOfArrays == null)
                return "";
      

            var prettyArrays = new string[arrayOfArrays.Length];

            for (int i = 0; i < arrayOfArrays.Length; i++)
            {
                prettyArrays[i] = String.Join("{;:}", arrayOfArrays[i]) ;
            }

            return String.Join("{/]'[}", prettyArrays);
        }
    }
    }