using System;

class RemoteControlCar
{   
    int metersDriven=0;
    int batteryCharge=100;
    public static  RemoteControlCar Buy()
    {
       RemoteControlCar car = new RemoteControlCar();
       return car;
    }
    public string DistanceDisplay()
    {
        return $"Driven {metersDriven} meters";
    }

    public string BatteryDisplay(){
    if(batteryCharge==0){
        return "Battery empty";
    }
    else{
        return $"Battery at {batteryCharge}%";
    }
    }
    
  
         
    

    public void Drive()
    {
        if(batteryCharge>0)
        {
            metersDriven+=20;
            batteryCharge-=1;
        }
        else if (batteryCharge==0)
        {
            Console.WriteLine("Battery empty. ");
        }
    }
    
}
