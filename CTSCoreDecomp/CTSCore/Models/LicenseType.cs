using System;
using System.Collections.Generic;

namespace CTSCore.Models;

public class LicenseType
{
	public Guid Id { get; set; }

	public string? Name { get; set; }

	public string? ShortCode { get; set; }

	public Guid? VehicleId { get; set; }

	public bool? IsDeleted { get; set; }

	public bool? IsActive { get; set; }

	public bool? DoesExpire { get; set; }

	public int? ValidityDays { get; set; }

	public int? ValidityMonths { get; set; }

	public Guid? AuthorisationId { get; set; }

	public virtual ICollection<ApplicationLicense> ApplicationLicenses { get; set; } = new List<ApplicationLicense>();


	public virtual LicenseTypeAuthorisation? Authorisation { get; set; }

	public virtual ICollection<License> Licenses { get; set; } = new List<License>();

}
