using System;

namespace CTSCore.Models;

public class VwLicensesAll
{
	public Guid Id { get; set; }

	public string? Name { get; set; }

	public bool? DoesExpire { get; set; }

	public int? ValidityMonths { get; set; }
}
