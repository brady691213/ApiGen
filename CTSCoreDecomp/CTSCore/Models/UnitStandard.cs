using System;

namespace CTSCore.Models;

public class UnitStandard
{
	public Guid Id { get; set; }

	public string? Code { get; set; }

	public string? Saqacode { get; set; }

	public Guid? CodeType { get; set; }

	public string? Name { get; set; }

	public int? Nqflevel { get; set; }

	public int? Credits { get; set; }

	public int? Version { get; set; }

	public int? Rewvision { get; set; }

	public string? Description { get; set; }

	public bool? IsActive { get; set; }

	public bool? IsDeleted { get; set; }

	public bool? DoesExpire { get; set; }

	public int? Validity { get; set; }
}
