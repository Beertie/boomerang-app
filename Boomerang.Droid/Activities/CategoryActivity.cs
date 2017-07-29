using System;
using System.Linq;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;
using Boomerang.Models;
using Android.Graphics;
using Android.Support.V7.App;
using Boomerang.Droid.Adapters;
using Android.Util;

namespace Boomerang.Droid.Activities
{
  [Activity(Theme = "@style/Theme.Boomerang", Icon = "@drawable/ic_launcher", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait, WindowSoftInputMode = SoftInput.StateHidden)]
  public partial class CategoryActivity : RootActivity
  {
    CategoryListAdapter listAdapter;

    protected override void OnCreate(Bundle bundle)
    {
      base.OnCreate(bundle);

      LayoutInflater.Inflate(Resource.Layout.CategoryPage, this.RootLinearLayout);

      base.SupportActionBar.Title = "Boomerang";

      this.listAdapter = new CategoryListAdapter(this, AppData.Categories);
      this.CategoryListView.Adapter = this.listAdapter;
    }

    #region Menu

    /// <summary>
    /// Inflate the menu items for use in the action bar
    /// </summary>
    /// <param name="menu"></param>
    /// <returns></returns>
    public override bool OnCreateOptionsMenu(IMenu menu)
    {
      //if (AppData.Roles.Where(r => r.RoleId == "90").Count() > 0)
      //  MenuInflater.Inflate(Resource.Menu.menuOverflowMenuWithSettings, menu);
      //else
      //  MenuInflater.Inflate(Resource.Menu.menuOverflowMenu, menu);

      return true;
    }

    /// <summary>
    /// Event handlers for selecting a menu item
    /// </summary>
    /// <param name="item"></param>
    /// <returns></returns>
    public override bool OnOptionsItemSelected(IMenuItem item)
    {
      //if (item.TitleFormatted.ToString() == "Uitloggen")
      //}

      return true;
    }

    #endregion
  }
}