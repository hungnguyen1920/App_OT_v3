using App_OT_v3.Views.TabCourse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_OT_v3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CoursePage : ContentPage
    {
        public CoursePage()
        {
            InitializeComponent();

            //Children.Add(new PrivateCoursePage());
            //Children.Add(new PublicCoursePage());
            //Children.Add(new ActivedCoursePage());
        }
        private async void OnButtonPrivateCourseClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PrivateCoursePage());
        }
        private async void OnButtonPublicCourseClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PublicCoursePage());
        }
        private async void OnButtonActivedCourseClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ActivedCoursePage());
        }
    }
}