﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondRoomCheck : MonoBehaviour
{
    private static bool key = false;

    public static void foundKey()
    {
        key = true;
    }

    public static bool isFoundTheKey()
    {
        return key;
    }
}
