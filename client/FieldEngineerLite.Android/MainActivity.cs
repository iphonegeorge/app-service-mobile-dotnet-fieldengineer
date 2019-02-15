﻿using Android.App;
using Android.Content.PM;
using Android.OS;


namespace FieldEngineerLite.Droid
{
    [Activity(Label = "FieldEngineerLite",
        Icon = "@drawable/icon",
        MainLauncher = true,
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation,
        Theme = "@android:style/Theme.Holo.Light")]
    public class MainActivity : FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            Xamarin.Forms.Forms.Init(this, bundle);
            Microsoft.WindowsAzure.MobileServices.CurrentPlatform.Init();

            App.UIContext = this;

            var app = new App();
            LoadApplication(app);
        }
    }
}

