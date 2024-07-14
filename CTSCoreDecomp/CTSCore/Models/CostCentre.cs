using System;
using System.Collections.Generic;

namespace CTSCore.Models;

public class CostCentre
{
	public Guid Id { get; set; }

	public string? CostCode { get; set; }

	public string? CostCentreName { get; set; }

	public bool? IsDeleted { get; set; }

	public bool? IsActive { get; set; }

	public virtual ICollection<Training> Training { get; set; } = new List<Training>();

}
