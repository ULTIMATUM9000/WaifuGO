using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewWaifu : MonoBehaviour
{
    Sprite[] s_Waifu;
    SpriteNew[] m_Waifu;
    const int TOTAL_WAIFU = 2;
    GameObject m_RefWaifu;


    private void Awake()
    {
        m_RefWaifu = GameObject.Find("Waifu");

        m_Waifu = new SpriteNew[TOTAL_WAIFU];
        s_Waifu = Resources.LoadAll<Sprite>("Waifus"); // Load all Sprites from resources

        for (int i = 0; i < TOTAL_WAIFU; i++)
        {
            Vector3 position = new Vector3(Random.Range(-0.215f, 0.474f), 0.1599348f, Random.Range(-0.464f, 0.615f));
            m_Waifu[i] = Instantiate(m_RefWaifu, position, Quaternion.identity).GetComponent<SpriteNew>();

            int Chance = Random.Range(0, s_Waifu.Length);
            m_Waifu[i].WaifuSpriteRenderer.sprite = s_Waifu[Chance];

            m_Waifu[i].transform.SetParent(m_RefWaifu.transform);
            m_Waifu[i].gameObject.SetActive(true);
        }
    }

   public void Reset_Button()
    {
        foreach (SpriteNew _s in m_Waifu)
        {
            int Chance = Random.Range(0, s_Waifu.Length);
              _s.WaifuSpriteRenderer.sprite = s_Waifu[Chance];
            _s.t_Body.Translate(Random.Range(-0.215f, 0.474f), 0.1599348f, Random.Range(-0.464f, 0.615f));

        }
    }
}
