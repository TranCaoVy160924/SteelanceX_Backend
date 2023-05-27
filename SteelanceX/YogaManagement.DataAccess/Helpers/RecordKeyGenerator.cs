namespace YogaManagement.DataAccess.Helpers;
public static class RecordKeyGenerator
{
    public static string GenerateRecordKey<T>()
        => typeof(T).Name + DateTime.Now.ToString("yyyyMMdd_hh");
}
