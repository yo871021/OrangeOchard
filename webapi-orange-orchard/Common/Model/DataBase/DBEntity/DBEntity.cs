using DataBase.Model;

namespace Common.Model.DataBase.DBEntity
{
    ///////////////////////// API_Request_Log BEGIN /////////////////////////
    // API_NAME varchar(100)
    // LOG_DATE varchar(30)
    // REQUEST_JSON nvarchar(-1)
    // RESPONSE_JSON nvarchar(-1)
    // UID varchar(100)
    // UPLOAD_FLAG varchar(1)
    // USER_ID varchar(30)
    public class @API_Request_Log : EntityBase
    {
        public const string TABLENAME = "API_Request_Log";
        public const string FULL_TABLENAME = "Models.DBEntity.@API_Request_Log";


        public string? @Api_Name { get { return _Api_Name; } set { @_Api_Name = value; SetDirty(CN_API_NAME); } }
        public const string CN_API_NAME = "Api_Name";
        public const string DT_API_NAME = "varchar(100)";
        private string? @_Api_Name;

        public string? @Log_Date { get { return _Log_Date; } set { @_Log_Date = value; SetDirty(CN_LOG_DATE); } }
        public const string CN_LOG_DATE = "Log_Date";
        public const string DT_LOG_DATE = "varchar(30)";
        private string? @_Log_Date;

        public string? @Request_Json { get { return _Request_Json; } set { @_Request_Json = value; SetDirty(CN_REQUEST_JSON); } }
        public const string CN_REQUEST_JSON = "Request_Json";
        public const string DT_REQUEST_JSON = "nvarchar(-1)";
        private string? @_Request_Json;

        public string? @Response_Json { get { return _Response_Json; } set { @_Response_Json = value; SetDirty(CN_RESPONSE_JSON); } }
        public const string CN_RESPONSE_JSON = "Response_Json";
        public const string DT_RESPONSE_JSON = "nvarchar(-1)";
        private string? @_Response_Json;

        public string? @UID { get { return _UID; } set { @_UID = value; SetDirty(CN_UID); } }
        public const string CN_UID = "UID";
        public const string DT_UID = "varchar(100)";
        private string? @_UID;

        public string? @Upload_Flag { get { return _Upload_Flag; } set { @_Upload_Flag = value; SetDirty(CN_UPLOAD_FLAG); } }
        public const string CN_UPLOAD_FLAG = "Upload_Flag";
        public const string DT_UPLOAD_FLAG = "varchar(1)";
        private string? @_Upload_Flag;

        public string? @User_ID { get { return _User_ID; } set { @_User_ID = value; SetDirty(CN_USER_ID); } }
        public const string CN_USER_ID = "User_ID";
        public const string DT_USER_ID = "varchar(30)";
        private string? @_User_ID;

        public @API_Request_Log() : base()
        {
            PKColumnNames.UnionWith(new List<string>(){
                CN_UID
            });
        }
    }
    ///////////////////////// API_Request_Log END /////////////////////////

    ///////////////////////// API_Response_Log BEGIN /////////////////////////
    // API_NAME varchar(100)
    // LOG_DATE varchar(30)
    // REQUEST_JSON nvarchar(-1)
    // RESPONSE_JSON nvarchar(-1)
    // UID varchar(100)
    // UPLOAD_FLAG varchar(1)
    // USER_ID varchar(30)
    public class @API_Response_Log : EntityBase
    {
        public const string TABLENAME = "API_Response_Log";
        public const string FULL_TABLENAME = "Models.DBEntity.@API_Response_Log";


        public string? @Api_Name { get { return _Api_Name; } set { @_Api_Name = value; SetDirty(CN_API_NAME); } }
        public const string CN_API_NAME = "Api_Name";
        public const string DT_API_NAME = "varchar(100)";
        private string? @_Api_Name;

        public string? @Log_Date { get { return _Log_Date; } set { @_Log_Date = value; SetDirty(CN_LOG_DATE); } }
        public const string CN_LOG_DATE = "Log_Date";
        public const string DT_LOG_DATE = "varchar(30)";
        private string? @_Log_Date;

        public string? @Request_Json { get { return _Request_Json; } set { @_Request_Json = value; SetDirty(CN_REQUEST_JSON); } }
        public const string CN_REQUEST_JSON = "Request_Json";
        public const string DT_REQUEST_JSON = "nvarchar(-1)";
        private string? @_Request_Json;

        public string? @Response_Json { get { return _Response_Json; } set { @_Response_Json = value; SetDirty(CN_RESPONSE_JSON); } }
        public const string CN_RESPONSE_JSON = "Response_Json";
        public const string DT_RESPONSE_JSON = "nvarchar(-1)";
        private string? @_Response_Json;

        public string? @UID { get { return _UID; } set { @_UID = value; SetDirty(CN_UID); } }
        public const string CN_UID = "UID";
        public const string DT_UID = "varchar(100)";
        private string? @_UID;

        public string? @Upload_Flag { get { return _Upload_Flag; } set { @_Upload_Flag = value; SetDirty(CN_UPLOAD_FLAG); } }
        public const string CN_UPLOAD_FLAG = "Upload_Flag";
        public const string DT_UPLOAD_FLAG = "varchar(1)";
        private string? @_Upload_Flag;

        public string? @User_ID { get { return _User_ID; } set { @_User_ID = value; SetDirty(CN_USER_ID); } }
        public const string CN_USER_ID = "User_ID";
        public const string DT_USER_ID = "varchar(30)";
        private string? @_User_ID;

        public @API_Response_Log() : base()
        {
            PKColumnNames.UnionWith(new List<string>(){
                CN_UID
            });
        }
    }
    ///////////////////////// API_Response_Log END /////////////////////////

    ///////////////////////// APLog BEGIN /////////////////////////
    // ACTION_LOG varchar(50)
    // CREATE_DATE varchar(30)
    // CREATE_USER nvarchar(50)
    // LOG_ID varchar(50)
    public class @APLog : EntityBase
    {
        public const string TABLENAME = "APLog";
        public const string FULL_TABLENAME = "Models.DBEntity.@APLog";


        public string? @Action_Log { get { return _Action_Log; } set { @_Action_Log = value; SetDirty(CN_ACTION_LOG); } }
        public const string CN_ACTION_LOG = "Action_Log";
        public const string DT_ACTION_LOG = "varchar(50)";
        private string? @_Action_Log;

        public string? @Create_Date { get { return _Create_Date; } set { @_Create_Date = value; SetDirty(CN_CREATE_DATE); } }
        public const string CN_CREATE_DATE = "Create_Date";
        public const string DT_CREATE_DATE = "varchar(30)";
        private string? @_Create_Date;

        public string? @Create_User { get { return _Create_User; } set { @_Create_User = value; SetDirty(CN_CREATE_USER); } }
        public const string CN_CREATE_USER = "Create_User";
        public const string DT_CREATE_USER = "nvarchar(50)";
        private string? @_Create_User;

        public string? @Log_ID { get { return _Log_ID; } set { @_Log_ID = value; SetDirty(CN_LOG_ID); } }
        public const string CN_LOG_ID = "Log_ID";
        public const string DT_LOG_ID = "varchar(50)";
        private string? @_Log_ID;

        public @APLog() : base()
        {
            PKColumnNames.UnionWith(new List<string>(){
                CN_LOG_ID
            });
        }
    }
    ///////////////////////// APLog END /////////////////////////

    ///////////////////////// Argument_Class BEGIN /////////////////////////
    // ARGUMENT_CLASS_ID varchar(50)
    // CREATE_DATE varchar(30)
    // CREATE_USER nvarchar(50)
    // EFFECTIVE char(1)
    // MEMO varchar(50)
    // MODIFY_DATE varchar(30)
    // MODIFY_USER nvarchar(50)
    // ORDER_BY int
    // SYS_ARGUMENT_CLASS_NAME nvarchar(50)
    public class @Argument_Class : EntityBase
    {
        public const string TABLENAME = "Argument_Class";
        public const string FULL_TABLENAME = "Models.DBEntity.@Argument_Class";


        public string? @Argument_Class_ID { get { return _Argument_Class_ID; } set { @_Argument_Class_ID = value; SetDirty(CN_ARGUMENT_CLASS_ID); } }
        public const string CN_ARGUMENT_CLASS_ID = "Argument_Class_ID";
        public const string DT_ARGUMENT_CLASS_ID = "varchar(50)";
        private string? @_Argument_Class_ID;

        public string? @Create_Date { get { return _Create_Date; } set { @_Create_Date = value; SetDirty(CN_CREATE_DATE); } }
        public const string CN_CREATE_DATE = "Create_Date";
        public const string DT_CREATE_DATE = "varchar(30)";
        private string? @_Create_Date;

        public string? @Create_User { get { return _Create_User; } set { @_Create_User = value; SetDirty(CN_CREATE_USER); } }
        public const string CN_CREATE_USER = "Create_User";
        public const string DT_CREATE_USER = "nvarchar(50)";
        private string? @_Create_User;

        public string? @Effective { get { return _Effective; } set { @_Effective = value; SetDirty(CN_EFFECTIVE); } }
        public const string CN_EFFECTIVE = "Effective";
        public const string DT_EFFECTIVE = "char(1)";
        private string? @_Effective;

        public string? @Memo { get { return _Memo; } set { @_Memo = value; SetDirty(CN_MEMO); } }
        public const string CN_MEMO = "Memo";
        public const string DT_MEMO = "varchar(50)";
        private string? @_Memo;

        public string? @Modify_Date { get { return _Modify_Date; } set { @_Modify_Date = value; SetDirty(CN_MODIFY_DATE); } }
        public const string CN_MODIFY_DATE = "Modify_Date";
        public const string DT_MODIFY_DATE = "varchar(30)";
        private string? @_Modify_Date;

        public string? @Modify_User { get { return _Modify_User; } set { @_Modify_User = value; SetDirty(CN_MODIFY_USER); } }
        public const string CN_MODIFY_USER = "Modify_User";
        public const string DT_MODIFY_USER = "nvarchar(50)";
        private string? @_Modify_User;

        public int? @Order_By { get { return _Order_By; } set { @_Order_By = value; SetDirty(CN_ORDER_BY); } }
        public const string CN_ORDER_BY = "Order_By";
        public const string DT_ORDER_BY = "int";
        private int? @_Order_By;

        public string? @SYS_Argument_Class_Name { get { return _SYS_Argument_Class_Name; } set { @_SYS_Argument_Class_Name = value; SetDirty(CN_SYS_ARGUMENT_CLASS_NAME); } }
        public const string CN_SYS_ARGUMENT_CLASS_NAME = "SYS_Argument_Class_Name";
        public const string DT_SYS_ARGUMENT_CLASS_NAME = "nvarchar(50)";
        private string? @_SYS_Argument_Class_Name;

        public @Argument_Class() : base()
        {
            PKColumnNames.UnionWith(new List<string>(){
                CN_ARGUMENT_CLASS_ID
            });
        }
    }
    ///////////////////////// Argument_Class END /////////////////////////

    ///////////////////////// Arguments BEGIN /////////////////////////
    // ARGUMENT_CLASS_ID varchar(50)
    // ARGUMENT_ID varchar(50)
    // ARGUMENT_VALUE nvarchar(50)
    // CREATE_DATE varchar(30)
    // CREATE_USER nvarchar(50)
    // MEMO varchar(50)
    // MODIFY_DATE varchar(30)
    // MODIFY_USER nvarchar(50)
    // ORDER_BY int
    public class @Arguments : EntityBase
    {
        public const string TABLENAME = "Arguments";
        public const string FULL_TABLENAME = "Models.DBEntity.@Arguments";


        public string? @Argument_Class_ID { get { return _Argument_Class_ID; } set { @_Argument_Class_ID = value; SetDirty(CN_ARGUMENT_CLASS_ID); } }
        public const string CN_ARGUMENT_CLASS_ID = "Argument_Class_ID";
        public const string DT_ARGUMENT_CLASS_ID = "varchar(50)";
        private string? @_Argument_Class_ID;

        public string? @Argument_ID { get { return _Argument_ID; } set { @_Argument_ID = value; SetDirty(CN_ARGUMENT_ID); } }
        public const string CN_ARGUMENT_ID = "Argument_ID";
        public const string DT_ARGUMENT_ID = "varchar(50)";
        private string? @_Argument_ID;

        public string? @Argument_Value { get { return _Argument_Value; } set { @_Argument_Value = value; SetDirty(CN_ARGUMENT_VALUE); } }
        public const string CN_ARGUMENT_VALUE = "Argument_Value";
        public const string DT_ARGUMENT_VALUE = "nvarchar(50)";
        private string? @_Argument_Value;

        public string? @Create_Date { get { return _Create_Date; } set { @_Create_Date = value; SetDirty(CN_CREATE_DATE); } }
        public const string CN_CREATE_DATE = "Create_Date";
        public const string DT_CREATE_DATE = "varchar(30)";
        private string? @_Create_Date;

        public string? @Create_User { get { return _Create_User; } set { @_Create_User = value; SetDirty(CN_CREATE_USER); } }
        public const string CN_CREATE_USER = "Create_User";
        public const string DT_CREATE_USER = "nvarchar(50)";
        private string? @_Create_User;

        public string? @Memo { get { return _Memo; } set { @_Memo = value; SetDirty(CN_MEMO); } }
        public const string CN_MEMO = "Memo";
        public const string DT_MEMO = "varchar(50)";
        private string? @_Memo;

        public string? @Modify_Date { get { return _Modify_Date; } set { @_Modify_Date = value; SetDirty(CN_MODIFY_DATE); } }
        public const string CN_MODIFY_DATE = "Modify_Date";
        public const string DT_MODIFY_DATE = "varchar(30)";
        private string? @_Modify_Date;

        public string? @Modify_User { get { return _Modify_User; } set { @_Modify_User = value; SetDirty(CN_MODIFY_USER); } }
        public const string CN_MODIFY_USER = "Modify_User";
        public const string DT_MODIFY_USER = "nvarchar(50)";
        private string? @_Modify_User;

        public int? @Order_By { get { return _Order_By; } set { @_Order_By = value; SetDirty(CN_ORDER_BY); } }
        public const string CN_ORDER_BY = "Order_By";
        public const string DT_ORDER_BY = "int";
        private int? @_Order_By;

        public @Arguments() : base()
        {
            PKColumnNames.UnionWith(new List<string>(){
                CN_ARGUMENT_CLASS_ID
                ,CN_ARGUMENT_ID
            });
        }
    }
    ///////////////////////// Arguments END /////////////////////////

    ///////////////////////// Authorize_By_Dep BEGIN /////////////////////////
    // ALLOW_ACTION varchar(200)
    // CREATE_DATE varchar(30)
    // CREATE_USER nvarchar(50)
    // DEPARTMENT_ID varchar(10)
    // MEMO varchar(50)
    // MODIFY_DATE varchar(30)
    // MODIFY_USER nvarchar(50)
    // PROGRAM_ID varchar(50)
    public class @Authorize_By_Dep : EntityBase
    {
        public const string TABLENAME = "Authorize_By_Dep";
        public const string FULL_TABLENAME = "Models.DBEntity.@Authorize_By_Dep";


        public string? @Allow_Action { get { return _Allow_Action; } set { @_Allow_Action = value; SetDirty(CN_ALLOW_ACTION); } }
        public const string CN_ALLOW_ACTION = "Allow_Action";
        public const string DT_ALLOW_ACTION = "varchar(200)";
        private string? @_Allow_Action;

        public string? @Create_Date { get { return _Create_Date; } set { @_Create_Date = value; SetDirty(CN_CREATE_DATE); } }
        public const string CN_CREATE_DATE = "Create_Date";
        public const string DT_CREATE_DATE = "varchar(30)";
        private string? @_Create_Date;

        public string? @Create_User { get { return _Create_User; } set { @_Create_User = value; SetDirty(CN_CREATE_USER); } }
        public const string CN_CREATE_USER = "Create_User";
        public const string DT_CREATE_USER = "nvarchar(50)";
        private string? @_Create_User;

        public string? @Department_ID { get { return _Department_ID; } set { @_Department_ID = value; SetDirty(CN_DEPARTMENT_ID); } }
        public const string CN_DEPARTMENT_ID = "Department_ID";
        public const string DT_DEPARTMENT_ID = "varchar(10)";
        private string? @_Department_ID;

        public string? @Memo { get { return _Memo; } set { @_Memo = value; SetDirty(CN_MEMO); } }
        public const string CN_MEMO = "Memo";
        public const string DT_MEMO = "varchar(50)";
        private string? @_Memo;

        public string? @Modify_Date { get { return _Modify_Date; } set { @_Modify_Date = value; SetDirty(CN_MODIFY_DATE); } }
        public const string CN_MODIFY_DATE = "Modify_Date";
        public const string DT_MODIFY_DATE = "varchar(30)";
        private string? @_Modify_Date;

        public string? @Modify_User { get { return _Modify_User; } set { @_Modify_User = value; SetDirty(CN_MODIFY_USER); } }
        public const string CN_MODIFY_USER = "Modify_User";
        public const string DT_MODIFY_USER = "nvarchar(50)";
        private string? @_Modify_User;

        public string? @Program_ID { get { return _Program_ID; } set { @_Program_ID = value; SetDirty(CN_PROGRAM_ID); } }
        public const string CN_PROGRAM_ID = "Program_ID";
        public const string DT_PROGRAM_ID = "varchar(50)";
        private string? @_Program_ID;

        public @Authorize_By_Dep() : base()
        {
            PKColumnNames.UnionWith(new List<string>(){
                CN_DEPARTMENT_ID
                ,CN_PROGRAM_ID
            });
        }
    }
    ///////////////////////// Authorize_By_Dep END /////////////////////////

    ///////////////////////// Authorize_By_Role BEGIN /////////////////////////
    // ALLOW_ACTION varchar(200)
    // CREATE_DATE varchar(30)
    // CREATE_USER nvarchar(50)
    // MEMO varchar(50)
    // MODIFY_DATE varchar(30)
    // MODIFY_USER nvarchar(50)
    // PROGRAM_ID varchar(50)
    // ROLE_ID varchar(20)
    public class @Authorize_By_Role : EntityBase
    {
        public const string TABLENAME = "Authorize_By_Role";
        public const string FULL_TABLENAME = "Models.DBEntity.@Authorize_By_Role";


        public string? @Allow_Action { get { return _Allow_Action; } set { @_Allow_Action = value; SetDirty(CN_ALLOW_ACTION); } }
        public const string CN_ALLOW_ACTION = "Allow_Action";
        public const string DT_ALLOW_ACTION = "varchar(200)";
        private string? @_Allow_Action;

        public string? @Create_Date { get { return _Create_Date; } set { @_Create_Date = value; SetDirty(CN_CREATE_DATE); } }
        public const string CN_CREATE_DATE = "Create_Date";
        public const string DT_CREATE_DATE = "varchar(30)";
        private string? @_Create_Date;

        public string? @Create_User { get { return _Create_User; } set { @_Create_User = value; SetDirty(CN_CREATE_USER); } }
        public const string CN_CREATE_USER = "Create_User";
        public const string DT_CREATE_USER = "nvarchar(50)";
        private string? @_Create_User;

        public string? @Memo { get { return _Memo; } set { @_Memo = value; SetDirty(CN_MEMO); } }
        public const string CN_MEMO = "Memo";
        public const string DT_MEMO = "varchar(50)";
        private string? @_Memo;

        public string? @Modify_Date { get { return _Modify_Date; } set { @_Modify_Date = value; SetDirty(CN_MODIFY_DATE); } }
        public const string CN_MODIFY_DATE = "Modify_Date";
        public const string DT_MODIFY_DATE = "varchar(30)";
        private string? @_Modify_Date;

        public string? @Modify_User { get { return _Modify_User; } set { @_Modify_User = value; SetDirty(CN_MODIFY_USER); } }
        public const string CN_MODIFY_USER = "Modify_User";
        public const string DT_MODIFY_USER = "nvarchar(50)";
        private string? @_Modify_User;

        public string? @Program_ID { get { return _Program_ID; } set { @_Program_ID = value; SetDirty(CN_PROGRAM_ID); } }
        public const string CN_PROGRAM_ID = "Program_ID";
        public const string DT_PROGRAM_ID = "varchar(50)";
        private string? @_Program_ID;

        public string? @Role_ID { get { return _Role_ID; } set { @_Role_ID = value; SetDirty(CN_ROLE_ID); } }
        public const string CN_ROLE_ID = "Role_ID";
        public const string DT_ROLE_ID = "varchar(20)";
        private string? @_Role_ID;

        public @Authorize_By_Role() : base()
        {
            PKColumnNames.UnionWith(new List<string>(){
                CN_PROGRAM_ID
                ,CN_ROLE_ID
            });
        }
    }
    ///////////////////////// Authorize_By_Role END /////////////////////////

    ///////////////////////// Counties BEGIN /////////////////////////
    // COUNTY_ID varchar(50)
    // COUNTY_NAME nvarchar(50)
    // CREATE_DATE varchar(30)
    // CREATE_USER nvarchar(50)
    // MODIFY_DATE varchar(30)
    // MODIFY_USER nvarchar(50)
    // ORDER_BY int
    public class @Counties : EntityBase
    {
        public const string TABLENAME = "Counties";
        public const string FULL_TABLENAME = "Models.DBEntity.@Counties";


        public string? @County_ID { get { return _County_ID; } set { @_County_ID = value; SetDirty(CN_COUNTY_ID); } }
        public const string CN_COUNTY_ID = "County_ID";
        public const string DT_COUNTY_ID = "varchar(50)";
        private string? @_County_ID;

        public string? @County_Name { get { return _County_Name; } set { @_County_Name = value; SetDirty(CN_COUNTY_NAME); } }
        public const string CN_COUNTY_NAME = "County_Name";
        public const string DT_COUNTY_NAME = "nvarchar(50)";
        private string? @_County_Name;

        public string? @Create_Date { get { return _Create_Date; } set { @_Create_Date = value; SetDirty(CN_CREATE_DATE); } }
        public const string CN_CREATE_DATE = "Create_Date";
        public const string DT_CREATE_DATE = "varchar(30)";
        private string? @_Create_Date;

        public string? @Create_User { get { return _Create_User; } set { @_Create_User = value; SetDirty(CN_CREATE_USER); } }
        public const string CN_CREATE_USER = "Create_User";
        public const string DT_CREATE_USER = "nvarchar(50)";
        private string? @_Create_User;

        public string? @Modify_Date { get { return _Modify_Date; } set { @_Modify_Date = value; SetDirty(CN_MODIFY_DATE); } }
        public const string CN_MODIFY_DATE = "Modify_Date";
        public const string DT_MODIFY_DATE = "varchar(30)";
        private string? @_Modify_Date;

        public string? @Modify_User { get { return _Modify_User; } set { @_Modify_User = value; SetDirty(CN_MODIFY_USER); } }
        public const string CN_MODIFY_USER = "Modify_User";
        public const string DT_MODIFY_USER = "nvarchar(50)";
        private string? @_Modify_User;

        public int? @Order_By { get { return _Order_By; } set { @_Order_By = value; SetDirty(CN_ORDER_BY); } }
        public const string CN_ORDER_BY = "Order_By";
        public const string DT_ORDER_BY = "int";
        private int? @_Order_By;

        public @Counties() : base()
        {
            PKColumnNames.UnionWith(new List<string>(){
                CN_COUNTY_ID
            });
        }
    }
    ///////////////////////// Counties END /////////////////////////

    ///////////////////////// Departments BEGIN /////////////////////////
    // ADDRESS nvarchar(100)
    // COUNTY_ID varchar(50)
    // CREATE_DATE varchar(30)
    // CREATE_USER nvarchar(50)
    // DEPARTMENT_ID varchar(10)
    // DEPARTMENT_NAME nvarchar(50)
    // DISTRICT_ID varchar(50)
    // IO_DEPARTMENT_ID varchar(10)
    // MODIFY_DATE varchar(30)
    // MODIFY_USER nvarchar(50)
    // ORDER_BY int
    // PARENT_ID varchar(10)
    public class @Departments : EntityBase
    {
        public const string TABLENAME = "Departments";
        public const string FULL_TABLENAME = "Models.DBEntity.@Departments";


        public string? @Address { get { return _Address; } set { @_Address = value; SetDirty(CN_ADDRESS); } }
        public const string CN_ADDRESS = "Address";
        public const string DT_ADDRESS = "nvarchar(100)";
        private string? @_Address;

        public string? @County_ID { get { return _County_ID; } set { @_County_ID = value; SetDirty(CN_COUNTY_ID); } }
        public const string CN_COUNTY_ID = "County_ID";
        public const string DT_COUNTY_ID = "varchar(50)";
        private string? @_County_ID;

        public string? @Create_Date { get { return _Create_Date; } set { @_Create_Date = value; SetDirty(CN_CREATE_DATE); } }
        public const string CN_CREATE_DATE = "Create_Date";
        public const string DT_CREATE_DATE = "varchar(30)";
        private string? @_Create_Date;

        public string? @Create_User { get { return _Create_User; } set { @_Create_User = value; SetDirty(CN_CREATE_USER); } }
        public const string CN_CREATE_USER = "Create_User";
        public const string DT_CREATE_USER = "nvarchar(50)";
        private string? @_Create_User;

        public string? @Department_ID { get { return _Department_ID; } set { @_Department_ID = value; SetDirty(CN_DEPARTMENT_ID); } }
        public const string CN_DEPARTMENT_ID = "Department_ID";
        public const string DT_DEPARTMENT_ID = "varchar(10)";
        private string? @_Department_ID;

        public string? @Department_Name { get { return _Department_Name; } set { @_Department_Name = value; SetDirty(CN_DEPARTMENT_NAME); } }
        public const string CN_DEPARTMENT_NAME = "Department_Name";
        public const string DT_DEPARTMENT_NAME = "nvarchar(50)";
        private string? @_Department_Name;

        public string? @District_ID { get { return _District_ID; } set { @_District_ID = value; SetDirty(CN_DISTRICT_ID); } }
        public const string CN_DISTRICT_ID = "District_ID";
        public const string DT_DISTRICT_ID = "varchar(50)";
        private string? @_District_ID;

        public string? @IO_Department_ID { get { return _IO_Department_ID; } set { @_IO_Department_ID = value; SetDirty(CN_IO_DEPARTMENT_ID); } }
        public const string CN_IO_DEPARTMENT_ID = "IO_Department_ID";
        public const string DT_IO_DEPARTMENT_ID = "varchar(10)";
        private string? @_IO_Department_ID;

        public string? @Modify_Date { get { return _Modify_Date; } set { @_Modify_Date = value; SetDirty(CN_MODIFY_DATE); } }
        public const string CN_MODIFY_DATE = "Modify_Date";
        public const string DT_MODIFY_DATE = "varchar(30)";
        private string? @_Modify_Date;

        public string? @Modify_User { get { return _Modify_User; } set { @_Modify_User = value; SetDirty(CN_MODIFY_USER); } }
        public const string CN_MODIFY_USER = "Modify_User";
        public const string DT_MODIFY_USER = "nvarchar(50)";
        private string? @_Modify_User;

        public int? @Order_By { get { return _Order_By; } set { @_Order_By = value; SetDirty(CN_ORDER_BY); } }
        public const string CN_ORDER_BY = "Order_By";
        public const string DT_ORDER_BY = "int";
        private int? @_Order_By;

        public string? @Parent_ID { get { return _Parent_ID; } set { @_Parent_ID = value; SetDirty(CN_PARENT_ID); } }
        public const string CN_PARENT_ID = "Parent_ID";
        public const string DT_PARENT_ID = "varchar(10)";
        private string? @_Parent_ID;

        public @Departments() : base()
        {
            PKColumnNames.UnionWith(new List<string>(){
                CN_DEPARTMENT_ID
            });
        }
    }
    ///////////////////////// Departments END /////////////////////////

    ///////////////////////// Departments_Permission BEGIN /////////////////////////
    // CREATE_DATE varchar(30)
    // CREATE_USER nvarchar(50)
    // DEPARTMENT_ID varchar(10)
    // MODIFY_DATE varchar(30)
    // MODIFY_USER nvarchar(50)
    // PERMISSION_DEP varchar(10)
    // PERMISSION_TYPE varchar(10)
    public class @Departments_Permission : EntityBase
    {
        public const string TABLENAME = "Departments_Permission";
        public const string FULL_TABLENAME = "Models.DBEntity.@Departments_Permission";


        public string? @Create_Date { get { return _Create_Date; } set { @_Create_Date = value; SetDirty(CN_CREATE_DATE); } }
        public const string CN_CREATE_DATE = "Create_Date";
        public const string DT_CREATE_DATE = "varchar(30)";
        private string? @_Create_Date;

        public string? @Create_User { get { return _Create_User; } set { @_Create_User = value; SetDirty(CN_CREATE_USER); } }
        public const string CN_CREATE_USER = "Create_User";
        public const string DT_CREATE_USER = "nvarchar(50)";
        private string? @_Create_User;

        public string? @Department_ID { get { return _Department_ID; } set { @_Department_ID = value; SetDirty(CN_DEPARTMENT_ID); } }
        public const string CN_DEPARTMENT_ID = "Department_ID";
        public const string DT_DEPARTMENT_ID = "varchar(10)";
        private string? @_Department_ID;

        public string? @Modify_Date { get { return _Modify_Date; } set { @_Modify_Date = value; SetDirty(CN_MODIFY_DATE); } }
        public const string CN_MODIFY_DATE = "Modify_Date";
        public const string DT_MODIFY_DATE = "varchar(30)";
        private string? @_Modify_Date;

        public string? @Modify_User { get { return _Modify_User; } set { @_Modify_User = value; SetDirty(CN_MODIFY_USER); } }
        public const string CN_MODIFY_USER = "Modify_User";
        public const string DT_MODIFY_USER = "nvarchar(50)";
        private string? @_Modify_User;

        public string? @Permission_Dep { get { return _Permission_Dep; } set { @_Permission_Dep = value; SetDirty(CN_PERMISSION_DEP); } }
        public const string CN_PERMISSION_DEP = "Permission_Dep";
        public const string DT_PERMISSION_DEP = "varchar(10)";
        private string? @_Permission_Dep;

        public string? @Permission_Type { get { return _Permission_Type; } set { @_Permission_Type = value; SetDirty(CN_PERMISSION_TYPE); } }
        public const string CN_PERMISSION_TYPE = "Permission_Type";
        public const string DT_PERMISSION_TYPE = "varchar(10)";
        private string? @_Permission_Type;

        public @Departments_Permission() : base()
        {
            PKColumnNames.UnionWith(new List<string>(){
                CN_DEPARTMENT_ID
                ,CN_PERMISSION_DEP
                ,CN_PERMISSION_TYPE
            });
        }
    }
    ///////////////////////// Departments_Permission END /////////////////////////

    ///////////////////////// Departments_Update BEGIN /////////////////////////
    // DEPARTMENT_ID varchar(10)
    // DEPARTMENT_NAME nvarchar(50)
    // DOWNLOAD_DATE varchar(30)
    // IO_DEPARTMENT_NAME varchar(10)
    // PARENT_ID varchar(10)
    // UNIT_ATTRIBUTE varchar(5)
    // UPLOAD_DATE varchar(30)
    public class @Departments_Update : EntityBase
    {
        public const string TABLENAME = "Departments_Update";
        public const string FULL_TABLENAME = "Models.DBEntity.@Departments_Update";


        public string? @Department_ID { get { return _Department_ID; } set { @_Department_ID = value; SetDirty(CN_DEPARTMENT_ID); } }
        public const string CN_DEPARTMENT_ID = "Department_ID";
        public const string DT_DEPARTMENT_ID = "varchar(10)";
        private string? @_Department_ID;

        public string? @Department_Name { get { return _Department_Name; } set { @_Department_Name = value; SetDirty(CN_DEPARTMENT_NAME); } }
        public const string CN_DEPARTMENT_NAME = "Department_Name";
        public const string DT_DEPARTMENT_NAME = "nvarchar(50)";
        private string? @_Department_Name;

        public string? @DownLoad_Date { get { return _DownLoad_Date; } set { @_DownLoad_Date = value; SetDirty(CN_DOWNLOAD_DATE); } }
        public const string CN_DOWNLOAD_DATE = "DownLoad_Date";
        public const string DT_DOWNLOAD_DATE = "varchar(30)";
        private string? @_DownLoad_Date;

        public string? @IO_Department_Name { get { return _IO_Department_Name; } set { @_IO_Department_Name = value; SetDirty(CN_IO_DEPARTMENT_NAME); } }
        public const string CN_IO_DEPARTMENT_NAME = "IO_Department_Name";
        public const string DT_IO_DEPARTMENT_NAME = "varchar(10)";
        private string? @_IO_Department_Name;

        public string? @Parent_ID { get { return _Parent_ID; } set { @_Parent_ID = value; SetDirty(CN_PARENT_ID); } }
        public const string CN_PARENT_ID = "Parent_ID";
        public const string DT_PARENT_ID = "varchar(10)";
        private string? @_Parent_ID;

        public string? @Unit_Attribute { get { return _Unit_Attribute; } set { @_Unit_Attribute = value; SetDirty(CN_UNIT_ATTRIBUTE); } }
        public const string CN_UNIT_ATTRIBUTE = "Unit_Attribute";
        public const string DT_UNIT_ATTRIBUTE = "varchar(5)";
        private string? @_Unit_Attribute;

        public string? @UpLoad_Date { get { return _UpLoad_Date; } set { @_UpLoad_Date = value; SetDirty(CN_UPLOAD_DATE); } }
        public const string CN_UPLOAD_DATE = "UpLoad_Date";
        public const string DT_UPLOAD_DATE = "varchar(30)";
        private string? @_UpLoad_Date;

        public @Departments_Update() : base()
        {
            PKColumnNames.UnionWith(new List<string>(){
                CN_DEPARTMENT_ID
            });
        }
    }
    ///////////////////////// Departments_Update END /////////////////////////

    ///////////////////////// Districts BEGIN /////////////////////////
    // COUNTY_ID varchar(50)
    // CREATE_DATE varchar(30)
    // CREATE_USER nvarchar(50)
    // DISTRICT_CODE int
    // DISTRICT_ID varchar(50)
    // DISTRICT_NAME nvarchar(50)
    // MODIFY_DATE varchar(30)
    // MODIFY_USER nvarchar(50)
    public class @Districts : EntityBase
    {
        public const string TABLENAME = "Districts";
        public const string FULL_TABLENAME = "Models.DBEntity.@Districts";


        public string? @County_ID { get { return _County_ID; } set { @_County_ID = value; SetDirty(CN_COUNTY_ID); } }
        public const string CN_COUNTY_ID = "County_ID";
        public const string DT_COUNTY_ID = "varchar(50)";
        private string? @_County_ID;

        public string? @Create_Date { get { return _Create_Date; } set { @_Create_Date = value; SetDirty(CN_CREATE_DATE); } }
        public const string CN_CREATE_DATE = "Create_Date";
        public const string DT_CREATE_DATE = "varchar(30)";
        private string? @_Create_Date;

        public string? @Create_User { get { return _Create_User; } set { @_Create_User = value; SetDirty(CN_CREATE_USER); } }
        public const string CN_CREATE_USER = "Create_User";
        public const string DT_CREATE_USER = "nvarchar(50)";
        private string? @_Create_User;

        public int? @District_Code { get { return _District_Code; } set { @_District_Code = value; SetDirty(CN_DISTRICT_CODE); } }
        public const string CN_DISTRICT_CODE = "District_Code";
        public const string DT_DISTRICT_CODE = "int";
        private int? @_District_Code;

        public string? @District_ID { get { return _District_ID; } set { @_District_ID = value; SetDirty(CN_DISTRICT_ID); } }
        public const string CN_DISTRICT_ID = "District_ID";
        public const string DT_DISTRICT_ID = "varchar(50)";
        private string? @_District_ID;

        public string? @District_Name { get { return _District_Name; } set { @_District_Name = value; SetDirty(CN_DISTRICT_NAME); } }
        public const string CN_DISTRICT_NAME = "District_Name";
        public const string DT_DISTRICT_NAME = "nvarchar(50)";
        private string? @_District_Name;

        public string? @Modify_Date { get { return _Modify_Date; } set { @_Modify_Date = value; SetDirty(CN_MODIFY_DATE); } }
        public const string CN_MODIFY_DATE = "Modify_Date";
        public const string DT_MODIFY_DATE = "varchar(30)";
        private string? @_Modify_Date;

        public string? @Modify_User { get { return _Modify_User; } set { @_Modify_User = value; SetDirty(CN_MODIFY_USER); } }
        public const string CN_MODIFY_USER = "Modify_User";
        public const string DT_MODIFY_USER = "nvarchar(50)";
        private string? @_Modify_User;

        public @Districts() : base()
        {
            PKColumnNames.UnionWith(new List<string>(){
                CN_COUNTY_ID
                ,CN_DISTRICT_ID
            });
        }
    }
    ///////////////////////// Districts END /////////////////////////

    ///////////////////////// Letter_Info BEGIN /////////////////////////
    // ADDRESS nvarchar(100)
    // BACK_DATE varchar(30)
    // BACK_TO_ADDRESS nvarchar(200)
    // BACK_TO_DEP varchar(10)
    // BULKREGIST_NUMBER varchar(50)
    // CHEQUE_NUMBER varchar(50)
    // COST_DEP varchar(10)
    // COUNTY_ID nvarchar(50)
    // CREATE_DATE varchar(30)
    // CREATE_USER nvarchar(50)
    // DISTRICT_ID nvarchar(50)
    // IMPORTANT char(1)
    // ITEM_ID varchar(50)
    // ITEM_NAME varchar(50)
    // LETTER_CLASS char(1)
    // LETTER_COST int
    // LETTER_ID varchar(100)
    // LETTER_IO char(1)
    // LOAN_ACCOUNT varchar(50)
    // LOC_ID varchar(64)
    // MEMO varchar(50)
    // MODIFY_DATE varchar(30)
    // MODIFY_USER nvarchar(50)
    // NOW_DEP varchar(10)
    // OUTSITE_TRACING_CODE varchar(50)
    // POLICY_NUMBER varchar(50)
    // RECEIVE_DATE varchar(30)
    // RECEIVER_NAME nvarchar(50)
    // RTN_FLAG char(1)
    // SEND_DATE varchar(30)
    // SENDER_NAME nvarchar(50)
    // SOURCE_ADDRESS nvarchar(100)
    // SOURCE_COUNTY_ID nvarchar(50)
    // SOURCE_DEP varchar(10)
    // SOURCE_DISTRICT_ID nvarchar(50)
    // TARGET_DEP varchar(10)
    // WEIGHT float(53.0)
    public class @Letter_Info : EntityBase
    {
        public const string TABLENAME = "Letter_Info";
        public const string FULL_TABLENAME = "Models.DBEntity.@Letter_Info";


        public string? @Address { get { return _Address; } set { @_Address = value; SetDirty(CN_ADDRESS); } }
        public const string CN_ADDRESS = "Address";
        public const string DT_ADDRESS = "nvarchar(100)";
        private string? @_Address;

        public string? @Back_Date { get { return _Back_Date; } set { @_Back_Date = value; SetDirty(CN_BACK_DATE); } }
        public const string CN_BACK_DATE = "Back_Date";
        public const string DT_BACK_DATE = "varchar(30)";
        private string? @_Back_Date;

        public string? @Back_To_Address { get { return _Back_To_Address; } set { @_Back_To_Address = value; SetDirty(CN_BACK_TO_ADDRESS); } }
        public const string CN_BACK_TO_ADDRESS = "Back_To_Address";
        public const string DT_BACK_TO_ADDRESS = "nvarchar(200)";
        private string? @_Back_To_Address;

        public string? @Back_To_Dep { get { return _Back_To_Dep; } set { @_Back_To_Dep = value; SetDirty(CN_BACK_TO_DEP); } }
        public const string CN_BACK_TO_DEP = "Back_To_Dep";
        public const string DT_BACK_TO_DEP = "varchar(10)";
        private string? @_Back_To_Dep;

        public string? @BulkRegist_Number { get { return _BulkRegist_Number; } set { @_BulkRegist_Number = value; SetDirty(CN_BULKREGIST_NUMBER); } }
        public const string CN_BULKREGIST_NUMBER = "BulkRegist_Number";
        public const string DT_BULKREGIST_NUMBER = "varchar(50)";
        private string? @_BulkRegist_Number;

        public string? @Cheque_Number { get { return _Cheque_Number; } set { @_Cheque_Number = value; SetDirty(CN_CHEQUE_NUMBER); } }
        public const string CN_CHEQUE_NUMBER = "Cheque_Number";
        public const string DT_CHEQUE_NUMBER = "varchar(50)";
        private string? @_Cheque_Number;

        public string? @Cost_Dep { get { return _Cost_Dep; } set { @_Cost_Dep = value; SetDirty(CN_COST_DEP); } }
        public const string CN_COST_DEP = "Cost_Dep";
        public const string DT_COST_DEP = "varchar(10)";
        private string? @_Cost_Dep;

        public string? @County_ID { get { return _County_ID; } set { @_County_ID = value; SetDirty(CN_COUNTY_ID); } }
        public const string CN_COUNTY_ID = "County_ID";
        public const string DT_COUNTY_ID = "nvarchar(50)";
        private string? @_County_ID;

        public string? @Create_Date { get { return _Create_Date; } set { @_Create_Date = value; SetDirty(CN_CREATE_DATE); } }
        public const string CN_CREATE_DATE = "Create_Date";
        public const string DT_CREATE_DATE = "varchar(30)";
        private string? @_Create_Date;

        public string? @Create_User { get { return _Create_User; } set { @_Create_User = value; SetDirty(CN_CREATE_USER); } }
        public const string CN_CREATE_USER = "Create_User";
        public const string DT_CREATE_USER = "nvarchar(50)";
        private string? @_Create_User;

        public string? @District_ID { get { return _District_ID; } set { @_District_ID = value; SetDirty(CN_DISTRICT_ID); } }
        public const string CN_DISTRICT_ID = "District_ID";
        public const string DT_DISTRICT_ID = "nvarchar(50)";
        private string? @_District_ID;

        public string? @Important { get { return _Important; } set { @_Important = value; SetDirty(CN_IMPORTANT); } }
        public const string CN_IMPORTANT = "Important";
        public const string DT_IMPORTANT = "char(1)";
        private string? @_Important;

        public string? @Item_ID { get { return _Item_ID; } set { @_Item_ID = value; SetDirty(CN_ITEM_ID); } }
        public const string CN_ITEM_ID = "Item_ID";
        public const string DT_ITEM_ID = "varchar(50)";
        private string? @_Item_ID;

        public string? @Item_Name { get { return _Item_Name; } set { @_Item_Name = value; SetDirty(CN_ITEM_NAME); } }
        public const string CN_ITEM_NAME = "Item_Name";
        public const string DT_ITEM_NAME = "varchar(50)";
        private string? @_Item_Name;

        public string? @Letter_Class { get { return _Letter_Class; } set { @_Letter_Class = value; SetDirty(CN_LETTER_CLASS); } }
        public const string CN_LETTER_CLASS = "Letter_Class";
        public const string DT_LETTER_CLASS = "char(1)";
        private string? @_Letter_Class;

        public int? @Letter_Cost { get { return _Letter_Cost; } set { @_Letter_Cost = value; SetDirty(CN_LETTER_COST); } }
        public const string CN_LETTER_COST = "Letter_Cost";
        public const string DT_LETTER_COST = "int";
        private int? @_Letter_Cost;

        public string? @Letter_ID { get { return _Letter_ID; } set { @_Letter_ID = value; SetDirty(CN_LETTER_ID); } }
        public const string CN_LETTER_ID = "Letter_ID";
        public const string DT_LETTER_ID = "varchar(100)";
        private string? @_Letter_ID;

        public string? @Letter_IO { get { return _Letter_IO; } set { @_Letter_IO = value; SetDirty(CN_LETTER_IO); } }
        public const string CN_LETTER_IO = "Letter_IO";
        public const string DT_LETTER_IO = "char(1)";
        private string? @_Letter_IO;

        public string? @Loan_Account { get { return _Loan_Account; } set { @_Loan_Account = value; SetDirty(CN_LOAN_ACCOUNT); } }
        public const string CN_LOAN_ACCOUNT = "Loan_Account";
        public const string DT_LOAN_ACCOUNT = "varchar(50)";
        private string? @_Loan_Account;

        public string? @Loc_ID { get { return _Loc_ID; } set { @_Loc_ID = value; SetDirty(CN_LOC_ID); } }
        public const string CN_LOC_ID = "Loc_ID";
        public const string DT_LOC_ID = "varchar(64)";
        private string? @_Loc_ID;

        public string? @Memo { get { return _Memo; } set { @_Memo = value; SetDirty(CN_MEMO); } }
        public const string CN_MEMO = "Memo";
        public const string DT_MEMO = "varchar(50)";
        private string? @_Memo;

        public string? @Modify_Date { get { return _Modify_Date; } set { @_Modify_Date = value; SetDirty(CN_MODIFY_DATE); } }
        public const string CN_MODIFY_DATE = "Modify_Date";
        public const string DT_MODIFY_DATE = "varchar(30)";
        private string? @_Modify_Date;

        public string? @Modify_User { get { return _Modify_User; } set { @_Modify_User = value; SetDirty(CN_MODIFY_USER); } }
        public const string CN_MODIFY_USER = "Modify_User";
        public const string DT_MODIFY_USER = "nvarchar(50)";
        private string? @_Modify_User;

        public string? @Now_Dep { get { return _Now_Dep; } set { @_Now_Dep = value; SetDirty(CN_NOW_DEP); } }
        public const string CN_NOW_DEP = "Now_Dep";
        public const string DT_NOW_DEP = "varchar(10)";
        private string? @_Now_Dep;

        public string? @Outsite_Tracing_Code { get { return _Outsite_Tracing_Code; } set { @_Outsite_Tracing_Code = value; SetDirty(CN_OUTSITE_TRACING_CODE); } }
        public const string CN_OUTSITE_TRACING_CODE = "Outsite_Tracing_Code";
        public const string DT_OUTSITE_TRACING_CODE = "varchar(50)";
        private string? @_Outsite_Tracing_Code;

        public string? @Policy_Number { get { return _Policy_Number; } set { @_Policy_Number = value; SetDirty(CN_POLICY_NUMBER); } }
        public const string CN_POLICY_NUMBER = "Policy_Number";
        public const string DT_POLICY_NUMBER = "varchar(50)";
        private string? @_Policy_Number;

        public string? @Receive_Date { get { return _Receive_Date; } set { @_Receive_Date = value; SetDirty(CN_RECEIVE_DATE); } }
        public const string CN_RECEIVE_DATE = "Receive_Date";
        public const string DT_RECEIVE_DATE = "varchar(30)";
        private string? @_Receive_Date;

        public string? @Receiver_Name { get { return _Receiver_Name; } set { @_Receiver_Name = value; SetDirty(CN_RECEIVER_NAME); } }
        public const string CN_RECEIVER_NAME = "Receiver_Name";
        public const string DT_RECEIVER_NAME = "nvarchar(50)";
        private string? @_Receiver_Name;

        public string? @Rtn_Flag { get { return _Rtn_Flag; } set { @_Rtn_Flag = value; SetDirty(CN_RTN_FLAG); } }
        public const string CN_RTN_FLAG = "Rtn_Flag";
        public const string DT_RTN_FLAG = "char(1)";
        private string? @_Rtn_Flag;

        public string? @Send_Date { get { return _Send_Date; } set { @_Send_Date = value; SetDirty(CN_SEND_DATE); } }
        public const string CN_SEND_DATE = "Send_Date";
        public const string DT_SEND_DATE = "varchar(30)";
        private string? @_Send_Date;

        public string? @Sender_Name { get { return _Sender_Name; } set { @_Sender_Name = value; SetDirty(CN_SENDER_NAME); } }
        public const string CN_SENDER_NAME = "Sender_Name";
        public const string DT_SENDER_NAME = "nvarchar(50)";
        private string? @_Sender_Name;

        public string? @Source_Address { get { return _Source_Address; } set { @_Source_Address = value; SetDirty(CN_SOURCE_ADDRESS); } }
        public const string CN_SOURCE_ADDRESS = "Source_Address";
        public const string DT_SOURCE_ADDRESS = "nvarchar(100)";
        private string? @_Source_Address;

        public string? @Source_County_ID { get { return _Source_County_ID; } set { @_Source_County_ID = value; SetDirty(CN_SOURCE_COUNTY_ID); } }
        public const string CN_SOURCE_COUNTY_ID = "Source_County_ID";
        public const string DT_SOURCE_COUNTY_ID = "nvarchar(50)";
        private string? @_Source_County_ID;

        public string? @Source_Dep { get { return _Source_Dep; } set { @_Source_Dep = value; SetDirty(CN_SOURCE_DEP); } }
        public const string CN_SOURCE_DEP = "Source_Dep";
        public const string DT_SOURCE_DEP = "varchar(10)";
        private string? @_Source_Dep;

        public string? @Source_District_ID { get { return _Source_District_ID; } set { @_Source_District_ID = value; SetDirty(CN_SOURCE_DISTRICT_ID); } }
        public const string CN_SOURCE_DISTRICT_ID = "Source_District_ID";
        public const string DT_SOURCE_DISTRICT_ID = "nvarchar(50)";
        private string? @_Source_District_ID;

        public string? @Target_Dep { get { return _Target_Dep; } set { @_Target_Dep = value; SetDirty(CN_TARGET_DEP); } }
        public const string CN_TARGET_DEP = "Target_Dep";
        public const string DT_TARGET_DEP = "varchar(10)";
        private string? @_Target_Dep;

        public float? @Weight { get { return _Weight; } set { @_Weight = value; SetDirty(CN_WEIGHT); } }
        public const string CN_WEIGHT = "Weight";
        public const string DT_WEIGHT = "float(53.0)";
        private float? @_Weight;

        public @Letter_Info() : base()
        {
            PKColumnNames.UnionWith(new List<string>(){
                CN_LETTER_ID
            });
        }
    }
    ///////////////////////// Letter_Info END /////////////////////////

    ///////////////////////// Letter_Info_History BEGIN /////////////////////////
    // ADDRESS nvarchar(100)
    // BACK_DATE varchar(30)
    // BACK_TO_ADDRESS nvarchar(200)
    // BACK_TO_DEP varchar(10)
    // BULKREGIST_NUMBER varchar(50)
    // CHEQUE_NUMBER varchar(50)
    // COST_DEP varchar(10)
    // COUNTY_ID nvarchar(50)
    // CREATE_DATE varchar(30)
    // CREATE_USER nvarchar(50)
    // DISTRICT_ID nvarchar(50)
    // IMPORTANT char(1)
    // ITEM_ID varchar(50)
    // ITEM_NAME varchar(50)
    // LETTER_CLASS char(1)
    // LETTER_COST int
    // LETTER_ID varchar(100)
    // LETTER_IO char(1)
    // LOAN_ACCOUNT varchar(50)
    // MEMO varchar(50)
    // MODIFY_DATE varchar(30)
    // MODIFY_USER nvarchar(50)
    // NOW_DEP varchar(10)
    // OUTSITE_TRACING_CODE varchar(50)
    // POLICY_NUMBER varchar(50)
    // RECEIVE_DATE varchar(30)
    // RECEIVER_NAME nvarchar(50)
    // RTN_FLAG char(1)
    // SEND_DATE varchar(30)
    // SENDER_NAME nvarchar(50)
    // SOURCE_ADDRESS nvarchar(100)
    // SOURCE_COUNTY_ID nvarchar(50)
    // SOURCE_DEP varchar(10)
    // SOURCE_DISTRICT_ID nvarchar(50)
    // TARGET_DEP varchar(10)
    // WEIGHT float(53.0)
    public class @Letter_Info_History : EntityBase
    {
        public const string TABLENAME = "Letter_Info_History";
        public const string FULL_TABLENAME = "Models.DBEntity.@Letter_Info_History";


        public string? @Address { get { return _Address; } set { @_Address = value; SetDirty(CN_ADDRESS); } }
        public const string CN_ADDRESS = "Address";
        public const string DT_ADDRESS = "nvarchar(100)";
        private string? @_Address;

        public string? @Back_Date { get { return _Back_Date; } set { @_Back_Date = value; SetDirty(CN_BACK_DATE); } }
        public const string CN_BACK_DATE = "Back_Date";
        public const string DT_BACK_DATE = "varchar(30)";
        private string? @_Back_Date;

        public string? @Back_To_Address { get { return _Back_To_Address; } set { @_Back_To_Address = value; SetDirty(CN_BACK_TO_ADDRESS); } }
        public const string CN_BACK_TO_ADDRESS = "Back_To_Address";
        public const string DT_BACK_TO_ADDRESS = "nvarchar(200)";
        private string? @_Back_To_Address;

        public string? @Back_To_Dep { get { return _Back_To_Dep; } set { @_Back_To_Dep = value; SetDirty(CN_BACK_TO_DEP); } }
        public const string CN_BACK_TO_DEP = "Back_To_Dep";
        public const string DT_BACK_TO_DEP = "varchar(10)";
        private string? @_Back_To_Dep;

        public string? @BulkRegist_Number { get { return _BulkRegist_Number; } set { @_BulkRegist_Number = value; SetDirty(CN_BULKREGIST_NUMBER); } }
        public const string CN_BULKREGIST_NUMBER = "BulkRegist_Number";
        public const string DT_BULKREGIST_NUMBER = "varchar(50)";
        private string? @_BulkRegist_Number;

        public string? @Cheque_Number { get { return _Cheque_Number; } set { @_Cheque_Number = value; SetDirty(CN_CHEQUE_NUMBER); } }
        public const string CN_CHEQUE_NUMBER = "Cheque_Number";
        public const string DT_CHEQUE_NUMBER = "varchar(50)";
        private string? @_Cheque_Number;

        public string? @Cost_Dep { get { return _Cost_Dep; } set { @_Cost_Dep = value; SetDirty(CN_COST_DEP); } }
        public const string CN_COST_DEP = "Cost_Dep";
        public const string DT_COST_DEP = "varchar(10)";
        private string? @_Cost_Dep;

        public string? @County_ID { get { return _County_ID; } set { @_County_ID = value; SetDirty(CN_COUNTY_ID); } }
        public const string CN_COUNTY_ID = "County_ID";
        public const string DT_COUNTY_ID = "nvarchar(50)";
        private string? @_County_ID;

        public string? @Create_Date { get { return _Create_Date; } set { @_Create_Date = value; SetDirty(CN_CREATE_DATE); } }
        public const string CN_CREATE_DATE = "Create_Date";
        public const string DT_CREATE_DATE = "varchar(30)";
        private string? @_Create_Date;

        public string? @Create_User { get { return _Create_User; } set { @_Create_User = value; SetDirty(CN_CREATE_USER); } }
        public const string CN_CREATE_USER = "Create_User";
        public const string DT_CREATE_USER = "nvarchar(50)";
        private string? @_Create_User;

        public string? @District_ID { get { return _District_ID; } set { @_District_ID = value; SetDirty(CN_DISTRICT_ID); } }
        public const string CN_DISTRICT_ID = "District_ID";
        public const string DT_DISTRICT_ID = "nvarchar(50)";
        private string? @_District_ID;

        public string? @Important { get { return _Important; } set { @_Important = value; SetDirty(CN_IMPORTANT); } }
        public const string CN_IMPORTANT = "Important";
        public const string DT_IMPORTANT = "char(1)";
        private string? @_Important;

        public string? @Item_ID { get { return _Item_ID; } set { @_Item_ID = value; SetDirty(CN_ITEM_ID); } }
        public const string CN_ITEM_ID = "Item_ID";
        public const string DT_ITEM_ID = "varchar(50)";
        private string? @_Item_ID;

        public string? @Item_Name { get { return _Item_Name; } set { @_Item_Name = value; SetDirty(CN_ITEM_NAME); } }
        public const string CN_ITEM_NAME = "Item_Name";
        public const string DT_ITEM_NAME = "varchar(50)";
        private string? @_Item_Name;

        public string? @Letter_Class { get { return _Letter_Class; } set { @_Letter_Class = value; SetDirty(CN_LETTER_CLASS); } }
        public const string CN_LETTER_CLASS = "Letter_Class";
        public const string DT_LETTER_CLASS = "char(1)";
        private string? @_Letter_Class;

        public int? @Letter_Cost { get { return _Letter_Cost; } set { @_Letter_Cost = value; SetDirty(CN_LETTER_COST); } }
        public const string CN_LETTER_COST = "Letter_Cost";
        public const string DT_LETTER_COST = "int";
        private int? @_Letter_Cost;

        public string? @Letter_ID { get { return _Letter_ID; } set { @_Letter_ID = value; SetDirty(CN_LETTER_ID); } }
        public const string CN_LETTER_ID = "Letter_ID";
        public const string DT_LETTER_ID = "varchar(100)";
        private string? @_Letter_ID;

        public string? @Letter_IO { get { return _Letter_IO; } set { @_Letter_IO = value; SetDirty(CN_LETTER_IO); } }
        public const string CN_LETTER_IO = "Letter_IO";
        public const string DT_LETTER_IO = "char(1)";
        private string? @_Letter_IO;

        public string? @Loan_Account { get { return _Loan_Account; } set { @_Loan_Account = value; SetDirty(CN_LOAN_ACCOUNT); } }
        public const string CN_LOAN_ACCOUNT = "Loan_Account";
        public const string DT_LOAN_ACCOUNT = "varchar(50)";
        private string? @_Loan_Account;

        public string? @Memo { get { return _Memo; } set { @_Memo = value; SetDirty(CN_MEMO); } }
        public const string CN_MEMO = "Memo";
        public const string DT_MEMO = "varchar(50)";
        private string? @_Memo;

        public string? @Modify_Date { get { return _Modify_Date; } set { @_Modify_Date = value; SetDirty(CN_MODIFY_DATE); } }
        public const string CN_MODIFY_DATE = "Modify_Date";
        public const string DT_MODIFY_DATE = "varchar(30)";
        private string? @_Modify_Date;

        public string? @Modify_User { get { return _Modify_User; } set { @_Modify_User = value; SetDirty(CN_MODIFY_USER); } }
        public const string CN_MODIFY_USER = "Modify_User";
        public const string DT_MODIFY_USER = "nvarchar(50)";
        private string? @_Modify_User;

        public string? @Now_Dep { get { return _Now_Dep; } set { @_Now_Dep = value; SetDirty(CN_NOW_DEP); } }
        public const string CN_NOW_DEP = "Now_Dep";
        public const string DT_NOW_DEP = "varchar(10)";
        private string? @_Now_Dep;

        public string? @Outsite_Tracing_Code { get { return _Outsite_Tracing_Code; } set { @_Outsite_Tracing_Code = value; SetDirty(CN_OUTSITE_TRACING_CODE); } }
        public const string CN_OUTSITE_TRACING_CODE = "Outsite_Tracing_Code";
        public const string DT_OUTSITE_TRACING_CODE = "varchar(50)";
        private string? @_Outsite_Tracing_Code;

        public string? @Policy_Number { get { return _Policy_Number; } set { @_Policy_Number = value; SetDirty(CN_POLICY_NUMBER); } }
        public const string CN_POLICY_NUMBER = "Policy_Number";
        public const string DT_POLICY_NUMBER = "varchar(50)";
        private string? @_Policy_Number;

        public string? @Receive_Date { get { return _Receive_Date; } set { @_Receive_Date = value; SetDirty(CN_RECEIVE_DATE); } }
        public const string CN_RECEIVE_DATE = "Receive_Date";
        public const string DT_RECEIVE_DATE = "varchar(30)";
        private string? @_Receive_Date;

        public string? @Receiver_Name { get { return _Receiver_Name; } set { @_Receiver_Name = value; SetDirty(CN_RECEIVER_NAME); } }
        public const string CN_RECEIVER_NAME = "Receiver_Name";
        public const string DT_RECEIVER_NAME = "nvarchar(50)";
        private string? @_Receiver_Name;

        public string? @Rtn_Flag { get { return _Rtn_Flag; } set { @_Rtn_Flag = value; SetDirty(CN_RTN_FLAG); } }
        public const string CN_RTN_FLAG = "Rtn_Flag";
        public const string DT_RTN_FLAG = "char(1)";
        private string? @_Rtn_Flag;

        public string? @Send_Date { get { return _Send_Date; } set { @_Send_Date = value; SetDirty(CN_SEND_DATE); } }
        public const string CN_SEND_DATE = "Send_Date";
        public const string DT_SEND_DATE = "varchar(30)";
        private string? @_Send_Date;

        public string? @Sender_Name { get { return _Sender_Name; } set { @_Sender_Name = value; SetDirty(CN_SENDER_NAME); } }
        public const string CN_SENDER_NAME = "Sender_Name";
        public const string DT_SENDER_NAME = "nvarchar(50)";
        private string? @_Sender_Name;

        public string? @Source_Address { get { return _Source_Address; } set { @_Source_Address = value; SetDirty(CN_SOURCE_ADDRESS); } }
        public const string CN_SOURCE_ADDRESS = "Source_Address";
        public const string DT_SOURCE_ADDRESS = "nvarchar(100)";
        private string? @_Source_Address;

        public string? @Source_County_ID { get { return _Source_County_ID; } set { @_Source_County_ID = value; SetDirty(CN_SOURCE_COUNTY_ID); } }
        public const string CN_SOURCE_COUNTY_ID = "Source_County_ID";
        public const string DT_SOURCE_COUNTY_ID = "nvarchar(50)";
        private string? @_Source_County_ID;

        public string? @Source_Dep { get { return _Source_Dep; } set { @_Source_Dep = value; SetDirty(CN_SOURCE_DEP); } }
        public const string CN_SOURCE_DEP = "Source_Dep";
        public const string DT_SOURCE_DEP = "varchar(10)";
        private string? @_Source_Dep;

        public string? @Source_District_ID { get { return _Source_District_ID; } set { @_Source_District_ID = value; SetDirty(CN_SOURCE_DISTRICT_ID); } }
        public const string CN_SOURCE_DISTRICT_ID = "Source_District_ID";
        public const string DT_SOURCE_DISTRICT_ID = "nvarchar(50)";
        private string? @_Source_District_ID;

        public string? @Target_Dep { get { return _Target_Dep; } set { @_Target_Dep = value; SetDirty(CN_TARGET_DEP); } }
        public const string CN_TARGET_DEP = "Target_Dep";
        public const string DT_TARGET_DEP = "varchar(10)";
        private string? @_Target_Dep;

        public float? @Weight { get { return _Weight; } set { @_Weight = value; SetDirty(CN_WEIGHT); } }
        public const string CN_WEIGHT = "Weight";
        public const string DT_WEIGHT = "float(53.0)";
        private float? @_Weight;

        public @Letter_Info_History() : base()
        {
            PKColumnNames.UnionWith(new List<string>(){
                CN_LETTER_ID
            });
        }
    }
    ///////////////////////// Letter_Info_History END /////////////////////////

    ///////////////////////// Letter_Sequence BEGIN /////////////////////////
    // CREATE_DATE varchar(30)
    // CREATE_USER nvarchar(50)
    // IO_TYPE varchar(3)
    // LETTER_ID varchar(100)
    // LETTER_SEQ int
    // MODIFY_DATE varchar(30)
    // MODIFY_USER nvarchar(50)
    // NEXT_DEP varchar(10)
    // NOW_DEP varchar(10)
    // RECEIVE_USER varchar(50)
    // SEND_USER varchar(50)
    public class @Letter_Sequence : EntityBase
    {
        public const string TABLENAME = "Letter_Sequence";
        public const string FULL_TABLENAME = "Models.DBEntity.@Letter_Sequence";


        public string? @Create_Date { get { return _Create_Date; } set { @_Create_Date = value; SetDirty(CN_CREATE_DATE); } }
        public const string CN_CREATE_DATE = "Create_Date";
        public const string DT_CREATE_DATE = "varchar(30)";
        private string? @_Create_Date;

        public string? @Create_User { get { return _Create_User; } set { @_Create_User = value; SetDirty(CN_CREATE_USER); } }
        public const string CN_CREATE_USER = "Create_User";
        public const string DT_CREATE_USER = "nvarchar(50)";
        private string? @_Create_User;

        public string? @IO_Type { get { return _IO_Type; } set { @_IO_Type = value; SetDirty(CN_IO_TYPE); } }
        public const string CN_IO_TYPE = "IO_Type";
        public const string DT_IO_TYPE = "varchar(3)";
        private string? @_IO_Type;

        public string? @Letter_ID { get { return _Letter_ID; } set { @_Letter_ID = value; SetDirty(CN_LETTER_ID); } }
        public const string CN_LETTER_ID = "Letter_ID";
        public const string DT_LETTER_ID = "varchar(100)";
        private string? @_Letter_ID;

        public int? @Letter_Seq { get { return _Letter_Seq; } set { @_Letter_Seq = value; SetDirty(CN_LETTER_SEQ); } }
        public const string CN_LETTER_SEQ = "Letter_Seq";
        public const string DT_LETTER_SEQ = "int";
        private int? @_Letter_Seq;

        public string? @Modify_Date { get { return _Modify_Date; } set { @_Modify_Date = value; SetDirty(CN_MODIFY_DATE); } }
        public const string CN_MODIFY_DATE = "Modify_Date";
        public const string DT_MODIFY_DATE = "varchar(30)";
        private string? @_Modify_Date;

        public string? @Modify_User { get { return _Modify_User; } set { @_Modify_User = value; SetDirty(CN_MODIFY_USER); } }
        public const string CN_MODIFY_USER = "Modify_User";
        public const string DT_MODIFY_USER = "nvarchar(50)";
        private string? @_Modify_User;

        public string? @Next_Dep { get { return _Next_Dep; } set { @_Next_Dep = value; SetDirty(CN_NEXT_DEP); } }
        public const string CN_NEXT_DEP = "Next_Dep";
        public const string DT_NEXT_DEP = "varchar(10)";
        private string? @_Next_Dep;

        public string? @Now_Dep { get { return _Now_Dep; } set { @_Now_Dep = value; SetDirty(CN_NOW_DEP); } }
        public const string CN_NOW_DEP = "Now_Dep";
        public const string DT_NOW_DEP = "varchar(10)";
        private string? @_Now_Dep;

        public string? @Receive_User { get { return _Receive_User; } set { @_Receive_User = value; SetDirty(CN_RECEIVE_USER); } }
        public const string CN_RECEIVE_USER = "Receive_User";
        public const string DT_RECEIVE_USER = "varchar(50)";
        private string? @_Receive_User;

        public string? @Send_User { get { return _Send_User; } set { @_Send_User = value; SetDirty(CN_SEND_USER); } }
        public const string CN_SEND_USER = "Send_User";
        public const string DT_SEND_USER = "varchar(50)";
        private string? @_Send_User;

        public @Letter_Sequence() : base()
        {
            PKColumnNames.UnionWith(new List<string>(){
                CN_LETTER_ID
                ,CN_LETTER_SEQ
            });
        }
    }
    ///////////////////////// Letter_Sequence END /////////////////////////

    ///////////////////////// Letter_Shelf BEGIN /////////////////////////
    // AREA varchar(30)
    // CREATE_DATE varchar(30)
    // CREATE_USER nvarchar(50)
    // CUR_LETTER_ID varchar(100)
    // DEPARTMENT_ID varchar(10)
    // IBS_ADDRESS numeric(20.0)
    // IBS_INDEX numeric(20.0)
    // LOC_ID varchar(64)
    // LOC_IP varchar(30)
    // LOC_LIGHT_ADRESS numeric(20.0)
    // LOC_LIGHT_INDEX numeric(20.0)
    // LOC_SENSOR_ADRESS numeric(20.0)
    // LOC_SENSOR_ADRESS_BEGIN numeric(20.0)
    // LOC_SENSOR_ADRESS_END numeric(20.0)
    // LOC_STS char(1)
    // MODIFY_DATE varchar(30)
    // MODIFY_USER nvarchar(50)
    // PROCESS_TIME varchar(30)
    // SHELF_ID varchar(64)
    public class @Letter_Shelf : EntityBase
    {
        public const string TABLENAME = "Letter_Shelf";
        public const string FULL_TABLENAME = "Models.DBEntity.@Letter_Shelf";


        public string? @Area { get { return _Area; } set { @_Area = value; SetDirty(CN_AREA); } }
        public const string CN_AREA = "Area";
        public const string DT_AREA = "varchar(30)";
        private string? @_Area;

        public string? @Create_Date { get { return _Create_Date; } set { @_Create_Date = value; SetDirty(CN_CREATE_DATE); } }
        public const string CN_CREATE_DATE = "Create_Date";
        public const string DT_CREATE_DATE = "varchar(30)";
        private string? @_Create_Date;

        public string? @Create_User { get { return _Create_User; } set { @_Create_User = value; SetDirty(CN_CREATE_USER); } }
        public const string CN_CREATE_USER = "Create_User";
        public const string DT_CREATE_USER = "nvarchar(50)";
        private string? @_Create_User;

        public string? @Cur_Letter_ID { get { return _Cur_Letter_ID; } set { @_Cur_Letter_ID = value; SetDirty(CN_CUR_LETTER_ID); } }
        public const string CN_CUR_LETTER_ID = "Cur_Letter_ID";
        public const string DT_CUR_LETTER_ID = "varchar(100)";
        private string? @_Cur_Letter_ID;

        public string? @Department_ID { get { return _Department_ID; } set { @_Department_ID = value; SetDirty(CN_DEPARTMENT_ID); } }
        public const string CN_DEPARTMENT_ID = "Department_ID";
        public const string DT_DEPARTMENT_ID = "varchar(10)";
        private string? @_Department_ID;

        public decimal? @IBS_Address { get { return _IBS_Address; } set { @_IBS_Address = value; SetDirty(CN_IBS_ADDRESS); } }
        public const string CN_IBS_ADDRESS = "IBS_Address";
        public const string DT_IBS_ADDRESS = "numeric(20.0)";
        private decimal? @_IBS_Address;

        public decimal? @IBS_Index { get { return _IBS_Index; } set { @_IBS_Index = value; SetDirty(CN_IBS_INDEX); } }
        public const string CN_IBS_INDEX = "IBS_Index";
        public const string DT_IBS_INDEX = "numeric(20.0)";
        private decimal? @_IBS_Index;

        public string? @Loc_ID { get { return _Loc_ID; } set { @_Loc_ID = value; SetDirty(CN_LOC_ID); } }
        public const string CN_LOC_ID = "Loc_ID";
        public const string DT_LOC_ID = "varchar(64)";
        private string? @_Loc_ID;

        public string? @Loc_IP { get { return _Loc_IP; } set { @_Loc_IP = value; SetDirty(CN_LOC_IP); } }
        public const string CN_LOC_IP = "Loc_IP";
        public const string DT_LOC_IP = "varchar(30)";
        private string? @_Loc_IP;

        public decimal? @Loc_Light_Adress { get { return _Loc_Light_Adress; } set { @_Loc_Light_Adress = value; SetDirty(CN_LOC_LIGHT_ADRESS); } }
        public const string CN_LOC_LIGHT_ADRESS = "Loc_Light_Adress";
        public const string DT_LOC_LIGHT_ADRESS = "numeric(20.0)";
        private decimal? @_Loc_Light_Adress;

        public decimal? @Loc_Light_Index { get { return _Loc_Light_Index; } set { @_Loc_Light_Index = value; SetDirty(CN_LOC_LIGHT_INDEX); } }
        public const string CN_LOC_LIGHT_INDEX = "Loc_Light_Index";
        public const string DT_LOC_LIGHT_INDEX = "numeric(20.0)";
        private decimal? @_Loc_Light_Index;

        public decimal? @Loc_Sensor_Adress { get { return _Loc_Sensor_Adress; } set { @_Loc_Sensor_Adress = value; SetDirty(CN_LOC_SENSOR_ADRESS); } }
        public const string CN_LOC_SENSOR_ADRESS = "Loc_Sensor_Adress";
        public const string DT_LOC_SENSOR_ADRESS = "numeric(20.0)";
        private decimal? @_Loc_Sensor_Adress;

        public decimal? @Loc_Sensor_Adress_Begin { get { return _Loc_Sensor_Adress_Begin; } set { @_Loc_Sensor_Adress_Begin = value; SetDirty(CN_LOC_SENSOR_ADRESS_BEGIN); } }
        public const string CN_LOC_SENSOR_ADRESS_BEGIN = "Loc_Sensor_Adress_Begin";
        public const string DT_LOC_SENSOR_ADRESS_BEGIN = "numeric(20.0)";
        private decimal? @_Loc_Sensor_Adress_Begin;

        public decimal? @Loc_Sensor_Adress_End { get { return _Loc_Sensor_Adress_End; } set { @_Loc_Sensor_Adress_End = value; SetDirty(CN_LOC_SENSOR_ADRESS_END); } }
        public const string CN_LOC_SENSOR_ADRESS_END = "Loc_Sensor_Adress_End";
        public const string DT_LOC_SENSOR_ADRESS_END = "numeric(20.0)";
        private decimal? @_Loc_Sensor_Adress_End;

        public string? @Loc_Sts { get { return _Loc_Sts; } set { @_Loc_Sts = value; SetDirty(CN_LOC_STS); } }
        public const string CN_LOC_STS = "Loc_Sts";
        public const string DT_LOC_STS = "char(1)";
        private string? @_Loc_Sts;

        public string? @Modify_Date { get { return _Modify_Date; } set { @_Modify_Date = value; SetDirty(CN_MODIFY_DATE); } }
        public const string CN_MODIFY_DATE = "Modify_Date";
        public const string DT_MODIFY_DATE = "varchar(30)";
        private string? @_Modify_Date;

        public string? @Modify_User { get { return _Modify_User; } set { @_Modify_User = value; SetDirty(CN_MODIFY_USER); } }
        public const string CN_MODIFY_USER = "Modify_User";
        public const string DT_MODIFY_USER = "nvarchar(50)";
        private string? @_Modify_User;

        public string? @Process_Time { get { return _Process_Time; } set { @_Process_Time = value; SetDirty(CN_PROCESS_TIME); } }
        public const string CN_PROCESS_TIME = "Process_Time";
        public const string DT_PROCESS_TIME = "varchar(30)";
        private string? @_Process_Time;

        public string? @Shelf_ID { get { return _Shelf_ID; } set { @_Shelf_ID = value; SetDirty(CN_SHELF_ID); } }
        public const string CN_SHELF_ID = "Shelf_ID";
        public const string DT_SHELF_ID = "varchar(64)";
        private string? @_Shelf_ID;

        public @Letter_Shelf() : base()
        {
            PKColumnNames.UnionWith(new List<string>(){
                CN_LOC_ID
            });
        }
    }
    ///////////////////////// Letter_Shelf END /////////////////////////

    ///////////////////////// Letter_Shelf_Log BEGIN /////////////////////////
    // LOC_ID varchar(64)
    // LOC_STS varchar(64)
    // LOG_CODE varchar(5)
    // LOG_DATE varchar(30)
    // QUANTITY int
    // UID varchar(100)
    public class @Letter_Shelf_Log : EntityBase
    {
        public const string TABLENAME = "Letter_Shelf_Log";
        public const string FULL_TABLENAME = "Models.DBEntity.@Letter_Shelf_Log";


        public string? @Loc_ID { get { return _Loc_ID; } set { @_Loc_ID = value; SetDirty(CN_LOC_ID); } }
        public const string CN_LOC_ID = "Loc_ID";
        public const string DT_LOC_ID = "varchar(64)";
        private string? @_Loc_ID;

        public string? @Loc_Sts { get { return _Loc_Sts; } set { @_Loc_Sts = value; SetDirty(CN_LOC_STS); } }
        public const string CN_LOC_STS = "Loc_Sts";
        public const string DT_LOC_STS = "varchar(64)";
        private string? @_Loc_Sts;

        public string? @Log_Code { get { return _Log_Code; } set { @_Log_Code = value; SetDirty(CN_LOG_CODE); } }
        public const string CN_LOG_CODE = "Log_Code";
        public const string DT_LOG_CODE = "varchar(5)";
        private string? @_Log_Code;

        public string? @Log_Date { get { return _Log_Date; } set { @_Log_Date = value; SetDirty(CN_LOG_DATE); } }
        public const string CN_LOG_DATE = "Log_Date";
        public const string DT_LOG_DATE = "varchar(30)";
        private string? @_Log_Date;

        public int? @Quantity { get { return _Quantity; } set { @_Quantity = value; SetDirty(CN_QUANTITY); } }
        public const string CN_QUANTITY = "Quantity";
        public const string DT_QUANTITY = "int";
        private int? @_Quantity;

        public string? @UID { get { return _UID; } set { @_UID = value; SetDirty(CN_UID); } }
        public const string CN_UID = "UID";
        public const string DT_UID = "varchar(100)";
        private string? @_UID;

        public @Letter_Shelf_Log() : base()
        {
            PKColumnNames.UnionWith(new List<string>(){
                CN_UID
            });
        }
    }
    ///////////////////////// Letter_Shelf_Log END /////////////////////////

    ///////////////////////// Location_Types BEGIN /////////////////////////
    // CREATE_DATE varchar(30)
    // CREATE_USER nvarchar(50)
    // LETTER_CLASS char(1)
    // LOC_ID varchar(64)
    // MODIFY_DATE varchar(30)
    // MODIFY_USER nvarchar(50)
    public class @Location_Types : EntityBase
    {
        public const string TABLENAME = "Location_Types";
        public const string FULL_TABLENAME = "Models.DBEntity.@Location_Types";


        public string? @Create_Date { get { return _Create_Date; } set { @_Create_Date = value; SetDirty(CN_CREATE_DATE); } }
        public const string CN_CREATE_DATE = "Create_Date";
        public const string DT_CREATE_DATE = "varchar(30)";
        private string? @_Create_Date;

        public string? @Create_User { get { return _Create_User; } set { @_Create_User = value; SetDirty(CN_CREATE_USER); } }
        public const string CN_CREATE_USER = "Create_User";
        public const string DT_CREATE_USER = "nvarchar(50)";
        private string? @_Create_User;

        public string? @Letter_Class { get { return _Letter_Class; } set { @_Letter_Class = value; SetDirty(CN_LETTER_CLASS); } }
        public const string CN_LETTER_CLASS = "Letter_Class";
        public const string DT_LETTER_CLASS = "char(1)";
        private string? @_Letter_Class;

        public string? @Loc_ID { get { return _Loc_ID; } set { @_Loc_ID = value; SetDirty(CN_LOC_ID); } }
        public const string CN_LOC_ID = "Loc_ID";
        public const string DT_LOC_ID = "varchar(64)";
        private string? @_Loc_ID;

        public string? @Modify_Date { get { return _Modify_Date; } set { @_Modify_Date = value; SetDirty(CN_MODIFY_DATE); } }
        public const string CN_MODIFY_DATE = "Modify_Date";
        public const string DT_MODIFY_DATE = "varchar(30)";
        private string? @_Modify_Date;

        public string? @Modify_User { get { return _Modify_User; } set { @_Modify_User = value; SetDirty(CN_MODIFY_USER); } }
        public const string CN_MODIFY_USER = "Modify_User";
        public const string DT_MODIFY_USER = "nvarchar(50)";
        private string? @_Modify_User;

        public @Location_Types() : base()
        {
            PKColumnNames.UnionWith(new List<string>(){
                CN_LETTER_CLASS
                ,CN_LOC_ID
            });
        }
    }
    ///////////////////////// Location_Types END /////////////////////////

    ///////////////////////// Modules BEGIN /////////////////////////
    // CREATE_DATE varchar(30)
    // CREATE_USER nvarchar(50)
    // MODIFY_DATE varchar(30)
    // MODIFY_USER nvarchar(50)
    // MODULE_ID varchar(50)
    // MODULE_NAME nvarchar(50)
    // ORDER_BY int
    // PARENT_MODULE_ID varchar(50)
    public class @Modules : EntityBase
    {
        public const string TABLENAME = "Modules";
        public const string FULL_TABLENAME = "Models.DBEntity.@Modules";


        public string? @Create_Date { get { return _Create_Date; } set { @_Create_Date = value; SetDirty(CN_CREATE_DATE); } }
        public const string CN_CREATE_DATE = "Create_Date";
        public const string DT_CREATE_DATE = "varchar(30)";
        private string? @_Create_Date;

        public string? @Create_User { get { return _Create_User; } set { @_Create_User = value; SetDirty(CN_CREATE_USER); } }
        public const string CN_CREATE_USER = "Create_User";
        public const string DT_CREATE_USER = "nvarchar(50)";
        private string? @_Create_User;

        public string? @Modify_Date { get { return _Modify_Date; } set { @_Modify_Date = value; SetDirty(CN_MODIFY_DATE); } }
        public const string CN_MODIFY_DATE = "Modify_Date";
        public const string DT_MODIFY_DATE = "varchar(30)";
        private string? @_Modify_Date;

        public string? @Modify_User { get { return _Modify_User; } set { @_Modify_User = value; SetDirty(CN_MODIFY_USER); } }
        public const string CN_MODIFY_USER = "Modify_User";
        public const string DT_MODIFY_USER = "nvarchar(50)";
        private string? @_Modify_User;

        public string? @Module_ID { get { return _Module_ID; } set { @_Module_ID = value; SetDirty(CN_MODULE_ID); } }
        public const string CN_MODULE_ID = "Module_ID";
        public const string DT_MODULE_ID = "varchar(50)";
        private string? @_Module_ID;

        public string? @Module_Name { get { return _Module_Name; } set { @_Module_Name = value; SetDirty(CN_MODULE_NAME); } }
        public const string CN_MODULE_NAME = "Module_Name";
        public const string DT_MODULE_NAME = "nvarchar(50)";
        private string? @_Module_Name;

        public int? @Order_By { get { return _Order_By; } set { @_Order_By = value; SetDirty(CN_ORDER_BY); } }
        public const string CN_ORDER_BY = "Order_By";
        public const string DT_ORDER_BY = "int";
        private int? @_Order_By;

        public string? @Parent_Module_ID { get { return _Parent_Module_ID; } set { @_Parent_Module_ID = value; SetDirty(CN_PARENT_MODULE_ID); } }
        public const string CN_PARENT_MODULE_ID = "Parent_Module_ID";
        public const string DT_PARENT_MODULE_ID = "varchar(50)";
        private string? @_Parent_Module_ID;

        public @Modules() : base()
        {
            PKColumnNames.UnionWith(new List<string>(){
                CN_MODULE_ID
            });
        }
    }
    ///////////////////////// Modules END /////////////////////////

    ///////////////////////// NFC_Info BEGIN /////////////////////////
    // CREATE_DATE varchar(30)
    // CREATE_USER nvarchar(50)
    // MODIFY_DATE varchar(30)
    // MODIFY_USER nvarchar(50)
    // NFC_ID varchar(100)
    // USER_NAME nvarchar(50)
    public class @NFC_Info : EntityBase
    {
        public const string TABLENAME = "NFC_Info";
        public const string FULL_TABLENAME = "Models.DBEntity.@NFC_Info";


        public string? @Create_Date { get { return _Create_Date; } set { @_Create_Date = value; SetDirty(CN_CREATE_DATE); } }
        public const string CN_CREATE_DATE = "Create_Date";
        public const string DT_CREATE_DATE = "varchar(30)";
        private string? @_Create_Date;

        public string? @Create_User { get { return _Create_User; } set { @_Create_User = value; SetDirty(CN_CREATE_USER); } }
        public const string CN_CREATE_USER = "Create_User";
        public const string DT_CREATE_USER = "nvarchar(50)";
        private string? @_Create_User;

        public string? @Modify_Date { get { return _Modify_Date; } set { @_Modify_Date = value; SetDirty(CN_MODIFY_DATE); } }
        public const string CN_MODIFY_DATE = "Modify_Date";
        public const string DT_MODIFY_DATE = "varchar(30)";
        private string? @_Modify_Date;

        public string? @Modify_User { get { return _Modify_User; } set { @_Modify_User = value; SetDirty(CN_MODIFY_USER); } }
        public const string CN_MODIFY_USER = "Modify_User";
        public const string DT_MODIFY_USER = "nvarchar(50)";
        private string? @_Modify_User;

        public string? @NFC_ID { get { return _NFC_ID; } set { @_NFC_ID = value; SetDirty(CN_NFC_ID); } }
        public const string CN_NFC_ID = "NFC_ID";
        public const string DT_NFC_ID = "varchar(100)";
        private string? @_NFC_ID;

        public string? @User_Name { get { return _User_Name; } set { @_User_Name = value; SetDirty(CN_USER_NAME); } }
        public const string CN_USER_NAME = "User_Name";
        public const string DT_USER_NAME = "nvarchar(50)";
        private string? @_User_Name;

        public @NFC_Info() : base()
        {
            PKColumnNames.UnionWith(new List<string>(){
                CN_NFC_ID
            });
        }
    }
    ///////////////////////// NFC_Info END /////////////////////////

    ///////////////////////// Operation_Item BEGIN /////////////////////////
    // CREATE_DATE varchar(30)
    // CREATE_USER nvarchar(50)
    // DEPARTMENT_ID varchar(10)
    // ITEM_ID varchar(50)
    // ITEM_NAME nvarchar(50)
    // MODIFY_DATE varchar(30)
    // MODIFY_USER nvarchar(50)
    public class @Operation_Item : EntityBase
    {
        public const string TABLENAME = "Operation_Item";
        public const string FULL_TABLENAME = "Models.DBEntity.@Operation_Item";


        public string? @Create_Date { get { return _Create_Date; } set { @_Create_Date = value; SetDirty(CN_CREATE_DATE); } }
        public const string CN_CREATE_DATE = "Create_Date";
        public const string DT_CREATE_DATE = "varchar(30)";
        private string? @_Create_Date;

        public string? @Create_User { get { return _Create_User; } set { @_Create_User = value; SetDirty(CN_CREATE_USER); } }
        public const string CN_CREATE_USER = "Create_User";
        public const string DT_CREATE_USER = "nvarchar(50)";
        private string? @_Create_User;

        public string? @Department_ID { get { return _Department_ID; } set { @_Department_ID = value; SetDirty(CN_DEPARTMENT_ID); } }
        public const string CN_DEPARTMENT_ID = "Department_ID";
        public const string DT_DEPARTMENT_ID = "varchar(10)";
        private string? @_Department_ID;

        public string? @Item_ID { get { return _Item_ID; } set { @_Item_ID = value; SetDirty(CN_ITEM_ID); } }
        public const string CN_ITEM_ID = "Item_ID";
        public const string DT_ITEM_ID = "varchar(50)";
        private string? @_Item_ID;

        public string? @Item_Name { get { return _Item_Name; } set { @_Item_Name = value; SetDirty(CN_ITEM_NAME); } }
        public const string CN_ITEM_NAME = "Item_Name";
        public const string DT_ITEM_NAME = "nvarchar(50)";
        private string? @_Item_Name;

        public string? @Modify_Date { get { return _Modify_Date; } set { @_Modify_Date = value; SetDirty(CN_MODIFY_DATE); } }
        public const string CN_MODIFY_DATE = "Modify_Date";
        public const string DT_MODIFY_DATE = "varchar(30)";
        private string? @_Modify_Date;

        public string? @Modify_User { get { return _Modify_User; } set { @_Modify_User = value; SetDirty(CN_MODIFY_USER); } }
        public const string CN_MODIFY_USER = "Modify_User";
        public const string DT_MODIFY_USER = "nvarchar(50)";
        private string? @_Modify_User;

        public @Operation_Item() : base()
        {
            PKColumnNames.UnionWith(new List<string>(){
                CN_ITEM_ID
            });
        }
    }
    ///////////////////////// Operation_Item END /////////////////////////

    ///////////////////////// Post_Cost BEGIN /////////////////////////
    // COST_ID varchar(50)
    // COST_PER_GRAM float(53.0)
    // CREATE_DATE varchar(30)
    // CREATE_USER nvarchar(50)
    // LETTER_CLASS char(1)
    // MODIFY_DATE varchar(30)
    // MODIFY_USER nvarchar(50)
    // WEIGHT_END float(53.0)
    // WEIGHT_START float(53.0)
    public class @Post_Cost : EntityBase
    {
        public const string TABLENAME = "Post_Cost";
        public const string FULL_TABLENAME = "Models.DBEntity.@Post_Cost";


        public string? @Cost_ID { get { return _Cost_ID; } set { @_Cost_ID = value; SetDirty(CN_COST_ID); } }
        public const string CN_COST_ID = "Cost_ID";
        public const string DT_COST_ID = "varchar(50)";
        private string? @_Cost_ID;

        public float? @Cost_Per_Gram { get { return _Cost_Per_Gram; } set { @_Cost_Per_Gram = value; SetDirty(CN_COST_PER_GRAM); } }
        public const string CN_COST_PER_GRAM = "Cost_Per_Gram";
        public const string DT_COST_PER_GRAM = "float(53.0)";
        private float? @_Cost_Per_Gram;

        public string? @Create_Date { get { return _Create_Date; } set { @_Create_Date = value; SetDirty(CN_CREATE_DATE); } }
        public const string CN_CREATE_DATE = "Create_Date";
        public const string DT_CREATE_DATE = "varchar(30)";
        private string? @_Create_Date;

        public string? @Create_User { get { return _Create_User; } set { @_Create_User = value; SetDirty(CN_CREATE_USER); } }
        public const string CN_CREATE_USER = "Create_User";
        public const string DT_CREATE_USER = "nvarchar(50)";
        private string? @_Create_User;

        public string? @Letter_Class { get { return _Letter_Class; } set { @_Letter_Class = value; SetDirty(CN_LETTER_CLASS); } }
        public const string CN_LETTER_CLASS = "Letter_Class";
        public const string DT_LETTER_CLASS = "char(1)";
        private string? @_Letter_Class;

        public string? @Modify_Date { get { return _Modify_Date; } set { @_Modify_Date = value; SetDirty(CN_MODIFY_DATE); } }
        public const string CN_MODIFY_DATE = "Modify_Date";
        public const string DT_MODIFY_DATE = "varchar(30)";
        private string? @_Modify_Date;

        public string? @Modify_User { get { return _Modify_User; } set { @_Modify_User = value; SetDirty(CN_MODIFY_USER); } }
        public const string CN_MODIFY_USER = "Modify_User";
        public const string DT_MODIFY_USER = "nvarchar(50)";
        private string? @_Modify_User;

        public float? @Weight_End { get { return _Weight_End; } set { @_Weight_End = value; SetDirty(CN_WEIGHT_END); } }
        public const string CN_WEIGHT_END = "Weight_End";
        public const string DT_WEIGHT_END = "float(53.0)";
        private float? @_Weight_End;

        public float? @Weight_Start { get { return _Weight_Start; } set { @_Weight_Start = value; SetDirty(CN_WEIGHT_START); } }
        public const string CN_WEIGHT_START = "Weight_Start";
        public const string DT_WEIGHT_START = "float(53.0)";
        private float? @_Weight_Start;

        public @Post_Cost() : base()
        {
            PKColumnNames.UnionWith(new List<string>(){
                CN_COST_ID
            });
        }
    }
    ///////////////////////// Post_Cost END /////////////////////////

    ///////////////////////// PostageMeter_Info BEGIN /////////////////////////
    // CREATE_DATE varchar(30)
    // CREATE_USER nvarchar(50)
    // DECREASE_NUMBER numeric(20.0)
    // DESTROY_NUMBER numeric(20.0)
    // IO_DEPARTMENT_ID varchar(10)
    // MODIFY_DATE varchar(30)
    // MODIFY_USER nvarchar(50)
    // SIGN_CODE varchar(30)
    // TEMP_CODE varchar(30)
    // TEMP_DATE varchar(30)
    // TEMP_USER varchar(30)
    // TOTAL_NUMBER numeric(20.0)
    public class @PostageMeter_Info : EntityBase
    {
        public const string TABLENAME = "PostageMeter_Info";
        public const string FULL_TABLENAME = "Models.DBEntity.@PostageMeter_Info";


        public string? @Create_Date { get { return _Create_Date; } set { @_Create_Date = value; SetDirty(CN_CREATE_DATE); } }
        public const string CN_CREATE_DATE = "Create_Date";
        public const string DT_CREATE_DATE = "varchar(30)";
        private string? @_Create_Date;

        public string? @Create_User { get { return _Create_User; } set { @_Create_User = value; SetDirty(CN_CREATE_USER); } }
        public const string CN_CREATE_USER = "Create_User";
        public const string DT_CREATE_USER = "nvarchar(50)";
        private string? @_Create_User;

        public decimal? @Decrease_Number { get { return _Decrease_Number; } set { @_Decrease_Number = value; SetDirty(CN_DECREASE_NUMBER); } }
        public const string CN_DECREASE_NUMBER = "Decrease_Number";
        public const string DT_DECREASE_NUMBER = "numeric(20.0)";
        private decimal? @_Decrease_Number;

        public decimal? @Destroy_Number { get { return _Destroy_Number; } set { @_Destroy_Number = value; SetDirty(CN_DESTROY_NUMBER); } }
        public const string CN_DESTROY_NUMBER = "Destroy_Number";
        public const string DT_DESTROY_NUMBER = "numeric(20.0)";
        private decimal? @_Destroy_Number;

        public string? @IO_Department_ID { get { return _IO_Department_ID; } set { @_IO_Department_ID = value; SetDirty(CN_IO_DEPARTMENT_ID); } }
        public const string CN_IO_DEPARTMENT_ID = "IO_Department_ID";
        public const string DT_IO_DEPARTMENT_ID = "varchar(10)";
        private string? @_IO_Department_ID;

        public string? @Modify_Date { get { return _Modify_Date; } set { @_Modify_Date = value; SetDirty(CN_MODIFY_DATE); } }
        public const string CN_MODIFY_DATE = "Modify_Date";
        public const string DT_MODIFY_DATE = "varchar(30)";
        private string? @_Modify_Date;

        public string? @Modify_User { get { return _Modify_User; } set { @_Modify_User = value; SetDirty(CN_MODIFY_USER); } }
        public const string CN_MODIFY_USER = "Modify_User";
        public const string DT_MODIFY_USER = "nvarchar(50)";
        private string? @_Modify_User;

        public string? @Sign_Code { get { return _Sign_Code; } set { @_Sign_Code = value; SetDirty(CN_SIGN_CODE); } }
        public const string CN_SIGN_CODE = "Sign_Code";
        public const string DT_SIGN_CODE = "varchar(30)";
        private string? @_Sign_Code;

        public string? @Temp_Code { get { return _Temp_Code; } set { @_Temp_Code = value; SetDirty(CN_TEMP_CODE); } }
        public const string CN_TEMP_CODE = "Temp_Code";
        public const string DT_TEMP_CODE = "varchar(30)";
        private string? @_Temp_Code;

        public string? @Temp_Date { get { return _Temp_Date; } set { @_Temp_Date = value; SetDirty(CN_TEMP_DATE); } }
        public const string CN_TEMP_DATE = "Temp_Date";
        public const string DT_TEMP_DATE = "varchar(30)";
        private string? @_Temp_Date;

        public string? @Temp_User { get { return _Temp_User; } set { @_Temp_User = value; SetDirty(CN_TEMP_USER); } }
        public const string CN_TEMP_USER = "Temp_User";
        public const string DT_TEMP_USER = "varchar(30)";
        private string? @_Temp_User;

        public decimal? @Total_Number { get { return _Total_Number; } set { @_Total_Number = value; SetDirty(CN_TOTAL_NUMBER); } }
        public const string CN_TOTAL_NUMBER = "Total_Number";
        public const string DT_TOTAL_NUMBER = "numeric(20.0)";
        private decimal? @_Total_Number;

        public @PostageMeter_Info() : base()
        {
            PKColumnNames.UnionWith(new List<string>(){
                CN_IO_DEPARTMENT_ID
                ,CN_TEMP_DATE
            });
        }
    }
    ///////////////////////// PostageMeter_Info END /////////////////////////

    ///////////////////////// PostageMeter_Sequence BEGIN /////////////////////////
    // CLASS_COST numeric(10.0)
    // CLASS_COUNT numeric(10.0)
    // CREATE_DATE varchar(30)
    // CREATE_USER nvarchar(50)
    // IO_DEPARTMENT_ID varchar(10)
    // LETTER_CLASS char(1)
    // MODIFY_DATE varchar(30)
    // MODIFY_USER nvarchar(50)
    // TEMP_DATE varchar(50)
    public class @PostageMeter_Sequence : EntityBase
    {
        public const string TABLENAME = "PostageMeter_Sequence";
        public const string FULL_TABLENAME = "Models.DBEntity.@PostageMeter_Sequence";


        public decimal? @Class_Cost { get { return _Class_Cost; } set { @_Class_Cost = value; SetDirty(CN_CLASS_COST); } }
        public const string CN_CLASS_COST = "Class_Cost";
        public const string DT_CLASS_COST = "numeric(10.0)";
        private decimal? @_Class_Cost;

        public decimal? @Class_Count { get { return _Class_Count; } set { @_Class_Count = value; SetDirty(CN_CLASS_COUNT); } }
        public const string CN_CLASS_COUNT = "Class_Count";
        public const string DT_CLASS_COUNT = "numeric(10.0)";
        private decimal? @_Class_Count;

        public string? @Create_Date { get { return _Create_Date; } set { @_Create_Date = value; SetDirty(CN_CREATE_DATE); } }
        public const string CN_CREATE_DATE = "Create_Date";
        public const string DT_CREATE_DATE = "varchar(30)";
        private string? @_Create_Date;

        public string? @Create_User { get { return _Create_User; } set { @_Create_User = value; SetDirty(CN_CREATE_USER); } }
        public const string CN_CREATE_USER = "Create_User";
        public const string DT_CREATE_USER = "nvarchar(50)";
        private string? @_Create_User;

        public string? @IO_Department_ID { get { return _IO_Department_ID; } set { @_IO_Department_ID = value; SetDirty(CN_IO_DEPARTMENT_ID); } }
        public const string CN_IO_DEPARTMENT_ID = "IO_Department_ID";
        public const string DT_IO_DEPARTMENT_ID = "varchar(10)";
        private string? @_IO_Department_ID;

        public string? @Letter_Class { get { return _Letter_Class; } set { @_Letter_Class = value; SetDirty(CN_LETTER_CLASS); } }
        public const string CN_LETTER_CLASS = "Letter_Class";
        public const string DT_LETTER_CLASS = "char(1)";
        private string? @_Letter_Class;

        public string? @Modify_Date { get { return _Modify_Date; } set { @_Modify_Date = value; SetDirty(CN_MODIFY_DATE); } }
        public const string CN_MODIFY_DATE = "Modify_Date";
        public const string DT_MODIFY_DATE = "varchar(30)";
        private string? @_Modify_Date;

        public string? @Modify_User { get { return _Modify_User; } set { @_Modify_User = value; SetDirty(CN_MODIFY_USER); } }
        public const string CN_MODIFY_USER = "Modify_User";
        public const string DT_MODIFY_USER = "nvarchar(50)";
        private string? @_Modify_User;

        public string? @Temp_Date { get { return _Temp_Date; } set { @_Temp_Date = value; SetDirty(CN_TEMP_DATE); } }
        public const string CN_TEMP_DATE = "Temp_Date";
        public const string DT_TEMP_DATE = "varchar(50)";
        private string? @_Temp_Date;

        public @PostageMeter_Sequence() : base()
        {
            PKColumnNames.UnionWith(new List<string>(){
                CN_IO_DEPARTMENT_ID
                ,CN_LETTER_CLASS
                ,CN_TEMP_DATE
            });
        }
    }
    ///////////////////////// PostageMeter_Sequence END /////////////////////////

    ///////////////////////// Programs BEGIN /////////////////////////
    // CREATE_DATE varchar(30)
    // CREATE_USER nvarchar(50)
    // FILE_PATH nvarchar(100)
    // MEMO varchar(50)
    // MODIFY_DATE varchar(30)
    // MODIFY_USER nvarchar(50)
    // MODULE_ID varchar(50)
    // ORDER_BY int
    // PROGRAM_ID varchar(50)
    // PROGRAM_NAME nvarchar(50)
    // SHOW_IN_LIST char(1)
    public class @Programs : EntityBase
    {
        public const string TABLENAME = "Programs";
        public const string FULL_TABLENAME = "Models.DBEntity.@Programs";


        public string? @Create_Date { get { return _Create_Date; } set { @_Create_Date = value; SetDirty(CN_CREATE_DATE); } }
        public const string CN_CREATE_DATE = "Create_Date";
        public const string DT_CREATE_DATE = "varchar(30)";
        private string? @_Create_Date;

        public string? @Create_User { get { return _Create_User; } set { @_Create_User = value; SetDirty(CN_CREATE_USER); } }
        public const string CN_CREATE_USER = "Create_User";
        public const string DT_CREATE_USER = "nvarchar(50)";
        private string? @_Create_User;

        public string? @File_Path { get { return _File_Path; } set { @_File_Path = value; SetDirty(CN_FILE_PATH); } }
        public const string CN_FILE_PATH = "File_Path";
        public const string DT_FILE_PATH = "nvarchar(100)";
        private string? @_File_Path;

        public string? @Memo { get { return _Memo; } set { @_Memo = value; SetDirty(CN_MEMO); } }
        public const string CN_MEMO = "Memo";
        public const string DT_MEMO = "varchar(50)";
        private string? @_Memo;

        public string? @Modify_Date { get { return _Modify_Date; } set { @_Modify_Date = value; SetDirty(CN_MODIFY_DATE); } }
        public const string CN_MODIFY_DATE = "Modify_Date";
        public const string DT_MODIFY_DATE = "varchar(30)";
        private string? @_Modify_Date;

        public string? @Modify_User { get { return _Modify_User; } set { @_Modify_User = value; SetDirty(CN_MODIFY_USER); } }
        public const string CN_MODIFY_USER = "Modify_User";
        public const string DT_MODIFY_USER = "nvarchar(50)";
        private string? @_Modify_User;

        public string? @Module_ID { get { return _Module_ID; } set { @_Module_ID = value; SetDirty(CN_MODULE_ID); } }
        public const string CN_MODULE_ID = "Module_ID";
        public const string DT_MODULE_ID = "varchar(50)";
        private string? @_Module_ID;

        public int? @Order_By { get { return _Order_By; } set { @_Order_By = value; SetDirty(CN_ORDER_BY); } }
        public const string CN_ORDER_BY = "Order_By";
        public const string DT_ORDER_BY = "int";
        private int? @_Order_By;

        public string? @Program_ID { get { return _Program_ID; } set { @_Program_ID = value; SetDirty(CN_PROGRAM_ID); } }
        public const string CN_PROGRAM_ID = "Program_ID";
        public const string DT_PROGRAM_ID = "varchar(50)";
        private string? @_Program_ID;

        public string? @Program_Name { get { return _Program_Name; } set { @_Program_Name = value; SetDirty(CN_PROGRAM_NAME); } }
        public const string CN_PROGRAM_NAME = "Program_Name";
        public const string DT_PROGRAM_NAME = "nvarchar(50)";
        private string? @_Program_Name;

        public string? @Show_In_List { get { return _Show_In_List; } set { @_Show_In_List = value; SetDirty(CN_SHOW_IN_LIST); } }
        public const string CN_SHOW_IN_LIST = "Show_In_List";
        public const string DT_SHOW_IN_LIST = "char(1)";
        private string? @_Show_In_List;

        public @Programs() : base()
        {
            PKColumnNames.UnionWith(new List<string>(){
                CN_PROGRAM_ID
            });
        }
    }
    ///////////////////////// Programs END /////////////////////////

    ///////////////////////// Receiver_Info BEGIN /////////////////////////
    // ADDRESS nvarchar(100)
    // COUNTY_ID varchar(50)
    // CREATE_DATE varchar(30)
    // CREATE_USER nvarchar(50)
    // DEPARTMENT_ID varchar(10)
    // DISTRICT_ID varchar(50)
    // INFO_DEP varchar(10)
    // INFO_ID varchar(40)
    // INFO_NAME nvarchar(50)
    // LETTER_IO char(1)
    // MODIFY_DATE varchar(30)
    // MODIFY_USER nvarchar(50)
    public class @Receiver_Info : EntityBase
    {
        public const string TABLENAME = "Receiver_Info";
        public const string FULL_TABLENAME = "Models.DBEntity.@Receiver_Info";


        public string? @Address { get { return _Address; } set { @_Address = value; SetDirty(CN_ADDRESS); } }
        public const string CN_ADDRESS = "Address";
        public const string DT_ADDRESS = "nvarchar(100)";
        private string? @_Address;

        public string? @County_ID { get { return _County_ID; } set { @_County_ID = value; SetDirty(CN_COUNTY_ID); } }
        public const string CN_COUNTY_ID = "County_ID";
        public const string DT_COUNTY_ID = "varchar(50)";
        private string? @_County_ID;

        public string? @Create_Date { get { return _Create_Date; } set { @_Create_Date = value; SetDirty(CN_CREATE_DATE); } }
        public const string CN_CREATE_DATE = "Create_Date";
        public const string DT_CREATE_DATE = "varchar(30)";
        private string? @_Create_Date;

        public string? @Create_User { get { return _Create_User; } set { @_Create_User = value; SetDirty(CN_CREATE_USER); } }
        public const string CN_CREATE_USER = "Create_User";
        public const string DT_CREATE_USER = "nvarchar(50)";
        private string? @_Create_User;

        public string? @Department_ID { get { return _Department_ID; } set { @_Department_ID = value; SetDirty(CN_DEPARTMENT_ID); } }
        public const string CN_DEPARTMENT_ID = "Department_ID";
        public const string DT_DEPARTMENT_ID = "varchar(10)";
        private string? @_Department_ID;

        public string? @District_ID { get { return _District_ID; } set { @_District_ID = value; SetDirty(CN_DISTRICT_ID); } }
        public const string CN_DISTRICT_ID = "District_ID";
        public const string DT_DISTRICT_ID = "varchar(50)";
        private string? @_District_ID;

        public string? @Info_Dep { get { return _Info_Dep; } set { @_Info_Dep = value; SetDirty(CN_INFO_DEP); } }
        public const string CN_INFO_DEP = "Info_Dep";
        public const string DT_INFO_DEP = "varchar(10)";
        private string? @_Info_Dep;

        public string? @Info_ID { get { return _Info_ID; } set { @_Info_ID = value; SetDirty(CN_INFO_ID); } }
        public const string CN_INFO_ID = "Info_ID";
        public const string DT_INFO_ID = "varchar(40)";
        private string? @_Info_ID;

        public string? @Info_Name { get { return _Info_Name; } set { @_Info_Name = value; SetDirty(CN_INFO_NAME); } }
        public const string CN_INFO_NAME = "Info_Name";
        public const string DT_INFO_NAME = "nvarchar(50)";
        private string? @_Info_Name;

        public string? @Letter_IO { get { return _Letter_IO; } set { @_Letter_IO = value; SetDirty(CN_LETTER_IO); } }
        public const string CN_LETTER_IO = "Letter_IO";
        public const string DT_LETTER_IO = "char(1)";
        private string? @_Letter_IO;

        public string? @Modify_Date { get { return _Modify_Date; } set { @_Modify_Date = value; SetDirty(CN_MODIFY_DATE); } }
        public const string CN_MODIFY_DATE = "Modify_Date";
        public const string DT_MODIFY_DATE = "varchar(30)";
        private string? @_Modify_Date;

        public string? @Modify_User { get { return _Modify_User; } set { @_Modify_User = value; SetDirty(CN_MODIFY_USER); } }
        public const string CN_MODIFY_USER = "Modify_User";
        public const string DT_MODIFY_USER = "nvarchar(50)";
        private string? @_Modify_User;

        public @Receiver_Info() : base()
        {
            PKColumnNames.UnionWith(new List<string>(){
                CN_DEPARTMENT_ID
                ,CN_INFO_ID
            });
        }
    }
    ///////////////////////// Receiver_Info END /////////////////////////

    ///////////////////////// Roles BEGIN /////////////////////////
    // CREATE_DATE varchar(30)
    // CREATE_USER nvarchar(50)
    // EFFECTIVE char(1)
    // MODIFY_DATE varchar(30)
    // MODIFY_USER nvarchar(50)
    // ROLE_ID varchar(20)
    // ROLE_NAME nvarchar(50)
    public class @Roles : EntityBase
    {
        public const string TABLENAME = "Roles";
        public const string FULL_TABLENAME = "Models.DBEntity.@Roles";


        public string? @Create_Date { get { return _Create_Date; } set { @_Create_Date = value; SetDirty(CN_CREATE_DATE); } }
        public const string CN_CREATE_DATE = "Create_Date";
        public const string DT_CREATE_DATE = "varchar(30)";
        private string? @_Create_Date;

        public string? @Create_User { get { return _Create_User; } set { @_Create_User = value; SetDirty(CN_CREATE_USER); } }
        public const string CN_CREATE_USER = "Create_User";
        public const string DT_CREATE_USER = "nvarchar(50)";
        private string? @_Create_User;

        public string? @Effective { get { return _Effective; } set { @_Effective = value; SetDirty(CN_EFFECTIVE); } }
        public const string CN_EFFECTIVE = "Effective";
        public const string DT_EFFECTIVE = "char(1)";
        private string? @_Effective;

        public string? @Modify_Date { get { return _Modify_Date; } set { @_Modify_Date = value; SetDirty(CN_MODIFY_DATE); } }
        public const string CN_MODIFY_DATE = "Modify_Date";
        public const string DT_MODIFY_DATE = "varchar(30)";
        private string? @_Modify_Date;

        public string? @Modify_User { get { return _Modify_User; } set { @_Modify_User = value; SetDirty(CN_MODIFY_USER); } }
        public const string CN_MODIFY_USER = "Modify_User";
        public const string DT_MODIFY_USER = "nvarchar(50)";
        private string? @_Modify_User;

        public string? @Role_ID { get { return _Role_ID; } set { @_Role_ID = value; SetDirty(CN_ROLE_ID); } }
        public const string CN_ROLE_ID = "Role_ID";
        public const string DT_ROLE_ID = "varchar(20)";
        private string? @_Role_ID;

        public string? @Role_Name { get { return _Role_Name; } set { @_Role_Name = value; SetDirty(CN_ROLE_NAME); } }
        public const string CN_ROLE_NAME = "Role_Name";
        public const string DT_ROLE_NAME = "nvarchar(50)";
        private string? @_Role_Name;

        public @Roles() : base()
        {
            PKColumnNames.UnionWith(new List<string>(){
                CN_ROLE_ID
            });
        }
    }
    ///////////////////////// Roles END /////////////////////////

    ///////////////////////// Setting BEGIN /////////////////////////
    // CREATE_DATE varchar(30)
    // CREATE_USER nvarchar(50)
    // MEMO varchar(50)
    // MODIFY_DATE varchar(30)
    // MODIFY_USER nvarchar(50)
    // SETTING_DESCRIPTION nvarchar(200)
    // SETTING_ID varchar(50)
    // SETTING_VALUE nvarchar(50)
    public class @Setting : EntityBase
    {
        public const string TABLENAME = "Setting";
        public const string FULL_TABLENAME = "Models.DBEntity.@Setting";


        public string? @Create_Date { get { return _Create_Date; } set { @_Create_Date = value; SetDirty(CN_CREATE_DATE); } }
        public const string CN_CREATE_DATE = "Create_Date";
        public const string DT_CREATE_DATE = "varchar(30)";
        private string? @_Create_Date;

        public string? @Create_User { get { return _Create_User; } set { @_Create_User = value; SetDirty(CN_CREATE_USER); } }
        public const string CN_CREATE_USER = "Create_User";
        public const string DT_CREATE_USER = "nvarchar(50)";
        private string? @_Create_User;

        public string? @Memo { get { return _Memo; } set { @_Memo = value; SetDirty(CN_MEMO); } }
        public const string CN_MEMO = "Memo";
        public const string DT_MEMO = "varchar(50)";
        private string? @_Memo;

        public string? @Modify_Date { get { return _Modify_Date; } set { @_Modify_Date = value; SetDirty(CN_MODIFY_DATE); } }
        public const string CN_MODIFY_DATE = "Modify_Date";
        public const string DT_MODIFY_DATE = "varchar(30)";
        private string? @_Modify_Date;

        public string? @Modify_User { get { return _Modify_User; } set { @_Modify_User = value; SetDirty(CN_MODIFY_USER); } }
        public const string CN_MODIFY_USER = "Modify_User";
        public const string DT_MODIFY_USER = "nvarchar(50)";
        private string? @_Modify_User;

        public string? @Setting_Description { get { return _Setting_Description; } set { @_Setting_Description = value; SetDirty(CN_SETTING_DESCRIPTION); } }
        public const string CN_SETTING_DESCRIPTION = "Setting_Description";
        public const string DT_SETTING_DESCRIPTION = "nvarchar(200)";
        private string? @_Setting_Description;

        public string? @Setting_ID { get { return _Setting_ID; } set { @_Setting_ID = value; SetDirty(CN_SETTING_ID); } }
        public const string CN_SETTING_ID = "Setting_ID";
        public const string DT_SETTING_ID = "varchar(50)";
        private string? @_Setting_ID;

        public string? @Setting_Value { get { return _Setting_Value; } set { @_Setting_Value = value; SetDirty(CN_SETTING_VALUE); } }
        public const string CN_SETTING_VALUE = "Setting_Value";
        public const string DT_SETTING_VALUE = "nvarchar(50)";
        private string? @_Setting_Value;

        public @Setting() : base()
        {
            PKColumnNames.UnionWith(new List<string>(){
                CN_SETTING_ID
            });
        }
    }
    ///////////////////////// Setting END /////////////////////////

    ///////////////////////// User_To_Role BEGIN /////////////////////////
    // CREATE_DATE varchar(30)
    // CREATE_USER nvarchar(50)
    // MODIFY_DATE varchar(30)
    // MODIFY_USER nvarchar(50)
    // ROLE_ID varchar(20)
    // USER_ID varchar(50)
    public class @User_To_Role : EntityBase
    {
        public const string TABLENAME = "User_To_Role";
        public const string FULL_TABLENAME = "Models.DBEntity.@User_To_Role";


        public string? @Create_Date { get { return _Create_Date; } set { @_Create_Date = value; SetDirty(CN_CREATE_DATE); } }
        public const string CN_CREATE_DATE = "Create_Date";
        public const string DT_CREATE_DATE = "varchar(30)";
        private string? @_Create_Date;

        public string? @Create_User { get { return _Create_User; } set { @_Create_User = value; SetDirty(CN_CREATE_USER); } }
        public const string CN_CREATE_USER = "Create_User";
        public const string DT_CREATE_USER = "nvarchar(50)";
        private string? @_Create_User;

        public string? @Modify_Date { get { return _Modify_Date; } set { @_Modify_Date = value; SetDirty(CN_MODIFY_DATE); } }
        public const string CN_MODIFY_DATE = "Modify_Date";
        public const string DT_MODIFY_DATE = "varchar(30)";
        private string? @_Modify_Date;

        public string? @Modify_User { get { return _Modify_User; } set { @_Modify_User = value; SetDirty(CN_MODIFY_USER); } }
        public const string CN_MODIFY_USER = "Modify_User";
        public const string DT_MODIFY_USER = "nvarchar(50)";
        private string? @_Modify_User;

        public string? @Role_ID { get { return _Role_ID; } set { @_Role_ID = value; SetDirty(CN_ROLE_ID); } }
        public const string CN_ROLE_ID = "Role_ID";
        public const string DT_ROLE_ID = "varchar(20)";
        private string? @_Role_ID;

        public string? @User_ID { get { return _User_ID; } set { @_User_ID = value; SetDirty(CN_USER_ID); } }
        public const string CN_USER_ID = "User_ID";
        public const string DT_USER_ID = "varchar(50)";
        private string? @_User_ID;

        public @User_To_Role() : base()
        {
            PKColumnNames.UnionWith(new List<string>(){
                CN_ROLE_ID
                ,CN_USER_ID
            });
        }
    }
    ///////////////////////// User_To_Role END /////////////////////////

    ///////////////////////// Users BEGIN /////////////////////////
    // CREATE_DATE varchar(30)
    // CREATE_USER nvarchar(50)
    // DEPARTMENT_ID varchar(10)
    // MODIFY_DATE varchar(30)
    // MODIFY_USER nvarchar(50)
    // PRINTER nvarchar(100)
    // USER_ID varchar(50)
    // USER_NAME nvarchar(50)
    // USER_PASSWORD varchar(200)
    public class @Users : EntityBase
    {
        public const string TABLENAME = "Users";
        public const string FULL_TABLENAME = "Models.DBEntity.@Users";


        public string? @Create_Date { get { return _Create_Date; } set { @_Create_Date = value; SetDirty(CN_CREATE_DATE); } }
        public const string CN_CREATE_DATE = "Create_Date";
        public const string DT_CREATE_DATE = "varchar(30)";
        private string? @_Create_Date;

        public string? @Create_User { get { return _Create_User; } set { @_Create_User = value; SetDirty(CN_CREATE_USER); } }
        public const string CN_CREATE_USER = "Create_User";
        public const string DT_CREATE_USER = "nvarchar(50)";
        private string? @_Create_User;

        public string? @Department_ID { get { return _Department_ID; } set { @_Department_ID = value; SetDirty(CN_DEPARTMENT_ID); } }
        public const string CN_DEPARTMENT_ID = "Department_ID";
        public const string DT_DEPARTMENT_ID = "varchar(10)";
        private string? @_Department_ID;

        public string? @Modify_Date { get { return _Modify_Date; } set { @_Modify_Date = value; SetDirty(CN_MODIFY_DATE); } }
        public const string CN_MODIFY_DATE = "Modify_Date";
        public const string DT_MODIFY_DATE = "varchar(30)";
        private string? @_Modify_Date;

        public string? @Modify_User { get { return _Modify_User; } set { @_Modify_User = value; SetDirty(CN_MODIFY_USER); } }
        public const string CN_MODIFY_USER = "Modify_User";
        public const string DT_MODIFY_USER = "nvarchar(50)";
        private string? @_Modify_User;

        public string? @Printer { get { return _Printer; } set { @_Printer = value; SetDirty(CN_PRINTER); } }
        public const string CN_PRINTER = "Printer";
        public const string DT_PRINTER = "nvarchar(100)";
        private string? @_Printer;

        public string? @User_ID { get { return _User_ID; } set { @_User_ID = value; SetDirty(CN_USER_ID); } }
        public const string CN_USER_ID = "User_ID";
        public const string DT_USER_ID = "varchar(50)";
        private string? @_User_ID;

        public string? @User_Name { get { return _User_Name; } set { @_User_Name = value; SetDirty(CN_USER_NAME); } }
        public const string CN_USER_NAME = "User_Name";
        public const string DT_USER_NAME = "nvarchar(50)";
        private string? @_User_Name;

        public string? @User_Password { get { return _User_Password; } set { @_User_Password = value; SetDirty(CN_USER_PASSWORD); } }
        public const string CN_USER_PASSWORD = "User_Password";
        public const string DT_USER_PASSWORD = "varchar(200)";
        private string? @_User_Password;

        public @Users() : base()
        {
            PKColumnNames.UnionWith(new List<string>(){
                CN_USER_ID
            });
        }
    }
    ///////////////////////// Users END /////////////////////////

    ///////////////////////// Users_Token BEGIN /////////////////////////
    // EXPIRATIONDATE nvarchar(20)
    // TOKEN nvarchar(1000)
    // USER_ID nvarchar(20)
    public class @Users_Token : EntityBase
    {
        public const string TABLENAME = "Users_Token";
        public const string FULL_TABLENAME = "Models.DBEntity.@Users_Token";


        public string? @ExpirationDate { get { return _ExpirationDate; } set { @_ExpirationDate = value; SetDirty(CN_EXPIRATIONDATE); } }
        public const string CN_EXPIRATIONDATE = "ExpirationDate";
        public const string DT_EXPIRATIONDATE = "nvarchar(20)";
        private string? @_ExpirationDate;

        public string? @Token { get { return _Token; } set { @_Token = value; SetDirty(CN_TOKEN); } }
        public const string CN_TOKEN = "Token";
        public const string DT_TOKEN = "nvarchar(1000)";
        private string? @_Token;

        public string? @User_ID { get { return _User_ID; } set { @_User_ID = value; SetDirty(CN_USER_ID); } }
        public const string CN_USER_ID = "User_ID";
        public const string DT_USER_ID = "nvarchar(20)";
        private string? @_User_ID;

        public @Users_Token() : base()
        {
            PKColumnNames.UnionWith(new List<string>()
            {
            });
        }
    }
    ///////////////////////// Users_Token END /////////////////////////

}

