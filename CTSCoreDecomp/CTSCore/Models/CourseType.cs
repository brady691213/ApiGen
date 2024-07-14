using System;
using System.Collections.Generic;

namespace CTSCore.Models;

public class CourseType
{
	public Guid Id { get; set; }

	public string Name { get; set; }

	public bool IsDeleted { get; set; }

	public virtual ICollection<CourseTemplate> CourseTemplates { get; set; } = new List<CourseTemplate>();

}
