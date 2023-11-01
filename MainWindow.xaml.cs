using System;
using System.Collections.Generic;
using System.Configuration;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using UIKitTutorials.Pages;
using UIKitTutorials.Properties;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace UIKitTutorials
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            if (Settings.Default.Username == null)
            {
                PagesNavigation.Navigate(new System.Uri("Pages/NotesPage.xaml", UriKind.RelativeOrAbsolute));
            }
            else
            {
                PagesNavigation.Navigate(new System.Uri("Pages/HomePage.xaml", UriKind.RelativeOrAbsolute));
            }
        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnRestore_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void rdHome_Click(object sender, RoutedEventArgs e)
        {
           // PagesNavigation.Navigate(new HomePage());
            
            PagesNavigation.Navigate(new System.Uri("Pages/HomePage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void rdSounds_Click(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Navigate(new System.Uri("Pages/SoundsPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void rdNotes_Click(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Navigate(new System.Uri("Pages/NotesPage.xaml", UriKind.RelativeOrAbsolute));
        }

        

        private void rdHome_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void PagesNavigation_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void rdNotes_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void btnMenu_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void rdSounds_Checked(object sender, RoutedEventArgs e)
        {

        }

        
    }
}
