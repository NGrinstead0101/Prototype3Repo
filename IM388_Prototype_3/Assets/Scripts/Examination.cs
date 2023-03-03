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
    [SerializeField] Image zoomedInImage;

    public void EvidenceClicked()
    {
        if (zoomedInSprite != null && zoomedInSprite.activeInHierarchy)
        {
            zoomedInSprite.SetActive(false);
        }
        else
        {
            descriptionText.text = evidenceData.evidenceDescription;
            zoomedInImage.sprite = evidenceData.evidenceSprite;
            zoomedInSprite.SetActive(true);
        }
    }
}
