using System;

namespace CTSCore.Models;

public class ApplicationLicense
{
	public Guid Id { get; set; }

	public Guid? ApplicationId { get; set; }

	public Guid? LicenceType { get; set; }

	public Guid? RestrictionType { get; set; }

	public DateOnly? DateIssued { get; set; }

	public DateOnly? DateExpire { get; set; }

	public int? Validity { get; set; }

	public bool? IsApproved { get; set; }

	public virtual LicenseApplication? Application { get; set; }

	public virtual LicenseType? LicenceTypeNavigation { get; set; }

	public virtual LicenseRestriction? RestrictionTypeNavigation { get; set; }
}
