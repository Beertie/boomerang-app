using Boomerang.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Boomerang.Services
{
  public interface IDownloadService
  {
    void Init(string webserviceUrl);

    Task<List<Tag>> GetTags();
    Task<List<Category>> GetCategories();
  }
}
