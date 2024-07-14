using System;

namespace CTSCore.Models;

public class EmployeeJobRequirement
{
	public Guid Id { get; set; }

	public Guid? EmployeeId { get; set; }

	public Guid? TrainingCourseId { get; set; }

	public string? TrainingCourseName { get; set; }

	public bool? Satisfied { get; set; }

	public Guid? TrainingRefMostRecent { get; set; }

	public DateOnly? MostRecentDate { get; set; }

	public bool? Expired { get; set; }

	public DateOnly? ExpiryDate { get; set; }

	public virtual Employee? Employee { get; set; }
}
