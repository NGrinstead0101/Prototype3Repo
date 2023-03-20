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
    [SerializeField] TMP_Dropdown[] weaponDropdowns = new TMP_Dropdown[2];
    [SerializeField] TMP_Dropdown[] minorMotivesDropdowns = new TMP_Dropdown[3];
    [SerializeField] TMP_Dropdown majorMotiveDropdown;

    public void ConfirmVerdict()
    {
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

    private bool CheckVerdict()
    {
        bool isMatch = true;

        // Checks date
        if (dateDropdown.options[dateDropdown.value].text.CompareTo("February 9th") != 0)
        {
            isMatch = false;
        }

        // Checks murderer's name
        foreach (TMP_Dropdown dropdown in murdererDropdowns)
        {
            if (dropdown.options[dropdown.value].text.CompareTo("Roommate C (Blue)") != 0)
            {
                isMatch = false;
            }
        }

        // Checks victim's name
        foreach (TMP_Dropdown dropdown in victimDropdowns)
        {
            if (dropdown.options[dropdown.value].text.CompareTo("Roommate D (Yellow)") != 0)
            {
                isMatch = false;
            }
        }

        // Checks weapon
        foreach (TMP_Dropdown dropdown in weaponDropdowns)
        {
            if (dropdown.options[dropdown.value].text.CompareTo("Steering Wheel") != 0)
            {
                isMatch = false;
            }
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
                isMatch = false;
            }
        }

        // Checks major motive
        if (majorMotiveDropdown.options[majorMotiveDropdown.value].text.CompareTo("Yellow Won Bario Going") != 0)
        {
            isMatch = false;
        }

        return isMatch;
    }
}
