using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace Xamarin.Forms
{
    public class MonkeyServices
    {
        


        public MonkeyServices()
        {
            //client.MaxResponseContentBufferSize = 256000;
        }


        private ObservableCollection<Monkey> Monkeys {get;} = new ObservableCollection<Monkey>();


        public async Task<ObservableCollection<Monkey>> GetMonkeysAsync()
        {
            try
            {
                var client = new HttpClient();
                var json = await client.GetStringAsync("http://montemagno.com/monkeys.json").ConfigureAwait(false);
                
                var items = JsonConvert.DeserializeObject<List<Monkey>>(json);
                
                foreach(var item in items)
                    Monkeys.Add(item);
                  
            }
            catch(Exception ex)
            {   
                Debug.WriteLine(ex);
            }

            return Monkeys;
        }
    }
}

