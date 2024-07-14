using System;

namespace CTSCore.Models;

public class ContentType
{
	public Guid ContentTypeId { get; set; }

	public int? ContentTypeCode { get; set; }

	public string? ContentType1 { get; set; }

	public bool? IsActive { get; set; }

	public bool? IsDeleted { get; set; }
}
