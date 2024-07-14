using System;
using System.Collections.Generic;

namespace CTSCore.Models;

public class AssessmentTemplateSpecificOutcome
{
	public Guid Id { get; set; }

	public string Name { get; set; }

	public bool IsDeleted { get; set; }

	public Guid AssessmentTemplateId { get; set; }

	public bool IsCriteriaforCompetent { get; set; }

	public string? Description { get; set; }

	public string? AssessorsNotes { get; set; }

	public string? AssessorsFeedback { get; set; }

	public int? OrderId { get; set; }

	public virtual AssessmentTemplate AssessmentTemplate { get; set; }

	public virtual ICollection<AssessmentTemplateSection> AssessmentTemplateSections { get; set; } = new List<AssessmentTemplateSection>();

}
