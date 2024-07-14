using System;

namespace CTSCore.Models;

public class EventStatus
{
	public Guid Id { get; set; }

	public string? Name { get; set; }

	public int? MaxAttendance { get; set; }

	public int? MinAttendance { get; set; }

	public bool? IsActive { get; set; }

	public bool? IsDeleted { get; set; }
}
