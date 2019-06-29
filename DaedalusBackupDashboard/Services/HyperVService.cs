using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using DaedalusBackupDashboard.Data;
using Microsoft.AspNetCore.Components;


namespace DaedalusBackupDashboard.Services 
{
    public class HyperVService
    {
        private readonly HttpClient _httpClient;
        private string _baseUrl = "http://local-daedalusapi.com/api/hyperv";

        public HyperVService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<VirtualMachine>> GetVMs()
        {
            Console.WriteLine("Hello world");
            //HttpClient httpClient = new HttpClient();
            //return await httpClient.GetJsonAsync<List<VirtualMachine>>("http://localhost:4000/api/hyperv/virtualmachines");
            return await _httpClient.GetJsonAsync<List<VirtualMachine>>($"{_baseUrl}/virtualmachines");
        }
    }
}