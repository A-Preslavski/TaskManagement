using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace TimeManagement.Models;

public partial class Task
{
    public Guid TaskKey { get; set; } = Guid.NewGuid();

    public string? TaskName { get; set; }

    public string? TaskDescription { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public DateTime? TimeSpent { get; set; }

    public DateTime? CreatedOn { get; set; } = DateTime.Now;

    public DateTime? UpdatedOn { get; set; }

    public bool IsDeleted { get; set; }
}
