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
using Boomerang.Models;

namespace Boomerang.Droid.Adapters
{
  public class CategoryListAdapter : BaseAdapter<Category>
  {
    private List<Category> items;
    private readonly Activity context;

    public CategoryListAdapter(Activity activity, List<Category> Categorys)
    {
      this.items = Categorys;
      this.context = activity;

      this.SetData(this.items);
    }

    public override long GetItemId(int position)
    {
      return position;
    }

    public override View GetView(int position, View convertView, ViewGroup parent)
    {
      var view = convertView ?? this.context.LayoutInflater.Inflate(Resource.Layout.CategoryListItemView, null);
      var item = this.items[position];

      view.FindViewById<TextView>(Resource.Id.categoryListItemTitle).Text = item.Tag.First().ToString().ToUpper() + item.Tag.Substring(1);
      view.FindViewById<ImageView>(Resource.Id.categoryListItemImageView).SetImageBitmap(AppData.Base64ToBitmap(item.Base64Image));

      return view;
    }

    /// <summary>
    /// Add new data to the adapter and reapply filter
    /// </summary>
    /// <param name="Categorys"></param>
    public void SetData(List<Category> Categorys)
    {
      this.items = Categorys;

      // Notify that the data has changed so list is updated
      this.NotifyDataSetChanged();
    }

    public override int Count
    {
      get { return this.items.Count; }
    }

    public override Category this[int position]
    {
      get { return this.items[position]; }
    }
  }
}