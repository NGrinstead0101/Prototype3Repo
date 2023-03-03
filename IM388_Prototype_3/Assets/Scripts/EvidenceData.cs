using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EvidenceData", menuName = "Evidence Data")]
public class EvidenceData : ScriptableObject
{
    bool hasBeenFound = false;

    public string evidenceName;
    public string evidenceDescription;

    public Sprite evidenceSprite;

    public bool HasBeenFound { get => hasBeenFound; set => hasBeenFound = value; }
}
