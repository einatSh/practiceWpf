﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using PracticeWpf.Logger;

namespace PracticeWpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            log4net.Config.XmlConfigurator.Configure();
            //base.OnStartup(e);

            

            //Current.MainWindow = new MainWindow();

            //Log.Instance.info("        =============  Started Logging  =============        ");
        }
    }
}
