using System;
using System.Collections.Generic;

namespace TrainingVSCodeDB.Models;

public partial class Develloper
{
    public int DevId { get; set; }

    public string DevName { get; set; } = null!;

    public virtual ICollection<Game> Games { get; set; } = new List<Game>();
}
