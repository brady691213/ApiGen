using System;

namespace CTSCore.Models;

public class SpecialRequest
{
	public Guid Id { get; set; }

	public Guid? OriginatorId { get; set; }

	public Guid? AssignedToId { get; set; }

	public Guid? AdminId { get; set; }

	public string? Message { get; set; }

	public bool? IsClosed { get; set; }

	public string? Status { get; set; }

	public string? RequestName { get; set; }

	public DateOnly? RequestForDate { get; set; }

	public string? RequestCourse { get; set; }

	public Guid? LockedById { get; set; }

	public bool? IsLocked { get; set; }

	public bool? IsApproved { get; set; }

	public Guid? ApprovedBy { get; set; }

	public DateTime? DateRequested { get; set; }

	public bool? IsNew { get; set; }

	public bool? IsChangedAdm { get; set; }

	public bool? IsChangedClient { get; set; }
}
