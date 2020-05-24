using App_OT_v3.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_OT_v3.Views.TabLecture
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LecturePage : ContentPage
    {
        LectureViewModel viewModel;

        public LecturePage()
        {
            InitializeComponent();

            BindingContext = viewModel = new LectureViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.lectures.Count == 0)
                viewModel.IsBusy = true;
        }
    }
}