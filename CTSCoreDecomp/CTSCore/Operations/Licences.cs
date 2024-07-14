using System;
using System.Collections.Generic;
using System.Linq;
using CTSCore.Models;
using Microsoft.EntityFrameworkCore;

namespace CTSCore.Operations;

public class Licences
{
	public List<LicenseApplicationIndex> GetLicenseApplicationsIndexForUser(Guid userToken)
	{
		CTSDBContext cTSDBContext = new CTSDBContext();
		try
		{
			return ((IQueryable<LicenseApplicationIndex>)cTSDBContext.LicenseApplicationIndices).Where((LicenseApplicationIndex x) => x.AssignedTo == userToken && x.IsCompleted == (bool?)false && x.IsDeleted == (bool?)false).ToList();
		}
		finally
		{
			((IDisposable)cTSDBContext)?.Dispose();
		}
	}

	public List<LicenseApplicationIndex> GetLicenseApplicationsIndexALL()
	{
		CTSDBContext cTSDBContext = new CTSDBContext();
		try
		{
			return ((IQueryable<LicenseApplicationIndex>)cTSDBContext.LicenseApplicationIndices).Where((LicenseApplicationIndex x) => x.IsCompleted == (bool?)false && x.IsDeleted == (bool?)false).ToList();
		}
		finally
		{
			((IDisposable)cTSDBContext)?.Dispose();
		}
	}

	public LicenseApplicationIndex GetLicenseApplicationIndex(Guid LicenseappID)
	{
		CTSDBContext cTSDBContext = new CTSDBContext();
		try
		{
			return ((IQueryable<LicenseApplicationIndex>)cTSDBContext.LicenseApplicationIndices).Where((LicenseApplicationIndex x) => x.Id == LicenseappID).FirstOrDefault();
		}
		finally
		{
			((IDisposable)cTSDBContext)?.Dispose();
		}
	}

	public bool ApproveLicense(Guid userToken, string userPIN, Guid licenseID, string deviceID, DateTime deviceTimestamp)
	{
		CTSDBContext cTSDBContext = new CTSDBContext();
		try
		{
			User user = ((IQueryable<User>)cTSDBContext.Users).Where((User x) => x.Id == userToken).FirstOrDefault();
			if (user.Password != userPIN)
			{
				throw new Exception("Incorrect PIN");
			}
			LicenseApplication licenseApplication = ((IQueryable<LicenseApplication>)cTSDBContext.LicenseApplications).Where((LicenseApplication x) => x.Id == licenseID).First();
			licenseApplication.Status = "Approved";
			licenseApplication.IsSigned = true;
			licenseApplication.AssignedTo = licenseApplication.Originator;
			licenseApplication.Notes = licenseApplication.Notes + "\r\n--------------------------------- \r\n On " + DateTime.Now.ToString() + " " + user.UserName + " wrote : \r\n--------------------------------- \r\nApplication Approved \r\n";
			((DbContext)cTSDBContext).SaveChanges();
			return true;
		}
		finally
		{
			((IDisposable)cTSDBContext)?.Dispose();
		}
	}
}
