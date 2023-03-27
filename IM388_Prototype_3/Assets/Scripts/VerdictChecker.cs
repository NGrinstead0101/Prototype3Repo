using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class VerdictChecker : MonoBehaviour
{
    [SerializeField] TMP_Dropdown dateDropdown;
    [SerializeField] TMP_Dropdown[] murdererDropdowns = new TMP_Dropdown[2];
    [SerializeField] TMP_Dropdown[] victimDropdowns = new TMP_Dropdown[2];
    [SerializeField] TMP_Dropdown weaponDropdown;
    [SerializeField] TMP_Dropdown[] minorMotivesDropdowns = new TMP_Dropdown[3];
    [SerializeField] TMP_Dropdown majorMotiveDropdown;
    [SerializeField] TMP_Dropdown cleanupDropdown;

    /// <summary>
    /// Calls CheckVerdict and loads a win or loss scene based on the result
    /// </summary>
    public void ConfirmVerdict()
    {
        FoundEvidence.ResetVerdictBools();

        bool isCorrect = CheckVerdict();

        if (isCorrect)
        {
            SceneManager.LoadScene("WinScene");
        }
        else
        {
            SceneManager.LoadScene("LoseScene");
        }
    }

    /// <summary>
    /// Checks each type of information to see if it's correct
    /// </summary>
    /// <returns>bool representing if the verdict was right</returns>
    private bool CheckVerdict()
    {
        bool isMatch = true;

        // Checks date
        if (dateDropdown.options[dateDropdown.value].text.CompareTo("February 9th") != 0)
        {
            Debug.Log("Date check failed");
            isMatch = false;
            FoundEvidence.dateCorrect = false;
        }

        // Checks murderer's name
        foreach (TMP_Dropdown dropdown in murdererDropdowns)
        {
            if (dropdown.options[dropdown.value].text.CompareTo("Roommate D (Yellow)") != 0)
            {
                Debug.Log("Murderer check failed");
                isMatch = false;
                FoundEvidence.murdererCorrect = false;
            }
        }

        // Checks victim's name
        foreach (TMP_Dropdown dropdown in victimDropdowns)
        {
            if (dropdown.options[dropdown.value].text.CompareTo("Roommate B (Green)") != 0)
            {
                Debug.Log("Victim check failed");
                isMatch = false;
                FoundEvidence.victimCorrect = false;
            }
        }

        // Checks weapon
        if (weaponDropdown.options[weaponDropdown.value].text.CompareTo("Steering Wheel") != 0)
        {
            Debug.Log("Weapon check failed");
            isMatch = false;
            FoundEvidence.weaponCorrect = false;
        }

        // Checks what killer cleaned up
        if (cleanupDropdown.options[cleanupDropdown.value].text.CompareTo("Steering Wheel") != 0 &&
            cleanupDropdown.options[cleanupDropdown.value].text.CompareTo("Victim's Body") != 0)
        {
            Debug.Log("Clean up check failed");
            isMatch = false;
            FoundEvidence.cleanupCorrect = false;
        }
        

        bool gotOption1 = false;
        bool gotOption2 = false;
        bool gotOption3 = false;

        // Checks minor motives
        foreach (TMP_Dropdown dropdown in minorMotivesDropdowns)
        {
            string dropdownSelection = dropdown.options[dropdown.value].text;

            if (!gotOption1 && dropdownSelection.CompareTo("Pay Rent") == 0)
            {
                gotOption1 = true;
            }
            else if (!gotOption2 && dropdownSelection.CompareTo("Pay Groceries") == 0)
            {
                gotOption2 = true;
            }
            else if (!gotOption3 && dropdownSelection.CompareTo("Clean Up") == 0)
            {
                gotOption3 = true;
            }
            else
            {
                Debug.Log("Minor motives check failed");
                isMatch = false;
                FoundEvidence.motivesCorrect = false;
            }
        }

        // Checks major motive
        if (majorMotiveDropdown.options[majorMotiveDropdown.value].text.CompareTo("Green Won Bario Going") != 0)
        {
            Debug.Log("Major motive check failed");
            isMatch = false;
            FoundEvidence.motivesCorrect = false;
        }

        return isMatch;
    }
}
