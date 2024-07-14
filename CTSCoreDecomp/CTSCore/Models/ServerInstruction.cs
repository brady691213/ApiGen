using System;

namespace CTSCore.Models;

public class ServerInstruction
{
	public Guid Id { get; set; }

	public int? ProcessIdentifier { get; set; }

	public string? Process { get; set; }

	public Guid? TargetId { get; set; }

	public DateTime? RequestDate { get; set; }

	public string? OriginatorIp { get; set; }

	public string? Originator { get; set; }

	public bool? IsProcessed { get; set; }

	public string? Result { get; set; }

	public DateTime? ProcessedDate { get; set; }

	public string? ServerMessage { get; set; }

	public Guid? ParamId { get; set; }

	public int? ParamType { get; set; }

	public string? ParamData { get; set; }
}
