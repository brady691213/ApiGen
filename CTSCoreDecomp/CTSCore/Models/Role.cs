using System;
using System.Collections.Generic;

namespace CTSCore.Models;

public class Role
{
	public Guid Id { get; set; }

	public string? Description { get; set; }

	public string Name { get; set; }

	public bool IsDeleted { get; set; }

	public virtual ICollection<RoleUser> RoleUsers { get; set; } = new List<RoleUser>();

}
