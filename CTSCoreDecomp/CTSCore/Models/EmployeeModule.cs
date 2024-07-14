using System;

namespace CTSCore.Models;

public class EmployeeModule
{
	public Guid Id { get; set; }

	public Guid? EmployeeId { get; set; }

	public Guid? UnitStandardId { get; set; }

	public string? UnitStandardName { get; set; }

	public DateOnly? DateStarted { get; set; }

	public DateOnly? DateCompleted { get; set; }

	public bool? DoesExpire { get; set; }

	public bool? Expired { get; set; }

	public DateTime? ExpiryDate { get; set; }

	public bool? AllowCredit { get; set; }
}
