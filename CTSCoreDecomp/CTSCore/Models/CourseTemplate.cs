using System;
using System.Collections.Generic;

namespace CTSCore.Models;

public class CourseTemplate
{
	public Guid Id { get; set; }

	public Guid? CourseMasterId { get; set; }

	public bool IsDeleted { get; set; }

	public Guid CourseTypeId { get; set; }

	public string Name { get; set; }

	public string? Description { get; set; }

	public string? Author { get; set; }

	public DateTime? ClientCreatedDate { get; set; }

	public DateTime? ClientModifiedDate { get; set; }

	public string? ClientModifiedBy { get; set; }

	public string? TemplateVersion { get; set; }

	public Guid? TemplateId { get; set; }

	public string? ProductVersion { get; set; }

	public int? ValidityMonths { get; set; }

	public int? CourseDurationDays { get; set; }

	public string? WelcomePage { get; set; }

	public int? OrderId { get; set; }

	public string? CourseFilePath { get; set; }

	public string? CourseLmspath { get; set; }

	public Guid? ContentFileId { get; set; }

	public string? FileName { get; set; }

	public string? MasterDocumentRev { get; set; }

	public string? MasterDocument { get; set; }

	public string? ChangeLog { get; set; }

	public Guid? MasterCopyId { get; set; }

	public virtual ICollection<CourseInstance> CourseInstances { get; set; } = new List<CourseInstance>();


	public virtual CourseTemplateMaster? CourseMaster { get; set; }

	public virtual ICollection<CourseTemplateContent> CourseTemplateContents { get; set; } = new List<CourseTemplateContent>();


	public virtual ICollection<CourseTemplateExam> CourseTemplateExams { get; set; } = new List<CourseTemplateExam>();


	public virtual ICollection<CourseTemplateQuestion> CourseTemplateQuestions { get; set; } = new List<CourseTemplateQuestion>();


	public virtual CourseType CourseType { get; set; }
}
