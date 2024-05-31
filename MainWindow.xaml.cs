﻿using Hotel.Pages;
using System;
using System.Collections.Generic;
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

namespace Hotel
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Manager.MainFrame = MainFrame;

        }

        private void Avt_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Avtoriz());
        }

        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Registartsia());
        }
    }
}
