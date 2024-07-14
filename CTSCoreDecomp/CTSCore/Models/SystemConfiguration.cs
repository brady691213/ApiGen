using System;

namespace CTSCore.Models;

public class SystemConfiguration
{
	public Guid CompanyId { get; set; }

	public string? CompanyName { get; set; }

	public string? CompanyReg { get; set; }

	public string? CompanyVat { get; set; }

	public int? ServerLicenceCount { get; set; }

	public int? DbversionMajor { get; set; }

	public int? DbversionMinor { get; set; }

	public string? LicenseKey { get; set; }

	public int? ClientRuntimeCount { get; set; }

	public string? ServerVersion { get; set; }

	public string? SqlserverVersion { get; set; }

	public int? AdminRuntimeCount { get; set; }

	public DateTime? DateInstalled { get; set; }

	public DateTime? DateLastUpgrade { get; set; }

	public string? LowestDesignToolVersion { get; set; }

	public string? LowestDatabaseVersion { get; set; }

	public string? UpgradePath { get; set; }

	public bool? SendNotifications { get; set; }

	public string? MailFrom { get; set; }

	public string? Smtpserver { get; set; }
}
