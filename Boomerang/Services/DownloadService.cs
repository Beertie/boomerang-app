using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Boomerang.Models;
using RestSharp;
using Boomerang.Serialization;
using System.Net;

namespace Boomerang.Services
{
  public class DownloadService : IDownloadService
  {
    private RestClient client;

    public void Init(string webserviceUrl)
    {
      client = new RestClient(webserviceUrl);
      client.Timeout = 10000;

      // Override with Newtonsoft JSON Handler
      client.AddHandler("application/json", NewtonsoftJsonSerializer.Default);
      client.AddHandler("text/json", NewtonsoftJsonSerializer.Default);
      client.AddHandler("text/x-json", NewtonsoftJsonSerializer.Default);
      client.AddHandler("text/javascript", NewtonsoftJsonSerializer.Default);
      client.AddHandler("*+json", NewtonsoftJsonSerializer.Default);

      // Manual SSL Certificate validation to prevent errors
      ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
    }

    public async Task<List<Tag>> GetTags()
    {
      var request = new RestRequest("/api/tags.json", Method.GET);

      var response = await client.ExecuteTaskAsync<Result<List<Tag>>>(request);

      if (response != null)
      {
        if (response.StatusCode == System.Net.HttpStatusCode.OK)
        {
          if (response.Data == null)
            throw new Exception("Converteren van de data is mislukt. Blijft deze melding zich voordoen, neem dan contact op met Datamex Automatisering.");

          if (response.Data.Success)
            return response.Data.Data;

          throw new Exception(response.Data.Message);
        }
        else
        {
          throw new Exception(string.Format("Er is een serverfout opgetreden. Controleer de webservice. \nMelding: {0}", response.StatusDescription));
        }
      }
      throw new Exception(response.ErrorMessage);
    }

    public async Task<List<Category>> GetCategories()
    {
      var request = new RestRequest("/api/categories.json", Method.GET);

      var response = await client.ExecuteTaskAsync<Result<List<Category>>>(request);

      if (response != null)
      {
        if (response.StatusCode == System.Net.HttpStatusCode.OK)
        {
          if (response.Data == null)
            throw new Exception("Converteren van de data is mislukt. Blijft deze melding zich voordoen, neem dan contact op met Datamex Automatisering.");

          if (response.Data.Success)
            return response.Data.Data;

          throw new Exception(response.Data.Message);
        }
        else
        {
          throw new Exception(string.Format("Er is een serverfout opgetreden. Controleer de webservice. \nMelding: {0}", response.StatusDescription));
        }
      }
      throw new Exception(response.ErrorMessage);
    }
  }
}
