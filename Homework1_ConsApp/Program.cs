using Homework1_ConsApp.src.extensions;
using Homework1_ConsApp.src.interfaces;
using Homework1_ConsApp.src.model;
using Homework1_ConsApp.src.repository;
using Newtonsoft.Json;
using System;

var PersonalData = JsonConvert.DeserializeObject<IList<Personal>>(Datas.PersonalJson);
var StudentData = JsonConvert.DeserializeObject<IList<Student>>(Datas.StudentJson);
var JobberData = JsonConvert.DeserializeObject<IList<Jobber>>(Datas.JobberJson);

IDictionary<string, IList<string>> indexList = new Dictionary<string, IList<string>>();
IDictionary<string, IUser> userList = new Dictionary<string, IUser>();

userList.AddToDictionary(JobberData.Select(user => (user as IUser)).ToList(), indexList);

var allUsers = FindByIndex("Popescu");
allUsers.ToList().ForEach(user => Console.WriteLine("\n" + JsonConvert.SerializeObject(user)));
Console.ReadKey();

IList<IUser>? FindByIndex(string search)
{
	if (indexList.ContainsKey(search))
	{
		var foundedKeys = indexList[search];
		return foundedKeys.Select(key => userList[key]).ToList();
	}
	return null;
}