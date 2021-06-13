using DBApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBApp
{
	public interface IService
	{
		bool GetCategory(int id);
	}


	public class Dal : IService
	{
		CitusTrainingContext context; 
		public Dal(CitusTrainingContext s)
		{
			context = new CitusTrainingContext(); ;
		}

		public bool GetCategory(int id)
		{
			var cat = context.Categories.Find(id);
			if (cat != null)
			{
				return true;
			}
			return false;
		}
	}

	public class BizApp
	{
		IService serv;

		public BizApp(IService serv)
		{
			this.serv = serv;
		}

		public bool IsRecordExists(int id)
		{
			var res = serv.GetCategory(id);
			return res;
		}
	}
}
