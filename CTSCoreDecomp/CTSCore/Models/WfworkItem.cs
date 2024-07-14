using System;

namespace CTSCore.Models;

public class WfworkItem
{
	public Guid Id { get; set; }

	public Guid? WorkitemType { get; set; }

	public Guid? WorkitemTarget { get; set; }

	public Guid? Originator { get; set; }

	public Guid? AssignedTo { get; set; }

	public Guid? WorkQueId { get; set; }

	public DateTime? DateStarted { get; set; }

	public DateTime? DateCompleted { get; set; }

	public DateTime? DateWithdrawn { get; set; }

	public Guid? WithdrawnBy { get; set; }

	public bool? IsLocked { get; set; }

	public Guid? LockedBy { get; set; }

	public bool? IsCompleted { get; set; }

	public bool? IsDeleted { get; set; }

	public string? Description { get; set; }
}
