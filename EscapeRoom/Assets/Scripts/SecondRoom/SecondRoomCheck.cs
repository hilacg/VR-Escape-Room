using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondRoomCheck : MonoBehaviour
{
    private static bool key = false;
    private static bool batteries = false;

    public static void foundKey()
    {
        key = true;
    }

    public static bool IsKeyFound()
    {
        return key;
    }
    public static void foundBattery()
    {
        key = true;
    }

    public static bool IsBatteryFound()
    {
        return key;
    }
}
