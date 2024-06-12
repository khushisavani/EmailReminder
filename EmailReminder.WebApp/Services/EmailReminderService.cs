using Blazored.LocalStorage;
using EmailReminder.Shared.Models;
﻿using EmailReminder.Shared.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace EmailReminder.WebApp.Services
{
    public class EmailReminderService
    {
        private readonly HttpClient _client;

        public EmailReminderService(
            HttpClient client)
        {
            _client = client;
        }

        public async Task<Reminder> CreateReminderAsync(Reminder reminder)
        {
            var content = new StringContent(JsonConvert.SerializeObject(reminder), Encoding.UTF8, "application/json");

            var result = await _client.PostAsync($"/api/reminders", content);

            if (!result.IsSuccessStatusCode)
            {
                throw new Exception("Could not create reminder.");
            }

            var resultContent = await result.Content.ReadAsStringAsync();
            var resultReminder = JsonConvert.DeserializeObject<Reminder>(resultContent);

            return resultReminder;
        }
      
    }
}
