namespace Domain.Constants;

#region Image Type
public static class ImageType
{
    public const string PNG = "*.png";
    public const string JPG = "*.jpg";
    public const string JPEG = "*.jpeg";
    public const string Gif = "*.gif";
}
#endregion

#region Database Connection String
public static class ConnectionString
{
    public const string DefaultConnection = "DefaultConnection";
}
#endregion

#region Get Month
public static class Month
{
    public const string February = "February";
    public const string March = "March";
    public const string April = "April";
    public const string May = "May";
    public const string June = "June";
    public const string July = "July";
    public const string August = "August";
    public const string September = "September";
    public const string October = "October";
    public const string November = "November";
    public const string December = "December";
}

#endregion

//public static class HRMConstants
//{
//    public static string AllowedUserNameCharacters
//    {
//        get => "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-_.@+";
//   
//}

#region Database Constants
/// <summary>
/// Database Store Procedures
/// </summary>
public static class StoreProcedure
{
    public const string DashboardStats = "[SP_DashboardStatsCounter]";
    public const string DashboardDATA = "[SP_GLTransactionsDto]";
}
#endregion