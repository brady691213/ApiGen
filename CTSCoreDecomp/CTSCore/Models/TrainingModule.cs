using System;

namespace CTSCore.Models;

public class TrainingModule
{
	public Guid Id { get; set; }

	public Guid? TrainingId { get; set; }

	public Guid? CouseModuleId { get; set; }

	public Guid? UnitStandardId { get; set; }

	public Guid? EmployeeId { get; set; }

	public string? Name { get; set; }

	public string? Description { get; set; }

	public bool? IsActive { get; set; }

	public bool? IsEnabled { get; set; }

	public bool? IsProcessed { get; set; }

	public bool? IsCompleted { get; set; }

	public DateOnly? DateCompleted { get; set; }

	public bool? DoesExpire { get; set; }

	public int? Validity { get; set; }

	public bool? IsExpired { get; set; }

	public virtual Training? Training { get; set; }
}
