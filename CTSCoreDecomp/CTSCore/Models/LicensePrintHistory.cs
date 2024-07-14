using System;

namespace CTSCore.Models;

public class LicensePrintHistory
{
	public Guid Id { get; set; }

	public DateTime? DatePrinted { get; set; }

	public Guid? UserId { get; set; }

	public string? UserName { get; set; }

	public string? LoggedOnUser { get; set; }

	public Guid? EmployeeId { get; set; }

	public string? Ipadress { get; set; }

	public string? DeviceName { get; set; }

	public string? PrintReason { get; set; }
}
