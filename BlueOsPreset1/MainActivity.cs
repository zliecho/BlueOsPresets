using Android.App;
using Android.OS;
using PresetLibrary;

namespace BlueOsPreset1
{
    [Activity(Label = "BlueOsPreset1", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Class1.Preset(1).Wait(10000);
            FinishAffinity();
        }

    }
}

