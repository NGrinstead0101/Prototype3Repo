using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Examination : MonoBehaviour
{
    //[SerializeField] EvidenceData evidenceData;
    [SerializeField] GameObject zoomedInSprite;
    [SerializeField] GameObject highlight;

    private void OnMouseEnter()
    {
        // highlight evidence
        highlight.SetActive(true);
    }

    private void OnMouseExit()
    {
        // unhighlight evidence
        highlight.SetActive(false);
    }

    private void OnMouseDown()
    {
        // pull up examine interface
    }
}
