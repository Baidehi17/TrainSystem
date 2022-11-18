using System;
using System.Collections.Generic;

namespace TrainGR.Models;

public partial class Train
{
    public int PnrNumber { get; set; }

    public string? Tname { get; set; }

    public string? Sources { get; set; }

    public string? Destination { get; set; }

    public string? RunDays { get; set; }

    public string? ArrivalTime { get; set; }

    public string? DepartureTime { get; set; }
}
