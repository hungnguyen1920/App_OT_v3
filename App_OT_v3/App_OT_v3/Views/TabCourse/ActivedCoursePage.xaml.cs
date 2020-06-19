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
    public partial class ActivedCoursePage : ContentPage
    {
        ActivedCourseViewModel viewModel;

        public ActivedCoursePage()
        {
            InitializeComponent();

            BindingContext = viewModel = new ActivedCourseViewModel();
        }

        private async void OnDetailInvoked(object sender, EventArgs e)
        {
            var layout = (BindableObject)sender;
            var course = (Course)layout.BindingContext;
            await Navigation.PushAsync(new ActivedCourseDetailPage(new ActivedCourseDetailViewModel(course)));
        }

        private async void OnLearnInvoked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LecturePage());

            //var layout = (BindableObject)sender;
            //var course = (Course)layout.BindingContext;
            //await Navigation.PushAsync(new LecturePage(new LectureViewModel(course)));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.activedCourses.Count == 0)
                viewModel.IsBusy = true;
        }
    }
}