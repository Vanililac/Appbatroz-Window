using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Gtk;
using UI = Gtk.Builder.ObjectAttribute;
using Appbatroz;
namespace Appbatroz
{
    class multilaunch : Window
    {
        [UI] private Entry entry1 = null;
        [UI] private Entry entry2 = null;
        [UI] private Entry entry3 = null;
        [UI] private Entry entry4 = null;
        [UI] private Entry entry5 = null;
         [UI] private Entry entry6 = null;
        [UI] private Entry entry7 = null;
        [UI] private Entry entry8 = null;
        [UI] private Entry entry9 = null;
        [UI] private Entry entry10 = null;
         [UI] private Entry entry11 = null;
        [UI] private Entry entry12 = null;
        [UI] private Entry entry13 = null;
        [UI] private Entry entry14 = null;
        [UI] private Entry entry15 = null;
         [UI] private Entry entry16 = null;
        [UI] private Entry entry17 = null;
        [UI] private Entry entry18 = null;
        [UI] private Entry entry19 = null;
        [UI] private Entry entry20 = null;
         [UI] private Entry entry21 = null;
        [UI] private Entry entry22 = null;
        [UI] private Entry entry23 = null;
             [UI] private Button _save = null;
      [UI] private Button _icon = null;
 
public multilaunch() : this(new Builder("multilaunch.glade")) { }

        private multilaunch(Builder builder) : base(builder.GetRawOwnedObject("multilaunch"))
        {
            builder.Autoconnect(this);
_save.Clicked += save_Clicked;
         _icon.Clicked += ofd_Clicked;

        }
 private void save_Clicked(object sender, EventArgs a)
        {
       

        try
        { string cn1,cn3,cn5,cn7,cn9,cn11,cn13,cn15,cn17,cn19;
            if(entry1.Text==""){
                cn1="";
            }
            else{
                cn1="\""+entry1.Text+"\"";
            }

             if(entry3.Text==""){
                cn3="";
            }
            else{
                cn3="\""+entry3.Text+"\"";
            }

            if(entry5.Text==""){
                cn5="";
            }
            else{
                cn5="\""+entry5.Text+"\"";
            }

             if(entry7.Text==""){
                cn7="";
            }
            else{
                cn7="\""+entry7.Text+"\"";
            }

            if(entry9.Text==""){
                cn9="";
            }
            else{
                cn9="\""+entry9.Text+"\"";
            }

             if(entry11.Text==""){
                cn11="";
            }
            else{
                cn11="\""+entry11.Text+"\"";
            }

            if(entry13.Text==""){
                cn13="";
            }
            else{
                cn13="\""+entry13.Text+"\"";
            }

             if(entry15.Text==""){
                cn15="";
            }
            else{
                cn15="\""+entry15.Text+"\"";
            }

            if(entry17.Text==""){
                cn17="";
            }
            else{
                cn17="\""+entry17.Text+"\"";
            }

             if(entry19.Text==""){
                cn19="";
            }
            else{
                cn19="\""+entry19.Text+"\"";
            }
            String txt = "";
            string en2,en4,en6,en8,en10,en12,en14,en16,en18,en20;
            if(entry2.Text==""){
                en2="";
            }
            else{
                en2="\""+entry2.Text+"\"";
            }

             if(entry4.Text==""){
                en4="";
            }
            else{
                en4="\""+entry4.Text+"\"";
            }

            if(entry6.Text==""){
                en6="";
            }
            else{
                en6="\""+entry6.Text+"\"";
            }

             if(entry8.Text==""){
                en8="";
            }
            else{
                en8="\""+entry8.Text+"\"";
            }

            if(entry10.Text==""){
                en10="";
            }
            else{
                en10="\""+entry10.Text+"\"";
            }

             if(entry12.Text==""){
                en12="";
            }
            else{
                en12="\""+entry12.Text+"\"";
            }

            if(entry14.Text==""){
                en14="";
            }
            else{
                en14="\""+entry14.Text+"\"";
            }

             if(entry16.Text==""){
                en16="";
            }
            else{
                en16="\""+entry16.Text+"\"";
            }

            if(entry18.Text==""){
                en18="";
            }
            else{
                en18="\""+entry18.Text+"\"";
            }

             if(entry20.Text==""){
                en20="";
            }
            else{
                en20="\""+entry20.Text+"\"";
            }
            ///
            if (entry1.Text != "" || entry2.Text != "")
            {
               
                    txt =  "start /b \"\" "+cn1 + " " + en2;
                

            }
            if (entry3.Text != "" || entry4.Text != "")
            {
               
                txt =  "start /b \"\" "+cn1 + " " + en2 +  " &"  +  "start /b \"\" "+cn3 + " " + en4;

                
            }
            if (entry5.Text != "" || entry6.Text != "")
            {
                txt = "start /b \"\" "+cn1 + " " + en2 +  " &"  + "start /b \"\" "+cn3 + " " + en4 +  " &"  + "start /b \"\" "+cn5 + " "  + en6;
            }
            if (entry7.Text != "" || entry8.Text != "")
            {
                txt = "start /b \"\" "+cn1 + " " + en2 +  " &"  + "start /b \"\" "+cn3 + " " + en4 +  " &"  +  "start /b \"\" "+cn5 + " " + en6 +  " &"  +  "start /b \"\" "+cn7 + " "  + en8;
            }
            if (entry9.Text != "" || entry10.Text != "")
            {
                txt =  "start /b \"\" "+cn1 + " " + en2 +  " &"  +  "start /b \"\" "+cn3 + " " + en4 +  " &"  + "start /b \"\" "+cn5 + " " + en6 +  " &"  + "start /b \"\" "+cn7 + " " + en8 +  " &"  + "start /b \"\" "+cn9 + " "  + en10;
            }
            if (entry11.Text != "" || entry12.Text != "")
            {
                txt =  "start /b \"\" "+cn1 + " " + en2 +  " &"  + "start /b \"\" "+cn3 + " " + en4 +  " &"  +  "start /b \"\" "+cn5 + " " + en6 +  " &"  + "start /b \"\" "+cn7 + " " + en8 +  " &"  + "start /b \"\" "+cn9 + " " + en10 +  " &"  +  "start /b \"\" "+cn11 + " "  + en12;
            }
            if (entry13.Text != "" || entry14.Text != "")
            {
                txt =  "start /b \"\" "+cn1 + " " + en2 +  " &"  + "start /b \"\" "+cn3 + " " + en4 +  " &"  +  "start /b \"\" "+cn5 + " " + en6 +  " &"  +  "start /b \"\" "+cn7 + " " + en8 +  " &"  + "start /b \"\" "+cn9 + " " + en10 +  " &"  +  "start /b \"\" "+cn11 + " " + en12 +  " &"  + "start /b \"\" "+cn13 + " "  + en14;
            }
            if (entry15.Text != "" || entry16.Text != "")
            {
                txt = "start /b \"\" "+cn1 + " " + en2 +  " &"  +  "start /b \"\" "+cn3 + " " + en4 +  " &"  + "start /b \"\" "+cn5 + " " + en6 +  " &"  + "start /b \"\" "+cn7 + " " + en8 +  " &"  + "start /b \"\" "+cn9 + " " + en10 +  " &"  + "start /b \"\" "+cn11 + " " + en12 +  " &"  + "start /b \"\" "+cn13 + " " + en14 +  " &"  +  "start /b \"\" "+cn15 + " "  + en16;
            }
            if (entry17.Text != "" || entry18.Text != "")
            {
                txt =  "start /b \"\" "+cn1 + " " + en2 +  " &"  + "start /b \"\" "+cn3 + " " + en4 +  " &"  + "start /b \"\" "+cn5 + " " + en6 +  " &"  + "start /b \"\" "+cn7 + " " + en8 +  " &"  +  "start /b \"\" "+cn9 + " " + en10 +  " &"  + "start /b \"\" "+cn11 + " " + en12 +  " &"  + "start /b \"\" "+cn13 + " " + en14 +  " &"  + "start /b \"\" "+cn15 + " " + en16 +  " &"  + "start /b \"\" "+cn17 + " "  + en18;
            }
            if (entry19.Text != "" || entry20.Text != "")
            {
                txt =  "start /b \"\" "+cn1 + " " + en2 +  " &" +  "start /b \"\" "+cn3 + " " + en4 +  " &" + "start /b \"\" "+cn5 + " " + en6 +  " &"  + "start /b \"\" "+cn7 + " " + en8 +  " &"  + "start /b \"\" "+cn9 + " " + en10 +  " &"  + "start /b \"\" "+cn11 + " " + en12 +  " &"  + "start /b \"\" "+cn13 + " " + en14 +  " &"  + "start /b \"\" "+cn15 + " " + en16 +  " &"  + "start /b \"\" "+cn17 + " " + en18 +  " &"  +  "start /b \"\" "+cn19 + " "  + en20;
            }
           
            string ftxt = '"' + txt + '"';
            var last="";
            if (entry23.Text != "") {
                string filepath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + "\\appbatrozwin\\appbatrozicon\\";
                System.IO.FileInfo file = new System.IO.FileInfo(filepath);
                file.Directory.Create();
                 if (!File.Exists(file.FullName+entry23.Text.Split('\\').Last())){
          
               File.Copy(entry23.Text, file.FullName+entry23.Text.Split('\\').Last());
          }
               // file.CopyTo(file.FullName+entry23.Text.Split('\\').Last());
                last = file.FullName + entry23.Text.Split('\\').Last();
            }
            string folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop) +"/";
            if(entry21.Text==""){
  MessageDialog mds = new MessageDialog(null, DialogFlags.Modal, MessageType.Other, ButtonsType.Ok, "Title is empty");
            mds.Run();
            mds.Destroy();
           }else{
            shellLink.make(ftxt,last,entry21.Text,entry22.Text);

            entry1.Text = "";
            entry2.Text = "";
            entry3.Text = "";
            entry4.Text = "";
            entry5.Text = "";
            entry6.Text = "";
            entry7.Text = "";
            entry8.Text = "";
            entry9.Text = "";
            entry10.Text = "";
            entry11.Text = "";
            entry12.Text = "";
            entry13.Text = "";
            entry14.Text = "";
            entry15.Text = "";
            entry16.Text = "";
            entry17.Text = "";
            entry18.Text = "";
            entry19.Text = "";
            entry20.Text = "";
            entry21.Text = "";
            entry22.Text = "";
            entry23.Text = "";
          
 
            MessageDialog md = new MessageDialog(null, DialogFlags.Modal, MessageType.Other, ButtonsType.Ok, "Success");
            md.Run();
            md.Destroy();

           
            }
            
        }
        catch (Exception ex)
        {
           MessageDialog md = new MessageDialog(null, DialogFlags.Modal, MessageType.Other, ButtonsType.Ok, ex.Message);
            md.Run();
            md.Destroy();
        }

          
       
        }
         private void OpenOFD()
    {
        Gtk.FileChooserDialog filechooser =
            new Gtk.FileChooserDialog("Choose the file to open",
                this,
                FileChooserAction.Open,
                "Cancel", ResponseType.Cancel,
                "Open", ResponseType.Accept);

        if (filechooser.Run() == (int)ResponseType.Accept)
        {
            entry23.Text = filechooser.Filename;
           
            //file.Close();
        }

        filechooser.Destroy();
    }
      protected void ofd_Clicked(object sender, EventArgs e)
    {
        OpenOFD();
    }

   
    }
}
