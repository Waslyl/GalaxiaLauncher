using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using UIKitTutorials.Properties;


namespace UIKitTutorials.Pages
{
    /// <summary>
    /// Lógica de interacción para HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
        }
        static Process FortniteClient = new Process();
        static String idkkk = AppDomain.CurrentDomain.BaseDirectory;
        static Process FortniteEAC = new Process();
        static Process FortniteLauncher = new Process();
        private void Button_Click(object sender, RoutedEventArgs e)
        {




        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }



        private void DownloadBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            FortniteLauncher.StartInfo.FileName = Settings.Default["Path"] + "/FortniteGame/Binaries/Win64/FortniteLauncher.exe";
            FortniteLauncher.Start();
            ProcessExtension.Suspend(FortniteLauncher);

            FortniteEAC.StartInfo.FileName = Settings.Default["Path"] + "/FortniteGame/Binaries/Win64/FortniteClient-Win64-Shipping_EAC.exe";
            FortniteEAC.Start();
            ProcessExtension.Suspend(FortniteEAC);

            FortniteClient.StartInfo.FileName = Settings.Default["Path"] + "/FortniteGame/Binaries/Win64/FortniteClient-Win64-Shipping.exe";
            FortniteClient.StartInfo.Arguments = $@"-epicapp=Fortnite -epicenv=Prod -epiclocale=en-us -epicportal -skippatchcheck -nobe -fromfl=eac -fltoken=3db3ba5dcbd2e16703f3978d -caldera=eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NvdW50X2lkIjoiYmU5ZGE1YzJmYmVhNDQwN2IyZjQwZWJhYWQ4NTlhZDQiLCJnZW5lcmF0ZWQiOjE2Mzg3MTcyNzgsImNhbGRlcmFHdWlkIjoiMzgxMGI4NjMtMmE2NS00NDU3LTliNTgtNGRhYjNiNDgyYTg2IiwiYWNQcm92aWRlciI6IkVhc3lBbnRpQ2hlYXQiLCJub3RlcyI6IiIsImZhbGxiYWNrIjpmYWxzZX0.VAWQB67RTxhiWOxx7DBjnzDnXyyEnX7OljJm-j2d88G_WgwQ9wrE6lwMEHZHjBd1ISJdUO1UVUqkfLdU5nofBQ -AUTH_LOGIN={Settings.Default["Username"]} -AUTH_PASSWORD={Settings.Default["Password"]} -AUTH_TYPE=epic";
            FortniteClient.StartInfo.UseShellExecute = false;
            FortniteClient.Start();

            Process inj = new Process();
            inj.StartInfo.FileName = $@"{idkkk}\\inj\\injector.exe";
            inj.StartInfo.Arguments = $@"-p {FortniteClient.Id} -i Galaxia.dll ";
            inj.StartInfo.CreateNoWindow = true; inj.StartInfo.RedirectStandardOutput = true;
            inj.StartInfo.UseShellExecute = false;
            inj.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            inj.Start();

            Process dllInjector = new Process();
            dllInjector.StartInfo.FileName = $@"{idkkk}\\inj\\injector.exe";
            dllInjector.StartInfo.UseShellExecute = false;
            dllInjector.StartInfo.CreateNoWindow = true; dllInjector.StartInfo.RedirectStandardOutput = true;
            dllInjector.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;

            DialogResult dialogResult = System.Windows.Forms.MessageBox.Show(
            "Cliquer sur ok pour injecter la console.",
            "GalaxiaLauncher",
            MessageBoxButtons.OK);

            if (dialogResult == System.Windows.Forms.DialogResult.OK)
            {
                dllInjector.StartInfo.Arguments = $@"-p {FortniteClient.Id} -i Console.dll";
                dllInjector.Start();


            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://cdn.fnbuilds.services/6.21.rar") { UseShellExecute = true });
        }



        public static class Anticheat
        {
            private static bool isTriggered = false;

            public static void Check(string directoryPath)
            {
                isTriggered = false;
                string[] files = Directory.GetFiles(directoryPath);

                foreach (string file in files)
                {
                    string fileName = Path.GetFileName(file);
                    if (!WhitelistedFiles.Contains(fileName))
                    {
                        isTriggered = true;
                        break;
                    }
                }

                if (isTriggered)
                {
            DialogResult dialogResult = System.Windows.Forms.MessageBox.Show(
            "Mon reuf, tu n'essayerais pas de cheat?",
            "GalaxiaAntiCheat",
            MessageBoxButtons.OK);
                }
            }

            public static bool IsTriggered
            {
                get { return isTriggered; }
            }

            private static readonly string[] WhitelistedFiles = new string[]
            {
    "pakchunk0_s1-WindowsClient.pak",
    "pakchunk0_s2-WindowsClient.pak",
    "pakchunk0_s3-WindowsClient.pak",
    "pakchunk0_s4-WindowsClient.pak",
    "pakchunk0_s5-WindowsClient.pak",
    "pakchunk0_s6-WindowsClient.pak",
    "pakchunk0_s7-WindowsClient.pak",
    "pakchunk0-WindowsClient.pak",
    "pakchunk1_s1-WindowsClient.pak",
    "pakchunk1-WindowsClient.pak",
    "pakchunk2-WindowsClient.pak",
    "pakchunk5-WindowsClient.pak",
    "pakchunk7-WindowsClient.pak",
    "pakchunk8-WindowsClient.pak",
    "pakchunk9-WindowsClient.pak",
    "pakchunk15-WindowsClient.pak",
    "pakchunk1000-WindowsClient.pak",
    "pakchunk1001-WindowsClient.pak",
    "pakchunk1002-WindowsClient.pak",
    "pakchunk1003-WindowsClient.pak",
    "pakchunk1004-WindowsClient.pak",
    "pakchunk0_s1-WindowsClient.sig",
    "pakchunk0_s2-WindowsClient.sig",
    "pakchunk0_s3-WindowsClient.sig",
    "pakchunk0_s4-WindowsClient.sig",
    "pakchunk0_s5-WindowsClient.sig",
    "pakchunk0_s6-WindowsClient.sig",
    "pakchunk0_s7-WindowsClient.sig",
    "pakchunk0-WindowsClient.sig",
    "pakchunk1_s1-WindowsClient.sig",
    "pakchunk1-WindowsClient.sig",
    "pakchunk2-WindowsClient.sig",
    "pakchunk5-WindowsClient.sig",
    "pakchunk7-WindowsClient.sig",
    "pakchunk8-WindowsClient.sig",
    "pakchunk9-WindowsClient.sig",
    "pakchunk15-WindowsClient.sig",
    "pakchunk1000-WindowsClient.sig",
    "pakchunk1001-WindowsClient.sig",
    "pakchunk1002-WindowsClient.sig",
    "pakchunk1003-WindowsClient.sig",
    "pakchunk1004-WindowsClient.sig"
            };

        }
    }
}
