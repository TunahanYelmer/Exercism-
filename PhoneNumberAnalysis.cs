using System;

public static class PhoneNumber
{
    public static (bool IsNewYork ,bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {   

        bool IsNewYork;
        bool IsFake;  
        int localind=Convert.ToInt16(phoneNumber[0]+phoneNumber[1]+phoneNumber[2]);
        int fakeind=Convert.ToInt16(phoneNumber[4]+phoneNumber[5]+phoneNumber[6]);
        string LocalNumber=(phoneNumber[8]+phoneNumber[9]+phoneNumber[10]+phoneNumber[11]).ToString();
        if(localind==212){
           IsNewYork=true;        
        }
        else
            IsNewYork=false;
        if(fakeind==555){
           IsFake=true;
        }
        else
          IsFake=false;   

        return (IsNewYork,IsFake,LocalNumber);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return true;
    }
}
