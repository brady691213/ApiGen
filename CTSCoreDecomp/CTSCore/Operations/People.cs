using System;
using System.Collections.Generic;
using System.Linq;
using CTSCore.Models;
using Microsoft.EntityFrameworkCore;

namespace CTSCore.Operations;

public class People
{
	public Employee GetPerson(Guid ID)
	{
		CTSDBContext cTSDBContext = new CTSDBContext();
		try
		{
			return ((IQueryable<Employee>)cTSDBContext.Employees).Where((Employee x) => x.Id == ID).FirstOrDefault();
		}
		finally
		{
			((IDisposable)cTSDBContext)?.Dispose();
		}
	}

	public List<Employee> GetPeopleAll(Guid uToken)
	{
		CTSDBContext cTSDBContext = new CTSDBContext();
		try
		{
			return ((IEnumerable<Employee>)cTSDBContext.Employees).ToList();
		}
		finally
		{
			((IDisposable)cTSDBContext)?.Dispose();
		}
	}

	public Employee GetPersonProfile(Guid id)
	{
		CTSDBContext cTSDBContext = new CTSDBContext();
		try
		{
			return EntityFrameworkQueryableExtensions.Include<Employee>(EntityFrameworkQueryableExtensions.Include<Employee>(((IQueryable<Employee>)cTSDBContext.Employees).Where((Employee x) => x.Id == id), "CourseInstanceEmployees"), "SmartClickCourses").FirstOrDefault();
		}
		finally
		{
			((IDisposable)cTSDBContext)?.Dispose();
		}
	}

	public void AddPerson(Employee emp)
	{
		CTSDBContext cTSDBContext = new CTSDBContext();
		try
		{
		}
		finally
		{
			((IDisposable)cTSDBContext)?.Dispose();
		}
	}
}
