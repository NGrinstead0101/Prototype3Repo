using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DropdownBehavior : MonoBehaviour
{
    [SerializeField] TMP_Dropdown dropdownMenu;
    List<string> dropdownOptions = new List<string>();
    [SerializeField] EvidenceTracker evidenceTracker;

    /// <summary>
    /// When entering found verdict scene, updates the dropdowns with the 
    /// evidence that's been found.
    /// </summary>
    private void Awake()
    {
        dropdownMenu.ClearOptions();

        for (int i = 0; i < FoundEvidence.foundList.Length; ++i)
        {
            if (FoundEvidence.foundList[i] == true)
            {
                dropdownOptions.Add(evidenceTracker.evidenceList[i].evidenceName);
            }
        }

        dropdownMenu.AddOptions(dropdownOptions);
    }
}
