using Android.App;
using Android.Widget;
using Android.OS;

namespace App1
{
    [Activity(Label = "App1", MainLauncher = true)]
    public class MainActivity : Activity
    {
        //EditText txt1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var t = 5;
            t++;
            EditText txt1 = null;
            txt1 = FindViewById<EditText>(Resource.Id.editText2);
            if (txt1== null)
            {
                while (true)
                {

                }
            }
          //  txt1.TextChanged += delegate { };
            txt1.KeyPress += delegate {
                txt1.Text = "text changed";
            };
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }


    }
}

