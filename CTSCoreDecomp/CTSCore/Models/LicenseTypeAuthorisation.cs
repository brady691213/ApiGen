using System;
using System.Collections.Generic;

namespace CTSCore.Models;

public class LicenseTypeAuthorisation
{
	public Guid Id { get; set; }

	public string? AuthName { get; set; }

	public string? AuthHeader { get; set; }

	public string? AuthText { get; set; }

	public DateTime? DateCreated { get; set; }

	public int? Version { get; set; }

	public DateTime? DateModified { get; set; }

	public bool? ModifiedBy { get; set; }

	public bool? IsActive { get; set; }

	public virtual ICollection<LicenseType> LicenseTypes { get; set; } = new List<LicenseType>();

}
