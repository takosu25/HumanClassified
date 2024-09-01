using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicLevel
{
    public int value;
    public const int MAX = 5;
    public const int MIN = 1;
    public static bool IsNone(MagicLevel magicLevel)
    {
        return magicLevel.value == 1;
    }
    public static bool IsWeak(MagicLevel magicLevel)
    {
        return magicLevel.value == 2;
    }
    public static bool IsMid(MagicLevel magicLevel)
    {
        return magicLevel.value == 3;
    }
    public static bool IsStrong(MagicLevel magicLevel)
    {
        return magicLevel.value == 4;
    }   
    public static bool IsSuper(MagicLevel magicLevel)
    {
        return magicLevel.value == 5;
    }
}
