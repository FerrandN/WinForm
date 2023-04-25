using System;
using System.Collections.Generic;

namespace ECF_Blanc.Models;

public partial class GameType
{
    public int GameTypeId { get; set; }

    public string GameTypeName { get; set; } = null!;

    public virtual ICollection<Game> Games { get; set; } = new List<Game>();
}
