using DiscordRpcDemo;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using UIKitTutorials.Properties;

namespace UIKitTutorials.Pages
{
    /// <summary>
    /// Logique d'interaction pour Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        private DiscordRpc.EventHandlers handlers;
        private DiscordRpc.RichPresence presence;

        public Login()
        {
            InitializeComponent();

        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }
        private void loginBtn_Click(object sender, RoutedEventArgs e)
        {

            Settings.Default["Username"] = Username.Text;
            Settings.Default["Password"] = Passwordd.Password;
            Settings.Default.Save(); //save username and Password

            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("1166777360507482122", ref this.handlers, true, null);
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("1166777360507482122", ref this.handlers, true, null);
            this.presence.details = "Discord: https://dsc.gg/galaxiafn";
            this.presence.state = "Battle Royale - In The Launcher.";
            this.presence.largeImageKey = "galaxia";
            this.presence.smallImageKey = "Image 2";
            this.presence.largeImageText = "GalaxiaFN";
            this.presence.smallImageText = "Image 2 Text";
            DiscordRpc.UpdatePresence(ref this.presence); //discord rpc on

            Menu Main = new Menu();
            Close();
            Main.ShowDialog(); //open Main page

            
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Username.Text = Settings.Default.Username;
            Passwordd.Password = Settings.Default.Password;
        }

        private void CloseApp(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void signupBtn_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://dsc.gg/galaxiafn") { UseShellExecute = true }); //discord
        }

        private void HelpButton(object sender, RoutedEventArgs e)
        {

        }

        private void HelpBtn(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://dsc.gg/galaxiafn") { UseShellExecute = true }); //same
        }
    }
}
