using System;
using System.Collections.Generic;

namespace CTSCore.Models;

public class AssessmentInstanceOutcome
{
	public Guid Id { get; set; }

	public Guid AssessmentInstanceSectionId { get; set; }

	public string? Text { get; set; }

	public bool IsCriteriaforCompetent { get; set; }

	public Guid? AssessmentResultId { get; set; }

	public string? AssessorsNotes { get; set; }

	public string? AssessorsFeedback { get; set; }

	public string Name { get; set; }

	public bool IsDeleted { get; set; }

	public int? OrderId { get; set; }

	public virtual ICollection<AssessmentEvidence> AssessmentEvidences { get; set; } = new List<AssessmentEvidence>();


	public virtual AssessmentInstanceSection AssessmentInstanceSection { get; set; }

	public virtual AssessmentResult? AssessmentResult { get; set; }
}
