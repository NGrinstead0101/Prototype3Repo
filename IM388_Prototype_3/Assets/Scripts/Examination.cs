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

    /// <summary>
    /// Stops examining when clicking anywhere
    /// </summary>
    private void Update()
    {
        if (zoomedInSprite != null && zoomedInSprite.activeInHierarchy && Input.GetMouseButtonDown(0))
        {
            EvidenceClicked();
            canBeClicked = false;
            StartCoroutine(PreventDoubleClick());
        }
    }

    /// <summary>
    /// When clicked, toggles the zoomed in sprite and adds evidence when found
    /// </summary>
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
                // If this evidence is new, update the found list
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

    /// <summary>
    /// Ensures player can't re-inspect evidence when clicking it
    /// </summary>
    /// <returns>1/10 of a second</returns>
    IEnumerator PreventDoubleClick()
    {
        yield return new WaitForSeconds(0.1f);

        canBeClicked = true;

        StopAllCoroutines();
    }
}
