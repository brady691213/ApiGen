using System;

namespace CTSCore.Models;

public class SmartClickTemplate
{
	public Guid Id { get; set; }

	public Guid? TemplateId { get; set; }

	public Guid? DesignId { get; set; }

	public string? TemplateName { get; set; }

	public string? TemplateDescription { get; set; }

	public DateTime? CreateDate { get; set; }

	public string? CreatedBy { get; set; }

	public DateTime? ModifiedDate { get; set; }

	public string? ModifiedBy { get; set; }

	public string? TemplateVersion { get; set; }

	public DateTime? DateImported { get; set; }

	public Guid? ImportedBy { get; set; }

	public bool? IsDeleted { get; set; }

	public bool? IsActive { get; set; }

	public string? FileName { get; set; }
}
