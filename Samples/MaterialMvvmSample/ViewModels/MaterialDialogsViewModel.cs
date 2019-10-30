using System;
using System.Collections.Generic;

namespace MaterialMvvmSample.ViewModels
{
    public class MaterialDialogsViewModel : BaseViewModel
    {
        public List<string> Options => new List<string>
        {
            "option 1",
            "option 2",
            "option 3",
            "option 4",
        };

        public MaterialDialogsViewModel()
        {
        }
    }
}
