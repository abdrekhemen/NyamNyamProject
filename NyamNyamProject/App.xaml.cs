﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using NyamNyamProject.Components.DB;

namespace NyamNyamProject
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Frame MainPageFrame;
        public static NyamNyamEntities db = new NyamNyamEntities();
        //public static AdelEntities db = new AdelEntities();
    }
}
