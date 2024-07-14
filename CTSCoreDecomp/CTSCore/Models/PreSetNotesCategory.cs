using System;

namespace CTSCore.Models;

public class PreSetNotesCategory
{
	public Guid Id { get; set; }

	public string? Category { get; set; }

	public bool? IsDeleted { get; set; }

	public bool? IsActive { get; set; }
}
