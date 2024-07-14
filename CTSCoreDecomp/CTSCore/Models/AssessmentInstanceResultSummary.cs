using System;

namespace CTSCore.Models;

public class AssessmentInstanceResultSummary
{
	public Guid Id { get; set; }

	public string EmployeeRefNum { get; set; }

	public string FullNames { get; set; }

	public string Surname { get; set; }

	public string IdNum { get; set; }

	public string? Initials { get; set; }

	public string Employee { get; set; }

	public string CompanyName { get; set; }

	public string AssessmentName { get; set; }

	public string? Description { get; set; }

	public DateTime BookingDate { get; set; }

	public DateTime? DateCheckedIn { get; set; }

	public string StatusName { get; set; }

	public string ResultName { get; set; }

	public DateTime? DateStarted { get; set; }

	public DateTime? DateCompleted { get; set; }

	public string? Assessor { get; set; }

	public Guid EmployeeId { get; set; }
}
