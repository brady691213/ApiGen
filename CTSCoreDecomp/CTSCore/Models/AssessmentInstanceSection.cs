using System;
using System.Collections.Generic;

namespace CTSCore.Models;

public class AssessmentInstanceSection
{
	public Guid Id { get; set; }

	public Guid AssessmentInstanceSpecificOutcomeId { get; set; }

	public string? Description { get; set; }

	public bool IsCriteriaforCompetent { get; set; }

	public Guid? AssessmentResultId { get; set; }

	public string? AssessorsNotes { get; set; }

	public string? AssessorsFeedback { get; set; }

	public string Name { get; set; }

	public bool IsDeleted { get; set; }

	public int? OrderId { get; set; }

	public virtual ICollection<AssessmentInstanceOutcome> AssessmentInstanceOutcomes { get; set; } = new List<AssessmentInstanceOutcome>();


	public virtual AssessmentInstanceSpecificOutcome AssessmentInstanceSpecificOutcome { get; set; }

	public virtual AssessmentResult? AssessmentResult { get; set; }
}
