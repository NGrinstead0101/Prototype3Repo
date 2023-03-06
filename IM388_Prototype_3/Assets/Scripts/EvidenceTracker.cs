using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvidenceTracker : MonoBehaviour
{
    [SerializeField] List<EvidenceData> evidenceList = new List<EvidenceData>();

    public void GetActiveEvidence()
    {
        for (int i = 0; i < evidenceList.Count; ++i)
        {
            if (FoundEvidence.foundList[i] == true)
            {
                // do something with evidenceList[i]
            }
        }
    }
}
