using System.Text.Json.Serialization;

public class CommentDetail
{
    [JsonPropertyName("comments")]
    public List<Comment> Comments { get; set; }

    [JsonPropertyName("self")]
    public string Self { get; set; }

    [JsonPropertyName("maxResults")]
    public int MaxResults { get; set; }

    [JsonPropertyName("total")]
    public int Total { get; set; }

    [JsonPropertyName("startAt")]
    public int StartAt { get; set; }
}

public class Comment
{
    [JsonPropertyName("self")]
    public string Self { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("author")]
    public CreatorDto Author { get; set; }

    [JsonPropertyName("body")]
    public Body Body { get; set; }

    [JsonPropertyName("updateAuthor")]
    public CreatorDto UpdateAuthor { get; set; }

    [JsonPropertyName("created")]
    public DateTime Created { get; set; }

    [JsonPropertyName("updated")]
    public DateTime Updated { get; set; }

    [JsonPropertyName("jsdPublic")]
    public bool JsdPublic { get; set; }
}

public class Body
{
    [JsonPropertyName("version")]
    public int Version { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("content")]
    public List<Content> Content { get; set; }
}

public class Content
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("content")]
    public List<TextContent> TextContents { get; set; }
}

public class TextContent
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("text")]
    public string Text { get; set; }
}
