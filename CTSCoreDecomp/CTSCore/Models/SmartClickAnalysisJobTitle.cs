using System;

namespace CTSCore.Models;

public class SmartClickAnalysisJobTitle
{
	public string? CourseName { get; set; }

	public string? QuestionText { get; set; }

	public Guid Id { get; set; }

	public Guid Questionid { get; set; }

	public string? EmployeeRef { get; set; }

	public string? TestType { get; set; }

	public DateTime? CourseDate { get; set; }

	public Guid? TemplateId { get; set; }

	public Guid? DesignCourseId { get; set; }

	public Guid LocalCourseId { get; set; }

	public string? Correct { get; set; }

	public string? Responce { get; set; }

	public string? JobTitle { get; set; }
}
