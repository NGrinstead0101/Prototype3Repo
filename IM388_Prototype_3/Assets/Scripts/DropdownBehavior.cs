using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DropdownBehavior : MonoBehaviour
{
    [SerializeField] TMP_Dropdown dropdownMenu;
    List<string> dropdownOptions = new List<string>();
    EvidenceTracker evidenceTracker;

    [SerializeField] int dropdownIndex;
    static bool gotInitialVals = false;

    /// <summary>
    /// When entering found verdict scene, updates the dropdowns with the 
    /// evidence that's been found.
    /// </summary>
    private void Awake()
    {
        evidenceTracker = GameObject.FindGameObjectWithTag("GameController").GetComponent<EvidenceTracker>();

        dropdownMenu.ClearOptions();

        for (int i = 0; i < FoundEvidence.foundList.Length; ++i)
        {
            if (FoundEvidence.foundList[i] == true)
            {
                dropdownOptions.Add(evidenceTracker.evidenceList[i].evidenceName);
            }
        }

        dropdownMenu.AddOptions(dropdownOptions);

        if (!gotInitialVals)
        {
            gotInitialVals = true;
            StoreNewValue();
        }

        RetrieveValue();
    }

    public void StoreNewValue()
    {
        FoundEvidence.dropDownInputs[dropdownIndex] = dropdownMenu.options[dropdownMenu.value].text;
    }

    public void RetrieveValue()
    {
        for (int i = 0; i < dropdownOptions.Count; ++i)
        {
            if (FoundEvidence.dropDownInputs[dropdownIndex].CompareTo(dropdownOptions[i]) == 0)
            {
                dropdownMenu.value = i;
                break;
            }
        }
    }
}
