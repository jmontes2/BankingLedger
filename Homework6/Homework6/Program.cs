// Homework #6 - modified TV program to use properties vs. methods

class Television
{
    private int channel;
    private int volume;
    private bool isOn;

    public bool IsOn
    {
        get
        {
            return isOn;
        }
        set
        {
            // Set value only if it differs from current state (treat this more like an on/off switch)
            if ((value == true && isOn == false) || (value == false && isOn == true))
            isOn = value;
        }
    }

    public int Volume
    {
        get
        {
            return volume;
        }
        set
        {
            if (value > 0 && value < 100)
            {
                volume = value;
            }
        }
    }

    public int Channel
    {
        get
        {
            return channel;
        }
        set
        {
            if (value > 0 && value < 50)
            {
                channel = value;
            }
        }
    }
}

class TestTV
{
    static void Main()
    {
        Television tv = new Television();

        // Moved the condition to the property set code, so all we need here is to set the property value
        //if (tv.IsOn == false)
        //{
        //    tv.IsOn = true;
        //}
        tv.IsOn = true;

        tv.Channel = 3;

        tv.Volume++;
        tv.Volume++;
        tv.Volume++;
        tv.Volume++;

        tv.IsOn = false;
    }
}