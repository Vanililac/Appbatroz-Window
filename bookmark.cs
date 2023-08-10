using System;
using Gtk;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using UI = Gtk.Builder.ObjectAttribute;
using Appbatroz;
namespace Appbatroz
{
    class bookmark : Window
    {
     
       [UI] private Button _button1 = null; 
       [UI] private Entry entry1 = null;
       [UI] private Entry entry2 = null;
       [UI] private Entry entry3 = null;
       [UI] private Viewport scrolledwindow1 = null;
       [UI] private Box vbox4 = null;
        List<string> lists = new List<string>();
        List<string> gdup = new List<string>();
        List<string[]> fl = new List<string[]>();
        int index;
        private int _counter;
           Button dynamicButton = new Button();
         string kk = "";
        VBox vb = new VBox(false, 0);
        public bookmark() : this(new Builder("bookmark.glade")) { }

        private bookmark(Builder builder) : base(builder.GetRawOwnedObject("bookmark"))
        {
            builder.Autoconnect(this);


            string text;
            //scrolledwindow1.Remove(vb);
            vb = new VBox(false, 0);
            string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
       if (!File.Exists(folder + "/appbatrozwin/appbatroztext/" + "bmrk.txt"))
          {
                System.IO.FileInfo file = new System.IO.FileInfo(folder + "/appbatrozwin/appbatroztext/");
               file.Directory.Create();

                FileStream fs = new FileStream(folder + "/appbatrozwin/appbatroztext/" + "bmrk.txt", FileMode.CreateNew);
     
            }
            else { 
            var fileStream = new FileStream(folder + "/appbatrozwin/appbatroztext/" + "bmrk.txt", FileMode.Open, FileAccess.Read);

            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                text = streamReader.ReadToEnd();
            }
            if(text!=""){
            string[] parts1 = text.Split(new string[] { "{/]'[}" }, StringSplitOptions.None);
            foreach (var i in parts1)
            {
                string[] ps2 = i.Split(new string[] { "{;:}" }, StringSplitOptions.None);
                foreach (var s in ps2)
                {
                    lists.Add(s);


                }
                fl.Add(lists.ToArray());
                lists.Clear();
            }
            Int32 length = fl.Count;
            if (length == 0)
            {
                length = 0;
            }
          
           
               
            
            foreach (var s in fl.ToArray())
            {
                dynamicButton = new Button();
                dynamicButton.Visible = true;
                dynamicButton.Label = s[0];
                dynamicButton.Clicked += delegate
                {

                    kk = string.Join("{;:}", s);
                    index = fl.IndexOf(s);
                    entry1.Text = s[0];
                    entry2.Text = s[1];
                    entry3.Text = s[2];
                    Console.Write(index);
                };

                vb.PackStart(dynamicButton, false, false, 0);
              scrolledwindow1.Add(vb);
                vb.Show();
                gdup.Add(s[1]);
            }

            List<string> unique = gdup.Distinct().ToList();
            foreach (var s in unique.ToArray())
            {

                Button groupbtn = new Button();
                groupbtn.Visible = true;
                groupbtn.Label = s;
                groupbtn.Clicked += delegate
                {
                    ////
                    /// 

                    //vbox3.Destroy();
                    scrolledwindow1.Remove(vb);
                    vb = new VBox(false, 0);



                    foreach (var p in fl.ToArray())
                    {
                        if (p[1] == s)
                        {
                            Button dynamicBn = new Button();
                            dynamicBn.Visible = true;
                            dynamicBn.Label = p[0];
                            dynamicBn.Clicked += delegate
                            {
                                 kk = string.Join("{;:}", p);
                    index = fl.IndexOf(p);
                                entry1.Text = p[0];
                                entry2.Text = p[1];
                                entry3.Text = p[2];
                            };
                           vb.PackStart(dynamicBn, false, false, 0);

                        }
                    };
                    scrolledwindow1.Add(vb);
                    vb.Show();

                    /// 
                };
                vbox4.PackStart(groupbtn, false, false, 0);
            }
            }
            }
           // DeleteEvent += Window_DeleteEvent;
         //   _button1.Clicked += Button1_Clicked;
        }

        protected void all_Clicked(object sender, EventArgs e)
        {
            scrolledwindow1.Remove(vb);
            vb = new VBox(false, 0);
            Int32 length = fl.Count;
            if (length == 0)
            {
                length = 0;
            }
            foreach (var s in fl.ToArray())
            {
                dynamicButton = new Button();
                dynamicButton.Visible = true;
                dynamicButton.Label = s[0];
                dynamicButton.Clicked += delegate
                {
                     kk = string.Join("{;:}", s);
                    index = fl.IndexOf(s);
                    entry1.Text = s[0];
                    entry2.Text = s[1];
                    entry3.Text = s[2];
                };

                vb.PackStart(dynamicButton, false, false, 0);
                scrolledwindow1.Add(vb);
                vb.Show();
               
            }
        }

        protected void open_Clicked(object sender, EventArgs e)
        {
            reviewwindow rw = new reviewwindow(kk,false);
            rw.Show();
        }

        protected void run_Clicked(object sender, EventArgs e)
        {
            reviewwindow rw = new reviewwindow(kk, true);
            rw.Show();
        }
        public string PrettyPrintArrayOfArrays(string[][] arrayOfArrays)
        {
            if (arrayOfArrays == null)
                return "";


            var prettyArrays = new string[arrayOfArrays.Length];

            for (int i = 0; i < arrayOfArrays.Length; i++)
            {
                prettyArrays[i] = String.Join("{;:}", arrayOfArrays[i]);
            }

            return String.Join("{/]'[}", prettyArrays);
        }

        protected void delete_Clicked(object sender, EventArgs e)
        {
            var fnl = fl.ToArray();
            for (int i = index; i < fl.ToArray().Length - 1; i++)
            {
                fnl[i] = fl.ToArray()[i + 1];
            }
           
            Array.Resize(ref fnl, fl.ToArray().Length - 1);
            string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + "/appbatrozwin/appbatroztext/";

            System.IO.FileInfo file = new System.IO.FileInfo(folder);
            file.Directory.Create();
            if (fnl.Length != 0) { 
            File.WriteAllText(folder + "bmrk.txt", PrettyPrintArrayOfArrays(fnl));
            }
            else
            {
                File.WriteAllText(folder + "bmrk.txt","");
            }
            
            MessageDialog md = new MessageDialog(null, DialogFlags.Modal, MessageType.Other, ButtonsType.Ok, "Deleted");
            md.Run();
            md.Destroy();
            this.Destroy();
            try { 
            bookmark bm = new bookmark();
            
            bm.Show();
            }
            catch (Exception ex)
            {
                MessageDialog mdd = new MessageDialog(null, DialogFlags.Modal, MessageType.Other, ButtonsType.Ok, ex.Message);
                mdd.Run();
                mdd.Destroy();
            }
        }

    }
    }