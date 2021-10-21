using System.Collections.Generic;
using System.Net;
using BuyMyHouseAgentTableStorage.service;
using Domain;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace BuyMyHouseAgentTableStorage
{
    public  class Function1
    {
        public HouseService _houseService { get; set; }
        public Function1(HouseService houseService)
        {
            _houseService = houseService;
        }
        [Function("Function1")]
        public  HttpResponseData Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequestData req,
            FunctionContext executionContext)
        {
            var logger = executionContext.GetLogger("Function1");
            logger.LogInformation("C# HTTP trigger function processed a request.");

            var response = req.CreateResponse(HttpStatusCode.OK);
            response.Headers.Add("Content-Type", "text/plain; charset=utf-8");

            response.WriteString("Welcome to Azure Functions!");

            House house = new House()
            {
                City = "den haag",
                NbrRooms = 5,
                Price = 5000,
                Id = 2,
                status = Status.forSale
            };
            _houseService.insert(house);

            return response;
        }
    }
}
