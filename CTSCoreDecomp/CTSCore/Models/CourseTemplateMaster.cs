using System;
using System.Collections.Generic;

namespace CTSCore.Models;

public class CourseTemplateMaster
{
	public Guid Id { get; set; }

	public Guid? DesignStudioId { get; set; }

	public string? Name { get; set; }

	public string? Description { get; set; }

	public int? Version { get; set; }

	public int? DefaultPassmark { get; set; }

	public int? DefaultTime { get; set; }

	public bool? IsLiveFeedback { get; set; }

	public bool? IsOutcomesBased { get; set; }

	public bool? IsAutoRebook { get; set; }

	public int? AutoRebookCount { get; set; }

	public int? QuestionsTotal { get; set; }

	public int? QuestionstoAsk { get; set; }

	public bool? IsActive { get; set; }

	public bool? IsDeleted { get; set; }

	public virtual ICollection<CourseTemplate> CourseTemplates { get; set; } = new List<CourseTemplate>();

}
