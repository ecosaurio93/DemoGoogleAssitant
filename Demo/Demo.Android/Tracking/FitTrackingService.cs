using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.Droid.Tracking
{
    public class FitTrackingService : Service
    {
        
        public override IBinder OnBind(Intent intent)
        {
            return null;
        }

        public override void OnCreate()
        {
            base.OnCreate();
            Console.WriteLine("Inicio FitTracking");
            System.Diagnostics.Debug.WriteLine("Inicio FitTracking");
        }

        public override void OnDestroy()
        {
            base.OnDestroy();
            Console.WriteLine("Termino FitTracking");
            System.Diagnostics.Debug.WriteLine("Termino FitTracking");
        }
    }
}