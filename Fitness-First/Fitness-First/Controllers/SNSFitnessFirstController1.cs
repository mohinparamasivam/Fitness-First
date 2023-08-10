using Microsoft.AspNetCore.Mvc;
using Amazon;
using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Fitness_First.Controllers
{
    public class SNSFitnessFirstController1 : Controller
    {
        private const string topicARN = "arn:aws:sns:us-east-1:294334747370:SNSFitnessFirst";
        //function 1: create function to ge tback keys from appsettings.
        private List<string> getKeysInformation()
        {
            List<string> keys = new List<string>();
            var builder = new ConfigurationBuilder()
                            .SetBasePath(Directory.GetCurrentDirectory())
                            .AddJsonFile("appsettings.json");
            IConfiguration configure = builder.Build(); //build the file

            keys.Add(configure["Keys:Key1"]);
            keys.Add(configure["Keys:Key2"]);
            keys.Add(configure["Keys:Key3"]);

            return keys;
        }
        //function 2: the page will be used to collect the user email and do the subscription for them
        //Not Using
        public IActionResult Index() //subscribe SNS topics
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken] //register for the subscription
        public async Task<IActionResult> subscription(string EmailId)
        {
            List<string> keys = getKeysInformation();
            var snsClient = new AmazonSimpleNotificationServiceClient(keys[0], keys[1], keys[2], RegionEndpoint.USEast1);
            if (ModelState.IsValid)
            {
                try
                {
                    //add email as the subscriber
                    SubscribeRequest emailRequest = new SubscribeRequest(topicARN, "email", EmailId);
                    SubscribeResponse emailSubscribeResponse = await snsClient.SubscribeAsync(emailRequest);
                    var emailRequestId = emailSubscribeResponse.ResponseMetadata.RequestId;
                }
                catch (AmazonSimpleNotificationServiceException ex)
                {
                    return BadRequest(ex.Message);
                }
            }
            else
            {
                return BadRequest("Unable to subscribe any email!");
            }

            return Content("Email Subscibed! :) ");
        }
    }



}

