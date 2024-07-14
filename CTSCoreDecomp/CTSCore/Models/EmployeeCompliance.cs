using System;

namespace CTSCore.Models;

public class EmployeeCompliance
{
	public Guid Id { get; set; }

	public Guid? EmployeeId { get; set; }

	public string? ComplianceName { get; set; }

	public Guid? ComplianceTypeId { get; set; }

	public Guid? SourceId { get; set; }

	public bool? Satisfied { get; set; }

	public DateOnly? MostRecentDate { get; set; }

	public bool? Expired { get; set; }

	public DateOnly? ExpiryDate { get; set; }

	public int? SatisfyType { get; set; }

	public Guid? SatisfyId { get; set; }

	public string? Notes { get; set; }

	public DateOnly? LastNotification { get; set; }

	public bool? IsEnabled { get; set; }

	public bool? IsDeleted { get; set; }

	public Guid? SatisfyRefId { get; set; }

	public virtual ComplianceType? ComplianceType { get; set; }

	public virtual Employee? Employee { get; set; }
}
