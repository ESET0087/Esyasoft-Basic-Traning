namespace Assignment_2
{
    internal class Program
    {
        static MeterObject[] meterObjects;
        static void Main(string[] args)
        {
            InitializeMeterObjects();

            DLMS dlmsService = new DLMS(meterObjects);

            // Test GET operation
            byte[] testObis = ObisCode.VOLTAGE;
            dlmsService.get(testObis);

            // Test SET operation
            dlmsService.set(testObis, 220);
        }

        static void InitializeMeterObjects()
        {
            meterObjects = new MeterObject[]
            {
                new MeterObject(ObisCode.ACTIVE_ENERGY, "Active Energy", 123),
                new MeterObject(ObisCode.REACTIVE_ENERGY, "Reactive Energy", 456),
                new MeterObject(ObisCode.VOLTAGE, "Voltage", 230),
                new MeterObject(ObisCode.CURRENT, "Current", 5),
            };
        }
    }
}
