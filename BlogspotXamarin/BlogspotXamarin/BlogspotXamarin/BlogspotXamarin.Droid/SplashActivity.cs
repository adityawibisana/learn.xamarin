
using Android.App;
using Android.Content;
using Android.OS;
using Android.Content.PM;

namespace BlogspotXamarin.Droid
{
    [Activity(Label = "Aditya Wibisana's", Icon = "@drawable/aw_logo", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation, MainLauncher=true, Theme = "@style/MyThemes", NoHistory =true)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.layout1);  
            Java.Lang.Runnable runnable = new Java.Lang.Runnable(() =>
            {
                Intent i = new Intent(this, typeof(MainActivity));
                StartActivity(i);
            });

            new Handler().PostDelayed(runnable, 1500);
        }
    }
}