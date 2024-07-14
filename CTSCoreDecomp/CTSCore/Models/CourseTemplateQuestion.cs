using System;
using System.Collections.Generic;

namespace CTSCore.Models;

public class CourseTemplateQuestion
{
	public Guid Id { get; set; }

	public Guid ClientQuestionId { get; set; }

	public bool IsDeleted { get; set; }

	public Guid? CourseTemplateExamId { get; set; }

	public Guid? CourseTemplateId { get; set; }

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

	public virtual ICollection<CourseInstanceQuestion> CourseInstanceQuestions { get; set; } = new List<CourseInstanceQuestion>();


	public virtual CourseTemplate? CourseTemplate { get; set; }

	public virtual CourseTemplateExam? CourseTemplateExam { get; set; }
}
