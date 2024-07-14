using System;
using System.Collections.Generic;

namespace CTSCore.Models;

public class LicenseApplication
{
	public Guid Id { get; set; }

	public Guid? LicenseTypeId { get; set; }

	public DateTime? DateIssued { get; set; }

	public DateTime? DateRequested { get; set; }

	public DateTime? LicenseStartDate { get; set; }

	public DateTime? LastActionDate { get; set; }

	public DateTime? ExpiryDate { get; set; }

	public Guid? EmployeeId { get; set; }

	public bool? IsSuspended { get; set; }

	public Guid? ProviderId { get; set; }

	public Guid? IssuedBy { get; set; }

	public bool? IsActive { get; set; }

	public bool? IsDeleted { get; set; }

	public bool? IsCompleted { get; set; }

	public bool? DoesExpire { get; set; }

	public int? ValidityMonths { get; set; }

	public int? ValidityDays { get; set; }

	public string? Notes { get; set; }

	public DateTime? DateStarted { get; set; }

	public string? DateCompleted { get; set; }

	public Guid? AssignedTo { get; set; }

	public Guid? Originator { get; set; }

	public bool? IsLocked { get; set; }

	public Guid? LockedBy { get; set; }

	public Guid? RestrictionId { get; set; }

	public Guid? LicenseId { get; set; }

	public string? Status { get; set; }

	public bool? IsSigned { get; set; }

	public bool? IsEscalated { get; set; }

	public Guid? EscalatedTo { get; set; }

	public bool? IsReleased { get; set; }

	public bool? IsIssued { get; set; }

	public virtual ICollection<ApplicationLicense> ApplicationLicenses { get; set; } = new List<ApplicationLicense>();


	public virtual ICollection<ESignature> ESignatures { get; set; } = new List<ESignature>();

}
