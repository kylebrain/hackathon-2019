﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordToggle : MonoBehaviour
{
    SpriteRenderer m_SpriteRenderer;
    Color32 transparent = new Color32(35, 238, 47, 130);
    Color32 bright = new Color32(35, 238, 47, 255);

    // Start is called before the first frame update
    void Start()
    {
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        m_SpriteRenderer.color = transparent;

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider collision)
    {
        m_SpriteRenderer.color = bright;
    }

    void OnTriggerExit(Collider collision)
    {
        m_SpriteRenderer.color = transparent;
    }
}
