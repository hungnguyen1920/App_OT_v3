using App_OT_v3.Services;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_OT_v3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataCourse>();

            DependencyService.Register<MockDataLecture>();

            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
