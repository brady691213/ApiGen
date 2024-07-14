using System;
using System.Collections.Generic;

namespace CTSCore.Models;

public class TrainingChannel
{
	public Guid Id { get; set; }

	public string? ChannelName { get; set; }

	public string? Description { get; set; }

	public bool? IsActive { get; set; }

	public bool? IsDeleted { get; set; }

	public virtual ICollection<Training> Training { get; set; } = new List<Training>();

}
