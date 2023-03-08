using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoTracker : MonoBehaviour
{
    [SerializeField] int photoIndex;

    private void Awake()
    {
        FoundEvidence.photosClicked[photoIndex] = true;
    }
}
