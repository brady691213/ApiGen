using System;

namespace CTSCore.Models;

public class CourseTemplateIndex
{
	public Guid Id { get; set; }

	public bool IsDeleted { get; set; }

	public string CourseType { get; set; }

	public string Name { get; set; }

	public string? Description { get; set; }
}
