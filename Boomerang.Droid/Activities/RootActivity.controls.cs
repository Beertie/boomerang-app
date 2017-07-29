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
using Toolbar = Android.Support.V7.Widget.Toolbar;
using Android.Support.Design.Widget;

namespace Boomerang.Droid.Activities
{
  public partial class RootActivity
  {
    private LinearLayout rootLinearLayout;
    public LinearLayout RootLinearLayout
    {
      get
      {
        if (this.rootLinearLayout != null)
          return rootLinearLayout;

        rootLinearLayout = FindViewById<LinearLayout>(Resource.Id.rootLinearLayout);
        return rootLinearLayout;
      }
    }

    private FloatingActionButton refreshButton;
    public FloatingActionButton RefreshButton
    {
      get
      {
        if (this.refreshButton != null)
          return refreshButton;

        refreshButton = FindViewById<FloatingActionButton>(Resource.Id.refreshButton);
        return refreshButton;
      }
    }

    private Toolbar toolbar;
    public Toolbar Toolbar
    {
      get
      {
        if (this.toolbar != null)
          return toolbar;

        toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
        return toolbar;
      }
    }
  }
}