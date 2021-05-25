﻿// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.PowerToys.Settings.UI.Library;
using Microsoft.PowerToys.Settings.UI.Library.ViewModels;
using Windows.UI.Xaml.Controls;

namespace Microsoft.PowerToys.Settings.UI.Views
{
    public sealed partial class EspressoPage : Page
    {
        private EspressoViewModel ViewModel { get; set; }

        public EspressoPage()
        {
            var settingsUtils = new SettingsUtils();
            ViewModel = new EspressoViewModel(SettingsRepository<GeneralSettings>.GetInstance(settingsUtils), SettingsRepository<EspressoSettings>.GetInstance(settingsUtils), ShellPage.SendDefaultIPCMessage);
            DataContext = ViewModel;
            InitializeComponent();
        }
    }
}
