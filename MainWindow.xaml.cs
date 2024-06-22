﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LabWork30
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SubscribeButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AgreeCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            SubscribeButton.IsEnabled = true;
        }

        private void AgreeCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            SubscribeButton.IsEnabled = false;
        }
    }
}