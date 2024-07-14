using System;
using System.Collections.Generic;

namespace CTSCore.Models;

public class SmartClickCourseQuestion
{
	public Guid Id { get; set; }

	public Guid CourseId { get; set; }

	public Guid EmployeeId { get; set; }

	public string? CorrectAnswer { get; set; }

	public string? Responce { get; set; }

	public DateTime? ResponceDate { get; set; }

	public int? ClickerId { get; set; }

	public int? OrderId { get; set; }

	public string? QuestionText { get; set; }

	public string? QuestionBody { get; set; }

	public virtual ICollection<SmartClickCourseResponce> SmartClickCourseResponces { get; set; } = new List<SmartClickCourseResponce>();

}
