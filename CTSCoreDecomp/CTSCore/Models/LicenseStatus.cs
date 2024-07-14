using System;

namespace CTSCore.Models;

public class LicenseStatus
{
	public Guid Id { get; set; }

	public string? Status { get; set; }

	public bool? IsActive { get; set; }

	public bool? IsDeleted { get; set; }
}
