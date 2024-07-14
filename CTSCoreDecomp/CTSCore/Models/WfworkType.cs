using System;

namespace CTSCore.Models;

public class WfworkType
{
	public Guid Id { get; set; }

	public string? WorkTypeName { get; set; }

	public bool? IsActive { get; set; }

	public bool? IsDeleted { get; set; }

	public string? EntityName { get; set; }
}
