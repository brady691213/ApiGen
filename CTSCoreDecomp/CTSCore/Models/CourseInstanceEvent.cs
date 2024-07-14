using System;

namespace CTSCore.Models;

public class CourseInstanceEvent
{
	public Guid Id { get; set; }

	public Guid? CourseInstanceId { get; set; }

	public Guid? EmpId { get; set; }

	public string? EventDescription { get; set; }

	public DateTime? EventDateTime { get; set; }

	public DateTime? EventDatetimeServer { get; set; }

	public string? EventSourceIp { get; set; }

	public string? EventPc { get; set; }

	public string? ClientRuntimeVersion { get; set; }
}
