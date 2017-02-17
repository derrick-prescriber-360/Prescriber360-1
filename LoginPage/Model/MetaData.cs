using System;
using System.Collections.Generic;

namespace LoginPage
{
	public class MetaDataList
	{
		public List<MetaData> value { get; set; }
	}

	public class MetaData
	{
		public string name { get; set; }
		public string kind { get; set; }
		public string url { get; set; }
	}
}
