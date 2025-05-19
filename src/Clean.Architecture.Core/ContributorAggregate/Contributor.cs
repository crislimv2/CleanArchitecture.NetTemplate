using System.ComponentModel.DataAnnotations.Schema;

namespace Clean.Architecture.Core.ContributorAggregate;

[Table("contributors")]
public class Contributor(string name) : EntityBase, IAggregateRoot
{
  // Example of validating primary constructor inputs
  // See: https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/tutorials/primary-constructors#initialize-base-class
  [Column("name")]
  public string Name { get; private set; } = Guard.Against.NullOrEmpty(name, nameof(name));
  [Column("status")]
  public ContributorStatus Status { get; private set; } = ContributorStatus.NotSet;
  [Column("phone_number")]
  public PhoneNumber? PhoneNumber { get; private set; }

  public void SetPhoneNumber(string phoneNumber) => PhoneNumber = new PhoneNumber(string.Empty, phoneNumber, string.Empty);

  public void UpdateName(string newName) => Name = Guard.Against.NullOrEmpty(newName, nameof(newName));
}

public class PhoneNumber(string countryCode,
  string number,
  string? extension) : ValueObject
{
  [Column("country_code")]
  public string CountryCode { get; private set; } = countryCode;
  [Column("number")]
  public string Number { get; private set; } = number;
  [Column("extension")]
  public string? Extension { get; private set; } = extension;

  protected override IEnumerable<object> GetEqualityComponents()
  {
    yield return CountryCode;
    yield return Number;
    yield return Extension ?? String.Empty;
  }
}
