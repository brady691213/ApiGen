using System;
using System.Collections.Generic;

namespace CTSCore.Models;

public class AssessmentInstance
{
	public Guid Id { get; set; }

	public bool IsDeleted { get; set; }

	public Guid EmployeeId { get; set; }

	public Guid AssessmentTemplateId { get; set; }

	public Guid? ClientAssessmentId { get; set; }

	public Guid? ClientTemplateId { get; set; }

	public string Name { get; set; }

	public string? Description { get; set; }

	public int? ValidityMonths { get; set; }

	public string? Author { get; set; }

	public string? TemplateVersion { get; set; }

	public string? ProductVersion { get; set; }

	public DateTime BookingDate { get; set; }

	public DateTime? DateCheckedOut { get; set; }

	public string? CheckedOutByUser { get; set; }

	public string? CheckOutByIpAddress { get; set; }

	public DateTime? DateCheckedIn { get; set; }

	public bool BookedOut { get; set; }

	public Guid? AssessorId { get; set; }

	public Guid AssessmentResultId { get; set; }

	public string? AssessorsNotes { get; set; }

	public string? AssessorsFeedback { get; set; }

	public Guid AssessmentStatusId { get; set; }

	public Guid? EmployeeId1 { get; set; }

	public Guid? ModeratedBy { get; set; }

	public string? Moderator { get; set; }

	public DateTime? DateModerated { get; set; }

	public string? ModeratorComments { get; set; }

	public bool? IsModerated { get; set; }

	public int? OrderId { get; set; }

	public DateTime? DateStarted { get; set; }

	public DateTime? DateCompleted { get; set; }

	public int? LogDays { get; set; }

	public virtual ICollection<AssessmentInstanceSpecificOutcome> AssessmentInstanceSpecificOutcomes { get; set; } = new List<AssessmentInstanceSpecificOutcome>();


	public virtual AssessmentResult AssessmentResult { get; set; }

	public virtual AssessmentStatus AssessmentStatus { get; set; }

	public virtual AssessmentTemplate AssessmentTemplate { get; set; }

	public virtual User? Assessor { get; set; }

	public virtual ICollection<ESignature> ESignatures { get; set; } = new List<ESignature>();


	public virtual Employee Employee { get; set; }
}
