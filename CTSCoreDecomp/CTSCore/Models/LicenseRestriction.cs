using System;
using System.Collections.Generic;

namespace CTSCore.Models;

public class LicenseRestriction
{
	public Guid Id { get; set; }

	public string? Name { get; set; }

	public bool? IsActive { get; set; }

	public bool? IsDeleted { get; set; }

	public virtual ICollection<ApplicationLicense> ApplicationLicenses { get; set; } = new List<ApplicationLicense>();


	public virtual ICollection<License> Licenses { get; set; } = new List<License>();

}
