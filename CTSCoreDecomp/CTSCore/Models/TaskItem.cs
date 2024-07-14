using System;

namespace CTSCore.Models;

public class TaskItem
{
	public Guid TaskItemId { get; set; }

	public Guid? TaskItemTemplateId { get; set; }

	public Guid? OriginatorId { get; set; }

	public Guid? AsigneeId { get; set; }

	public DateTime? DateOriginated { get; set; }

	public Guid? TaskStatusId { get; set; }

	public DateTime? DateClosed { get; set; }

	public Guid? TaskTargetId { get; set; }

	public string? TaskTargetTypeId { get; set; }

	public string? TaskDescription { get; set; }
}
