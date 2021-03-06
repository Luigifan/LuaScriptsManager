﻿// /**
// * Author: Mike Santiago
// */
using System;
using Gtk;
using System.Diagnostics;
using System.IO;
using Gtktester;
using MonoDevelop.Core;
using System.Reflection;

namespace Updater
{
    public class Program
    {
        public static string ManagerDir = "";
        public static void Main(string[] args)
        {
            Gtktester.Settings filler = new Gtktester.Settings();

            if(Internals.CurrentOS == InternalOperatingSystem.Windows)
                CheckWindowsGtk();

            if (args.Length > 0)
                ManagerDir = args[0].Trim('"');

            Application.Init();
            MainWindow win = new MainWindow();
            win.Show();

            Application.Run();
        }

        [System.Runtime.InteropServices.DllImport("kernel32.dll", CharSet = System.Runtime.InteropServices.CharSet.Unicode, SetLastError = true)]
        [return: System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Bool)]
        static extern bool SetDllDirectory (string lpPathName);

        static bool CheckWindowsGtk ()
        {
            string location = null;
            Version version = null;
            Version minVersion = new Version (2, 12, 22);

            using (var key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Xamarin\GtkSharp\InstallFolder")) {
                if (key != null)
                    location = key.GetValue (null) as string;
            }
            using (var key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey (@"SOFTWARE\Xamarin\GtkSharp\Version")) {
                if (key != null)
                    Version.TryParse (key.GetValue (null) as string, out version);
            }

            //TODO: check build version of GTK# dlls in GAC
            if (version == null || version < minVersion || location == null || !File.Exists (Path.Combine (location, "bin", "libgtk-win32-2.0-0.dll"))) {
                //LoggingService.LogError ("Did not find required GTK# installation");
                Console.WriteLine("Did not find required GTK# installation");
                string url = "http://monodevelop.com/Download";
                string caption = "Fatal Error";
                string message =
                    "{0} did not find the required version of GTK#. Please click OK to open the download page, where " +
                    "you can download and install the latest version.";
                if (DisplayWindowsOkCancelMessage (string.Format (message, BrandingService.ApplicationName, url), caption)) 
                {
                    Process.Start (url);

                }
                return false;
            }

            //LoggingService.LogInfo ("Found GTK# version " + version);
            Console.WriteLine("Found GTK# version {0}", version);

            var path = Path.Combine (location, @"bin");
            try {
                if (SetDllDirectory (path)) {
                    return true;
                }
            } catch (EntryPointNotFoundException) {
            }
            // this shouldn't happen unless something is weird in Windows
            //LoggingService.LogError ("Unable to set GTK+ dll directory");
            Console.WriteLine("Unable to set Gtk+ dll directory");
            return true;
        }

        static void SetupTheme ()
        {
            // Use the bundled gtkrc only if the Xamarin theme is installed
            if (File.Exists (Path.Combine (Gtk.Rc.ModuleDir, "libxamarin.so")) || File.Exists (Path.Combine (Gtk.Rc.ModuleDir, "libxamarin.dll"))) {
                var gtkrc = "gtkrc";
                if (Internals.CurrentOS == InternalOperatingSystem.Windows) {
                    gtkrc += ".win32";
                    var osv = Environment.OSVersion.Version;
                    if (osv.Major == 6 && osv.Minor < 1)
                        gtkrc += "-vista";
                } else if (Internals.CurrentOS == InternalOperatingSystem.MacOSX) {
                    gtkrc += ".mac";

                    //var osv = Platform.OSVersion;
                    //if (osv.Major == 10 && osv.Minor >= 10) {
                    //    gtkrc += "-yosemite";
                    //}
                }
                Environment.SetEnvironmentVariable ("GTK2_RC_FILES", PropertyService.EntryAssemblyPath.Combine (gtkrc));
            }
        }

        static bool DisplayWindowsOkCancelMessage (string message, string caption)
        {
            var name = typeof(int).Assembly.FullName.Replace ("mscorlib", "System.Windows.Forms");
            var asm = Assembly.Load (name);
            var md = asm.GetType ("System.Windows.Forms.MessageBox");
            var mbb = asm.GetType ("System.Windows.Forms.MessageBoxButtons");
            var okCancel = Enum.ToObject (mbb, 1);
            var dr = asm.GetType ("System.Windows.Forms.DialogResult");
            var ok = Enum.ToObject (dr, 1);

            const BindingFlags flags = BindingFlags.InvokeMethod | BindingFlags.Public | BindingFlags.Static;
            return md.InvokeMember ("Show", flags, null, null, new object[] { message, caption, okCancel }).Equals (ok);
        }
    }
}
