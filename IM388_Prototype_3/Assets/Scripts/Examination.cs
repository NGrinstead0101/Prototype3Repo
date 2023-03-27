using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Examination : MonoBehaviour
{
    [SerializeField] EvidenceData primaryEvidence;
    [SerializeField] List<EvidenceData> secondaryEvidence;
    [SerializeField] GameObject zoomedInSprite;
    [SerializeField] TextMeshProUGUI descriptionText;
    Image zoomGradient;
    //[SerializeField] Image zoomedInImage;

    bool canBeClicked = true;

    private void Awake()
    {
        zoomGradient = GameObject.FindGameObjectWithTag("Gradient").GetComponent<Image>();
    }

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
                zoomGradient.enabled = false;
            }
            else
            {
                // If this evidence is new, update the found list
                if (FoundEvidence.foundList[primaryEvidence.trackingIndex] == false)
                {
                    FoundEvidence.foundList[primaryEvidence.trackingIndex] = true;
                }

                foreach (EvidenceData evidence in secondaryEvidence)
                {
                    if (FoundEvidence.foundList[evidence.trackingIndex] == false)
                    {
                        FoundEvidence.foundList[evidence.trackingIndex] = true;
                    }
                }

                descriptionText.text = primaryEvidence.evidenceDescription;
                //zoomedInImage.sprite = evidenceData.evidenceSprite;
                zoomedInSprite.SetActive(true);
                zoomGradient.enabled = true;
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
