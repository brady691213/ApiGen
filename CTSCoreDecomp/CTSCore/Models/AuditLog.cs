using System;

namespace CTSCore.Models;

public class AuditLog
{
	public Guid Id { get; set; }

	public DateTime? DateLogged { get; set; }

	public string? LoggedPc { get; set; }

	public string? LoggedIp { get; set; }

	public string? LoggedCtsuser { get; set; }

	public string? LoggedUser { get; set; }

	public int? LogType { get; set; }

	public string? LogTypeText { get; set; }

	public string? LogDescription { get; set; }
}
