﻿using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public partial class MainvievModel : ObservableObject, IMainVievModel
    {
        [ObservableProperty]
        private string aaa;
    }
}
