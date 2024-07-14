using System;
using System.Collections.Generic;

namespace CTSCore.Models;

public class JobTitle
{
	public Guid Id { get; set; }

	public string? Description { get; set; }

	public string Name { get; set; }

	public bool IsDeleted { get; set; }

	public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();


	public virtual ICollection<JobTrainingRequirement> JobTrainingRequirements { get; set; } = new List<JobTrainingRequirement>();

}
