using System.Text.Json.Serialization;

public class Attachment
{
    [JsonPropertyName("self")]
    public string Self { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("filename")]
    public string Filename { get; set; }

    [JsonPropertyName("author")]
    public AuthorDto Author { get; set; }

    [JsonPropertyName("created")]
    public DateTime Created { get; set; }

    [JsonPropertyName("size")]
    public int Size { get; set; }

    [JsonPropertyName("mimeType")]
    public string MimeType { get; set; }

    [JsonPropertyName("content")]
    public string Content { get; set; }

    [JsonPropertyName("thumbnail")]
    public string Thumbnail { get; set; }
}

public class AuthorDto
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

public class AvatarUrls
{
    [JsonPropertyName("48x48")]
    public string Size48x48 { get; set; }

    [JsonPropertyName("24x24")]
    public string Size24x24 { get; set; }

    [JsonPropertyName("16x16")]
    public string Size16x16 { get; set; }

    [JsonPropertyName("32x32")]
    public string Size32x32 { get; set; }
}
