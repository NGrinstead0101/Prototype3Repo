using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EvidenceData", menuName = "Evidence Data")]
public class EvidenceData : ScriptableObject
{
    public int trackingIndex;

    public string evidenceName;
    public string evidenceDescription;

    public Sprite evidenceSprite;
}
