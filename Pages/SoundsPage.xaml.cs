using System;
using System.Collections.Generic;
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
    /// Lógica de interacción para SoundsPage.xaml
    /// </summary>
    public partial class SoundsPage : Page
    {
        public SoundsPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            folderDialog.ShowNewFolderButton = false;
            folderDialog.SelectedPath = System.AppDomain.CurrentDomain.BaseDirectory;
            System.Windows.Forms.DialogResult result = folderDialog.ShowDialog();

            Settings.Default["Path"] = folderDialog.SelectedPath;
            Settings.Default.Save();

            DialogResult dialogResult = System.Windows.Forms.MessageBox.Show(
           "Le path de votre jeu est enregistré",
           "GalaxiaPath",
           MessageBoxButtons.OK);

        }
    }
}
