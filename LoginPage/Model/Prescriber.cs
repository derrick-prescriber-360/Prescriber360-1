﻿using System;
using System.Collections.Generic;

namespace LoginPage
{
	public class ContactList
	{
		public List<Prescriber> value { get; set; }
	}

	public class Prescriber
	{
		public int customertypecode { get; set; }
		public string mobilephone { get; set; }
		public string yomifullname { get; set; }
		public bool merged { get; set; }
		public int territorycode { get; set; }
		public int haschildrencode { get; set; }
		public double? exchangerate { get; set; }
		public int preferredappointmenttimecode { get; set; }
		public bool isbackofficecustomer { get; set; }
		public string _owningbusinessunit_value { get; set; }
		public string _owninguser_value { get; set; }
		public bool vcm_sculptratrainingcompleted { get; set; }
		public bool vcm_podiatry { get; set; }
		public string lastname { get; set; }
		public bool donotpostalmail { get; set; }
		public bool donotphone { get; set; }
		public int preferredcontactmethodcode { get; set; }
		public string _ownerid_value { get; set; }
		public int vcm_prescriberstatus { get; set; }
		public int customersizecode { get; set; }
		public string firstname { get; set; }
		public int vcm_leadresolution { get; set; }
		public int address2_addresstypecode { get; set; }
		public bool vcm_maillocked { get; set; }
		public bool donotemail { get; set; }
		public int address2_shippingmethodcode { get; set; }
		public string fullname { get; set; }
		public string address1_addressid { get; set; }
		public int address2_freighttermscode { get; set; }
		public int statuscode { get; set; }
		public string createdon { get; set; }
		public int versionnumber { get; set; }
		public bool donotsendmm { get; set; }
		public bool donotfax { get; set; }
		public int leadsourcecode { get; set; }
		public bool vcm_dermatology { get; set; }
		public string modifiedon { get; set; }
		public bool creditonhold { get; set; }
		public bool vcm_emaillocked { get; set; }
		public bool vcm_removetemp { get; set; }
		public bool vcm_amaa0a2new { get; set; }
		public string _transactioncurrencyid_value { get; set; }
		public string address3_addressid { get; set; }
		public bool vcm_amaa0a1new { get; set; }
		public bool donotbulkemail { get; set; }
		public string _modifiedby_value { get; set; }
		public bool vcm_cmanew { get; set; }
		public string _createdby_value { get; set; }
		public bool donotbulkpostalmail { get; set; }
		public bool vcm_pdrp { get; set; }
		public string contactid { get; set; }
		public bool vcm_aesthetics { get; set; }
		public bool participatesinworkflow { get; set; }
		public int statecode { get; set; }
		public bool vcm_nocontact { get; set; }
		public string address2_addressid { get; set; }
		public bool vcm_practicingnew { get; set; }
		public bool vcm_faxlocked { get; set; }
		public int shippingmethodcode { get; set; }
		public object address3_city { get; set; }
		public object address2_line2 { get; set; }
		public object assistantphone { get; set; }
		public object utcconversiontimezonecode { get; set; }
		public object address1_county { get; set; }
		public object address3_line3 { get; set; }
		public object yomimiddlename { get; set; }
		public object ftpsiteurl { get; set; }
		public object address1_longitude { get; set; }
		public object accountrolecode { get; set; }
		public object address1_postalcode { get; set; }
		public object pager { get; set; }
		public object address3_postalcode { get; set; }
		public object _createdbyexternalparty_value { get; set; }
		public object address1_composite { get; set; }
		public object assistantname { get; set; }
		public object anniversary { get; set; }
		public object governmentid { get; set; }
		public object vcm_customerid { get; set; }
		public object emailaddress3 { get; set; }
		public object address2_telephone1 { get; set; }
		public object address1_upszone { get; set; }
		public object address3_utcoffset { get; set; }
		public object _vcm_shippingaddress_value { get; set; }
		public object address2_stateorprovince { get; set; }
		public object _defaultpricelevelid_value { get; set; }
		public object address3_telephone3 { get; set; }
		public object _vcm_managerid_value { get; set; }
		public object salutation { get; set; }
		public object address1_telephone3 { get; set; }
		public object birthdate { get; set; }
		public object familystatuscode { get; set; }
		public object yomilastname { get; set; }
		public object lastusedincampaign { get; set; }
		public object _parentcustomerid_value { get; set; }
		public object address2_country { get; set; }
		public object aging60 { get; set; }
		public object address1_telephone2 { get; set; }
		public object address2_longitude { get; set; }
		public object vcm_recordtype { get; set; }
		public object _owningteam_value { get; set; }
		public object nickname { get; set; }
		public object address1_country { get; set; }
		public object address1_telephone1 { get; set; }
		public object _accountid_value { get; set; }
		public object _parentcontactid_value { get; set; }
		public object entityimage_url { get; set; }
		public object address3_longitude { get; set; }
		public object address2_city { get; set; }
		public object address1_freighttermscode { get; set; }
		public object externaluseridentifier { get; set; }
		public object address3_name { get; set; }
		public object entityimage { get; set; }
		public object subscriptionid { get; set; }
		public object overriddencreatedon { get; set; }
		public object yomifirstname { get; set; }
		public object _vcm_homeaddress_value { get; set; }
		public object paymenttermscode { get; set; }
		public object address1_primarycontactname { get; set; }
		public object processid { get; set; }
		public object vcm_salesforcecontactid { get; set; }
		public object vcm_creditstatus { get; set; }
		public object _masterid_value { get; set; }
		public object managerphone { get; set; }
		public object address1_utcoffset { get; set; }
		public object address2_latitude { get; set; }
		public object creditlimit_base { get; set; }
		public object address1_city { get; set; }
		public object address3_latitude { get; set; }
		public object callback { get; set; }
		public object middlename { get; set; }
		public object aging30 { get; set; }
		public object company { get; set; }
		public object address2_utcoffset { get; set; }
		public object vcm_status { get; set; }
		public object numberofchildren { get; set; }
		public object vcm_creditbalance { get; set; }
		public object gendercode { get; set; }
		public object _modifiedbyexternalparty_value { get; set; }
		public object address2_line3 { get; set; }
		public object telephone2 { get; set; }
		public object address3_upszone { get; set; }
		public object address3_line1 { get; set; }
		public object emailaddress1 { get; set; }
		public object vcm_valeantid { get; set; }
		public object address1_stateorprovince { get; set; }
		public object lastonholdtime { get; set; }
		public object _originatingleadid_value { get; set; }
		public object aging30_base { get; set; }
		public object annualincome_base { get; set; }
		public object vcm_sampleenrollmentformnumber { get; set; }
		public object childrensnames { get; set; }
		public object vcm_leadresolutioncomments { get; set; }
		public object address3_line2 { get; set; }
		public object address1_name { get; set; }
		public object department { get; set; }
		public object educationcode { get; set; }
		public object address2_telephone3 { get; set; }
		public object business2 { get; set; }
		public object entityimageid { get; set; }
		public object _vcm_country_value { get; set; }
		public object vcm_sculptratrainingcompleteddescription { get; set; }
		public object address1_latitude { get; set; }
		public object address1_postofficebox { get; set; }
		public object spousesname { get; set; }
		public object address3_county { get; set; }
		public object home2 { get; set; }
		public object address2_county { get; set; }
		public object traversedpath { get; set; }
		public object address2_fax { get; set; }
		public object address2_composite { get; set; }
		public object creditlimit { get; set; }
		public object preferredappointmentdaycode { get; set; }
		public object _preferredsystemuserid_value { get; set; }
		public object address1_line2 { get; set; }
		public object jobtitle { get; set; }
		public object _preferredserviceid_value { get; set; }
		public object address2_line1 { get; set; }
		public object importsequencenumber { get; set; }
		public object address3_telephone1 { get; set; }
		public object address2_telephone2 { get; set; }
		public object telephone1 { get; set; }
		public object address1_line3 { get; set; }
		public object description { get; set; }
		public object _slaid_value { get; set; }
		public object entityimage_timestamp { get; set; }
		public object address3_primarycontactname { get; set; }
		public object address3_stateorprovince { get; set; }
		public object address2_upszone { get; set; }
		public object timezoneruleversionnumber { get; set; }
		public object address3_country { get; set; }
		public object _preferredequipmentid_value { get; set; }
		public object address2_postofficebox { get; set; }
		public object telephone3 { get; set; }
		public object websiteurl { get; set; }
		public object address2_postalcode { get; set; }
		public object annualincome { get; set; }
		public object aging90 { get; set; }
		public object fax { get; set; }
		public object address1_shippingmethodcode { get; set; }
		public object address3_addresstypecode { get; set; }
		public object _modifiedonbehalfby_value { get; set; }
		public object address1_line1 { get; set; }
		public object address3_postofficebox { get; set; }
		public object address3_composite { get; set; }
		public object address2_name { get; set; }
		public object suffix { get; set; }
		public object vcm_creditlimit { get; set; }
		public object address3_freighttermscode { get; set; }
		public object address3_shippingmethodcode { get; set; }
		public object employeeid { get; set; }
		public object managername { get; set; }
		public object address2_primarycontactname { get; set; }
		public object stageid { get; set; }
		public object aging60_base { get; set; }
		public object address1_addresstypecode { get; set; }
		public object vcm_sampleenrollmentdatereceived { get; set; }
		public object vcm_leadtype { get; set; }
		public object _createdonbehalfby_value { get; set; }
		public object address3_telephone2 { get; set; }
		public object address1_fax { get; set; }
		public object emailaddress2 { get; set; }
		public object aging90_base { get; set; }
		public object onholdtime { get; set; }
		public object vcm_salesforce { get; set; }
		public object address3_fax { get; set; }
		public object vcm_sculptratraininngcompletedon { get; set; }
		public object _slainvokedid_value { get; set; }
	}
}
