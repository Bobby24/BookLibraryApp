using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace BookLibraryApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Delete_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            // Add your event handler logic here
        }
        private void ExitContextMenu_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            // Exit context menu click logic here
        }

        private void AddOption_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            // Add option click logic here
        }

        private void DeleteOption_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            // Delete option click logic here
        }

        private void FindOption_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            // Find option click logic here
        }

        private void AuthorSort_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            // Author sort click logic here
        }

        private void TitleSort_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            // Title sort click logic here
        }

        private void YearSort_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            // Year sort click logic here
        }

        private void Exit_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            // Exit click logic here
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
