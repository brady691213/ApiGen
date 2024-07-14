using System;

namespace CTSCore.Models;

public class AssessmentTemplateOutcome
{
	public Guid Id { get; set; }

	public bool IsDeleted { get; set; }

	public string Name { get; set; }

	public Guid AssessmentTemplateSectionId { get; set; }

	public string? Text { get; set; }

	public string? AssessorsNotes { get; set; }

	public string? AssessorsFeedback { get; set; }

	public bool IsCriteriaforCompetent { get; set; }

	public int? OrderId { get; set; }

	public virtual AssessmentTemplateSection AssessmentTemplateSection { get; set; }
}
