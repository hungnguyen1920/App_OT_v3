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
    public partial class PublicCourseDetailPage : ContentPage
    {
        PublicCourseDetailViewModel viewModel;

        public PublicCourseDetailPage(PublicCourseDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public PublicCourseDetailPage()
        {
            InitializeComponent();

            var course = new Course();

            viewModel = new PublicCourseDetailViewModel(course);
            BindingContext = viewModel;
        }
    }
}