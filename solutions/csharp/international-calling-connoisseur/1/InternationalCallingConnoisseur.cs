public static class DialingCodes
{
    public static Dictionary<int, string> GetEmptyDictionary() => new Dictionary<int, string>();
    public static Dictionary<int, string> GetExistingDictionary() => new Dictionary<int, string>
    {
        {1,"United States of America"},
        {55,"Brazil"},
        {91,"India"}
    };

    public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName)
    {
        var empty = GetEmptyDictionary();
        empty.Add(countryCode, countryName);
        return empty;
    }

    public static Dictionary<int, string> AddCountryToExistingDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    { existingDictionary.Add(countryCode, countryName); return existingDictionary; }

    public static string GetCountryNameFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode) => (string)existingDictionary.GetValueOrDefault(countryCode, string.Empty);
    public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode) => existingDictionary.ContainsKey(countryCode);
    public static Dictionary<int, string> UpdateDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        if (DialingCodes.CheckCodeExists(existingDictionary, countryCode))
            existingDictionary[countryCode] = countryName;
        return existingDictionary;
    }
    public static Dictionary<int, string> RemoveCountryFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        if (DialingCodes.CheckCodeExists(existingDictionary, countryCode)) existingDictionary.Remove(countryCode);
        return existingDictionary;
    }

    public static string FindLongestCountryName(Dictionary<int, string> existingDictionary) => existingDictionary.Count() > 0 ? existingDictionary.OrderByDescending((item) => item.Value.Length).First().Value : string.Empty;
}