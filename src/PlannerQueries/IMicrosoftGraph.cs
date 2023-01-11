using PlannerQueries.Model;
using Refit;

namespace PlannerQueries
{
    internal interface IMicrosoftGraph
    {
        [Get("/me/memberOf")]
        [Headers("Authorization: Bearer")]
        Task<ApiResult<Group>> GetMyGroupsAsync();

        [Get("/groups/{groupId}/planner/plans")]
        [Headers("Authorization: Bearer")]
        Task<ApiResult<Plan>> GetGroupPlansAsync(string groupId);

        [Get("/planner/plans/{planId}/buckets")]
        [Headers("Authorization: Bearer")]
        Task<ApiResult<Bucket>> GetPlanBucketsAsync(string planId);

        [Get("/planner/plans/{planId}/tasks")]
        [Headers("Authorization: Bearer")]
        Task<ApiResult<PlanTask>> GetPlanTasksAsync(string planId);

        [Get("/planner/tasks/{taskId}/details")]
        [Headers("Authorization: Bearer")]
        Task<TaskDetails> GetTaskDetailsAsync(string taskId);

    }
}
