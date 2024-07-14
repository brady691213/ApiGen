using System;

namespace CTSCore.Models;

public class AtrSpecialisation
{
	public Guid Id { get; set; }

	public string? SpesialisationType { get; set; }

	public Guid? QualificationId { get; set; }

	public bool? IsActive { get; set; }

	public bool? IsDeleted { get; set; }
}
