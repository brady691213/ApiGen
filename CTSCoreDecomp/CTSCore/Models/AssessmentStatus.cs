using System;
using System.Collections.Generic;

namespace CTSCore.Models;

public class AssessmentStatus
{
	public Guid Id { get; set; }

	public string Name { get; set; }

	public bool IsDeleted { get; set; }

	public virtual ICollection<AssessmentInstance> AssessmentInstances { get; set; } = new List<AssessmentInstance>();

}
