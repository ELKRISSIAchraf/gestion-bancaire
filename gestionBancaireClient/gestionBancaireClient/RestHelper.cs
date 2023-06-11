using gestionBancaireClient.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace gestionBancaireClient
{
    public static class RestHelper
    {
        private static readonly string baseURL = "https://localhost:7013/api/";
        public static Compte GetOne(string id)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(baseURL);
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var response = client.GetAsync(client.BaseAddress + "comptes/compte/" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                var data = response.Content.ReadAsStringAsync().Result;
                var compte = new Compte();
                JsonConvert.PopulateObject(data.ToString(), compte);

                return compte;
            }
            return null;
        }

        public static List<Compte> GetAll()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(baseURL);
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var response = client.GetAsync(client.BaseAddress + "comptes").Result;
            if (response.IsSuccessStatusCode)
            {
                var data = response.Content.ReadAsStringAsync().Result;
                var comptes = new List<Compte>();
                JsonConvert.PopulateObject(data.ToString(), comptes);

                return comptes;
            }
            return null;
        }
        public static void creditCompte(string id, float montant)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(baseURL);
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            HttpContent content = new StringContent(montant.ToString(), System.Text.Encoding.UTF8, "application/json");
            var response = client.PostAsync(client.BaseAddress + "comptes/" + id + "/credit", content).Result;
            if (response.IsSuccessStatusCode)
            {
                
            }
        }
        public static void debitCompte(string id, float montant)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(baseURL);
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            HttpContent content = new StringContent(montant.ToString(), System.Text.Encoding.UTF8, "application/json");
            var response = client.PostAsync(client.BaseAddress + "comptes/" + id + "/debit", content).Result;
            if (response.IsSuccessStatusCode)
            {

            }
        }
        public static void virementCompte(string id, string recipientId, float montant)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(baseURL);
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            HttpContent content = new StringContent(montant.ToString(), System.Text.Encoding.UTF8, "application/json");
            var response = client.PostAsync(client.BaseAddress + "comptes/" + id + "/virement/" + recipientId, content).Result;
            if (response.IsSuccessStatusCode)
            {

            }
        }
        public static List<Movement> GetAccountMovements()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(baseURL);
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var response = client.GetAsync(client.BaseAddress + "mouvements").Result;
            if (response.IsSuccessStatusCode)
            {
                var data = response.Content.ReadAsStringAsync().Result;
                var mouvements = new List<Movement>();
                JsonConvert.PopulateObject(data.ToString(), mouvements);

                return mouvements;
            }
            return null;
        }
    }
}
