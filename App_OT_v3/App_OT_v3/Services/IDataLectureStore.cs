using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App_OT_v3.Services
{
    public interface IDataLectureStore<T>
    {
        Task<IEnumerable<T>> GetLecturesAsync(bool forceRefresh = false);
    }
}
