using System;

namespace CTSCore.Models;

public class LicenseEscalation
{
	public Guid Id { get; set; }

	public Guid? AssignedUserId { get; set; }

	public Guid? EscalateToUserId { get; set; }

	public bool? IsActive { get; set; }

	public bool? IsDeleted { get; set; }
}
