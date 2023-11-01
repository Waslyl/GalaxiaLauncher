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
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UIKitTutorials.Properties;

namespace UIKitTutorials.Pages
{
    /// <summary>
    /// Lógica de interacción para NotesPage.xaml
    /// </summary>
    public partial class NotesPage : Page
    {
        public NotesPage()
        {
            InitializeComponent();

            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Settings.Default["Username"] = Username.Text;
            Settings.Default["Password"] = Passwordd.Password;
            Settings.Default.Save();

            DialogResult dialogResult = System.Windows.Forms.MessageBox.Show(
           "Vous êtes connecté à votre compte Galaxia",
           "GalaxiaRegister",
           MessageBoxButtons.OK);
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Username.Text = Settings.Default.Username;
            Passwordd.Password = Settings.Default.Password;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://discord.gg/3a3buYrM2Q") { UseShellExecute = true });
        }

        private void Username_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
