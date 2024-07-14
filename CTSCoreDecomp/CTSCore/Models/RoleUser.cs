using System;

namespace CTSCore.Models;

public class RoleUser
{
	public Guid Id { get; set; }

	public Guid UserId { get; set; }

	public Guid RoleId { get; set; }

	public bool IsDeleted { get; set; }

	public string UserName { get; set; }

	public virtual Role Role { get; set; }

	public virtual User User { get; set; }
}
