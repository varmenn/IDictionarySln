using Homework1_ConsApp.src.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_ConsApp.src.extensions
{
	public static class DictionaryExtension
	{
		public static void AddToDictionary<TKey, TValue>(
		this IDictionary<TKey, TValue> values,
		IList<TValue> users,
		IDictionary<TKey, IList<TKey>> indexList
		)
		where TValue : IUser
		where TKey : notnull
		{
			TKey castToKey(object key)
			{
				return (TKey)key;
			};
			void addIndex(object findKeyObject, TKey dataKey)
			{
				TKey findKey = castToKey(findKeyObject);
				if (indexList.ContainsKey(findKey))
				{
					indexList[findKey].Add(dataKey);
				}
				else
				{
					indexList.Add(findKey, new List<TKey>() { dataKey });
				}
			};
			users?.ToList().ForEach(user =>
			{
				TKey key = castToKey(user.UserName);
				values.Add(key, user);
				addIndex(user.FirstName, key);
				addIndex(user.LastName, key);
				addIndex(user.UserIDnumber, key);
				
				var personal = user.CastTo<IPersonal>();
				if (personal != null)
				{
					addIndex(personal.SSN, key);
					addIndex(personal.Salary.ToString(), key);
				}
				var student = user.CastTo<IStudent>();
				if (student != null)
				{
					addIndex(student.AbsenceCount, key);
					addIndex(student.Marks, key);
					addIndex(student.StudentID,key);
				}
				var Jobber = user.CastTo<IJobber>();
				if (student != null)
				{
					addIndex(Jobber.PlateID, key);
					addIndex(Jobber.JobArea, key);
					
				}
			});
		}
		public static TObject? CastTo<TObject>(this object value)
		where TObject : class
		{
			if (value is TObject)
			{
				return value as TObject;
			}
			return null;
		}
	}
}
