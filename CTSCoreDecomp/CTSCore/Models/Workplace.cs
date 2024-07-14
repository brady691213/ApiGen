using System;
using System.Collections.Generic;

namespace CTSCore.Models;

public class Workplace
{
	public Guid Id { get; set; }

	public string? Name { get; set; }

	public string? Description { get; set; }

	public bool? IsActive { get; set; }

	public bool? IsDeleted { get; set; }

	public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

}
