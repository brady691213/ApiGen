using System;
using System.Collections.Generic;

namespace CTSCore.Models;

public class License
{
	public Guid Id { get; set; }

	public Guid? LicenseTypeId { get; set; }

	public DateTime? DateIssued { get; set; }

	public DateTime? ExpiryDate { get; set; }

	public Guid? EmployeeId { get; set; }

	public bool? IsSuspended { get; set; }

	public Guid? ProviderId { get; set; }

	public Guid? IssuedBy { get; set; }

	public bool? IsActive { get; set; }

	public bool? IsDeleted { get; set; }

	public bool? DoesExpire { get; set; }

	public int? ValidityDays { get; set; }

	public string? Notes { get; set; }

	public Guid? Restriction { get; set; }

	public virtual ICollection<ESignature> ESignatures { get; set; } = new List<ESignature>();


	public virtual Employee? Employee { get; set; }

	public virtual User? IssuedByNavigation { get; set; }

	public virtual LicenseType? LicenseType { get; set; }

	public virtual LicenseRestriction? RestrictionNavigation { get; set; }
}
