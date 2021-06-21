using Bogus;
using SpecFlowEasyHire.Models.HttpModels.Request;

namespace SpecFlowEasyHire.Utils
{
    public static class RequestDataGenerator
    {
        private const int SentenceLength = 5;
        private const int MinSuiteModeValue = 1;
        private const int MaxSuiteModeValue = 3;
        
        public static AddProjectData AddProjectDataRequest()
        {
            return new Faker<AddProjectData>()
                .RuleFor(data => data.Name, f => f.Company.CompanyName())
                .RuleFor(data => data.Announcement, f => f.Lorem.Sentence(SentenceLength))
                .RuleFor(data => data.ShowAnnouncement, f => f.Random.Bool())
                .RuleFor(data => data.SuiteMode, f => f.Random.Int(MinSuiteModeValue, MaxSuiteModeValue));
        }
    }
}