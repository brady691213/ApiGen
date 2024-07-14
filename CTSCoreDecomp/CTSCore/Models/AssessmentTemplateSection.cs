using System;
using System.Collections.Generic;

namespace CTSCore.Models;

public class AssessmentTemplateSection
{
	public Guid Id { get; set; }

	public bool IsDeleted { get; set; }

	public string? Name { get; set; }

	public Guid AssessmentTemplateSpecificOutcomeId { get; set; }

	public string? Description { get; set; }

	public bool IsCriteriaforCompetent { get; set; }

	public string? AssessorsNotes { get; set; }

	public string? AssessorsFeedback { get; set; }

	public int? OrderId { get; set; }

	public virtual ICollection<AssessmentTemplateOutcome> AssessmentTemplateOutcomes { get; set; } = new List<AssessmentTemplateOutcome>();


	public virtual AssessmentTemplateSpecificOutcome AssessmentTemplateSpecificOutcome { get; set; }
}
