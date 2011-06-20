namespace TFM.DAL.Utils
{
	public class DbConstants
	{
        public struct TRANSACTION
		{
            public const string TRANSACTIONID = "TRANSACTIONID";
            public const string STATION = "STATION";
            public const string TIME = "TIME";
            public const string PRICE = "PRICE";
            public const string USERID = "USERID";
            public const string CAR = "CAR";
            public const string EVIDENCE = "EVIDENCE";
		}
        public struct ROLES
		{
            public const string ROLEID = "ROLEID";
			public const string NAME = "Name";
		}
        public struct USER_DETAIL
		{
            public const string USERID = "USERID";
            public const string FULLNAME = "FULLNAME";
			public const string ADDRESS = "Address";
            public const string PHONE = "PHONE";
			public const string EMAIL = "Email";
            public const string COMPANY = "COMPANY";
            public const string TITLE = "TITLE";
            public const string CMND = "CMND";
            public const string STATION = "STATION";
		}
        public struct CAR
		{
            public const string NUMBER_PLATE = "NUMBER_PLATE";
            public const string CAR_TYPE = "CAR_TYPE";
            public const string BRAND = "BRAND";
            public const string PROVINCE = "PROVINCE";
		}
        public struct USERS
		{
            public const string USERID = "USERID";
            public const string USERNAME = "USERNAME";
            public const string PASSWORD = "PASSWORD";
            public const string ROLEID = "ROLEID";
		}
        public struct STATION
		{
            public const string STATIONID = "STATIONID";
			public const string NAME = "Name";
            public const string PROVINCE = "PROVINCE";
            public const string COMPANY = "COMPANY";
		}
        public struct CAR_TYPE
		{
            public const string TYPEID = "TYPEID";
			public const string NAME = "Name";
            public const string NOTE = "NOTE";
            public const string SEAT = "SEAT";
            public const string WEIGHT = "WEIGHT";
            public const string CAPACITY = "CAPACITY";
		}
        public struct EVIDENCE
		{
            public const string EVIDENCEID = "EVIDENCEID";
			public const string NAME = "Name";
            public const string IMAGE_URI = "IMAGE_URI";
            public const string NOTE = "NOTE";
		}
        public struct TICKET_TYPE
		{
            public const string TICKET_TYPE_ID = "TICKET_TYPE_ID";
            public const string CREATED_DATE = "CREATED_DATE";
			public const string NAME = "Name";
		}
        public struct CAR_GROUPS
		{
            public const string GROUPID = "GROUPID";
            public const string DESCRIPTION = "DESCRIPTION";
			public const string NAME = "Name";
            public const string MIN_WEIGHT = "MIN_WEIGHT";
            public const string MAX_WEIGHT = "MAX_WEIGHT";
            public const string MIN_SEAT = "MIN_SEAT";
            public const string MAX_SEAT = "MAX_SEAT";
            public const string MIN_CAPACITY = "MIN_CAPACITY";
            public const string MAX_CAPACITY = "MAX_CAPACITY";
		}
        public struct ROLE_PERMISSIONS
		{
            public const string ROLEID = "ROLEID";
            public const string PERMISSION = "PERMISSION";
		}
        public struct FARE
		{
            public const string FAREID = "FAREID";
            public const string CAR_GROUP = "CAR_GROUP";
            public const string TICKET_TYPE = "TICKET_TYPE";
            public const string STATION = "STATION";
            public const string PRICE = "PRICE";
            public const string APPLY_DATE = "APPLY_DATE";
            public const string CREATED_DATE = "CREATED_DATE";
            public const string IS_ACTIVE = "IS_ACTIVE";
		}

        public struct TICKET_REGISTRATION
        {
            public const string TICKETID = "TICKETID";
            public const string NUMBER_PLATE = "NUMBER_PLATE";
            public const string TICKET_TYPE = "TICKET_TYPE";
            public const string START_DATE = "START_DATE";
            public const string STATION = "STATION";
            public const string END_DATE = "END_DATE";
        }
	}
}
