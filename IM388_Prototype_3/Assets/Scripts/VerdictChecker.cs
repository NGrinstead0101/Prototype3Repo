using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class VerdictChecker : MonoBehaviour
{
    [SerializeField] TMP_Dropdown dateDropdown;
    [SerializeField] TMP_Dropdown[] murdererDropdowns = new TMP_Dropdown[2];
    [SerializeField] TMP_Dropdown[] victimDropdowns = new TMP_Dropdown[2];
    [SerializeField] TMP_Dropdown[] weaponDropdowns = new TMP_Dropdown[2];
    [SerializeField] TMP_Dropdown[] minorMotivesDropdowns = new TMP_Dropdown[3];
    [SerializeField] TMP_Dropdown majorMotiveDropdown; 

    private bool CheckVerdict()
    {
        bool isMatch = true;

        // Checks date
        if (dateDropdown.options[dateDropdown.value].text.CompareTo("") != 0)
        {
            isMatch = false;
        }

        // Checks murderer's name
        foreach (TMP_Dropdown dropdown in murdererDropdowns)
        {
            if (dropdown.options[dropdown.value].text.CompareTo("") != 0)
            {
                isMatch = false;
            }
        }

        // Checks victim's name
        foreach (TMP_Dropdown dropdown in victimDropdowns)
        {
            if (dropdown.options[dropdown.value].text.CompareTo("") != 0)
            {
                isMatch = false;
            }
        }

        // Checks weapon
        foreach (TMP_Dropdown dropdown in weaponDropdowns)
        {
            if (dropdown.options[dropdown.value].text.CompareTo("") != 0)
            {
                isMatch = false;
            }
        }

        // Checks minor motives
        foreach (TMP_Dropdown dropdown in minorMotivesDropdowns)
        {
            string dropdownSelection = dropdown.options[dropdown.value].text;

            if (dropdownSelection.CompareTo("") != 0 ||
                dropdownSelection.CompareTo("") != 0 || 
                dropdownSelection.CompareTo("") != 0)
            {
                isMatch = false;
            }
        }

        // Checks major motive
        if (majorMotiveDropdown.options[majorMotiveDropdown.value].text.CompareTo("") != 0)
        {
            isMatch = false;
        }

        return isMatch;
    }
}
