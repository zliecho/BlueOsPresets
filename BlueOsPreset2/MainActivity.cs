using Android.App;
using Android.OS;
using PresetLibrary;

namespace BlueOsPreset2
{
    [Activity(Label = "BlueOsPreset2", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            Class1.Preset(2).Wait(10000);
            FinishAffinity();

        }
    }
}

