using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

public class IssueDto
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("key")]
    public string Key { get; set; }

    [JsonPropertyName("self")]
    public string Self { get; set; }

    [JsonPropertyName("fields")]
    public IssueFields Fields { get; set; }
}

public class IssueFields
{
    [JsonPropertyName("summary")]
    public string Summary { get; set; }

    [JsonPropertyName("status")]
    public Status Status { get; set; }

    [JsonPropertyName("assignee")]
    public User Assignee { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }
}

public class Status
{
    [JsonPropertyName("self")]
    public string Self { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }
}

public class User
{
    [JsonPropertyName("self")]
    public string Self { get; set; }

    [JsonPropertyName("accountId")]
    public string AccountId { get; set; }

    [JsonPropertyName("emailAddress")]
    public string EmailAddress { get; set; }

    [JsonPropertyName("avatarUrls")]
    public Dictionary<string, string> AvatarUrls { get; set; }

    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; }
}
