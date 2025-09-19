using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class DLMS
    {
        private MeterObject[] meterObjects;
        private int meterObjectCount;

        public DLMS (MeterObject[] objects)
        {
            meterObjects = objects;
            meterObjectCount = objects.Length;
        }

        public void get(byte[] obis)
        {
            for (int i = 0; i < meterObjectCount; i++)
            {
                if (ObisCode.ObisMatch(obis, meterObjects[i].obis))
                {
                    Console.WriteLine($"[GET] {meterObjects[i].name} = {meterObjects[i].value}");
                    return;
                }
            }
            Console.WriteLine("[GET] OBIS not found.");
        }

        public void set(byte[] obis, Int32 newValue)
        {
            for (int i = 0; i < meterObjectCount; i++)
            {
                if (ObisCode.ObisMatch(obis, meterObjects[i].obis))
                {
                    meterObjects[i].value = newValue;
                    Console.WriteLine($"[SET] {meterObjects[i].name} updated to {newValue}");
                    return;
                }
            }
            Console.WriteLine("[SET] OBIS not found.");
        }

        public void action(ObisCode obis, string method)
        {
            if (method == "RESET")
            {
                Console.WriteLine("[ACTION] Resetting meter values...");
                for (int i = 0; i < meterObjectCount; i++)
                {
                    meterObjects[i].value = 0;
                }
                Console.WriteLine("[ACTION] Reset complete.");
            }
            else if (method == "SYNC_TIME")
            {
                Console.WriteLine("[ACTION] Synchronizing meter clock to system time...");
            }
            else
            {
                Console.WriteLine("[ACTION] Unknown method.");
            }
        }
    }
}
