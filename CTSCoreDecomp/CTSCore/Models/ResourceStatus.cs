using System;

namespace CTSCore.Models;

public class ResourceStatus
{
	public Guid Id { get; set; }

	public string? Name { get; set; }

	public bool? IsActive { get; set; }

	public bool? IsDeleted { get; set; }
}
