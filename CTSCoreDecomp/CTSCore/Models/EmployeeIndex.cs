using System;

namespace CTSCore.Models;

public class EmployeeIndex
{
	public Guid Id { get; set; }

	public bool IsDeleted { get; set; }

	public string RefNum { get; set; }

	public string Surname { get; set; }

	public string? Initials { get; set; }

	public string FullNames { get; set; }

	public string IdNum { get; set; }

	public string JobTitle { get; set; }

	public string JobLevel { get; set; }

	public string? Cell { get; set; }

	public string? Email { get; set; }

	public string Status { get; set; }

	public string Company { get; set; }

	public string? Workplace { get; set; }

	public string? Gender { get; set; }

	public string? Race { get; set; }
}
