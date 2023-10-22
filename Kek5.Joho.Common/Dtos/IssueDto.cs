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
    [JsonPropertyName("statuscategorychangedate")]
    public string StatusCategoryChangeDate { get; set; }

    [JsonPropertyName("issuetype")]
    public IssueType IssueType { get; set; }

    [JsonPropertyName("timespent")]
    public string TimeSpent { get; set; }

    [JsonPropertyName("customfield_10030")]
    public string CustomField10030 { get; set; }

    [JsonPropertyName("project")]
    public Project Project { get; set; }

    [JsonPropertyName("fixVersions")]
    public List<string> FixVersions { get; set; } 

    [JsonPropertyName("aggregatetimespent")]
    public int? AggregateTimeSpent { get; set; }

    [JsonPropertyName("resolutiondate")]
    public DateTime? ResolutionDate { get; set; }

    [JsonPropertyName("workratio")]
    public int WorkRatio { get; set; }

    [JsonPropertyName("watches")]
    public WatchesDto Watches { get; set; }

    [JsonPropertyName("issuerestriction")]
    public IssueRestrictionDto IssueRestriction { get; set; }

    [JsonPropertyName("lastViewed")]
    public DateTime LastViewed { get; set; }

    [JsonPropertyName("created")]
    public DateTime Created { get; set; }

    [JsonPropertyName("priority")]
    public PriorityDto Priority { get; set; }

    [JsonPropertyName("labels")]
    public List<string> Labels { get; set; }

    [JsonPropertyName("aggregatetimeoriginalestimate")]
    public int? AggregateTimeOriginalEstimate { get; set; }

    [JsonPropertyName("timeestimate")]
    public int? TimeEstimate { get; set; }

    [JsonPropertyName("issuelinks")]
    public List<IssueLinkDto> IssueLinks { get; set; }

    [JsonPropertyName("assignee")]
    public AssigneeDto Assignee { get; set; }

    [JsonPropertyName("updated")]
    public DateTime Updated { get; set; }

    [JsonPropertyName("status")]
    public StatusDto Status { get; set; }

    [JsonPropertyName("attachment")]
    public AttachmentDto Attachment { get; set; }

    [JsonPropertyName("summary")]
    public string Summary { get; set; }

    [JsonPropertyName("creator")]
    public CreatorDto Creator { get; set; }

    [JsonPropertyName("reporter")]
    public CreatorDto Reporter { get; set; }
   
    [JsonPropertyName("comment")]
    public CommentDetail Comment { get; set; }
    // subtasks 
}

public class IssueType 
{
    [JsonPropertyName("self")]
    public string Self { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("iconUrl")]
    public string IconUrl { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("subtask")]
    public bool Subtask { get; set; }

    [JsonPropertyName("avatarId")]
    public int AvatarId { get; set; }

    [JsonPropertyName("entityId")]
    public string EntityId { get; set; }

    [JsonPropertyName("hierarchyLevel")]
    public int HierarchyLevel { get; set; }
}

public class Project 
{
    [JsonPropertyName("self")]
    public string Self { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("key")]
    public string Key { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("projectTypeKey")]
    public string ProjectTypeKey { get; set; }

    [JsonPropertyName("simplified")]
    public bool Simplified { get; set; }

    [JsonPropertyName("avatarUrls")]
    public AvatarUrls AvatarUrls { get; set; }

}

public class WatchesDto
{
    [JsonPropertyName("self")]
    public string Self { get; set; }

    [JsonPropertyName("watchCount")]
    public int WatchCount { get; set; }

    [JsonPropertyName("isWatching")]
    public bool IsWatching { get; set; }
}

public class IssueRestrictionDto
{
    [JsonPropertyName("issuerestrictions")]
    public object IssueRestrictions { get; set; }

    [JsonPropertyName("shouldDisplay")]
    public bool ShouldDisplay { get; set; }
}

public class PriorityDto
{
    [JsonPropertyName("self")]
    public string Self { get; set; }

    [JsonPropertyName("iconUrl")]
    public string IconUrl { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }
}

public class IssueLinkDto
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("self")]
    public string Self { get; set; }

    [JsonPropertyName("type")]
    public IssueLinkTypeDto Type { get; set; }

    [JsonPropertyName("inwardIssue")]
    public InwardIssueDto InwardIssue { get; set; }
}

public class IssueLinkTypeDto
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("inward")]
    public string Inward { get; set; }

    [JsonPropertyName("outward")]
    public string Outward { get; set; }

    [JsonPropertyName("self")]
    public string Self { get; set; }
}

public class InwardIssueDto
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("key")]
    public string Key { get; set; }

    [JsonPropertyName("self")]
    public string Self { get; set; }

    [JsonPropertyName("fields")]
    public InwardIssueFieldsDto Fields { get; set; }
}

public class InwardIssueFieldsDto
{
    [JsonPropertyName("summary")]
    public string Summary { get; set; }

    [JsonPropertyName("status")]
    public StatusDto Status { get; set; }

    [JsonPropertyName("priority")]
    public PriorityDto Priority { get; set; }

    [JsonPropertyName("issuetype")]
    public IssueTypeDto IssueType { get; set; }
}

public class StatusDto
{
    [JsonPropertyName("self")]
    public string Self { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("iconUrl")]
    public string IconUrl { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("statusCategory")]
    public StatusCategoryDto StatusCategory { get; set; }
}

public class StatusCategoryDto
{
    [JsonPropertyName("self")]
    public string Self { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("key")]
    public string Key { get; set; }

    [JsonPropertyName("colorName")]
    public string ColorName { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }
}

public class IssueTypeDto 
{
    [JsonPropertyName("self")]
    public string Self { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("iconUrl")]
    public string IconUrl { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("subtask")]
    public bool Subtask { get; set; }

    [JsonPropertyName("avatarId")]
    public int AvatarId { get; set; }

    [JsonPropertyName("entityId")]
    public string EntityId { get; set; }

    [JsonPropertyName("hierarchyLevel")]
    public int HierarchyLevel { get; set; }
}

public class AssigneeDto
{
    [JsonPropertyName("self")]
    public string Self { get; set; }

    [JsonPropertyName("accountId")]
    public string AccountId { get; set; }

    [JsonPropertyName("emailAddress")]
    public string EmailAddress { get; set; }

    [JsonPropertyName("avatarUrls")]
    public AvatarUrls AvatarUrls { get; set; }

    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; }

    [JsonPropertyName("active")]
    public bool Active { get; set; }

    [JsonPropertyName("timeZone")]
    public string TimeZone { get; set; }

    [JsonPropertyName("accountType")]
    public string AccountType { get; set; }
}


public class CreatorDto
{
    [JsonPropertyName("self")]
    public string Self { get; set; }

    [JsonPropertyName("accountId")]
    public string AccountId { get; set; }

    [JsonPropertyName("emailAddress")]
    public string EmailAddress { get; set; }

    [JsonPropertyName("avatarUrls")]
    public AvatarUrls AvatarUrls { get; set; }

    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; }

    [JsonPropertyName("active")]
    public bool Active { get; set; }

    [JsonPropertyName("timeZone")]
    public string TimeZone { get; set; }

    [JsonPropertyName("accountType")]
    public string AccountType { get; set; }
}
