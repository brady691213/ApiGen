using System;
using System.Collections.Generic;
using System.Linq;
using CTSCore.Models;

namespace CTSCore.Utilities;

public class Utils
{
	public List<EmployeeIndex> GetSearchList()
	{
		CTSDBContext cTSDBContext = new CTSDBContext();
		try
		{
			return ((IEnumerable<EmployeeIndex>)cTSDBContext.EmployeeIndices).ToList();
		}
		finally
		{
			((IDisposable)cTSDBContext)?.Dispose();
		}
	}
}
