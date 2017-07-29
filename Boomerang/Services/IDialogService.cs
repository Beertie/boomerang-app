using System;
using System.Collections.Generic;
using System.Text;

namespace Boomerang.Services
{
  public interface IDialogService
  {
    void ShowAlertDialog(string title, string message, object context);
    object ShowLoadingDialog(object context);
  }
}
