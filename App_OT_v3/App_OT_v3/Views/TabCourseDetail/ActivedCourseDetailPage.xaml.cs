using App_OT_v3.Models;
using App_OT_v3.ViewModels.CourseDetailViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_OT_v3.Views.TabCourseDetail
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ActivedCourseDetailPage : ContentPage
    {
        ActivedCourseDetailViewModel viewModel;
        public ActivedCourseDetailPage(ActivedCourseDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public ActivedCourseDetailPage()
        {
            InitializeComponent();

            var course = new Course();
            viewModel = new ActivedCourseDetailViewModel(course);
            BindingContext = viewModel;
        }
    }
}