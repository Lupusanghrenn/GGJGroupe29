﻿using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEngine.InputSystem;
using System.Collections;

public class MenuManager : MonoBehaviour
{
    public AudioClip selectSound;

    private List<GameObject> buttons;
    private int currentIndex;
    private int maxIndex;
    private AudioSource audioSource;
    private bool waiting;
    public List<GameObject> disactivateButtons;
    public GameObject prenoms;
    private float currentTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject go in disactivateButtons)
        {
            go.SetActive(false);
        }
        audioSource = GetComponent<AudioSource>();


        buttons = new List<GameObject>();
        for (int i = 0; i < transform.childCount; i++)
        {
            if (transform.GetChild(i).name.Contains("Button"))
            {
                buttons.Add(transform.GetChild(i).gameObject);
            }
        }

        currentIndex = 0;
        maxIndex = buttons.Count - 1;

        buttons[currentIndex].GetComponent<Animator>().SetBool("selected", true);   
    }

    public void SetSelected(int index)
    {
        PlaySound(selectSound);

        for (int i = 0; i < buttons.Count; i++)
        {
            if (i == index)
            {
                buttons[i].GetComponent<Animator>().SetBool("selected", true);
            }
            else
            {
                buttons[i].GetComponent<Animator>().SetBool("selected", false);
            }
        }
    }

    public void PlaySound(AudioClip sound)
    {
        audioSource.clip = sound;
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
     {
        currentTime += Time.deltaTime;
        if (currentTime >= 5f)
        {
            prenoms.SetActive(false);
            foreach (GameObject go in disactivateButtons)
            {
                go.SetActive(true);
            }
        }
     }

    public void OnMove(InputValue value)
    {
        Vector2 vec = value.Get<Vector2>();
        if (vec.y <= -0.9f)
        {
            if (!waiting)
            {
                currentIndex--;
                if (currentIndex < 0)
                {
                    currentIndex = maxIndex;
                }

                SetSelected(currentIndex);
                StartCoroutine(Wait());
            }

        }
        else if (vec.y >= 0.9f)
        {
            if (!waiting)
            {
                //incrémentation
                currentIndex++;
                if (currentIndex > maxIndex)
                {
                    currentIndex = 0;
                }

                SetSelected(currentIndex);
                StartCoroutine(Wait());
            }

        }
    }

    public void OnAction(InputValue value)
    {
        if (currentIndex == 0)
        {
            SceneManager.LoadScene("Max");
        }
        else
        {
            Application.Quit();
        }
    }

    public IEnumerator Wait()
    {
        waiting = true;
        yield return new WaitForSeconds(0.5f);
        waiting = false;
    }


}
