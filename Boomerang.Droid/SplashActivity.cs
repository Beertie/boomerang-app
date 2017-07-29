using System;
using System.Collections.Generic;
using System.Linq;

using Android.App;
using Android.OS;
using System.Threading;
using Boomerang.Droid.Activities;
using Boomerang.Models;
using Boomerang.Droid;

namespace Datamex.Projects.Nassau.Droid
{
  [Activity(Theme = "@style/Theme.Splash", MainLauncher = true, NoHistory = true)]
  public class SplashActivity : Activity
  {
    public SplashActivity()
    {
      Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
    }

    protected async override void OnCreate(Bundle bundle)
    {
      base.OnCreate(bundle);

      AppData.Init();

      var dialog = AppData.DialogService.ShowLoadingDialog(this) as ProgressDialog;
      try
      {
        await AppData.LoadData();
      }
      catch (Exception ex)
      {
        throw new Exception(ex.Message);
      }
      finally
      {
        dialog.Cancel();
      }

      StartActivity(typeof(CategoryActivity));
    }
  }
}