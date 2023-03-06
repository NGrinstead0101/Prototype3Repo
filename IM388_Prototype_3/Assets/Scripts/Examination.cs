using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Examination : MonoBehaviour
{
    [SerializeField] EvidenceData evidenceData;
    [SerializeField] GameObject zoomedInSprite;
    [SerializeField] TextMeshProUGUI descriptionText;
    //[SerializeField] Image zoomedInImage;

    public void EvidenceClicked()
    {
        if (zoomedInSprite != null && zoomedInSprite.activeInHierarchy)
        {
            zoomedInSprite.SetActive(false);
        }
        else
        {
            if (FoundEvidence.foundList[evidenceData.trackingIndex] == false)
            {
                Debug.Log("The bool at index " + evidenceData.trackingIndex + " was " + FoundEvidence.foundList[evidenceData.trackingIndex]);
                FoundEvidence.foundList[evidenceData.trackingIndex] = true;
                Debug.Log("Now it is " + FoundEvidence.foundList[evidenceData.trackingIndex]);
            }

            descriptionText.text = evidenceData.evidenceDescription;
            //zoomedInImage.sprite = evidenceData.evidenceSprite;
            zoomedInSprite.SetActive(true);
        }
    }
}
