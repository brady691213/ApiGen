using System;

namespace CTSCore.Models;

public class ReportsWorkbench
{
	public Guid ReportId { get; set; }

	public string? Name { get; set; }

	public string? Description { get; set; }

	public string? CreatedBy { get; set; }

	public DateTime? DateCreated { get; set; }

	public string? ModifiedBy { get; set; }

	public DateTime? DateModified { get; set; }

	public bool? IsDeleted { get; set; }

	public bool IsActive { get; set; }

	public bool IsSystem { get; set; }

	public string? ReportData { get; set; }

	public int? TemplateType { get; set; }
}
