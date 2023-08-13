using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

 
namespace Appbatroz
{
    class shellLink
    {
       public static void make(string argument, string icon, string filename, string description)
        {
      
            IShellLink link = (IShellLink)new ShellLink();

            // setup shortcut information
            link.SetDescription(description);
            link.SetPath(@"C:\Windows\System32\cmd.exe");
            link.SetArguments(" /c " + argument);
            link.SetIconLocation(icon, 0);

            // save it
            IPersistFile file = (IPersistFile)link;
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            file.Save(Path.Combine(desktopPath, filename+".lnk"), false);
         
        }
    }
		[ComImportAttribute()]

		[GuidAttribute("0000010C-0000-0000-C000-000000000046")]

		[InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]

		public interface IPersist

		{

			[PreserveSig]

			void GetClassID(out Guid pClassID);

		}
		[ComImportAttribute()]

		[GuidAttribute("0000010B-0000-0000-C000-000000000046")]

		[InterfaceTypeAttribute(ComInterfaceType.InterfaceIsIUnknown)]

		public interface IPersistFile

		{

			[PreserveSig]

			void GetClassID(out Guid pClassID);



			void IsDirty();



			void Load([MarshalAs(UnmanagedType.LPWStr)] string pszFileName, uint dwMode);



			void Save([MarshalAs(UnmanagedType.LPWStr)] string pszFileName, [MarshalAs(UnmanagedType.Bool)] bool fRemember);



			void SaveCompleted([MarshalAs(UnmanagedType.LPWStr)] string pszFileName);



			void GetCurFile([MarshalAs(UnmanagedType.LPWStr)] out string ppszFileName);

		}

    [ComImport]
    [Guid("00021401-0000-0000-C000-000000000046")]
    internal class ShellLink
    {
    }

    [ComImport]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [Guid("000214F9-0000-0000-C000-000000000046")]
    internal interface IShellLink
    {
        void GetPath([Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszFile, int cchMaxPath, out IntPtr pfd, int fFlags);
        void GetIDList(out IntPtr ppidl);
        void SetIDList(IntPtr pidl);
        void GetDescription([Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszName, int cchMaxName);
        void SetDescription([MarshalAs(UnmanagedType.LPWStr)] string pszName);
        void GetWorkingDirectory([Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszDir, int cchMaxPath);
        void SetWorkingDirectory([MarshalAs(UnmanagedType.LPWStr)] string pszDir);
        void GetArguments([Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszArgs, int cchMaxPath);
        void SetArguments([MarshalAs(UnmanagedType.LPWStr)] string pszArgs);
        void GetHotkey(out short pwHotkey);
        void SetHotkey(short wHotkey);
        void GetShowCmd(out int piShowCmd);
        void SetShowCmd(int iShowCmd);
        void GetIconLocation([Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszIconPath, int cchIconPath, out int piIcon);
        void SetIconLocation([MarshalAs(UnmanagedType.LPWStr)] string pszIconPath, int iIcon);
        void SetRelativePath([MarshalAs(UnmanagedType.LPWStr)] string pszPathRel, int dwReserved);
        void Resolve(IntPtr hwnd, int fFlags);
        void SetPath([MarshalAs(UnmanagedType.LPWStr)] string pszFile);
    }
    
}
