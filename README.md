# Microsoft.Graph.Api.Examples

## General Information

An example of how to use API provided by Microsoft Graph.

This example shows the usage of API for getting the **Planner** data such as:

- groups

- plan
- buckets
- tasks
- task details

more details about the API and the explorer can be found at:

[Graph Explorer | Try Microsoft Graph APIs - Microsoft Graph](https://developer.microsoft.com/en-us/graph/graph-explorer)

you might need to sign up for *Microsoft 365 Developer Program* to be able to access it.

## User Secrets

in the solution the user secrets are used for the sensitive data. Microsoft.Extensions.Configuration.UserSecrets package is used and the variables used in secrets.json are:

{
  "groupId": "YOUR_GROUP_ID",
  "planId": "YOUR_PLAN_ID",
  "taskId": "YOUR_TASK_ID",
  "token": "YOUR_ACCESS_TOKEN"
}

## Temporary Access Token

a temporary access token can be used for the testing purposes from the [Graph Explorer](https://developer.microsoft.com/en-us/graph/graph-explorer) page after you have logged in:

![](images\temporary_token.png)



## Permanent Access Token

To get a permanent access token, one needs to register an app with Azure AD, authorize and get a token from there.

more details and instructions can be found here:

https://learn.microsoft.com/en-us/graph/auth-v2-user

https://learn.microsoft.com/en-us/graph/auth-v2-service