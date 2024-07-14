using System;
using System.Collections.Generic;
using System.Linq;
using CTSCore.Models;

namespace CTSCore.Security;

internal class Permissions
{
	private bool CheckPermissions(Guid uToken, string Module, string Operation)
	{
		string Module2 = Module;
		string Operation2 = Operation;
		CTSDBContext cTSDBContext = new CTSDBContext();
		try
		{
			List<UserPrivilage> source = ((IQueryable<UserPrivilage>)cTSDBContext.UserPrivilages).Where((UserPrivilage x) => x.UserId == uToken).ToList();
			Privilege priv = ((IQueryable<Privilege>)cTSDBContext.Privileges).Where((Privilege x) => x.Module == Module2 && x.Privilege1 == Operation2).FirstOrDefault();
			if (priv == null)
			{
				return false;
			}
			if (source.Where((UserPrivilage x) => x.PrivilegeId == priv.Id).FirstOrDefault() == null)
			{
				return false;
			}
			return true;
		}
		finally
		{
			((IDisposable)cTSDBContext)?.Dispose();
		}
	}
}
