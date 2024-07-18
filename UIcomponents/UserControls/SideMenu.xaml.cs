using System;
using System.Windows;
using System.Windows.Controls;

namespace FicmaDT.UIcomponents.UserControls
{
    public partial class SideMenu : UserControl
    {
        public SideMenu()
        {
            InitializeComponent();
        }

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            // Handle the button click event here
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                MessageBox.Show($"Button clicked: {clickedButton.Content}");
            }
        }
    }
}
