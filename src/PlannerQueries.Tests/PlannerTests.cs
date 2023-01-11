using Xunit;
using PlannerQueries.Model;
using Microsoft.Extensions.Configuration;

namespace PlannerQueries.Tests
{
    public class PlannerTests
    {
        IConfigurationRoot _configuration;

        public PlannerTests()
        {
            _configuration = new ConfigurationBuilder()
               .AddUserSecrets<PlannerTests>(false)
               .Build();
        }

        [Fact]
        public async Task CanGetGroups()
        {
            PlannerComm comm = GetPlanner();
            ApiResult<Group> result = await comm.GetGroupsAsync();
            Assert.NotEmpty(result.Items);
        }

        private PlannerComm GetPlanner()
        {
            return PlannerComm.FromToken(_configuration["token"]);
        }

        [Fact]
        public async Task CanGetPlans()
        {
            string groupId = _configuration["groupId"];

            PlannerComm comm = GetPlanner();
            ApiResult<Plan> result = await comm.GetPlansAsync(groupId);
            Assert.NotEmpty(result.Items);
        }

        [Fact]
        public async Task CanGetBuckets()
        {
            string planId = _configuration["planId"];

            PlannerComm comm = GetPlanner();
            ApiResult<Bucket> result = await comm.GetBucketsAsync(planId);
            Assert.NotEmpty(result.Items);
        }

        [Fact]
        public async Task CanGetTasks()
        {
            string planId = _configuration["planId"];

            PlannerComm comm = GetPlanner();
            ApiResult<PlanTask> result = await comm.GetTasksAsync(planId);
            Assert.NotEmpty(result.Items);
        }

        [Fact]
        public async Task CanGetTaskDetails()
        {
            string taskId = _configuration["taskId"];
            PlannerComm comm = GetPlanner();
            TaskDetails result = await comm.GetTaskDetailsAsync(taskId);
            Assert.NotNull(result.Description);
        }
    }
}