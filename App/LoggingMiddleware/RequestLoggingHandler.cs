using Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace App.LoggingMiddleware
{
    public class RequestLoggingHandler : DelegatingHandler
    {
        private RequestLogRepository repo;
        public RequestLoggingHandler()
        {
            this.repo = new RequestLogRepository();
        }
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var pocetak = DateTime.Now; // stopwatch?

            var response = await base.SendAsync(request, cancellationToken);

            var kraj = DateTime.Now;

            var log = new RequestLog
            {
                Request = JsonConvert.SerializeObject(new
                {
                    request.Content,
                    request.Headers,
                    request.Method,
                    request.RequestUri
                }),
                VrijemePocetka = pocetak,
                VrijemeKraja = kraj
            };

            repo.Insert(log);

            return response;
        }
    }
}