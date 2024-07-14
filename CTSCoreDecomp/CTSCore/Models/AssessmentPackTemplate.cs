using System;

namespace CTSCore.Models;

public class AssessmentPackTemplate
{
	public Guid Id { get; set; }

	public Guid? PackId { get; set; }

	public Guid? TempId { get; set; }

	public string? Name { get; set; }

	public string? Description { get; set; }

	public bool? IsActive { get; set; }

	public bool? IsDeleted { get; set; }

	public virtual AssessmentPack? Pack { get; set; }
}
