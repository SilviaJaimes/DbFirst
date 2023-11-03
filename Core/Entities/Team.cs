﻿namespace Core.Entities;

public partial class Team : BaseEntity
{
    public string Name { get; set; }

    public virtual ICollection<Driver> Drivers { get; set; } = new List<Driver>();
    public ICollection<TeamDriver> TeamDrivers { get; set; }
}
