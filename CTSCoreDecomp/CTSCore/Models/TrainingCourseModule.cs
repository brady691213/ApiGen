using System;

namespace CTSCore.Models;

public class TrainingCourseModule
{
	public Guid Id { get; set; }

	public Guid? TrainingCourseId { get; set; }

	public Guid? UnitStandardId { get; set; }

	public string? ModuleName { get; set; }

	public bool? IsActive { get; set; }

	public bool? IsDeleted { get; set; }

	public bool? DoesExpire { get; set; }

	public int? Validity { get; set; }

	public virtual TrainingCourse? TrainingCourse { get; set; }
}
