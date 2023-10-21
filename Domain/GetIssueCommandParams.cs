using Kek5.Joho.Emums;

namespace Kek5.Joho;

public class GetIssueCommandParams {
    public Commands Command { get 
        {
            return Commands.GetIssue;
        }
    }

    public String ProjectKey { get 
        {
            return "ROCK";
        }
    }

    public String IssueId { get; set; } = "1";

    public String IssueKey { get 
        {
            return $"{ProjectKey}-{IssueId}";
        }
    }   
}
