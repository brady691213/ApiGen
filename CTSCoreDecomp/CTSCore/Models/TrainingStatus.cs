using System;
using System.Collections.Generic;

namespace CTSCore.Models;

public class TrainingStatus
{
	public Guid Id { get; set; }

	public string Name { get; set; }

	public bool IsDeleted { get; set; }

	public virtual ICollection<CourseInstance> CourseInstances { get; set; } = new List<CourseInstance>();

}
