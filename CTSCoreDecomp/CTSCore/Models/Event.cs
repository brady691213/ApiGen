using System;

namespace CTSCore.Models;

public class Event
{
	public Guid Id { get; set; }

	public string? Name { get; set; }

	public string? Description { get; set; }

	public bool? IsActive { get; set; }

	public bool? IsDeleted { get; set; }
}
