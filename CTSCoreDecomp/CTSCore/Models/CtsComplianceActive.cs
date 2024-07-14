using System;

namespace CTSCore.Models;

public class CtsComplianceActive
{
	public string Refnum { get; set; }

	public string Fullnames { get; set; }

	public string Surname { get; set; }

	public string Idnum { get; set; }

	public string? Coursename { get; set; }

	public DateTime? Datecompleted { get; set; }

	public DateTime? Expirydate { get; set; }
}
