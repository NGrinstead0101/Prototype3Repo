using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvidenceTracker : MonoBehaviour
{
    public List<EvidenceData> evidenceList = new List<EvidenceData>();

    private void Awake()
    {
        for (int i = 0; i < evidenceList.Count; ++i)
        {
            evidenceList[i].trackingIndex = i;
        }
    }
}
