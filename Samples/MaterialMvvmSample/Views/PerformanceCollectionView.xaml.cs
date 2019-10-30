using System;
using System.Collections.Generic;
using System.Linq;
using MaterialMvvmSample.ViewModels;
using Xamarin.Forms;

namespace MaterialMvvmSample.Views
{
    public partial class PerformanceCollectionView : ContentPage
    {
        public PerformanceCollectionView()
        {
            InitializeComponent();

            this.BindingContext = new PerformanceViewModel();
        }
    }
}
