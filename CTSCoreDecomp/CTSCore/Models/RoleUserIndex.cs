using System;

namespace CTSCore.Models;

public class RoleUserIndex
{
	public Guid Id { get; set; }

	public Guid RoleId { get; set; }

	public string UserName { get; set; }

	public bool IsDeleted { get; set; }

	public DateTime? LastLoginTime { get; set; }

	public bool? IsLockedOut { get; set; }

	public string? EmpNum { get; set; }

	public string? Surname { get; set; }

	public string? FullNames { get; set; }

	public string? EmpComb { get; set; }

	public string? IdNum { get; set; }

	public string? Name { get; set; }

	public Guid UserId { get; set; }

	public string? EMail { get; set; }

	public bool? Expr1 { get; set; }
}
