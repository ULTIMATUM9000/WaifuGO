using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteNew : MonoBehaviour
{
    SpriteRenderer m_SpriteRenderer;
    



    public SpriteRenderer WaifuSpriteRenderer
    {
        get { return m_SpriteRenderer; }
        set { m_SpriteRenderer = value; }
    }

    void OnEnable()
    {
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
    }
}
