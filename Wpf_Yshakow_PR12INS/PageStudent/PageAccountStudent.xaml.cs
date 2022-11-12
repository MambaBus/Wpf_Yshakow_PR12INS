﻿using System;
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

namespace Wpf_Yshakow_PR12INS.PageStudent
{
    /// <summary>
    /// Логика взаимодействия для PageAccountStudent.xaml
    /// </summary>
    public partial class PageAccountStudent : Page
    {
        public PageAccountStudent()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageMain.PageLogin());
        }
    }
}
