using System;

namespace CTSCore.Models;

public class AssessmentInstanceResultDetail
{
	public Guid Id { get; set; }

	public string EmployeeRefNum { get; set; }

	public string FullNames { get; set; }

	public string Surname { get; set; }

	public string IdNum { get; set; }

	public string? Initials { get; set; }

	public string Employee { get; set; }

	public string CompanyName { get; set; }

	public string? Assessor { get; set; }

	public DateTime BookingDate { get; set; }

	public DateTime DateCheckedIn { get; set; }

	public string AsstTitle { get; set; }

	public string? AsstText { get; set; }

	public string? AsstNotes { get; set; }

	public string? AsstFeedback { get; set; }

	public string? AsstStatus { get; set; }

	public string? AsstResult { get; set; }

	public string SpecTitle { get; set; }

	public string? SpecText { get; set; }

	public string? SpecNotes { get; set; }

	public string? SpecFeedback { get; set; }

	public string? SpecResult { get; set; }

	public bool SpecIsCriteria { get; set; }

	public string SectTitle { get; set; }

	public string? SectText { get; set; }

	public string? SectNotes { get; set; }

	public string? SectFeedback { get; set; }

	public string? SectResult { get; set; }

	public bool SectIsCriteria { get; set; }

	public string OutcTitle { get; set; }

	public string? OutcText { get; set; }

	public string? OutcNotes { get; set; }

	public string? OutcFeedback { get; set; }

	public string? OutcResult { get; set; }

	public bool OuctIsCriteria { get; set; }
}
