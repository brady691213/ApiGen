using System;
using System.Collections.Generic;

namespace CTSCore.Models;

public class AssessmentPack
{
	public Guid Id { get; set; }

	public string? Name { get; set; }

	public string? Description { get; set; }

	public bool? IsActive { get; set; }

	public bool? IsDeleted { get; set; }

	public Guid? CreatedBy { get; set; }

	public Guid? ModifiedBy { get; set; }

	public string? Test { get; set; }

	public virtual ICollection<AssessmentPackTemplate> AssessmentPackTemplates { get; set; } = new List<AssessmentPackTemplate>();

}
