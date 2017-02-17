using System;
using SQLite;
using Xamarin.Forms;
using LoginPage.iOS;
using System.IO;

[assembly: Dependency(typeof(Sqlite))]
namespace LoginPage.iOS
{
	public class Sqlite : ISqlite
	{
		public Sqlite()
		{
		}

		public SQLiteConnection GetConnection()
		{
			var fileName = "datatbase.db3";
			var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			var libraryPath = Path.Combine(documentsPath, "..", "Library");
			var path = Path.Combine(libraryPath, fileName);

			var platform = new SQLite.Net.Platform.XamarinIOS.SQLitePlatformIOS();
			var connection = new SQLite.Net.SQLiteConnection(platform, path);

			return connection;
		}

	}
}
