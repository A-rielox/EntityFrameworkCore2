using EntityFrameworkCore2.Domain.Common;

namespace EntityFrameworkCore2.Domain;

public class Match : BaseDomainObject
{
    public int HomeTeamId { get; set; }
    public virtual Team HomeTeam { get; set; } // la navigation propertie que corresponde a la FK
    
    public int AwayTeamId { get; set; }
    public virtual Team AwayTeam { get; set; }//  navigation prop

    public DateTime Date { get; set; }
}
