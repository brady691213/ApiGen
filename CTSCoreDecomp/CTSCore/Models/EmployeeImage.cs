using System;

namespace CTSCore.Models;

public class EmployeeImage
{
	public Guid Id { get; set; }

	public Guid? EmployeeId { get; set; }

	public byte[]? EmployeeImage1 { get; set; }

	public byte[]? ImageThumbnail { get; set; }

	public bool? IsDeleted { get; set; }

	public virtual Employee? Employee { get; set; }
}
