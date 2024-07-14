using System;

namespace CTSCore.Models;

public class TrainingCreditModule
{
	public Guid TrainingCreditModuleId { get; set; }

	public Guid? TrainingModuleId { get; set; }

	public Guid? CreditSourceId { get; set; }

	public Guid? CreditSourceChannel { get; set; }

	public bool? IsActive { get; set; }

	public bool? IsDeleted { get; set; }
}
