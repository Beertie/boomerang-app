using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boomerang.Models
{
  public class Category
  {
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("tag")]
    public string Tag { get; set; }

    [JsonProperty("image")]
    public string Base64Image { get; set; }
  }
}
