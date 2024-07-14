using System;

namespace CTSCore.Models;

public class CourseInstanceQuestion
{
	public Guid Id { get; set; }

	public bool IsDeleted { get; set; }

	public Guid CourseInstanceExamId { get; set; }

	public Guid? CourseTemplateQuestionId { get; set; }

	public string? Name { get; set; }

	public string? Text { get; set; }

	public string? Body { get; set; }

	public string? Type { get; set; }

	public string? Answer { get; set; }

	public string? Description { get; set; }

	public int Marks { get; set; }

	public bool IsAlwaysAsked { get; set; }

	public string? FeedbackText { get; set; }

	public string? FeedbackBody { get; set; }

	public int? OrderId { get; set; }

	public Guid? NavigationId { get; set; }

	public string? FilePath { get; set; }

	public string? Lmspath { get; set; }

	public string? CandidateAnswer { get; set; }

	public virtual CourseInstanceExam CourseInstanceExam { get; set; }

	public virtual CourseTemplateQuestion? CourseTemplateQuestion { get; set; }
}
