using System.Collections.Generic;
using System.Linq;
using Humanizer;
using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using SpecFlowEasyHire.Constants;
using SpecFlowEasyHire.Models.HttpModels.Request;
using SpecFlowEasyHire.Models.HttpModels.Response;
using SpecFlowEasyHire.Utils;
using TechTalk.SpecFlow;

namespace SpecFlowEasyHire.Steps.TestRailApi
{
    [Binding]
    public sealed class TestRailProjectSteps
    {
        private readonly ScenarioContext _scenarioContext;

        public TestRailProjectSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [When("uri for add project")]
        public void WhenUriForAddProject()
        {
            _scenarioContext.Set<IRestRequest>(GetRequest(ApiConstants.AddProjectUri, Method.POST));
        }

        [When("body for add project created")]
        public void WhenBodyForAddProjectCreated()
        {
            var addProjectDataBody = RequestDataGenerator.AddProjectDataRequest();
            _scenarioContext.Set<AddProjectData>(addProjectDataBody);
            _scenarioContext.Get<IRestRequest>()
                .AddJsonBody(JsonConvert.SerializeObject(addProjectDataBody));
        }

        [When("send api request")]
        public void WhenSendApiRequest()
        {
            _scenarioContext.Set(new RestClient(ApiConstants.BaseApiUrl).Execute(_scenarioContext.Get<IRestRequest>()));
        }

        [Then("check status code (.*)")]
        public void ThenCheckStatusCode(string statusCode)
        {
            Assert.AreEqual(statusCode, _scenarioContext.Get<IRestResponse>().StatusCode.Humanize(), $"Status code should be equals [{statusCode}]");
        }

        [Then("check project body from response")]
        public void ThenCheckProjectBodyFromResponse()
        {
            var projectResponse = JsonConvert.DeserializeObject<Project>(_scenarioContext.Get<IRestResponse>().Content);
            Assert.Multiple(() =>
            {
                Assert.AreEqual(_scenarioContext.Get<AddProjectData>().Name, projectResponse.Name,
                    "Name should be equals");
                Assert.AreEqual(_scenarioContext.Get<AddProjectData>().Announcement, projectResponse.Announcement,
                    "Announcement should be equals");
                Assert.AreEqual(_scenarioContext.Get<AddProjectData>().ShowAnnouncement,
                    projectResponse.ShowAnnouncement, "Show announcement should be equals");
                Assert.AreEqual(_scenarioContext.Get<AddProjectData>().SuiteMode, projectResponse.SuiteMode,
                    "Suite mode should be equals");
            });
        }

        [When("uri for get all projects")]
        public void WhenUriForGetAllProjects()
        {
            _scenarioContext.Set<IRestRequest>(new RestRequest(ApiConstants.GetProjectsUri, Method.GET)
                .AddHeader("Authorization", ApiConstants.BasicToken));
        }

        [When("uri for delete last project")]
        public void WhenUriForDeleteLastProject()
        {
            _scenarioContext.Set<IRestRequest>(GetRequest(ApiConstants.DeleteProjectUri, Method.POST)
                .AddUrlSegment("projectId", _scenarioContext.Get<int>("LastProjectId")));
        }

        [When("get id last project")]
        public void WhenGetIdLastProject()
        {
            var allProjectsResponse = new RestClient(ApiConstants.BaseApiUrl).Execute(GetRequest(ApiConstants.GetProjectsUri, Method.GET));
            _scenarioContext.Set(JsonConvert.DeserializeObject<List<Project>>(allProjectsResponse.Content).Last().Id,
                "LastProjectId");
        }
        
        private IRestRequest GetRequest(string uri, Method method) => new RestRequest(uri, method)
            .AddHeader("Content-Type", "application/json")
            .AddHeader("Authorization", ApiConstants.BasicToken);
    }
}