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
using DiscordRpcDemo;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using UIKitTutorials.Properties;
using System.Xml.Linq;

namespace UIKitTutorials.Pages
{
    /// <summary>
    /// Logique d'interaction pour Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        int flag = -1;
        static Process FortniteClient = new Process();
        static String idkkk = AppDomain.CurrentDomain.BaseDirectory;
        private DiscordRpc.EventHandlers handlers;
        private DiscordRpc.RichPresence presence;
        static Process node = new Process();
        static Process FortniteEAC = new Process();
        static Process FortniteLauncher = new Process();
        public Menu()
        {
            InitializeComponent();

        }
       
        private void LaunchLabelLOADING_Click(object sender, RoutedEventArgs e)
        {
            

            FortniteLauncher.StartInfo.FileName = Settings.Default["Path"] + "/FortniteGame/Binaries/Win64/FortniteLauncher.exe";
            FortniteLauncher.Start();
            ProcessExtension.Suspend(FortniteLauncher); //launch and suspend because after the game crash


            FortniteEAC.StartInfo.FileName = Settings.Default["Path"] + "/FortniteGame/Binaries/Win64/FortniteClient-Win64-Shipping_EAC.exe";
            FortniteEAC.Start();
            ProcessExtension.Suspend(FortniteEAC); //same
            

            FortniteClient.StartInfo.FileName = Settings.Default["Path"] + "/FortniteGame/Binaries/Win64/FortniteClient-Win64-Shipping.exe";
            FortniteClient.StartInfo.Arguments = $@"-epicapp=Fortnite -epicenv=Prod -epiclocale=en-us -epicportal -skippatchcheck -nobe -fromfl=eac -fltoken=3db3ba5dcbd2e16703f3978d -caldera=eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NvdW50X2lkIjoiYmU5ZGE1YzJmYmVhNDQwN2IyZjQwZWJhYWQ4NTlhZDQiLCJnZW5lcmF0ZWQiOjE2Mzg3MTcyNzgsImNhbGRlcmFHdWlkIjoiMzgxMGI4NjMtMmE2NS00NDU3LTliNTgtNGRhYjNiNDgyYTg2IiwiYWNQcm92aWRlciI6IkVhc3lBbnRpQ2hlYXQiLCJub3RlcyI6IiIsImZhbGxiYWNrIjpmYWxzZX0.VAWQB67RTxhiWOxx7DBjnzDnXyyEnX7OljJm-j2d88G_WgwQ9wrE6lwMEHZHjBd1ISJdUO1UVUqkfLdU5nofBQ -AUTH_LOGIN={Settings.Default["Username"]} -AUTH_PASSWORD={Settings.Default["Password"]} -AUTH_TYPE=epic"; //skipped epic verification...
            FortniteClient.StartInfo.UseShellExecute = false;
            FortniteClient.Start(); //Start Fortnite

            Process inj = new Process();
            inj.StartInfo.FileName = $@"{idkkk}\\inj\\injector.exe";
            inj.StartInfo.Arguments = $@"-p {FortniteClient.Id} -i Galaxia.dll ";
            inj.StartInfo.CreateNoWindow = true; inj.StartInfo.RedirectStandardOutput = false;
            inj.StartInfo.UseShellExecute = false;
            inj.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            inj.Start(); //inject redirect dll

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Download download = new Download();
            download.Show(); //open download page
        }



        private void SettingsBtn_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            folderDialog.ShowNewFolderButton = false;
            folderDialog.SelectedPath = System.AppDomain.CurrentDomain.BaseDirectory;
            System.Windows.Forms.DialogResult result = folderDialog.ShowDialog(); //Choose the location of the folder

            Settings.Default["Path"] = folderDialog.SelectedPath;
            Settings.Default.Save(); //Save Path

            DialogResult dialogResult = System.Windows.Forms.MessageBox.Show(
           "Le path de votre jeu est enregistré",
           "GalaxiaPath",
           MessageBoxButtons.OK);
        }



        private void server_Click(object sender, RoutedEventArgs e)
        {
            Process voiceChat = new Process();
            voiceChat.StartInfo.FileName = $@"{idkkk}\\GalaxiaVoiceChat\\GalaxiaFN.exe"; //Start GalaxiaVoice Chat
            voiceChat.Start();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            node.Kill();
            FortniteClient.Kill();
            FortniteEAC.Kill();
            FortniteLauncher.Kill();
            Close();
            //close Fortnite and Discrd RPC
        }

        private void btnRestore_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void shop_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://galaxiashop.tebex.io/") { UseShellExecute = true }); //tebex
        }

        

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }

        private void ModCrashBtn_Click(object sender, RoutedEventArgs e)
        {
            Process dllInjector = new Process();
            dllInjector.StartInfo.FileName = $@"{idkkk}\\inj\\injector.exe";
            dllInjector.StartInfo.UseShellExecute = false;
            dllInjector.StartInfo.CreateNoWindow = true; dllInjector.StartInfo.RedirectStandardOutput = true;
            dllInjector.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;

            DialogResult dialogResult = System.Windows.Forms.MessageBox.Show(
            "appuyer sur ok au lobby pour injecter l'anticrash (uniquement si vous avez des problèmes de crash).",
            "GalaxiaLauncher",
            MessageBoxButtons.OK);

            if (dialogResult == System.Windows.Forms.DialogResult.OK)
            {
                dllInjector.StartInfo.Arguments = $@"-p {FortniteClient.Id} -i anticrash.dll";
                dllInjector.Start(); //inject AntiCrash


            }
        }

        private void ModEditBtn_Click(object sender, RoutedEventArgs e)
        {
            Process dllInjector = new Process();
            dllInjector.StartInfo.FileName = $@"{idkkk}\\inj\\injector.exe";
            dllInjector.StartInfo.UseShellExecute = false;
            dllInjector.StartInfo.CreateNoWindow = true; dllInjector.StartInfo.RedirectStandardOutput = false;
            dllInjector.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;

            DialogResult dialogResult = System.Windows.Forms.MessageBox.Show(
            "appuyer sur ok au lobby pour l'edit on release.",
            "GalaxiaLauncher",
            MessageBoxButtons.OK);

            if (dialogResult == System.Windows.Forms.DialogResult.OK)
            {
                dllInjector.StartInfo.Arguments = $@"-p {FortniteClient.Id} -i edit.dll";
                dllInjector.Start(); //inject edit on release


            }
        }
    }
}
