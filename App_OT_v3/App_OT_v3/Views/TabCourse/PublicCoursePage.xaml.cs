using App_OT_v3.Models;
using App_OT_v3.ViewModels;
using App_OT_v3.ViewModels.CourseDetailViewModel;
using App_OT_v3.Views.TabCourseDetail;
using App_OT_v3.Views.TabLecture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_OT_v3.Views.TabCourse
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PublicCoursePage : ContentPage
    {
        PublicCourseViewModel viewModel;
        public PublicCoursePage()
        {
            InitializeComponent();

            BindingContext = viewModel = new PublicCourseViewModel();
        }

        public async void OnDetailInvoked(object sender, EventArgs e)
        {
            var layout = (BindableObject)sender;
            var course = (Course)layout.BindingContext;
            await Navigation.PushAsync(new PublicCourseDetailPage(new PublicCourseDetailViewModel(course)));
        }

        public async void OnRegisterInvoked(object sender, EventArgs e)
        {
            
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.publicCourses.Count == 0)
                viewModel.IsBusy = true;
        }
    }
}