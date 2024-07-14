using System;
using System.Collections.Generic;

namespace CTSCore.Models;

public class TrainingCourse
{
	public Guid Id { get; set; }

	public string? CourseName { get; set; }

	public string? CourseDescription { get; set; }

	public string? Duration { get; set; }

	public bool? IsActive { get; set; }

	public bool? IsDeleted { get; set; }

	public Guid? CouseType { get; set; }

	public Guid? Channel { get; set; }

	public Guid? ChannelRef { get; set; }

	public bool? DoesExpire { get; set; }

	public int? Validity { get; set; }

	public Guid? CategoryId { get; set; }

	public Guid? QualificationId { get; set; }

	public Guid? SpecialisationId { get; set; }

	public string? SpecialisationNoLookup { get; set; }

	public virtual ICollection<JobTrainingRequirement> JobTrainingRequirements { get; set; } = new List<JobTrainingRequirement>();


	public virtual ICollection<Training> Training { get; set; } = new List<Training>();


	public virtual ICollection<TrainingCourseModule> TrainingCourseModules { get; set; } = new List<TrainingCourseModule>();

}
