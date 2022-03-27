using NUnit.Framework;
using RestSharp;
using SpecFlowProject_livingDoc.Base;
using SpecFlowProject_livingDoc.Utilities;
using System.Threading;
using TechTalk.SpecFlow;

namespace SpecFlowProject_livingDoc.Steps
{
    [Binding]
    public sealed class UserStepDefinitions
    {


        private Settings _settings;
        public UserStepDefinitions(Settings settings) => _settings = settings;

        [Given(@"I perform GET operation for (.*)")]
        public void GivenIPerformGETOperationFor(string url)
        {

            _settings.Request = new RestRequest(url, Method.GET);
        }

        [When(@"I perform operation for user (.*)")]
        public void GivenIPerformOperationForPost(int userid)
        {
            Thread.Sleep(2000);
            _settings.Request.AddUrlSegment("userid", userid.ToString());
            _settings.Response = _settings.RestClient.ExecuteAsyncRequests<Model.Users>(_settings.Request).GetAwaiter().GetResult();
        }

        [Then(@"I should see the (.*) as (.*)")]
        public void ThenIShouldSeeTheNameAs(string key, string value)
        {
            Assert.That(_settings.Response.GetResponseObject(key), Is.EqualTo(value), $"The {key} is not matching");
        }

    }
}
