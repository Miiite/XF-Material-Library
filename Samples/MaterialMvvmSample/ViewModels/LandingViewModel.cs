﻿using System;
using System.Windows.Input;
using MaterialMvvmSample.Views;
using Xamarin.Forms;

namespace MaterialMvvmSample.ViewModels
{
    public class LandingViewModel : BaseViewModel
    {
        public ICommand GoToMaterialDialogsCommand => this.GoToCommand(ViewNames.MaterialDialogsView);

        public ICommand GoToChipFontSizeViewCommand => this.GoToCommand(ViewNames.ChipFontSizeView);

        public ICommand GoToCheckboxesSampleCommand => this.GoToCommand(ViewNames.CheckboxesView);

        public ICommand GoToMaterialCircularViewCommand => this.GoToCommand(ViewNames.MaterialCircularView);

        private ICommand GoToCommand(string name) => new Command(() => this.Navigation.PushAsync(name));
    }
}
