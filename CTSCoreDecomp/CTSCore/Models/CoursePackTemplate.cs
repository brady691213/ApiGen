using System;

namespace CTSCore.Models;

public class CoursePackTemplate
{
	public Guid Id { get; set; }

	public Guid? CoursePackId { get; set; }

	public Guid? TemplateId { get; set; }

	public string? TemplateName { get; set; }

	public string? TemplateDescription { get; set; }

	public string? TemplateVersion { get; set; }

	public int? DefaultQuestions { get; set; }

	public int? CourseQuestions { get; set; }

	public int? DefaultPassmark { get; set; }

	public int? DefaultTime { get; set; }

	public bool? IsAutoRebook { get; set; }

	public int? AutoRebookCount { get; set; }

	public bool? IsOutcomesBased { get; set; }

	public bool? IsLiveFeedback { get; set; }

	public bool? IsActive { get; set; }

	public bool? IsDeletetd { get; set; }

	public virtual CoursePack? CoursePack { get; set; }
}
