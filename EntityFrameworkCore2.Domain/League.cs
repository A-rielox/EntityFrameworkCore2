using EntityFrameworkCore2.Domain.Common;

namespace EntityFrameworkCore2.Domain;

public class League : BaseDomainObject
{
    public string Name { get; set; }
    
    public List<Team> Teams { get; set; } // navigation prop, solo x la foreign key en
                                          // Team q hace referencia a esta ( esta no se crea
                                          // como columna en la tabla ), asi queda especificada la
                                          // relacion one-to-many con Teams
}


// public class Team
// {
//     public int Id { get; set; }
//     public string Name { get; set; }
   
//     public int LeagueId { get; set; }
//     public League League { get; set; }
// }