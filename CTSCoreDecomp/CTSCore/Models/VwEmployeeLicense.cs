using System;

namespace CTSCore.Models;

public class VwEmployeeLicense
{
	public string? RefNum { get; set; }

	public string? FullNames { get; set; }

	public string? Surname { get; set; }

	public string? IdNum { get; set; }

	public string? LicenseName { get; set; }

	public Guid LicenseTypeId { get; set; }

	public DateTime? DateIssued { get; set; }

	public DateTime? ExpiryDate { get; set; }

	public bool? DoesExpire { get; set; }

	public string? Restriction { get; set; }
}
