using System;

namespace CTSCore.Models;

public class CtsComplianceAllEmp
{
	public string RefNum { get; set; }

	public string Surname { get; set; }

	public string FullNames { get; set; }

	public string IdNum { get; set; }

	public string? Coursename { get; set; }

	public DateTime? Datecompleted { get; set; }

	public DateTime? Expirydate { get; set; }

	public Guid StatusId { get; set; }
}
