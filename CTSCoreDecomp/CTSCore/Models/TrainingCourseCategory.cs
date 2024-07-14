using System;

namespace CTSCore.Models;

public class TrainingCourseCategory
{
	public Guid Id { get; set; }

	public string? Name { get; set; }

	public string? Decsription { get; set; }

	public string? Mqaid { get; set; }

	public bool? IsActive { get; set; }

	public bool? IsDeleted { get; set; }
}
