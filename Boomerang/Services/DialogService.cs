using Android.App;
using System;
using System.Collections.Generic;
using System.Text;

namespace Boomerang.Services
{
  public class DialogService : IDialogService
  {
    public void ShowAlertDialog(string title, string message, object context)
    {
      var activity = context as Activity;

      // Create dialog, disable the cancel button and close on OK button click
      var dialog = new AlertDialog.Builder(activity)
                         .SetTitle(title)
                         .SetMessage(message)
                         .SetCancelable(false)
                         .SetPositiveButton("OK", (s, e) =>
                         {
                           var dlg = s as AlertDialog;
                           dlg.Cancel();
                         });

      // Show dialog
      activity.RunOnUiThread(() =>
      {
        dialog.Show();
      });
    }

    public object ShowLoadingDialog(object context)
    {
      var activity = context as Activity;

      ProgressDialog dialog = new ProgressDialog(activity);
      dialog.SetMessage("Verwerken...");
      dialog.Indeterminate = true;
      dialog.SetProgressStyle(ProgressDialogStyle.Spinner);
      dialog.SetCancelable(false);
      dialog.SetCanceledOnTouchOutside(false);

      // Show dialog
      activity.RunOnUiThread(() =>
      {
        dialog.Show();
      });

      return dialog;
    }
  }
}
