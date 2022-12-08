using EntityFrameworkCore2.Domain.Common;

namespace EntityFrameworkCore2.Domain;

public class Coach : BaseDomainObject
{
    public string Name { get; set; }
    public int? TeamId { get; set; }
    public Team Team { get; set; }
}

//en Team.cs
// es "Coach Coach" y no como abajo xq es "one to one" relationship, la otra seria one-to-many
// public List<Coach> Coaches { get; set; }