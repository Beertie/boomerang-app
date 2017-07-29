using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Support.V7.App;
using System.Threading;
using Android;
using Boomerang.Helpers;

namespace Boomerang.Droid.Activities
{
  [Activity(Theme = "@style/Theme.Boomerang", Icon = "@drawable/ic_launcher", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait, WindowSoftInputMode = SoftInput.StateHidden)]
  public partial class RootActivity : AppCompatActivity
  {
    protected override void OnCreate(Bundle bundle)
    {
      base.OnCreate(bundle);

      SetContentView(Resource.Layout.RootPage);

      // Toolbar will now take on default actionbar characteristics
      SetSupportActionBar(this.Toolbar);

      this.RefreshButton.Touch += (s, e) =>
      {

      };

      this.RefreshButton.Visibility = ViewStates.Visible;
      DrawableAwesome drable = new DrawableAwesome.DrawableAwesomeBuilder(this.RefreshButton.Context, Resources.GetString(Resource.String.fa_refresh)).build();
      this.RefreshButton.SetImageDrawable(drable);
    }
  }
}