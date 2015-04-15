using Android.App;
using Android.OS;
using Com.Freshdesk.Mobihelp;

namespace FreshDeskAndroidSample
{
    [Activity(Label = "FreshDeskAndroidSample", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            var config = new MobihelpConfig(
                "http://your-domain.freshdesk.com",
            "m1-1-8f852b32ab9ee75d834f1f9c576e260f",
            "fbddf783378ddfe8fbaf9a9aceb6c1760cc0f704");

            Mobihelp.Init(this, config);


           Mobihelp.ShowSupport(this);
        }
    }
}

