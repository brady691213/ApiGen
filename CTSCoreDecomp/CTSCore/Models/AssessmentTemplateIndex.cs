using System;

namespace CTSCore.Models;

public class AssessmentTemplateIndex
{
	public Guid Id { get; set; }

	public bool IsDeleted { get; set; }

	public string Name { get; set; }

	public string? Description { get; set; }

	public string? Author { get; set; }

	public DateTime? ClientCreatedDate { get; set; }

	public DateTime? ClientModifiedDate { get; set; }

	public string? ClientModifiedBy { get; set; }

	public string? TemplateVersion { get; set; }

	public Guid? TemplateId { get; set; }

	public string? ProductVersion { get; set; }

	public int? ValidityMonths { get; set; }

	public string? AssessorsNotes { get; set; }

	public string? AssessorsFeedback { get; set; }

	public int? OrderId { get; set; }
}
