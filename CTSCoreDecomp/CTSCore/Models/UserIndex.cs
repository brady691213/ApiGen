using System;

namespace CTSCore.Models;

public class UserIndex
{
	public string UserName { get; set; }

	public bool IsDeleted { get; set; }

	public DateTime LastLoginTime { get; set; }

	public bool IsLockedOut { get; set; }

	public string? EmpNum { get; set; }

	public string? Surname { get; set; }

	public string? FullNames { get; set; }

	public string? IdNum { get; set; }

	public Guid? Id { get; set; }

	public Guid Expr1 { get; set; }

	public Guid? EmployeeId { get; set; }

	public string? EMail { get; set; }
}
