using System;
using System.Collections.Generic;

namespace TrainingVSCodeDB.Models;

public partial class Game
{
    public int GameId { get; set; }

    public string GameName { get; set; } = null!;

    public int GameTypeId { get; set; }

    public int DevId { get; set; }

    public virtual Develloper Dev { get; set; } = null!;

    public virtual GameType GameType { get; set; } = null!;
}
