using System;
using System.Collections.Generic;

namespace CTSCore.Models;

public class User
{
	public Guid Id { get; set; }

	public Guid? EmployeeId { get; set; }

	public string UserName { get; set; }

	public string? UserType { get; set; }

	public bool IsDeleted { get; set; }

	public string Password { get; set; }

	public DateTime PasswordDate { get; set; }

	public DateTime LastLoginTime { get; set; }

	public bool IsLockedOut { get; set; }

	public string? EMail { get; set; }

	public byte[]? ESignature { get; set; }

	public virtual ICollection<AssessmentInstance> AssessmentInstances { get; set; } = new List<AssessmentInstance>();


	public virtual Employee? Employee { get; set; }

	public virtual ICollection<License> Licenses { get; set; } = new List<License>();


	public virtual ICollection<RoleUser> RoleUsers { get; set; } = new List<RoleUser>();


	public virtual ICollection<UserPrivilage> UserPrivilages { get; set; } = new List<UserPrivilage>();

}
