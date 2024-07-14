using System;

namespace CTSCore.Models;

public class UserPrivelagesIndex
{
	public Guid Id { get; set; }

	public Guid? UserId { get; set; }

	public Guid? PrivilegeId { get; set; }

	public Guid? EmployeeId { get; set; }

	public string? UserName { get; set; }

	public string? Surname { get; set; }

	public string? FullNames { get; set; }

	public string? Privilege { get; set; }

	public string? Module { get; set; }
}
