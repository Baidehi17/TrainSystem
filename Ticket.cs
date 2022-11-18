using System;
using System.Collections.Generic;

namespace TrainGR.Models;

public partial class Ticket
{
    public int PnrNumber { get; set; }

    public string? Pname { get; set; }

    public string? Gender { get; set; }

    public int? SeatNo { get; set; }

    public int? Age { get; set; }
}
