using System;

namespace CTSCore.Models;

public class SmartClickIndex
{
	public string? CourseName { get; set; }

	public DateTime? CourseDate { get; set; }

	public Guid Id { get; set; }

	public string? Teacher { get; set; }

	public DateTime? DateSynced { get; set; }

	public string? TestType { get; set; }

	public string? Moderator { get; set; }

	public Guid? ModeraredBy { get; set; }

	public string? ModeratorComments { get; set; }

	public DateTime? DateModerated { get; set; }

	public string? SyncedFrom { get; set; }

	public bool? IsDeleted { get; set; }

	public string? RefNum { get; set; }

	public string? Surname { get; set; }

	public string? Initials { get; set; }

	public string? FullNames { get; set; }

	public string? IdNum { get; set; }

	public string? JobTitle { get; set; }

	public string? JobLevel { get; set; }

	public string? Cell { get; set; }

	public string? Email { get; set; }

	public string? Status { get; set; }

	public string? Company { get; set; }

	public string? Workplace { get; set; }

	public string? Gender { get; set; }

	public string? Race { get; set; }

	public float? PassMark { get; set; }

	public string? Result { get; set; }

	public float? Score { get; set; }

	public bool? IsModerated { get; set; }

	public Guid? EmployeeId { get; set; }

	public Guid? TemplateId { get; set; }
}
