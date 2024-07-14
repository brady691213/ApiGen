using System;

namespace CTSCore.Models;

public class UserPrivilage
{
	public Guid Id { get; set; }

	public Guid? UserId { get; set; }

	public Guid? PrivilegeId { get; set; }

	public virtual Privilege? Privilege { get; set; }

	public virtual User? User { get; set; }
}
