using System;

namespace CTSCore.Models;

public class WfworkitemIndex
{
	public Guid Id { get; set; }

	public string? Originator { get; set; }

	public string? WorkTypeName { get; set; }

	public DateTime? DateStarted { get; set; }

	public DateTime? DateCompleted { get; set; }

	public DateTime? DateWithdrawn { get; set; }

	public bool? IsLocked { get; set; }

	public Guid? LockedBy { get; set; }

	public bool? IsCompleted { get; set; }

	public bool? IsDeleted { get; set; }

	public string? Description { get; set; }

	public string? WithdrawnBy { get; set; }

	public Guid? AssignedTo { get; set; }

	public Guid? WorkQueId { get; set; }
}
