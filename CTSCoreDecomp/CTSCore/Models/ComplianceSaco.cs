using System;

namespace CTSCore.Models;

public class ComplianceSaco
{
	public string RefNum { get; set; }

	public string Surname { get; set; }

	public Guid? ModuleId { get; set; }

	public string? CourseName { get; set; }

	public DateTime? DateCompleted { get; set; }

	public Guid StatusId { get; set; }
}
