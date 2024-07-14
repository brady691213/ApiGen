using System;
using System.Linq;
using CTSCore.Models;

namespace CTSCore.Security;

public class Users
{
	public Guid LoginUser(string username, string password)
	{
		string username2 = username;
		string password2 = password;
		try
		{
			CTSDBContext cTSDBContext = new CTSDBContext();
			try
			{
				return ((IQueryable<User>)cTSDBContext.Users).Where((User x) => x.UserName == username2 && x.Password == password2).FirstOrDefault()?.Id ?? Guid.Empty;
			}
			finally
			{
				((IDisposable)cTSDBContext)?.Dispose();
			}
		}
		catch (Exception)
		{
			throw;
		}
	}

	public bool CheckUserRole(Guid userToken, string UserRole)
	{
		string UserRole2 = UserRole;
		CTSDBContext cTSDBContext = new CTSDBContext();
		try
		{
			if (((IQueryable<RoleUserIndex>)cTSDBContext.RoleUserIndices).Where((RoleUserIndex x) => x.UserId == userToken && x.Name == UserRole2).FirstOrDefault() != null)
			{
				return true;
			}
			return false;
		}
		finally
		{
			((IDisposable)cTSDBContext)?.Dispose();
		}
	}
}
