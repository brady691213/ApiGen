using System;

namespace CTSCore.Models;

public class PreSetNote
{
	public Guid Id { get; set; }

	public Guid? CategoryId { get; set; }

	public string? NoteText { get; set; }

	public bool? IsActive { get; set; }

	public bool? IsDeleted { get; set; }
}
