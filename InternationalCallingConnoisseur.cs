using System;
using System.Collections.Generic;
public static class DialingCodes
{
    public static Dictionary<int, string> GetEmptyDictionary()
    {
    Dictionary<int, string> countriesEmpty = new Dictionary<int, string>();
        return countriesEmpty;
    }
    public static Dictionary<int, string> GetExistingDictionary()
    {
        Dictionary<int, string> countries = new Dictionary<int, string>();
        countries.Add(1, "United States of America");
        countries.Add(55, "Brazil");
        countries.Add(91, "India");
        return countries;
    }
    public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName)
    {
    Dictionary<int, string> dictionary= new Dictionary<int,string>();    
    dictionary.Add(countryCode, countryName);
    return dictionary;
    }
    public static Dictionary<int, string> AddCountryToExistingDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        existingDictionary.Add(countryCode, countryName);
        return existingDictionary;
    }
    public static string GetCountryNameFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
       if (!CheckCodeExists(existingDictionary, countryCode))
        {
            return "";
        }
        else
            return existingDictionary[countryCode];
    }
    public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode)
    {
        return existingDictionary.ContainsKey(countryCode);
    }
    
    public static Dictionary<int, string> UpdateDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {   if (CheckCodeExists(existingDictionary, countryCode))
        {
            existingDictionary[countryCode] = countryName;
        }
       
        return existingDictionary;
    }
    public static Dictionary<int, string> RemoveCountryFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        existingDictionary.Remove(countryCode);
        return existingDictionary;
    }
    
    public static string FindLongestCountryName(Dictionary<int, string> existingDictionary)
    {
        string longestCountryName = "";
        foreach (var country in existingDictionary)
        {
            if (country.Value.Length > longestCountryName.Length)
            {
                longestCountryName = country.Value;
            }
        }
        return longestCountryName;
    }
}