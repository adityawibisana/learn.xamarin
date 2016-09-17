using Android.App;
using Android.Content.PM;
using Android.OS;
using Xamarin.Forms;

namespace BlogspotXamarin.Droid
{
    [Activity(Label = "Aditya Wibisana's", Icon = "@drawable/aw_logo", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            
            global::Xamarin.Forms.Forms.Init(this, bundle); 
            LoadApplication(new App()); 
            
        } 
    }
}

