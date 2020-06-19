using App_OT_v3.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading;
using Xamarin.Forms;

namespace App_OT_v3.ViewModels
{
    public class LectureDetailViewModel : BaseViewModel
    {
        public Lecture Lecture { get; set; }

        public LectureDetailViewModel(Lecture lecture = null)
        {
            Title = lecture?.nameLecture;
            Lecture = lecture;
        }
    }
}
