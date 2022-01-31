﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class TextTyper : MonoBehaviour
{
    private TextMeshProUGUI textBox;
    private string text;
    private int length;

    void Start()
    {
        textBox = GetComponent<TextMeshProUGUI>();
        text = textBox.text;
        length = text.Length;

        StartCoroutine(Type());
    }

    private IEnumerator Type()
    {
        for(int i = 0; i < length + 1; i++)
        {
            textBox.SetText(text.Substring(0, i));

            yield return new WaitForSeconds(0.028f);
        }
    }
}
