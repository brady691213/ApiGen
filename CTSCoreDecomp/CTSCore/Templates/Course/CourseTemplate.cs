using System;
using System.Collections.Generic;
using System.Linq;
using CTSCore.Models;

namespace CTSCore.Templates.Course;

public class CourseTemplate
{
	public List<CourseTemplateMaster> GetCourseTemplateMasters()
	{
		CTSDBContext cTSDBContext = new CTSDBContext();
		try
		{
			return ((IQueryable<CourseTemplateMaster>)cTSDBContext.CourseTemplateMasters).Where((CourseTemplateMaster x) => x.IsActive == (bool?)true && x.IsDeleted == (bool?)false).ToList();
		}
		finally
		{
			((IDisposable)cTSDBContext)?.Dispose();
		}
	}

	public CourseTemplateMaster GetCourseTemplateMaster(Guid CMasterID)
	{
		CTSDBContext cTSDBContext = new CTSDBContext();
		try
		{
			return ((IQueryable<CourseTemplateMaster>)cTSDBContext.CourseTemplateMasters).Where((CourseTemplateMaster x) => x.Id == CMasterID && x.IsDeleted == (bool?)false && x.IsActive == (bool?)true).FirstOrDefault();
		}
		finally
		{
			((IDisposable)cTSDBContext)?.Dispose();
		}
	}

	public void AddCourseTemplateMater(CourseTemplateMaster templateMaster)
	{
		CTSDBContext cTSDBContext = new CTSDBContext();
		try
		{
			cTSDBContext.CourseTemplateMasters.Add(templateMaster);
		}
		finally
		{
			((IDisposable)cTSDBContext)?.Dispose();
		}
	}

	public void EditCourseTemplateMaster(CourseTemplateMaster templateMaster)
	{
	}
}
