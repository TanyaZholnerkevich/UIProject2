using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsController : MonoBehaviour
{
    [SerializeField] private GameObject mask;
    [SerializeField] private GameObject[] stars;
    void Start()
    {
        foreach (var fullStar in stars)
        {
            fullStar.SetActive(false);
        }
        mask.SetActive(false);
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) && mask.activeSelf)
        {
            ActivateStars(1);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2) && mask.activeSelf)
        {
            ActivateStars(2);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3) && mask.activeSelf)
        {
            ActivateStars(3);
        }
    }

    private void ActivateStars(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            stars[i].SetActive(true);
        }
        for (int i = stars.Length - 1; i > amount - 1; i--)
        {
            stars[i].SetActive(false);
        }
    }
}
