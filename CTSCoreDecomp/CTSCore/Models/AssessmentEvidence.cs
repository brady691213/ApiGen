using System;

namespace CTSCore.Models;

public class AssessmentEvidence
{
	public Guid Id { get; set; }

	public Guid? AssessmentInstanceId { get; set; }

	public Guid? AssessmentOutcomeId { get; set; }

	public DateTime? ImageDate { get; set; }

	public string? ImageNotes { get; set; }

	public string? TakenBy { get; set; }

	public byte[]? Picture { get; set; }

	public virtual AssessmentInstanceOutcome? AssessmentOutcome { get; set; }
}
