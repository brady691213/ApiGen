using System;

namespace CTSCore.Models;

public class AtrQualification
{
	public Guid Id { get; set; }

	public string? QualificationType { get; set; }

	public bool? IsActive { get; set; }

	public bool? IsDeleted { get; set; }
}
