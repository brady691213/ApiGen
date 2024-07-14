using System;
using System.Collections.Generic;

namespace CTSCore.Models;

public class AssessmentResult
{
	public Guid Id { get; set; }

	public string Name { get; set; }

	public bool IsDeleted { get; set; }

	public virtual ICollection<AssessmentInstanceOutcome> AssessmentInstanceOutcomes { get; set; } = new List<AssessmentInstanceOutcome>();


	public virtual ICollection<AssessmentInstanceSection> AssessmentInstanceSections { get; set; } = new List<AssessmentInstanceSection>();


	public virtual ICollection<AssessmentInstanceSpecificOutcome> AssessmentInstanceSpecificOutcomes { get; set; } = new List<AssessmentInstanceSpecificOutcome>();


	public virtual ICollection<AssessmentInstance> AssessmentInstances { get; set; } = new List<AssessmentInstance>();

}
