using System;

class RemoteControlCar
{   public int BatteryLevel =100;
    private int _speed;
    private int _batteryDrain;
    public int distanceDriven=0;
    public RemoteControlCar(int speed, int batteryDrain)
    {   
        _speed = speed;
        _batteryDrain = batteryDrain;
    }
    public bool BatteryDrained()
    {   if (BatteryLevel <= 0)
        {   return true;
        }
        else
        {   return false;
        }
        
    }

    public int DistanceDriven()
    {
        return distanceDriven;
    }

    public void Drive()
    {   if (BatteryDrained() == false)
        {    
            BatteryLevel -= _batteryDrain;
            distanceDriven+=_speed;
        }
        else
        {   _speed = 0;
            _batteryDrain = 0;
        }
       
    }

    public static RemoteControlCar Nitro()
    {
        RemoteControlCar car = new RemoteControlCar(50, 4);
        return car;
    }
}

class RaceTrack
{   
    private int _length;
    public RaceTrack(int length)
    {
        _length = length;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        if (car.DistanceDriven() >= _length)
        {   return true;
        }
        else
        {   return false;
        }
    }
}
