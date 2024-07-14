using System;

namespace CTSCore.Models;

public class CourseTemplateContent
{
	public Guid Id { get; set; }

	public bool IsDeleted { get; set; }

	public Guid CourseTemplateId { get; set; }

	public string? Description { get; set; }

	public bool IsExternal { get; set; }

	public string? ExternalLink { get; set; }

	public bool IsCtsRepository { get; set; }

	public string? ContentBody { get; set; }

	public string? ContentText { get; set; }

	public string? Name { get; set; }

	public int? OrderId { get; set; }

	public Guid? NavigationId { get; set; }

	public string? FilePath { get; set; }

	public string? Lmspath { get; set; }

	public Guid? ContentTypeId { get; set; }

	public int? ContentTypeCode { get; set; }

	public virtual CourseTemplate CourseTemplate { get; set; }
}
