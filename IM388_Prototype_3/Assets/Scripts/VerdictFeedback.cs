using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class VerdictFeedback : MonoBehaviour
{
    private void Awake()
    {
        TextMeshProUGUI feedbackText = GetComponent<TextMeshProUGUI>();

        string correctData = "";
        string incorrectData = "";

        if (FoundEvidence.dateCorrect)
        {
            correctData += "Date, ";
        }
        else
        {
            incorrectData += "Date, ";
        }

        if (FoundEvidence.murdererCorrect)
        {
            correctData += "Murderer, ";
        }
        else
        {
            incorrectData += "Murderer, ";
        }

        if (FoundEvidence.victimCorrect)
        {
            correctData += "Victim, ";
        }
        else
        {
            incorrectData += "Victim, ";
        }

        if (FoundEvidence.weaponCorrect)
        {
            correctData += "Weapon, ";
        }
        else
        {
            incorrectData += "Weapon, ";
        }

        if (FoundEvidence.motivesCorrect)
        {
            correctData += "Motives, ";
        }
        else
        {
            incorrectData += "Motives, ";
        }

        if (FoundEvidence.cleanupCorrect)
        {
            correctData += "What got Cleaned-up, ";
        }
        else
        {
            incorrectData += "What got Cleaned-up, ";
        }

        feedbackText.text = "What you got correct: " + correctData + 
            "\n\nWhat you got wrong: " + incorrectData;
    }
}
