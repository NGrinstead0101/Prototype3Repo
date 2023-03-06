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

    bool canBeClicked = true;

    private void Update()
    {
        if (zoomedInSprite != null && zoomedInSprite.activeInHierarchy && Input.GetMouseButtonDown(0))
        {
            EvidenceClicked();
            canBeClicked = false;
            StartCoroutine(PreventDoubleClick());
        }
    }

    public void EvidenceClicked()
    {
        if (canBeClicked)
        {
            if (zoomedInSprite != null && zoomedInSprite.activeInHierarchy)
            {
                zoomedInSprite.SetActive(false);
            }
            else
            {
                if (FoundEvidence.foundList[evidenceData.trackingIndex] == false)
                {
                    FoundEvidence.foundList[evidenceData.trackingIndex] = true;
                }

                descriptionText.text = evidenceData.evidenceDescription;
                //zoomedInImage.sprite = evidenceData.evidenceSprite;
                zoomedInSprite.SetActive(true);
            }
        }
    }

    IEnumerator PreventDoubleClick()
    {
        yield return new WaitForSeconds(0.1f);

        canBeClicked = true;

        StopAllCoroutines();
    }
}
