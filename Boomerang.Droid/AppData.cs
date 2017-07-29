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
using Android.Graphics;
using Boomerang.Models;
using Boomerang.Services;
using System.Threading.Tasks;
using Android.Util;

namespace Boomerang.Droid
{
  public static class AppData
  {
    public static IDownloadService DownloadService;
    public static IDialogService DialogService;

    public static List<Tag> Tags { get; set; }
    public static List<Category> Categories { get; set; }

    public static Typeface FontAwesomeTypeface { get; set; }

    public static void Init()
    {
      Tags = new List<Tag>();

      FontAwesomeTypeface = Typeface.CreateFromAsset(Application.Context.Assets, "fonts/FontAwesome.ttf");

      DownloadService = new DownloadService();
      DialogService = new DialogService();

      DownloadService.Init("http://boomerang.huizendebeer.nl");
    }

    public static async Task LoadData()
    {
      try
      {
        Tags = await DownloadService.GetTags();
        Categories = await DownloadService.GetCategories();
      }
      catch (Exception ex)
      {
        throw new Exception(ex.Message);
      }
    }

    public static Bitmap Base64ToBitmap(string base64String)
    {
      byte[] imageAsBytes = Base64.Decode(base64String, Base64Flags.Default);
      return BitmapFactory.DecodeByteArray(imageAsBytes, 0, imageAsBytes.Length);
    }
  }
}