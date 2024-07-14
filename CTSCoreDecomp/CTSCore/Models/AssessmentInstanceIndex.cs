using System;

namespace CTSCore.Models;

public class AssessmentInstanceIndex
{
	public Guid Id { get; set; }

	public bool IsDeleted { get; set; }

	public string Name { get; set; }

	public string? Description { get; set; }

	public Guid EmployeeId { get; set; }

	public string EmployeeRefNum { get; set; }

	public string FullNames { get; set; }

	public string Surname { get; set; }

	public string IdNumber { get; set; }

	public string? Initials { get; set; }

	public string Employee { get; set; }

	public string JobTitle { get; set; }

	public DateTime BookingDate { get; set; }

	public string Status { get; set; }

	public Guid AssessmentStatusId { get; set; }

	public string Result { get; set; }

	public Guid AssessmentResultId { get; set; }

	public string UserName { get; set; }

	public string Assessor { get; set; }

	public Guid UserId { get; set; }

	public bool? IsModerated { get; set; }

	public DateTime? DateModerated { get; set; }

	public DateTime? DateStarted { get; set; }

	public DateTime? DateCompleted { get; set; }

	public string? Moderator { get; set; }
}
