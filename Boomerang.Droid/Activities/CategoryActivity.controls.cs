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

namespace Boomerang.Droid.Activities
{
  public partial class CategoryActivity
  {
    private ImageButton currentPhotoImageButton;
    public ImageButton CurrentPhotoImageButton
    {
      get
      {
        if (this.currentPhotoImageButton != null)
          return currentPhotoImageButton;

        currentPhotoImageButton = FindViewById<ImageButton>(Resource.Id.currentPhotoImageButton);
        return currentPhotoImageButton;
      }
    }

    private ListView categoryListView;
    public ListView CategoryListView
    {
      get
      {
        if (this.categoryListView != null)
          return categoryListView;

        categoryListView = FindViewById<ListView>(Resource.Id.categoryListView);
        return categoryListView;
      }
    }
  }
}