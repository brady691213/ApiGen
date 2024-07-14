using System;

namespace CTSCore.Models;

public class SmartClickCourseResponce
{
	public Guid Id { get; set; }

	public Guid? CourseId { get; set; }

	public Guid? QuestionId { get; set; }

	public string? Responce { get; set; }

	public string? Correct { get; set; }

	public bool? IsDeleted { get; set; }

	public virtual SmartClickCourse? Course { get; set; }

	public virtual SmartClickCourseQuestion? Question { get; set; }
}
