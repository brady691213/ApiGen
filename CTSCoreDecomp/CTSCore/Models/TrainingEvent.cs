using System;

namespace CTSCore.Models;

public class TrainingEvent
{
	public Guid TrainingEventId { get; set; }

	public string? EventName { get; set; }

	public string? EventDescription { get; set; }

	public int? EventDuration { get; set; }

	public int? EventSeats { get; set; }

	public bool? IsActive { get; set; }

	public bool? IsDeleted { get; set; }
}
