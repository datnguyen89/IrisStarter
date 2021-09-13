using BusinessService;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerApp.Pages
{
    public partial class Index
    {
        [Inject] protected Greeter.GreeterClient _greeterClient { get; set; }
        private string responseMessage = "";
        private async void HandleClickHello()
        {
            try
            {
                var request = new HelloRequest();
                request.Name = "Server App";
                var response = await _greeterClient.SayHelloAsync(request);
                responseMessage = response.Message;
            }
            catch (Exception e)
            {
                responseMessage = e.Message;
            }
            StateHasChanged();
        }
    }
}
