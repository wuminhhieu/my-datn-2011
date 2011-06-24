namespace TFM.DAL.Utils
{
	public class DbConstants
	{
		public struct CAR
		{
			public const string NUMBER_PLATE = "number_plate";
			public const string CAR_TYPE = "car_type";
			public const string BRAND = "brand";
			public const string PROVINCE = "province";
		}
		public struct CAR_GROUPS
		{
			public const string GROUPID = "groupid";
			public const string NAME = "name";
			public const string DESCRIPTION = "description";
			public const string MIN_WEIGHT = "min_weight";
			public const string MAX_WEIGHT = "max_weight";
			public const string MIN_SEAT = "min_seat";
			public const string MAX_SEAT = "max_seat";
			public const string MIN_CAPACITY = "min_capacity";
			public const string MAX_CAPACITY = "max_capacity";
		}
		public struct CAR_TYPE
		{
			public const string TYPEID = "typeid";
			public const string NAME = "name";
			public const string NOTE = "note";
			public const string WEIGHT = "weight";
			public const string SEAT = "seat";
			public const string CAPACITY = "capacity";
			public const string PRIORITY_PROPERTY = "priority_property";
		}
		public struct EVIDENCE
		{
			public const string EVIDENCEID = "evidenceid";
			public const string NAME = "name";
			public const string IMAGE_URI = "image_uri";
			public const string NOTE = "note";
		}
		public struct FARE
		{
			public const string FAREID = "fareid";
			public const string CAR_GROUP = "car_group";
			public const string TICKET_TYPE = "ticket_type";
			public const string STATION = "station";
			public const string PRICE = "price";
			public const string APPLY_DATE = "apply_date";
			public const string CREATED_DATE = "created_date";
			public const string IS_ACTIVE = "is_active";
		}
		public struct ROLE_PERMISSIONS
		{
			public const string ROLEID = "roleid";
			public const string PERMISSION = "permission";
		}
		public struct ROLES
		{
			public const string ROLEID = "roleid";
			public const string NAME = "name";
		}
		public struct STATION
		{
			public const string STATIONID = "stationid";
			public const string NAME = "name";
			public const string PROVINCE = "province";
			public const string COMPANY = "company";
			public const string DESCRIPTION = "description";
		}
		public struct TICKET_REGISTRATION
		{
			public const string TICKETID = "ticketid";
			public const string NUMBER_PLATE = "number_plate";
			public const string TICKET_TYPE = "ticket_type";
			public const string START_DATE = "start_date";
			public const string END_DATE = "end_date";
			public const string STATION = "station";
			public const string CUSTOMER = "customer";
			public const string STAFF = "staff";
		}
		public struct TICKET_TYPE
		{
			public const string TICKET_TYPE_ID = "ticket_type_id";
			public const string NAME = "name";
			public const string CREATED_DATE = "created_date";
			public const string DESCRIPTION = "description";
		}
		public struct TRANSACTION
		{
			public const string TRANSACTIONID = "transactionid";
			public const string STATION = "station";
			public const string TIME = "time";
			public const string USERID = "userid";
			public const string PRICE = "price";
			public const string NUMBER_PLATE = "number_plate";
			public const string EVIDENCE = "evidence";
		}
		public struct USER_DETAIL
		{
			public const string USERID = "userid";
			public const string FULLNAME = "fullname";
			public const string PICTURE = "picture";
			public const string EMAIL = "email";
			public const string ADDRESS = "address";
			public const string PHONE = "phone";
			public const string COMPANY = "company";
			public const string TITLE = "title";
			public const string CMND = "cmnd";
			public const string STATION = "station";
		}
		public struct USERS
		{
			public const string USERID = "userid";
			public const string USERNAME = "username";
			public const string PASSWORD = "password";
			public const string ROLEID = "roleid";
			public const string CREATED_DATE = "created_date";
			public const string LAST_LOGIN = "last_login";
			public const string LAST_LOGOUT = "last_logout";
		}
	}
}
