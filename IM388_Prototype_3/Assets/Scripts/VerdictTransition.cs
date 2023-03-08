using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VerdictTransition : MonoBehaviour
{
    [SerializeField] GameObject verdictTransButton;

    private void Awake()
    {
        bool visitedAllPhotos = true;

        foreach (bool photoClicked in FoundEvidence.photosClicked)
        {
            if (!photoClicked)
            {
                visitedAllPhotos = false;
            }
        }

        if (visitedAllPhotos)
        {
            verdictTransButton.SetActive(true);
        }
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene("FinalVerdict");
    }
}
