﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace KrileMediaPlayer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public MainWindow mwindow;

        private void SummerSunCelebration(object sender, StartupEventArgs e)
        {
            mwindow = new MainWindow(e.Args);

            mwindow.Show();
        }
    }
}
