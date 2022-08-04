using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SeedText : MonoBehaviour
{
    TMP_Text thetext;

    void Start()
    {
        thetext = GetComponent<TMP_Text>();
        if (!thetext)
        {
            return;
        }
        thetext.text = $"Seed: {Random.seed}";
    }
}
