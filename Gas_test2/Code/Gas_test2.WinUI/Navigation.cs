﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Globalization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

using EAS.Data;
using EAS.Data.ORM;
using EAS.Data.Access;
using EAS.Modularization;

using EAS;
using EAS.Services;
using EAS.Data.Linq;

using Gas_test2.Entities;
using Gas_test2.BLL; 

namespace Gas_test2.WinUI
{
    [Module("EB3FB755-C566-4558-B026-5DCBF62F7A01", "导航界面", "FunctionList")]
    
    public partial class Navigation : UserControl
    {
        public Navigation()
        {
            InitializeComponent();
        }

        [ModuleStart]
        public void StartEx()
        {

        }

        private void Navigation_Load(object sender, EventArgs e)
        {
            //Menustripe修改

            //treeview


        }













    }
}
