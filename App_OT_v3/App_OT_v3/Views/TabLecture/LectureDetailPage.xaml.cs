using App_OT_v3.Models;
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
    public partial class LectureDetailPage : ContentPage
    {
        LectureDetailViewModel viewModel;
        public LectureDetailPage(LectureDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }
        public LectureDetailPage()
        {
            InitializeComponent();

            var lecture = new Lecture();
            viewModel = new LectureDetailViewModel(lecture);
            BindingContext = viewModel;
        }
    }
}