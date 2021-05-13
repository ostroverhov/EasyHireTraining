using Bogus;
using SpecFlowEasyHire.Models.HttpModels.Request;

namespace SpecFlowEasyHire.Utils
{
    public static class RequestDataGenerator
    {
        private static readonly Faker Faker = new Faker();
        private const int SentenceLength = 5;
        private const int MinSuiteModeValue = 1;
        private const int MaxSuiteModeValue = 3;
        
        public static AddProjectData AddProjectDataRequest()
        {
            return new AddProjectData
            {
                Name = Faker.Company.CompanyName(),
                Announcement = Faker.Lorem.Sentence(SentenceLength),
                ShowAnnouncement = Faker.Random.Bool(),
                SuiteMode = Faker.Random.Int(MinSuiteModeValue, MaxSuiteModeValue)
            };
        }
    }
}