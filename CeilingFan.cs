namespace CommandPatternRemoteControl
{
    //receiver no3 ceiling fan

    class CeilingFan
    {
        public int speed;
        public int prevSpeed;

        public CeilingFan()
        {
            speed = 0;
            prevSpeed = 0;
        }

        public int GetSpeed()
        {
            return speed;
        }

        public void SetSpeed(int newSpeed)
        {
            prevSpeed = speed;
            speed = newSpeed;
            Console.WriteLine($"Ceiling fan speed: {speed}");
        }

        public void Undo()
        {
            Console.WriteLine($"Setting Ceiling Fan Speed to the previous speed {prevSpeed}");
            speed = prevSpeed;
        }
    }

}