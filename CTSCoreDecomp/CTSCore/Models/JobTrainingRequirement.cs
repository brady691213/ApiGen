using System;

namespace CTSCore.Models;

public class JobTrainingRequirement
{
	public Guid Id { get; set; }

	public Guid? JobTitleId { get; set; }

	public Guid? UnitStandardId { get; set; }

	public bool? IsActive { get; set; }

	public bool? IsDeleted { get; set; }

	public Guid? CourseId { get; set; }

	public int? RequirementType { get; set; }

	public Guid? SatisfyingRefId { get; set; }

	public virtual TrainingCourse? Course { get; set; }

	public virtual JobTitle? JobTitle { get; set; }
}
