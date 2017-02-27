using System;
using System.Collections.Generic;

namespace LoginPage
{
	public class Appointment
	{
		public string scheduledstart { get; set; }
		public int scheduleddurationminutes { get; set; }
		public int statuscode { get; set; }
		public bool isbilled { get; set; }
		public string description { get; set; }
		public string createdon { get; set; }
		public int statecode { get; set; }
		public string location { get; set; }
		public string subject { get; set; }
		public string _ownerid_value { get; set; }
		public string modifiedon { get; set; }
		public int versionnumber { get; set; }
		public int prioritycode { get; set; }
		public string _transactioncurrencyid_value { get; set; }
		public double exchangerate { get; set; }
		public int timezoneruleversionnumber { get; set; }
		public bool isregularactivity { get; set; }
		public bool isalldayevent { get; set; }
		public bool ismapiprivate { get; set; }
		public string _modifiedby_value { get; set; }
		public string actualstart { get; set; }
		public string activitytypecode { get; set; }
		public int instancetypecode { get; set; }
		public bool isworkflowcreated { get; set; }
		public string _createdby_value { get; set; }
		public int attachmenterrors { get; set; }
		public string _owningbusinessunit_value { get; set; }
		public string _owninguser_value { get; set; }
		public string activityid { get; set; }
		public string scheduledend { get; set; }
		public object activityadditionalparams { get; set; }
		public object _regardingobjectid_value { get; set; }
		public object lastonholdtime { get; set; }
		public object _sendermailboxid_value { get; set; }
		public object _modifiedonbehalfby_value { get; set; }
		public object _slainvokedid_value { get; set; }
		public object postponeactivityprocessinguntil { get; set; }
		public object deliveryprioritycode { get; set; }
		public object _owningteam_value { get; set; }
		public object traversedpath { get; set; }
		public object actualend { get; set; }
		public object actualdurationminutes { get; set; }
		public object _serviceid_value { get; set; }
		public object _createdonbehalfby_value { get; set; }
		public object seriesid { get; set; }
		public object leftvoicemail { get; set; }
		public object senton { get; set; }
		public object processid { get; set; }
		public object community { get; set; }
		public object utcconversiontimezonecode { get; set; }
		public object deliverylastattemptedon { get; set; }
		public object stageid { get; set; }
		public object onholdtime { get; set; }
		public object _slaid_value { get; set; }
		public object overriddencreatedon { get; set; }
		public object importsequencenumber { get; set; }
		public object subscriptionid { get; set; }
		public object modifiedfieldsmask { get; set; }
		public object globalobjectid { get; set; }
		public object outlookownerapptid { get; set; }
		public object subcategory { get; set; }
		public object originalstartdate { get; set; }
		public object category { get; set; }
	}

	public class AppointmentList
	{
		public List<Appointment> value { get; set; }
	}
}
