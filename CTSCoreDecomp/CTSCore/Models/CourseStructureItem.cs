using System;

namespace CTSCore.Models;

public class CourseStructureItem
{
	public Guid Id { get; set; }

	public bool IsDeleted { get; set; }

	public Guid TemplateId { get; set; }

	public Guid ItemId { get; set; }

	public Guid? ParentId { get; set; }

	public int ItemTypeId { get; set; }

	public string? Name { get; set; }
}
