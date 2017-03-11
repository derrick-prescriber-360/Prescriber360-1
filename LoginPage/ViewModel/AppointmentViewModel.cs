using System;
using System.ComponentModel;
using Xamarin.Forms;
using System.Diagnostics;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace LoginPage
{
	public class AppointmentViewModel : INotifyPropertyChanged
	{
		private bool isBusy;
		private JObject jsonData = null;
		private Repository repository = new Repository();
		private ObservableCollection<Appointment> _filteredappointmentcontactlist = new ObservableCollection<Appointment>();
		private List<Appointment> _appointmentlist = new List<Appointment>();
		private bool isRefreshing;

		public AppointmentViewModel(INavigation navigation)
		{
			if ((GlobalVariables.GlobalAppointmentList == null) || (GlobalVariables.GlobalAppointmentList.Count == 0))
				Initialize();
			else
			{
				foreach (var c in GlobalVariables.GlobalAppointmentList)
				{
					AppointmentList.Add(c);
					_appointmentlist.Add(c);
				}
			}
		}

		public ObservableCollection<Appointment> AppointmentList
		{
			get
			{
				return _filteredappointmentcontactlist;
			}
			set
			{
				_filteredappointmentcontactlist = value;
				OnPropertyChanged("PrescriberContactList");
			}
		}

		public bool IsBusy
		{
			get
			{
				return isBusy;
			}

			set
			{
				isBusy = value;
				OnPropertyChanged("IsBusy");
			}
		}

		public bool IsRefreshing
		{
			get
			{
				return isRefreshing;
			}

			set
			{
				isRefreshing = value;
				OnPropertyChanged("IsRefreshing");
			}
		}


		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this,
					new PropertyChangedEventArgs(propertyName));
			}
		}

		public async void Initialize()
		{
			try
			{
				IsBusy = true;
				_appointmentlist = await GetAppointmentList();

				foreach (var c in _appointmentlist)
				{
					AppointmentList.Add(c);
					GlobalVariables.GlobalAppointmentList.Add(c);
				}
				IsBusy = false;
			}

			catch (Exception err)
			{
				IsBusy = false;
				Debug.WriteLine(err.Message);
			}
		}

		public async void Refresh()
		{
			try
			{
				IsRefreshing = true;
				_appointmentlist.Clear();
				AppointmentList.Clear();
				GlobalVariables.GlobalAppointmentList.Clear();
				_appointmentlist = await GetAppointmentList();

				foreach (var c in _appointmentlist)
				{
					AppointmentList.Add(c);
					GlobalVariables.GlobalAppointmentList.Add(c);
				}
				IsRefreshing = false;
			}

			catch (Exception err)
			{
				IsRefreshing = false;
				Debug.WriteLine(err.Message);
			}
		}

		public async Task<List<Appointment>> GetAppointmentList()
		{
			try
			{
				jsonData = await repository.Retrieve(GlobalVariables.AuthToken, "appointments", "");
				var contactdata = JsonConvert.DeserializeObject<AppointmentList>(jsonData.ToString());
				return contactdata.value;
			}
			catch (Exception err)
			{
				Debug.WriteLine(err.Message);
				var a = new App();
				a.Logout();
			}

			return null;
		}

		public void FilterContactList(string text)
		{
			try
			{
				AppointmentList.Clear();
				foreach (var c in _appointmentlist)
				{
					if (c.description.ToLower().Contains(text.ToLower()))
					{
						AppointmentList.Add(c);
					}
				}
			}
			catch (Exception err)
			{
				Debug.WriteLine(err.Message);
			}

		}
	}
}
