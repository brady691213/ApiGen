using System;

namespace CTSCore.Models;

public class ESignature
{
	public Guid Id { get; set; }

	public Guid SourceId { get; set; }

	public byte[]? SigEmployee { get; set; }

	public DateTime? SigEmployeeDate { get; set; }

	public string? SigEmployeeFor { get; set; }

	public string? SigEmployeeWho { get; set; }

	public byte[]? SigAssessor { get; set; }

	public DateTime? SigAssessorDate { get; set; }

	public string? SigAssessorFor { get; set; }

	public string? SigAssessorWho { get; set; }

	public byte[]? SigFacilitator { get; set; }

	public DateTime? SigFacilitatorDate { get; set; }

	public string? SigFacilitatorFor { get; set; }

	public string? SigFacilitratorWho { get; set; }

	public byte[]? SigMderator { get; set; }

	public DateTime? SigModeratorDate { get; set; }

	public string? SigModeratorFor { get; set; }

	public string? SigModeratorWho { get; set; }

	public byte[]? SigOther { get; set; }

	public DateTime? SigOtherDate { get; set; }

	public string? SigOtherFor { get; set; }

	public string? SigOtherWho { get; set; }

	public string? IsDeleted { get; set; }

	public string? IsActive { get; set; }

	public virtual AssessmentInstance Source { get; set; }

	public virtual License Source1 { get; set; }

	public virtual LicenseApplication Source2 { get; set; }

	public virtual SmartClickCourse Source3 { get; set; }

	public virtual CourseInstance SourceNavigation { get; set; }
}
