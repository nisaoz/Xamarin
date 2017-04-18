using Ders5.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Ders5.Provider
{
    public class ServiceManager
    {
        private string url = "http://192.168.0.35/ServiceHub/api/aakademi/";

        //Servis katmanı her zmaan async yazılmalı
        private async Task<HttpClient> GetClient()
        {
            HttpClient client = new HttpClient();
            //Jsonla haberlesmek istedigimiz icin 
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            return client;
        }

        public async Task<IEnumerable<StudentModel>> GetAll()
        {
            HttpClient client = await GetClient();
            try
            {
                var result = await client.GetStringAsync(url + "getall");
                var mobileResult = JsonConvert.DeserializeObject<MobileResult>(result);
                return JsonConvert.DeserializeObject<IEnumerable<StudentModel>>(mobileResult.Data.ToString());
            }
            catch(Exception ex)
            {
                ex.Message.ToString();
                throw;
            }
        }

        public async Task<MobileResult> Insert(StudentModel model)
        {
            return await Process(model, "insert");
        }

        public async Task<MobileResult> Delete(StudentModel model)
        {
            return await Process(model, "delete");
        }

        public async Task<MobileResult> Update(StudentModel model)
        {
            return await Process(model, "update");
        }

        private async Task<MobileResult> Process(StudentModel model, string processType)
        {
            HttpClient client = await GetClient();
            //insert yapıldı
            var response = await client.PostAsync(url + processType,
                new StringContent(JsonConvert.SerializeObject(model),
                Encoding.UTF8, "application/json"));
            var mobileResult = await response.Content.ReadAsStringAsync();
            //insert isleminin cevabı alınıyor
            var result = JsonConvert.DeserializeObject<MobileResult>(mobileResult);
            return result;
        }
    }
}
