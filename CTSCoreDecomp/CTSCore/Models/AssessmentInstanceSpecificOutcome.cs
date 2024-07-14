using System;
using System.Collections.Generic;

namespace CTSCore.Models;

public class AssessmentInstanceSpecificOutcome
{
	public Guid Id { get; set; }

	public Guid AssessmentInstanceId { get; set; }

	public string? Description { get; set; }

	public bool IsCriteriaforCompetent { get; set; }

	public Guid? AssessmentResultId { get; set; }

	public string? AssessorsNotes { get; set; }

	public string? AssessorsFeedback { get; set; }

	public string Name { get; set; }

	public bool IsDeleted { get; set; }

	public int? OrderId { get; set; }

	public virtual AssessmentInstance AssessmentInstance { get; set; }

	public virtual ICollection<AssessmentInstanceSection> AssessmentInstanceSections { get; set; } = new List<AssessmentInstanceSection>();


	public virtual AssessmentResult? AssessmentResult { get; set; }
}
