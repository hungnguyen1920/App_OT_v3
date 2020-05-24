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
    public partial class PrivateCoursePage : ContentPage
    {
        PrivateCourseViewModel viewModel;

        public PrivateCoursePage()
        {
            InitializeComponent();
            BindingContext = viewModel = new PrivateCourseViewModel();
        }

        public async void OnDetailInvoked (object sender, EventArgs e)
        {
            var layout = (BindableObject)sender;
            var course = (Course)layout.BindingContext;
            await Navigation.PushAsync(new PrivateCourseDetailPage(new PrivateCourseDetailViewModel(course)));
        }

        public async void OnLearnInvoked (object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LecturePage());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.privateCourses.Count == 0)
                viewModel.IsBusy = true;
        }
    }
}