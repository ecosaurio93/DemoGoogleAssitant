using Android.App;
using Android.App.Slices;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.Droid.Slices
{
    public class FitSliceProvider : SliceProvider
    {

        internal const string SLICE_AUTHORITY = "com.demo.droid.Slices.provider";       


        public override bool OnCreate()
        {
            return true;
        }
    }
}