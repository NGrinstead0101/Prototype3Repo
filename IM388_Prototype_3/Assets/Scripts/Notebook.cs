using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notebook : MonoBehaviour
{
    [SerializeField] GameObject notebookUI;
    bool notebookActive = false;
    bool canClick = true;

    GameObject[] noteObjects;
    Note[] noteScriptList;

    [SerializeField] EvidenceTracker evidenceTracker;

    private void Awake()
    {
        noteObjects = GameObject.FindGameObjectsWithTag("Note");

        foreach (GameObject noteObject in noteObjects)
        {
            noteObject.SetActive(false);
        }

        noteScriptList = new Note[noteObjects.Length];

        for (int i = 0; i < noteScriptList.Length; ++i)
        {
            noteScriptList[i] = noteObjects[i].GetComponent<Note>();
        }
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1) && canClick)
        {
            canClick = false;
            StartCoroutine(PreventDoubleClick());
            ToggleNotebook();
        }
    }

    private void ToggleNotebook()
    {
        notebookActive = !notebookActive;
        notebookUI.SetActive(notebookActive);

        if (notebookActive)
        {
            for (int i = 0; i < noteObjects.Length && i < FoundEvidence.foundList.Length; ++i)
            {
                if (FoundEvidence.foundList[i] == true)
                {
                    noteObjects[i].SetActive(true);
                    noteScriptList[i].RevealNote(evidenceTracker.evidenceList[i].evidenceName);
                }
            }
        }
        else
        {
            foreach (GameObject noteObject in noteObjects)
            {
                noteObject.SetActive(false);
            }
        }
    }

    IEnumerator PreventDoubleClick()
    {
        yield return new WaitForSeconds(0.25f);

        canClick = true;

        StopAllCoroutines();
    }
}
