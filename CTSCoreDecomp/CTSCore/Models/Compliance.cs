using System;

namespace CTSCore.Models;

public class Compliance
{
	public Guid? ModuleId { get; set; }

	public string? CourseName { get; set; }

	public string RefNum { get; set; }

	public string FullNames { get; set; }

	public string Surname { get; set; }

	public string IdNum { get; set; }

	public DateTime? DateCompleted { get; set; }

	public Guid EmpId { get; set; }

	public Guid StatusId { get; set; }
}
