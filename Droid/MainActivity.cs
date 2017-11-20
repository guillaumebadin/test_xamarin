using Android.App;
using Android.Widget;
using Android.OS;
using System.Threading.Tasks;
using test_xamarin.Services;

namespace test_xamarin.Droid
{
    [Activity(Label = "test_xamarin", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ActivityMain);
        }
    }
}

