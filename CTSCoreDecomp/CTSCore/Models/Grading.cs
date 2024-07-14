using System;
using System.Collections.Generic;

namespace CTSCore.Models;

public class Grading
{
	public Guid Id { get; set; }

	public string? Grading1 { get; set; }

	public bool? IsActive { get; set; }

	public bool? IsDeleted { get; set; }

	public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

}
