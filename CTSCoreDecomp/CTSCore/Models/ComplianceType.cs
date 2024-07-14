using System;
using System.Collections.Generic;

namespace CTSCore.Models;

public class ComplianceType
{
	public Guid ComplianceTypeId { get; set; }

	public string? Name { get; set; }

	public bool? DoesExpire { get; set; }

	public int? ValidForMonths { get; set; }

	public bool? IsActive { get; set; }

	public bool? IsDeleted { get; set; }

	public virtual ICollection<EmployeeCompliance> EmployeeCompliances { get; set; } = new List<EmployeeCompliance>();

}
