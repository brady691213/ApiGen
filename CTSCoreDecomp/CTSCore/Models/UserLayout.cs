using System;

namespace CTSCore.Models;

public class UserLayout
{
	public Guid Id { get; set; }

	public Guid? UserId { get; set; }

	public string? ComponentName { get; set; }

	public string? LayoutData { get; set; }
}
