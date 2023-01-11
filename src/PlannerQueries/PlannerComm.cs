using PlannerQueries.Model;
using Refit;

namespace PlannerQueries
{
    public class PlannerComm
    {
        private readonly IMicrosoftGraph _api;

        public static PlannerComm FromToken(string token)
        {
            return new PlannerComm(token);
        }

        public PlannerComm(string token)
        {
            _api = RestService.For<IMicrosoftGraph>("https://graph.microsoft.com/v1.0", new RefitSettings()
            {
                AuthorizationHeaderValueGetter = () => Task.FromResult(token),
                ContentSerializer = SerializationHelper.GetContentSerializer()
                
            });
        }

        public async Task<ApiResult<Group>> GetGroupsAsync()
        {
            ApiResult<Group> result = await _api.GetMyGroupsAsync().ConfigureAwait(false);
            return result;
        }

        public async Task<ApiResult<Plan>> GetPlansAsync(string groupId)
        {
            ApiResult<Plan> result = await _api.GetGroupPlansAsync(groupId).ConfigureAwait(false);
            return result;
        }

        public async Task<ApiResult<Bucket>> GetBucketsAsync(string planId)
        {
            ApiResult<Bucket> result = await _api.GetPlanBucketsAsync(planId).ConfigureAwait(false);
            return result;
        }

        public async Task<ApiResult<PlanTask>> GetTasksAsync(string planId)
        {
            ApiResult<PlanTask> result = await _api.GetPlanTasksAsync(planId).ConfigureAwait(false);
            return result;
        }

        public async Task<TaskDetails> GetTaskDetailsAsync(string taskId)
        {
            TaskDetails result = await _api.GetTaskDetailsAsync(taskId).ConfigureAwait(false);
            return result;
        }
    }
}