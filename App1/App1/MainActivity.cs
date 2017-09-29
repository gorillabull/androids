using Android.App;
using Android.Widget;
using Android.OS;

namespace App1
{
    [Activity(Label = "App1", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var t = 5;
            t++;
            
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
    }
}

