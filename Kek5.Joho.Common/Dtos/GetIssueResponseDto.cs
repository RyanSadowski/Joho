using System;
using System.Text.Json.Serialization;

namespace Kek5.Joho.Common.Dtos;
public class IssueDetail
{
	[JsonPropertyName("id")]
	public string Id { get; set; }

	[JsonPropertyName("self")]
	public string Self { get; set; }

	[JsonPropertyName("key")]
	public string Key { get; set; }

	[JsonPropertyName("fields")]
	public Fields Fields { get; set; }
}

public class Fields
{
	[JsonPropertyName("summary")]
	public string Summary { get; set; }

	[JsonPropertyName("status")]
	public Status Status { get; set; }

	[JsonPropertyName("assignee")]
	public Assignee Assignee { get; set; }

	[JsonPropertyName("description")]
	public string Description { get; set; }

}
