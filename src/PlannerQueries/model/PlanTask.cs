using System.Diagnostics;
using System.Text.Json.Serialization;

namespace PlannerQueries.Model
{
    [DebuggerDisplay("{Name}:{Id}")]
    public class PlanTask
    {
        public string odataetag { get; set; }
        public string planId { get; set; }
        public string bucketId { get; set; }
        [JsonPropertyName("title")]
        public string Name { get; set; }
        public string orderHint { get; set; }
        public string assigneePriority { get; set; }
        public int percentComplete { get; set; }
        public object startDateTime { get; set; }
        public DateTime createdDateTime { get; set; }
        public DateTime? dueDateTime { get; set; }
        public bool hasDescription { get; set; }
        public string previewType { get; set; }
        public DateTime? completedDateTime { get; set; }
        public Completedby completedBy { get; set; }
        public int referenceCount { get; set; }
        public int checklistItemCount { get; set; }
        public int activeChecklistItemCount { get; set; }
        public string conversationThreadId { get; set; }
        public int priority { get; set; }
        [JsonPropertyName("id")]
        public string Id { get; set; }
        public Createdby createdBy { get; set; }
        public Appliedcategories appliedCategories { get; set; }
        public Assignments assignments { get; set; }

        public class Completedby
        {
            public User user { get; set; }
            public Application application { get; set; }
        }

        public class User
        {
            public object displayName { get; set; }
            public string id { get; set; }
        }

        public class Application
        {
            public object displayName { get; set; }
            public string id { get; set; }
        }

        public class Createdby
        {
            public User1 user { get; set; }
            public Application1 application { get; set; }
        }

        public class User1
        {
            public object displayName { get; set; }
            public string id { get; set; }
        }

        public class Application1
        {
            public object displayName { get; set; }
            public string id { get; set; }
        }

        public class Appliedcategories
        {
            public bool category14 { get; set; }
            public bool category15 { get; set; }
            public bool category18 { get; set; }
            public bool category20 { get; set; }
            public bool category11 { get; set; }
            public bool category12 { get; set; }
            public bool category21 { get; set; }
            public bool category13 { get; set; }
            public bool category17 { get; set; }
            public bool category4 { get; set; }
            public bool category16 { get; set; }
            public bool category10 { get; set; }
            public bool category22 { get; set; }
            public bool category7 { get; set; }
            public bool category23 { get; set; }
            public bool category8 { get; set; }
            public bool category6 { get; set; }
            public bool category1 { get; set; }
            public bool category25 { get; set; }
            public bool category5 { get; set; }
        }

        public class Assignments
        {
            public _21Ef8eb8Ff50439685051F75313193b9 _21ef8eb8ff50439685051f75313193b9 { get; set; }
            public B0e89441E5cb4053AdfaA0f51ef3e5cd b0e89441e5cb4053adfaa0f51ef3e5cd { get; set; }
            public F465f360B8d04C129784D3c811650b87 f465f360b8d04c129784d3c811650b87 { get; set; }
            public _36D67a58Cc724275Bc2dF9d12ffa3719 _36d67a58cc724275bc2df9d12ffa3719 { get; set; }
            public C372ea1548E0428BB92bE575d21d93da c372ea1548e0428bb92be575d21d93da { get; set; }
            public D7085edf0F694Ee3Bf9953F5271621ad d7085edf0f694ee3bf9953f5271621ad { get; set; }
            public B352cc7760844D78A25b0B88131f85c2 b352cc7760844d78a25b0b88131f85c2 { get; set; }
            public _8E5f8e267Ebc4Cb58C5235F1cb379c4d _8e5f8e267ebc4cb58c5235f1cb379c4d { get; set; }
            public _84D551f9A18946FcBc7a92F2f802b11a _84d551f9a18946fcbc7a92f2f802b11a { get; set; }
            public _57F9c2e946Df4A3f8E08B41adc2ba064 _57f9c2e946df4a3f8e08b41adc2ba064 { get; set; }
        }

        public class _21Ef8eb8Ff50439685051F75313193b9
        {
            public string odatatype { get; set; }
            public DateTime assignedDateTime { get; set; }
            public string orderHint { get; set; }
            public Assignedby assignedBy { get; set; }
        }

        public class Assignedby
        {
            public User2 user { get; set; }
            public Application2 application { get; set; }
        }

        public class User2
        {
            public object displayName { get; set; }
            public string id { get; set; }
        }

        public class Application2
        {
            public object displayName { get; set; }
            public string id { get; set; }
        }

        public class B0e89441E5cb4053AdfaA0f51ef3e5cd
        {
            public string odatatype { get; set; }
            public DateTime assignedDateTime { get; set; }
            public string orderHint { get; set; }
            public Assignedby1 assignedBy { get; set; }
        }

        public class Assignedby1
        {
            public User3 user { get; set; }
            public Application3 application { get; set; }
        }

        public class User3
        {
            public object displayName { get; set; }
            public string id { get; set; }
        }

        public class Application3
        {
            public object displayName { get; set; }
            public string id { get; set; }
        }

        public class F465f360B8d04C129784D3c811650b87
        {
            public string odatatype { get; set; }
            public DateTime assignedDateTime { get; set; }
            public string orderHint { get; set; }
            public Assignedby2 assignedBy { get; set; }
        }

        public class Assignedby2
        {
            public User4 user { get; set; }
            public Application4 application { get; set; }
        }

        public class User4
        {
            public object displayName { get; set; }
            public string id { get; set; }
        }

        public class Application4
        {
            public object displayName { get; set; }
            public string id { get; set; }
        }

        public class _36D67a58Cc724275Bc2dF9d12ffa3719
        {
            public string odatatype { get; set; }
            public DateTime assignedDateTime { get; set; }
            public string orderHint { get; set; }
            public Assignedby3 assignedBy { get; set; }
        }

        public class Assignedby3
        {
            public User5 user { get; set; }
            public Application5 application { get; set; }
        }

        public class User5
        {
            public object displayName { get; set; }
            public string id { get; set; }
        }

        public class Application5
        {
            public object displayName { get; set; }
            public string id { get; set; }
        }

        public class C372ea1548E0428BB92bE575d21d93da
        {
            public string odatatype { get; set; }
            public DateTime assignedDateTime { get; set; }
            public string orderHint { get; set; }
            public Assignedby4 assignedBy { get; set; }
        }

        public class Assignedby4
        {
            public User6 user { get; set; }
            public Application6 application { get; set; }
        }

        public class User6
        {
            public object displayName { get; set; }
            public string id { get; set; }
        }

        public class Application6
        {
            public object displayName { get; set; }
            public string id { get; set; }
        }

        public class D7085edf0F694Ee3Bf9953F5271621ad
        {
            public string odatatype { get; set; }
            public DateTime assignedDateTime { get; set; }
            public string orderHint { get; set; }
            public Assignedby5 assignedBy { get; set; }
        }

        public class Assignedby5
        {
            public User7 user { get; set; }
            public Application7 application { get; set; }
        }

        public class User7
        {
            public object displayName { get; set; }
            public string id { get; set; }
        }

        public class Application7
        {
            public object displayName { get; set; }
            public string id { get; set; }
        }

        public class B352cc7760844D78A25b0B88131f85c2
        {
            public string odatatype { get; set; }
            public DateTime assignedDateTime { get; set; }
            public string orderHint { get; set; }
            public Assignedby6 assignedBy { get; set; }
        }

        public class Assignedby6
        {
            public User8 user { get; set; }
            public Application8 application { get; set; }
        }

        public class User8
        {
            public object displayName { get; set; }
            public string id { get; set; }
        }

        public class Application8
        {
            public object displayName { get; set; }
            public string id { get; set; }
        }

        public class _8E5f8e267Ebc4Cb58C5235F1cb379c4d
        {
            public string odatatype { get; set; }
            public DateTime assignedDateTime { get; set; }
            public string orderHint { get; set; }
            public Assignedby7 assignedBy { get; set; }
        }

        public class Assignedby7
        {
            public User9 user { get; set; }
            public Application9 application { get; set; }
        }

        public class User9
        {
            public object displayName { get; set; }
            public string id { get; set; }
        }

        public class Application9
        {
            public object displayName { get; set; }
            public string id { get; set; }
        }

        public class _84D551f9A18946FcBc7a92F2f802b11a
        {
            public string odatatype { get; set; }
            public DateTime assignedDateTime { get; set; }
            public string orderHint { get; set; }
            public Assignedby8 assignedBy { get; set; }
        }

        public class Assignedby8
        {
            public User10 user { get; set; }
            public Application10 application { get; set; }
        }

        public class User10
        {
            public object displayName { get; set; }
            public string id { get; set; }
        }

        public class Application10
        {
            public object displayName { get; set; }
            public string id { get; set; }
        }

        public class _57F9c2e946Df4A3f8E08B41adc2ba064
        {
            public string odatatype { get; set; }
            public DateTime assignedDateTime { get; set; }
            public string orderHint { get; set; }
            public Assignedby9 assignedBy { get; set; }
        }

        public class Assignedby9
        {
            public User11 user { get; set; }
            public Application11 application { get; set; }
        }

        public class User11
        {
            public object displayName { get; set; }
            public string id { get; set; }
        }

        public class Application11
        {
            public object displayName { get; set; }
            public string id { get; set; }
        }
    }

   

}