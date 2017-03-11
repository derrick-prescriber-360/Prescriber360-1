using System;
using EventKit;

namespace LoginPage.iOS
{
	public class EventSingleton
	{
		public static EventSingleton Current
		{
			get { return current; }
		}
		private static EventSingleton current;

		public EKEventStore EventStore
		{
			get { return eventStore; }
		}
		protected EKEventStore eventStore;

		static EventSingleton()
		{
			current = new EventSingleton();
		}
		protected EventSingleton()
		{
			eventStore = new EKEventStore();
		}

	}
}
