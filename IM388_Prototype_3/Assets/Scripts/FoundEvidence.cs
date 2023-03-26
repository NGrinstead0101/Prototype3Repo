using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class FoundEvidence
{
    public static bool[] foundList = new bool[20];
    public static bool[] photosClicked = new bool[4];
    public static Vector2[] notePositions = new Vector2[20];
    public static Vector2[] photoPositions = new Vector2[] 
    { new Vector2(-6.5f, 0), new Vector2(-2.2f, 0), new Vector2(2.2f, 0), new Vector2(6.5f, 0) };
    public static string[] dropDownInputs = new string[11];

    public static bool dateCorrect = true;
    public static bool murdererCorrect = true;
    public static bool victimCorrect = true;
    public static bool weaponCorrect = true;
    public static bool motivesCorrect = true;
    public static bool cleanupCorrect = true;

    /// <summary>
    /// Called by VerdictChecker to reset what the player got right/wrong
    /// </summary>
    public static void ResetVerdictBools()
    {
        dateCorrect = true;
        murdererCorrect = true;
        victimCorrect = true;
        weaponCorrect = true;
        motivesCorrect = true;
        cleanupCorrect = true;
    }
}
