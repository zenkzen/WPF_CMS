using System;
using WPF_CMS.Models;

namespace WPF_CMS.ViewModels
{
    public class AppointmentViewModel
    {
        private Appointment _appointment;
        public AppointmentViewModel(Appointment appointment)
        {
            _appointment = appointment;
        }
        public int Id { get => _appointment.Id; }
        //public int? CustomerId
        //{
        //    get { return _appointment.CustomerId; }
        //    set
        //    {
        //        if (_appointment.CustomerId != value)
        //        {
        //            _appointment.CustomerId = value;
        //        }

        //    }
        //}
        public DateTime Time 
        { 
            get => _appointment.Time;
            set
            {
                if ( value != _appointment.Time) 
                { 
                    _appointment.Time = value;
                } 
            }
        }
    }
}