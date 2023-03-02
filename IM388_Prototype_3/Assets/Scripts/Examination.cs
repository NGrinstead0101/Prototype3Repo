using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Examination : MonoBehaviour
{
    //[SerializeField] EvidenceData evidenceData;
    [SerializeField] GameObject zoomedInSprite;
    
    public void EvidenceClicked()
    {
        if (zoomedInSprite != null && zoomedInSprite.activeInHierarchy)
        {
            zoomedInSprite.SetActive(false);
        }
        else
        {
            zoomedInSprite.SetActive(true);
        }
    }

    private void OnMouseDown()
    {
        if (zoomedInSprite != null && zoomedInSprite.activeInHierarchy)
        {
            zoomedInSprite.SetActive(false);
        }
        else
        {
            zoomedInSprite.SetActive(true);
        }
    }
}
