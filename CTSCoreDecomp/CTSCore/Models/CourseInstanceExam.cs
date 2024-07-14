using System;
using System.Collections.Generic;

namespace CTSCore.Models;

public class CourseInstanceExam
{
	public Guid Id { get; set; }

	public bool IsDeleted { get; set; }

	public Guid CourseInstanceId { get; set; }

	public string Name { get; set; }

	public string? UnitStandardId { get; set; }

	public string? ExamInstructions { get; set; }

	public int DefaultPassMark { get; set; }

	public int DefaultTime { get; set; }

	public string? ContentBody { get; set; }

	public string? ContentText { get; set; }

	public bool IsAutoRebook { get; set; }

	public bool? IsOutcomesBased { get; set; }

	public bool IsFeedback { get; set; }

	public int AutoRebookCount { get; set; }

	public int? QuestionsToAsk { get; set; }

	public int? OrderId { get; set; }

	public Guid? NavigationId { get; set; }

	public string? FliePath { get; set; }

	public string? LmsPath { get; set; }

	public DateTime? StartDateTime { get; set; }

	public DateTime? EndDateTime { get; set; }

	public int? Score { get; set; }

	public virtual CourseInstance CourseInstance { get; set; }

	public virtual ICollection<CourseInstanceQuestion> CourseInstanceQuestions { get; set; } = new List<CourseInstanceQuestion>();

}
