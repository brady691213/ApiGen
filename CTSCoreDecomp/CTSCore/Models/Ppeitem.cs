using System;
using System.Collections.Generic;

namespace CTSCore.Models;

public class Ppeitem
{
	public Guid Id { get; set; }

	public string? Name { get; set; }

	public string? Description { get; set; }

	public Guid? SizeId { get; set; }

	public Guid? UnitId { get; set; }

	public int? Quantity { get; set; }

	public bool? IsDeleted { get; set; }

	public bool? IsActive { get; set; }

	public virtual ICollection<Ppeissue> Ppeissues { get; set; } = new List<Ppeissue>();

}
