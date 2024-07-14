using System;
using System.Collections.Generic;

namespace CTSCore.Models;

public class CourseInstance
{
	public Guid Id { get; set; }

	public string? Name { get; set; }

	public bool IsDeleted { get; set; }

	public Guid CourseTemplateId { get; set; }

	public int? ValidityMonths { get; set; }

	public Guid EmployeeId { get; set; }

	public Guid StatusId { get; set; }

	public bool AutoFeedbackEnabled { get; set; }

	public bool OutcomesBasedExams { get; set; }

	public bool AutoRebookEnabled { get; set; }

	public int RebookCount { get; set; }

	public int? RebookInstanceCount { get; set; }

	public bool Satisfied { get; set; }

	public string? ResultText { get; set; }

	public double? ResultScore { get; set; }

	public DateTime? BookingDate { get; set; }

	public DateTime? StartDate { get; set; }

	public DateTime? CompletionDate { get; set; }

	public DateTime? CompletionUploadDate { get; set; }

	public Guid? InstructorId { get; set; }

	public string? ResultFile { get; set; }

	public int? OrderId { get; set; }

	public Guid? NavigationId { get; set; }

	public string? CourseFilePath { get; set; }

	public string? CourseLmspath { get; set; }

	public Guid? ContentFileId { get; set; }

	public int? ClientStatus { get; set; }

	public Guid? ParentId { get; set; }

	public bool? IsUnrestricted { get; set; }

	public Guid? CtscourseId { get; set; }

	public virtual ICollection<CourseInstanceExam> CourseInstanceExams { get; set; } = new List<CourseInstanceExam>();


	public virtual CourseTemplate CourseTemplate { get; set; }

	public virtual ICollection<ESignature> ESignatures { get; set; } = new List<ESignature>();


	public virtual Employee Employee { get; set; }

	public virtual Employee? Instructor { get; set; }

	public virtual TrainingStatus Status { get; set; }
}
