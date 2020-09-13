using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Assignment1_WorkerService
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly string _url = "https://google.com";

        private HttpClient _client;
        private HttpResponseMessage _result;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        public override Task StartAsync(CancellationToken cancellationToken)
        {
            _client = new HttpClient();
            _logger.LogInformation("Service has started");
            
            return base.StartAsync(cancellationToken);
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            _client.Dispose();
            _logger.LogInformation("Service has stopped");
            return base.StopAsync(cancellationToken);
        }



        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    _result = await _client.GetAsync(_url);
                    _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);

                    if (_result.IsSuccessStatusCode)
                        _logger.LogInformation($"The website ({_url})is up. Status Code = {_result.StatusCode}");
                    else
                        _logger.LogInformation($"The website ({_url})is down. Status Code = {_result.StatusCode}");
                }
                catch (Exception ex)
                {
                    _logger.LogInformation($"Failed, the website ({_url}) - {ex.Message}");
                }


                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
