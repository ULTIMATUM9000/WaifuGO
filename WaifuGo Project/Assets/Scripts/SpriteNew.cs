using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteNew : MonoBehaviour
{
    SpriteRenderer m_SpriteRenderer;
    Transform m_Transform;



    public SpriteRenderer WaifuSpriteRenderer
    {
        get { return m_SpriteRenderer; }
        set { m_SpriteRenderer = value; }
    }

    public Transform t_Body
    {
        get { return m_Transform; }
        set { m_Transform = value; }
    }
    void OnEnable()
    {
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        m_Transform = transform;
    }
}
