using EntityFrameworkCore2.Domain.Common;

namespace EntityFrameworkCore2.Domain;

public class Team : BaseDomainObject
{
    public string Name { get; set; }

    public int LeagueId { get; set; }
    public League League { get; set; }

    public Coach Coach { get; set; }
    // es "Coach Coach" y no como abajo xq es "one to one" relationship, la otra seria one-to-many
    // public List<Coach> Coaches { get; set; }

    public virtual List<Match> HomeMatches { get; set; }
    public virtual List<Match> AwayMatches { get; set; }

}


//public class Coach : BaseDomainObject
//{
//    public string Name { get; set; }
//    public int? TeamId { get; set; }
//    public Team Team { get; set; }
//}