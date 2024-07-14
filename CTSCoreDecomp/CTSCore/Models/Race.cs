using System;
using System.Collections.Generic;

namespace CTSCore.Models;

public class Race
{
	public Guid Id { get; set; }

	public string Name { get; set; }

	public bool IsDeleted { get; set; }

	public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

}
