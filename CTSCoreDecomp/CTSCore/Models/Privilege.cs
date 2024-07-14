using System;
using System.Collections.Generic;

namespace CTSCore.Models;

public class Privilege
{
	public Guid Id { get; set; }

	public string? Privilege1 { get; set; }

	public string? Module { get; set; }

	public bool? IsDeleted { get; set; }

	public bool? IsActive { get; set; }

	public virtual ICollection<UserPrivilage> UserPrivilages { get; set; } = new List<UserPrivilage>();

}
