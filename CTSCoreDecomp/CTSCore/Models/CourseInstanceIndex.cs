using System;

namespace CTSCore.Models;

public class CourseInstanceIndex
{
	public Guid Id { get; set; }

	public bool IsDeleted { get; set; }

	public Guid EmployeeId { get; set; }

	public string Surname { get; set; }

	public string FullNames { get; set; }

	public string RefNum { get; set; }

	public string IdNum { get; set; }

	public string Name { get; set; }

	public string CourseType { get; set; }

	public DateTime? BookingDate { get; set; }

	public DateTime? CompletionDate { get; set; }

	public double? ResultScore { get; set; }

	public int? ValidityMonths { get; set; }

	public string? Description { get; set; }

	public DateTime? StartDate { get; set; }

	public string? ResultText { get; set; }

	public int? RebookInstanceCount { get; set; }

	public int RebookCount { get; set; }

	public int? ClientStatus { get; set; }

	public string Status { get; set; }

	public string JobTitle { get; set; }

	public string JobLevel { get; set; }

	public string Company { get; set; }

	public string? Workplace { get; set; }

	public string? Gender { get; set; }

	public string? Race { get; set; }
}
