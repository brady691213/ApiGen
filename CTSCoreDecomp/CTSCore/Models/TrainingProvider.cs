using System;
using System.Collections.Generic;

namespace CTSCore.Models;

public class TrainingProvider
{
	public Guid Id { get; set; }

	public string? ProviderName { get; set; }

	public bool? IsDeleted { get; set; }

	public bool? IsActive { get; set; }

	public virtual ICollection<Training> Training { get; set; } = new List<Training>();

}
