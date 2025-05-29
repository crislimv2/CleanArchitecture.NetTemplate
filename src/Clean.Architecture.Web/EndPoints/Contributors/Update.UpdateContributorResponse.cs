using Clean.Architecture.Web.EndPoints.Contributors;

namespace Clean.Architecture.Web.Contributors;

public class UpdateContributorResponse(ContributorRecord contributor)
{
  public ContributorRecord Contributor { get; set; } = contributor;
}
