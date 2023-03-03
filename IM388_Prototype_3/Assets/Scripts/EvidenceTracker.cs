using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvidenceTracker : MonoBehaviour
{
    [SerializeField] static List<EvidenceData> evidenceList = new List<EvidenceData>();

    public void FindEvidence(EvidenceData newEvidence)
    {
        foreach (EvidenceData evidence in evidenceList)
        {
            if (evidence.evidenceName.CompareTo(newEvidence.evidenceName) == 0)
            {
                evidence.HasBeenFound = true;
                break;
            }
        }
    }
}
