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

    //public interface INoteApi
    //{
    //    [Get("/api/v1/notes")]
    //    Task<NotesResponse> GetNotes(NoteQueryParameters parameters = null);

    //    [Get("/api/v1/notes/{id}")]
    //    Task<NoteResponse> GetNoteById(string id);

    //    [Post("/api/v1/notes")]
    //    Task<string> Create([Body] CreateNoteRequest createNoteRequest);

    //    [Put("/api/v1/notes/{id}")]
    //    Task<HttpResponseMessage> Update(string id, [Body] UpdateNoteRequest updateNoteRequest);

    //    [Delete("/api/v1/notes/{id}")]
    //    Task<HttpResponseMessage> Delete(string id);
    //}
}
