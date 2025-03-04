namespace Common.Model.DBEntity
{
    using Common.Model.DBEntity.Base;
    using DataBase.Model;
    ///////////////////////// Arguments BEGIN /////////////////////////
    // ARGUMENT_CLASS_ID varchar(20)
    // ARGUMENT_ID int
    // ARGUMENT_VALUE nvarchar(50)
    // CREATED_DATE datetime
    // CREATED_USER datetime
    // SORT_NO int
    // UPDATED_DATE datetime
    // UPDATED_USER datetime
    public class @Arguments : EntityBase
    {
        public const string TABLENAME = "Arguments";
        public const string FULL_TABLENAME = "Models.DBEntity.@Arguments";


        public string? @Argument_Class_ID { get { return _Argument_Class_ID; } set { @_Argument_Class_ID = value; SetDirty(@Arguments.CN_ARGUMENT_CLASS_ID); } }
        public const string CN_ARGUMENT_CLASS_ID = "Argument_Class_ID";
        public const string DT_ARGUMENT_CLASS_ID = "varchar(20)";
        private string? @_Argument_Class_ID;

        public int? @Argument_ID { get { return _Argument_ID; } set { @_Argument_ID = value; SetDirty(@Arguments.CN_ARGUMENT_ID); } }
        public const string CN_ARGUMENT_ID = "Argument_ID";
        public const string DT_ARGUMENT_ID = "int";
        private int? @_Argument_ID;

        public string? @Argument_Value { get { return _Argument_Value; } set { @_Argument_Value = value; SetDirty(@Arguments.CN_ARGUMENT_VALUE); } }
        public const string CN_ARGUMENT_VALUE = "Argument_Value";
        public const string DT_ARGUMENT_VALUE = "nvarchar(50)";
        private string? @_Argument_Value;

        public DateTime? @Created_Date { get { return _Created_Date; } set { @_Created_Date = value; SetDirty(@Arguments.CN_CREATED_DATE); } }
        public const string CN_CREATED_DATE = "Created_Date";
        public const string DT_CREATED_DATE = "datetime";
        private DateTime? @_Created_Date;

        public DateTime? @Created_User { get { return _Created_User; } set { @_Created_User = value; SetDirty(@Arguments.CN_CREATED_USER); } }
        public const string CN_CREATED_USER = "Created_User";
        public const string DT_CREATED_USER = "datetime";
        private DateTime? @_Created_User;

        public int? @Sort_No { get { return _Sort_No; } set { @_Sort_No = value; SetDirty(@Arguments.CN_SORT_NO); } }
        public const string CN_SORT_NO = "Sort_No";
        public const string DT_SORT_NO = "int";
        private int? @_Sort_No;

        public DateTime? @Updated_Date { get { return _Updated_Date; } set { @_Updated_Date = value; SetDirty(@Arguments.CN_UPDATED_DATE); } }
        public const string CN_UPDATED_DATE = "Updated_Date";
        public const string DT_UPDATED_DATE = "datetime";
        private DateTime? @_Updated_Date;

        public DateTime? @Updated_User { get { return _Updated_User; } set { @_Updated_User = value; SetDirty(@Arguments.CN_UPDATED_USER); } }
        public const string CN_UPDATED_USER = "Updated_User";
        public const string DT_UPDATED_USER = "datetime";
        private DateTime? @_Updated_User;

        public @Arguments() : base()
        {
            this.PKColumnNames.UnionWith(new List<string>(){
                CN_ARGUMENT_ID
            });
        }
    }
    ///////////////////////// Arguments END /////////////////////////

    ///////////////////////// Counties BEGIN /////////////////////////
    // COUNTY_ID varchar(20)
    // COUNTY_NAME nvarchar(10)
    // SORT_NO int
    public class @Counties : EntityBase
    {
        public const string TABLENAME = "Counties";
        public const string FULL_TABLENAME = "Models.DBEntity.@Counties";


        public string? @County_ID { get { return _County_ID; } set { @_County_ID = value; SetDirty(@Counties.CN_COUNTY_ID); } }
        public const string CN_COUNTY_ID = "County_ID";
        public const string DT_COUNTY_ID = "varchar(20)";
        private string? @_County_ID;

        public string? @County_Name { get { return _County_Name; } set { @_County_Name = value; SetDirty(@Counties.CN_COUNTY_NAME); } }
        public const string CN_COUNTY_NAME = "County_Name";
        public const string DT_COUNTY_NAME = "nvarchar(10)";
        private string? @_County_Name;

        public int? @Sort_No { get { return _Sort_No; } set { @_Sort_No = value; SetDirty(@Counties.CN_SORT_NO); } }
        public const string CN_SORT_NO = "Sort_No";
        public const string DT_SORT_NO = "int";
        private int? @_Sort_No;

        public @Counties() : base()
        {
            this.PKColumnNames.UnionWith(new List<string>(){
                CN_COUNTY_ID
            });
        }
    }
    ///////////////////////// Counties END /////////////////////////

    ///////////////////////// Districts BEGIN /////////////////////////
    // COUNTY_ID varchar(20)
    // DISTRICT_CODE int
    // DISTRICT_ID varchar(20)
    // DISTRICT_NAME nvarchar(10)
    public class @Districts : EntityBase
    {
        public const string TABLENAME = "Districts";
        public const string FULL_TABLENAME = "Models.DBEntity.@Districts";


        public string? @County_ID { get { return _County_ID; } set { @_County_ID = value; SetDirty(@Districts.CN_COUNTY_ID); } }
        public const string CN_COUNTY_ID = "County_ID";
        public const string DT_COUNTY_ID = "varchar(20)";
        private string? @_County_ID;

        public int? @District_Code { get { return _District_Code; } set { @_District_Code = value; SetDirty(@Districts.CN_DISTRICT_CODE); } }
        public const string CN_DISTRICT_CODE = "District_Code";
        public const string DT_DISTRICT_CODE = "int";
        private int? @_District_Code;

        public string? @District_ID { get { return _District_ID; } set { @_District_ID = value; SetDirty(@Districts.CN_DISTRICT_ID); } }
        public const string CN_DISTRICT_ID = "District_ID";
        public const string DT_DISTRICT_ID = "varchar(20)";
        private string? @_District_ID;

        public string? @District_Name { get { return _District_Name; } set { @_District_Name = value; SetDirty(@Districts.CN_DISTRICT_NAME); } }
        public const string CN_DISTRICT_NAME = "District_Name";
        public const string DT_DISTRICT_NAME = "nvarchar(10)";
        private string? @_District_Name;

        public @Districts() : base()
        {
            this.PKColumnNames.UnionWith(new List<string>(){
                CN_COUNTY_ID
                ,CN_DISTRICT_ID
            });
        }
    }
    ///////////////////////// Districts END /////////////////////////

    ///////////////////////// Orders_Info BEGIN /////////////////////////
    // ADDRESS nvarchar(255)
    // COUNTY_ID nvarchar(50)
    // CREATED_DATE datetime
    // CREATED_USER datetime
    // DISTRICT_ID nvarchar(50)
    // ORDER_ID int
    // ORDER_NO varchar(16)
    // ORDER_STS varchar(10)
    // REVEIVER_NAME nvarchar(50)
    // TOTAL_AMOUNT decimal(10.2)
    // UPDATED_DATE datetime
    // UPDATED_USER datetime
    // USER_ID int
    public class @Orders_Info : EntityBase
    {
        public const string TABLENAME = "Orders_Info";
        public const string FULL_TABLENAME = "Models.DBEntity.@Orders_Info";


        public string? @Address { get { return _Address; } set { @_Address = value; SetDirty(@Orders_Info.CN_ADDRESS); } }
        public const string CN_ADDRESS = "Address";
        public const string DT_ADDRESS = "nvarchar(255)";
        private string? @_Address;

        public string? @County_ID { get { return _County_ID; } set { @_County_ID = value; SetDirty(@Orders_Info.CN_COUNTY_ID); } }
        public const string CN_COUNTY_ID = "County_ID";
        public const string DT_COUNTY_ID = "nvarchar(50)";
        private string? @_County_ID;

        public DateTime? @Created_Date { get { return _Created_Date; } set { @_Created_Date = value; SetDirty(@Orders_Info.CN_CREATED_DATE); } }
        public const string CN_CREATED_DATE = "Created_Date";
        public const string DT_CREATED_DATE = "datetime";
        private DateTime? @_Created_Date;

        public DateTime? @Created_User { get { return _Created_User; } set { @_Created_User = value; SetDirty(@Orders_Info.CN_CREATED_USER); } }
        public const string CN_CREATED_USER = "Created_User";
        public const string DT_CREATED_USER = "datetime";
        private DateTime? @_Created_User;

        public string? @District_ID { get { return _District_ID; } set { @_District_ID = value; SetDirty(@Orders_Info.CN_DISTRICT_ID); } }
        public const string CN_DISTRICT_ID = "District_ID";
        public const string DT_DISTRICT_ID = "nvarchar(50)";
        private string? @_District_ID;

        public int? @Order_ID { get { return _Order_ID; } set { @_Order_ID = value; SetDirty(@Orders_Info.CN_ORDER_ID); } }
        public const string CN_ORDER_ID = "Order_ID";
        public const string DT_ORDER_ID = "int";
        private int? @_Order_ID;

        public string? @Order_No { get { return _Order_No; } set { @_Order_No = value; SetDirty(@Orders_Info.CN_ORDER_NO); } }
        public const string CN_ORDER_NO = "Order_No";
        public const string DT_ORDER_NO = "varchar(16)";
        private string? @_Order_No;

        public string? @Order_Sts { get { return _Order_Sts; } set { @_Order_Sts = value; SetDirty(@Orders_Info.CN_ORDER_STS); } }
        public const string CN_ORDER_STS = "Order_Sts";
        public const string DT_ORDER_STS = "varchar(10)";
        private string? @_Order_Sts;

        public string? @Reveiver_Name { get { return _Reveiver_Name; } set { @_Reveiver_Name = value; SetDirty(@Orders_Info.CN_REVEIVER_NAME); } }
        public const string CN_REVEIVER_NAME = "Reveiver_Name";
        public const string DT_REVEIVER_NAME = "nvarchar(50)";
        private string? @_Reveiver_Name;

        public decimal? @Total_Amount { get { return _Total_Amount; } set { @_Total_Amount = value; SetDirty(@Orders_Info.CN_TOTAL_AMOUNT); } }
        public const string CN_TOTAL_AMOUNT = "Total_Amount";
        public const string DT_TOTAL_AMOUNT = "decimal(10.2)";
        private decimal? @_Total_Amount;

        public DateTime? @Updated_Date { get { return _Updated_Date; } set { @_Updated_Date = value; SetDirty(@Orders_Info.CN_UPDATED_DATE); } }
        public const string CN_UPDATED_DATE = "Updated_Date";
        public const string DT_UPDATED_DATE = "datetime";
        private DateTime? @_Updated_Date;

        public DateTime? @Updated_User { get { return _Updated_User; } set { @_Updated_User = value; SetDirty(@Orders_Info.CN_UPDATED_USER); } }
        public const string CN_UPDATED_USER = "Updated_User";
        public const string DT_UPDATED_USER = "datetime";
        private DateTime? @_Updated_User;

        public int? @User_ID { get { return _User_ID; } set { @_User_ID = value; SetDirty(@Orders_Info.CN_USER_ID); } }
        public const string CN_USER_ID = "User_ID";
        public const string DT_USER_ID = "int";
        private int? @_User_ID;

        public @Orders_Info() : base()
        {
            this.PKColumnNames.UnionWith(new List<string>(){
                CN_ORDER_ID
            });
        }
    }
    ///////////////////////// Orders_Info END /////////////////////////

    ///////////////////////// Orders_Sequence BEGIN /////////////////////////
    // CREATED_DATE datetime
    // CREATED_USER datetime
    // ITEM_ID int
    // ORDER_ID int
    // ORDER_SEQ_ID int
    // QUANTITY int
    // UNIT_PRICE decimal(10.2)
    // UPDATED_DATE datetime
    // UPDATED_USER datetime
    public class @Orders_Sequence : EntityBase
    {
        public const string TABLENAME = "Orders_Sequence";
        public const string FULL_TABLENAME = "Models.DBEntity.@Orders_Sequence";


        public DateTime? @Created_Date { get { return _Created_Date; } set { @_Created_Date = value; SetDirty(@Orders_Sequence.CN_CREATED_DATE); } }
        public const string CN_CREATED_DATE = "Created_Date";
        public const string DT_CREATED_DATE = "datetime";
        private DateTime? @_Created_Date;

        public DateTime? @Created_User { get { return _Created_User; } set { @_Created_User = value; SetDirty(@Orders_Sequence.CN_CREATED_USER); } }
        public const string CN_CREATED_USER = "Created_User";
        public const string DT_CREATED_USER = "datetime";
        private DateTime? @_Created_User;

        public int? @Item_ID { get { return _Item_ID; } set { @_Item_ID = value; SetDirty(@Orders_Sequence.CN_ITEM_ID); } }
        public const string CN_ITEM_ID = "Item_ID";
        public const string DT_ITEM_ID = "int";
        private int? @_Item_ID;

        public int? @Order_ID { get { return _Order_ID; } set { @_Order_ID = value; SetDirty(@Orders_Sequence.CN_ORDER_ID); } }
        public const string CN_ORDER_ID = "Order_ID";
        public const string DT_ORDER_ID = "int";
        private int? @_Order_ID;

        public int? @Order_Seq_ID { get { return _Order_Seq_ID; } set { @_Order_Seq_ID = value; SetDirty(@Orders_Sequence.CN_ORDER_SEQ_ID); } }
        public const string CN_ORDER_SEQ_ID = "Order_Seq_ID";
        public const string DT_ORDER_SEQ_ID = "int";
        private int? @_Order_Seq_ID;

        public int? @Quantity { get { return _Quantity; } set { @_Quantity = value; SetDirty(@Orders_Sequence.CN_QUANTITY); } }
        public const string CN_QUANTITY = "Quantity";
        public const string DT_QUANTITY = "int";
        private int? @_Quantity;

        public decimal? @Unit_Price { get { return _Unit_Price; } set { @_Unit_Price = value; SetDirty(@Orders_Sequence.CN_UNIT_PRICE); } }
        public const string CN_UNIT_PRICE = "Unit_Price";
        public const string DT_UNIT_PRICE = "decimal(10.2)";
        private decimal? @_Unit_Price;

        public DateTime? @Updated_Date { get { return _Updated_Date; } set { @_Updated_Date = value; SetDirty(@Orders_Sequence.CN_UPDATED_DATE); } }
        public const string CN_UPDATED_DATE = "Updated_Date";
        public const string DT_UPDATED_DATE = "datetime";
        private DateTime? @_Updated_Date;

        public DateTime? @Updated_User { get { return _Updated_User; } set { @_Updated_User = value; SetDirty(@Orders_Sequence.CN_UPDATED_USER); } }
        public const string CN_UPDATED_USER = "Updated_User";
        public const string DT_UPDATED_USER = "datetime";
        private DateTime? @_Updated_User;

        public @Orders_Sequence() : base()
        {
            this.PKColumnNames.UnionWith(new List<string>(){
                CN_ORDER_SEQ_ID
            });
        }
    }
    ///////////////////////// Orders_Sequence END /////////////////////////

    ///////////////////////// Payments BEGIN /////////////////////////
    // CREATED_DATE datetime
    // CREATED_USER datetime
    // ORDER_ID int
    // PAID_AMOUNT decimal(10.2)
    // PAID_DATE datetime
    // PAYMENT_ID int
    // PAYMENT_METHOD varchar(10)
    // PAYMENT_STS varchar(10)
    // TRANSACTIONID nvarchar(100)
    // UPDATED_DATE datetime
    // UPDATED_USER datetime
    public class @Payments : EntityBase
    {
        public const string TABLENAME = "Payments";
        public const string FULL_TABLENAME = "Models.DBEntity.@Payments";


        public DateTime? @Created_Date { get { return _Created_Date; } set { @_Created_Date = value; SetDirty(@Payments.CN_CREATED_DATE); } }
        public const string CN_CREATED_DATE = "Created_Date";
        public const string DT_CREATED_DATE = "datetime";
        private DateTime? @_Created_Date;

        public DateTime? @Created_User { get { return _Created_User; } set { @_Created_User = value; SetDirty(@Payments.CN_CREATED_USER); } }
        public const string CN_CREATED_USER = "Created_User";
        public const string DT_CREATED_USER = "datetime";
        private DateTime? @_Created_User;

        public int? @Order_ID { get { return _Order_ID; } set { @_Order_ID = value; SetDirty(@Payments.CN_ORDER_ID); } }
        public const string CN_ORDER_ID = "Order_ID";
        public const string DT_ORDER_ID = "int";
        private int? @_Order_ID;

        public decimal? @Paid_Amount { get { return _Paid_Amount; } set { @_Paid_Amount = value; SetDirty(@Payments.CN_PAID_AMOUNT); } }
        public const string CN_PAID_AMOUNT = "Paid_Amount";
        public const string DT_PAID_AMOUNT = "decimal(10.2)";
        private decimal? @_Paid_Amount;

        public DateTime? @Paid_Date { get { return _Paid_Date; } set { @_Paid_Date = value; SetDirty(@Payments.CN_PAID_DATE); } }
        public const string CN_PAID_DATE = "Paid_Date";
        public const string DT_PAID_DATE = "datetime";
        private DateTime? @_Paid_Date;

        public int? @Payment_ID { get { return _Payment_ID; } set { @_Payment_ID = value; SetDirty(@Payments.CN_PAYMENT_ID); } }
        public const string CN_PAYMENT_ID = "Payment_ID";
        public const string DT_PAYMENT_ID = "int";
        private int? @_Payment_ID;

        public string? @Payment_Method { get { return _Payment_Method; } set { @_Payment_Method = value; SetDirty(@Payments.CN_PAYMENT_METHOD); } }
        public const string CN_PAYMENT_METHOD = "Payment_Method";
        public const string DT_PAYMENT_METHOD = "varchar(10)";
        private string? @_Payment_Method;

        public string? @Payment_Sts { get { return _Payment_Sts; } set { @_Payment_Sts = value; SetDirty(@Payments.CN_PAYMENT_STS); } }
        public const string CN_PAYMENT_STS = "Payment_Sts";
        public const string DT_PAYMENT_STS = "varchar(10)";
        private string? @_Payment_Sts;

        public string? @TransactionID { get { return _TransactionID; } set { @_TransactionID = value; SetDirty(@Payments.CN_TRANSACTIONID); } }
        public const string CN_TRANSACTIONID = "TransactionID";
        public const string DT_TRANSACTIONID = "nvarchar(100)";
        private string? @_TransactionID;

        public DateTime? @Updated_Date { get { return _Updated_Date; } set { @_Updated_Date = value; SetDirty(@Payments.CN_UPDATED_DATE); } }
        public const string CN_UPDATED_DATE = "Updated_Date";
        public const string DT_UPDATED_DATE = "datetime";
        private DateTime? @_Updated_Date;

        public DateTime? @Updated_User { get { return _Updated_User; } set { @_Updated_User = value; SetDirty(@Payments.CN_UPDATED_USER); } }
        public const string CN_UPDATED_USER = "Updated_User";
        public const string DT_UPDATED_USER = "datetime";
        private DateTime? @_Updated_User;

        public @Payments() : base()
        {
            this.PKColumnNames.UnionWith(new List<string>(){
                CN_PAYMENT_ID
            });
        }
    }
    ///////////////////////// Payments END /////////////////////////

    ///////////////////////// Products BEGIN /////////////////////////
    // CREATED_DATE datetime
    // CREATED_USER datetime
    // ITEM_DESC nvarchar(500)
    // ITEM_ID int
    // ITEM_NAME nvarchar(30)
    // ITEM_STS varchar(10)
    // ITEM_SUBNAME nvarchar(10)
    // ITEM_SUBTITLE nvarchar(30)
    // SORT_NO int
    // STOCK_QTY int
    // UNIT nvarchar(5)
    // UNIT_PRICE decimal(10.2)
    // UPDATED_DATE datetime
    // UPDATED_USER datetime
    public class @Products : EntityBase
    {
        public const string TABLENAME = "Products";
        public const string FULL_TABLENAME = "Models.DBEntity.@Products";


        public DateTime? @Created_Date { get { return _Created_Date; } set { @_Created_Date = value; SetDirty(@Products.CN_CREATED_DATE); } }
        public const string CN_CREATED_DATE = "Created_Date";
        public const string DT_CREATED_DATE = "datetime";
        private DateTime? @_Created_Date;

        public DateTime? @Created_User { get { return _Created_User; } set { @_Created_User = value; SetDirty(@Products.CN_CREATED_USER); } }
        public const string CN_CREATED_USER = "Created_User";
        public const string DT_CREATED_USER = "datetime";
        private DateTime? @_Created_User;

        public string? @Item_Desc { get { return _Item_Desc; } set { @_Item_Desc = value; SetDirty(@Products.CN_ITEM_DESC); } }
        public const string CN_ITEM_DESC = "Item_Desc";
        public const string DT_ITEM_DESC = "nvarchar(500)";
        private string? @_Item_Desc;

        public int? @Item_ID { get { return _Item_ID; } set { @_Item_ID = value; SetDirty(@Products.CN_ITEM_ID); } }
        public const string CN_ITEM_ID = "Item_ID";
        public const string DT_ITEM_ID = "int";
        private int? @_Item_ID;

        public string? @Item_Name { get { return _Item_Name; } set { @_Item_Name = value; SetDirty(@Products.CN_ITEM_NAME); } }
        public const string CN_ITEM_NAME = "Item_Name";
        public const string DT_ITEM_NAME = "nvarchar(30)";
        private string? @_Item_Name;

        public string? @Item_Sts { get { return _Item_Sts; } set { @_Item_Sts = value; SetDirty(@Products.CN_ITEM_STS); } }
        public const string CN_ITEM_STS = "Item_Sts";
        public const string DT_ITEM_STS = "varchar(10)";
        private string? @_Item_Sts;

        public string? @Item_SubName { get { return _Item_SubName; } set { @_Item_SubName = value; SetDirty(@Products.CN_ITEM_SUBNAME); } }
        public const string CN_ITEM_SUBNAME = "Item_SubName";
        public const string DT_ITEM_SUBNAME = "nvarchar(10)";
        private string? @_Item_SubName;

        public string? @Item_SubTitle { get { return _Item_SubTitle; } set { @_Item_SubTitle = value; SetDirty(@Products.CN_ITEM_SUBTITLE); } }
        public const string CN_ITEM_SUBTITLE = "Item_SubTitle";
        public const string DT_ITEM_SUBTITLE = "nvarchar(30)";
        private string? @_Item_SubTitle;

        public int? @Sort_No { get { return _Sort_No; } set { @_Sort_No = value; SetDirty(@Products.CN_SORT_NO); } }
        public const string CN_SORT_NO = "Sort_No";
        public const string DT_SORT_NO = "int";
        private int? @_Sort_No;

        public int? @Stock_Qty { get { return _Stock_Qty; } set { @_Stock_Qty = value; SetDirty(@Products.CN_STOCK_QTY); } }
        public const string CN_STOCK_QTY = "Stock_Qty";
        public const string DT_STOCK_QTY = "int";
        private int? @_Stock_Qty;

        public string? @Unit { get { return _Unit; } set { @_Unit = value; SetDirty(@Products.CN_UNIT); } }
        public const string CN_UNIT = "Unit";
        public const string DT_UNIT = "nvarchar(5)";
        private string? @_Unit;

        public decimal? @Unit_Price { get { return _Unit_Price; } set { @_Unit_Price = value; SetDirty(@Products.CN_UNIT_PRICE); } }
        public const string CN_UNIT_PRICE = "Unit_Price";
        public const string DT_UNIT_PRICE = "decimal(10.2)";
        private decimal? @_Unit_Price;

        public DateTime? @Updated_Date { get { return _Updated_Date; } set { @_Updated_Date = value; SetDirty(@Products.CN_UPDATED_DATE); } }
        public const string CN_UPDATED_DATE = "Updated_Date";
        public const string DT_UPDATED_DATE = "datetime";
        private DateTime? @_Updated_Date;

        public DateTime? @Updated_User { get { return _Updated_User; } set { @_Updated_User = value; SetDirty(@Products.CN_UPDATED_USER); } }
        public const string CN_UPDATED_USER = "Updated_User";
        public const string DT_UPDATED_USER = "datetime";
        private DateTime? @_Updated_User;

        public @Products() : base()
        {
            this.PKColumnNames.UnionWith(new List<string>(){
                CN_ITEM_ID
            });
        }
    }
    ///////////////////////// Products END /////////////////////////

    ///////////////////////// Products_Images BEGIN /////////////////////////
    // CREATED_DATE datetime
    // CREATED_USER datetime
    // IMAGE_ID int
    // IMAGE_SRC varchar(-1)
    // IMAGE_TYPE varchar(10)
    // ITEM_ID int
    // UPDATED_DATE datetime
    // UPDATED_USER datetime
    public class @Products_Images : EntityBase
    {
        public const string TABLENAME = "Products_Images";
        public const string FULL_TABLENAME = "Models.DBEntity.@Products_Images";


        public DateTime? @Created_Date { get { return _Created_Date; } set { @_Created_Date = value; SetDirty(@Products_Images.CN_CREATED_DATE); } }
        public const string CN_CREATED_DATE = "Created_Date";
        public const string DT_CREATED_DATE = "datetime";
        private DateTime? @_Created_Date;

        public DateTime? @Created_User { get { return _Created_User; } set { @_Created_User = value; SetDirty(@Products_Images.CN_CREATED_USER); } }
        public const string CN_CREATED_USER = "Created_User";
        public const string DT_CREATED_USER = "datetime";
        private DateTime? @_Created_User;

        public int? @Image_ID { get { return _Image_ID; } set { @_Image_ID = value; SetDirty(@Products_Images.CN_IMAGE_ID); } }
        public const string CN_IMAGE_ID = "Image_ID";
        public const string DT_IMAGE_ID = "int";
        private int? @_Image_ID;

        public string? @Image_Src { get { return _Image_Src; } set { @_Image_Src = value; SetDirty(@Products_Images.CN_IMAGE_SRC); } }
        public const string CN_IMAGE_SRC = "Image_Src";
        public const string DT_IMAGE_SRC = "varchar(-1)";
        private string? @_Image_Src;

        public string? @Image_Type { get { return _Image_Type; } set { @_Image_Type = value; SetDirty(@Products_Images.CN_IMAGE_TYPE); } }
        public const string CN_IMAGE_TYPE = "Image_Type";
        public const string DT_IMAGE_TYPE = "varchar(10)";
        private string? @_Image_Type;

        public int? @Item_ID { get { return _Item_ID; } set { @_Item_ID = value; SetDirty(@Products_Images.CN_ITEM_ID); } }
        public const string CN_ITEM_ID = "Item_ID";
        public const string DT_ITEM_ID = "int";
        private int? @_Item_ID;

        public DateTime? @Updated_Date { get { return _Updated_Date; } set { @_Updated_Date = value; SetDirty(@Products_Images.CN_UPDATED_DATE); } }
        public const string CN_UPDATED_DATE = "Updated_Date";
        public const string DT_UPDATED_DATE = "datetime";
        private DateTime? @_Updated_Date;

        public DateTime? @Updated_User { get { return _Updated_User; } set { @_Updated_User = value; SetDirty(@Products_Images.CN_UPDATED_USER); } }
        public const string CN_UPDATED_USER = "Updated_User";
        public const string DT_UPDATED_USER = "datetime";
        private DateTime? @_Updated_User;

        public @Products_Images() : base()
        {
            this.PKColumnNames.UnionWith(new List<string>(){
                CN_IMAGE_ID
            });
        }
    }
    ///////////////////////// Products_Images END /////////////////////////

    ///////////////////////// Users BEGIN /////////////////////////
    // ADDRESS nvarchar(255)
    // COUNTY_ID varchar(20)
    // CREATED_DATE datetime
    // CREATED_USER datetime
    // DISTRICT_ID varchar(20)
    // EMAIL nvarchar(255)
    // PASSWORDHASH nvarchar(255)
    // PHONENUMBER nvarchar(20)
    // ROLE nvarchar(20)
    // UPDATED_DATE datetime
    // UPDATED_USER datetime
    // USER_ID int
    // USER_NAME nvarchar(50)
    public class @Users : EntityBase
    {
        public const string TABLENAME = "Users";
        public const string FULL_TABLENAME = "Models.DBEntity.@Users";


        public string? @Address { get { return _Address; } set { @_Address = value; SetDirty(@Users.CN_ADDRESS); } }
        public const string CN_ADDRESS = "Address";
        public const string DT_ADDRESS = "nvarchar(255)";
        private string? @_Address;

        public string? @County_ID { get { return _County_ID; } set { @_County_ID = value; SetDirty(@Users.CN_COUNTY_ID); } }
        public const string CN_COUNTY_ID = "County_ID";
        public const string DT_COUNTY_ID = "varchar(20)";
        private string? @_County_ID;

        public DateTime? @Created_Date { get { return _Created_Date; } set { @_Created_Date = value; SetDirty(@Users.CN_CREATED_DATE); } }
        public const string CN_CREATED_DATE = "Created_Date";
        public const string DT_CREATED_DATE = "datetime";
        private DateTime? @_Created_Date;

        public DateTime? @Created_User { get { return _Created_User; } set { @_Created_User = value; SetDirty(@Users.CN_CREATED_USER); } }
        public const string CN_CREATED_USER = "Created_User";
        public const string DT_CREATED_USER = "datetime";
        private DateTime? @_Created_User;

        public string? @District_ID { get { return _District_ID; } set { @_District_ID = value; SetDirty(@Users.CN_DISTRICT_ID); } }
        public const string CN_DISTRICT_ID = "District_ID";
        public const string DT_DISTRICT_ID = "varchar(20)";
        private string? @_District_ID;

        public string? @Email { get { return _Email; } set { @_Email = value; SetDirty(@Users.CN_EMAIL); } }
        public const string CN_EMAIL = "Email";
        public const string DT_EMAIL = "nvarchar(255)";
        private string? @_Email;

        public string? @PasswordHash { get { return _PasswordHash; } set { @_PasswordHash = value; SetDirty(@Users.CN_PASSWORDHASH); } }
        public const string CN_PASSWORDHASH = "PasswordHash";
        public const string DT_PASSWORDHASH = "nvarchar(255)";
        private string? @_PasswordHash;

        public string? @PhoneNumber { get { return _PhoneNumber; } set { @_PhoneNumber = value; SetDirty(@Users.CN_PHONENUMBER); } }
        public const string CN_PHONENUMBER = "PhoneNumber";
        public const string DT_PHONENUMBER = "nvarchar(20)";
        private string? @_PhoneNumber;

        public string? @Role { get { return _Role; } set { @_Role = value; SetDirty(@Users.CN_ROLE); } }
        public const string CN_ROLE = "Role";
        public const string DT_ROLE = "nvarchar(20)";
        private string? @_Role;

        public DateTime? @Updated_Date { get { return _Updated_Date; } set { @_Updated_Date = value; SetDirty(@Users.CN_UPDATED_DATE); } }
        public const string CN_UPDATED_DATE = "Updated_Date";
        public const string DT_UPDATED_DATE = "datetime";
        private DateTime? @_Updated_Date;

        public DateTime? @Updated_User { get { return _Updated_User; } set { @_Updated_User = value; SetDirty(@Users.CN_UPDATED_USER); } }
        public const string CN_UPDATED_USER = "Updated_User";
        public const string DT_UPDATED_USER = "datetime";
        private DateTime? @_Updated_User;

        public int? @User_ID { get { return _User_ID; } set { @_User_ID = value; SetDirty(@Users.CN_USER_ID); } }
        public const string CN_USER_ID = "User_ID";
        public const string DT_USER_ID = "int";
        private int? @_User_ID;

        public string? @User_Name { get { return _User_Name; } set { @_User_Name = value; SetDirty(@Users.CN_USER_NAME); } }
        public const string CN_USER_NAME = "User_Name";
        public const string DT_USER_NAME = "nvarchar(50)";
        private string? @_User_Name;

        public @Users() : base()
        {
            this.PKColumnNames.UnionWith(new List<string>(){
                CN_USER_ID
            });
        }
    }
    ///////////////////////// Users END /////////////////////////

}

