using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewWaifu : MonoBehaviour
{
    public static NewWaifu instance;

    Sprite[] s_Waifu; //Sprites
    SpriteNew[] m_Waifu;
    [SerializeField] int TOTAL_WAIFU;
    [SerializeField] GameObject m_RefWaifu; //Prefab
	[SerializeField] GameObject groundPlane;

    [SerializeField] Vector3 size;
	private void Awake()
    {
        instance = this;
        //m_RefWaifu = GameObject.Find("Waifu");
        m_Waifu = new SpriteNew[TOTAL_WAIFU];
        s_Waifu = Resources.LoadAll<Sprite>("Waifus"); // Load all Sprites from resources

        ShuffleLocation();
    }

    public void ShuffleLocation()
	{
        for (int i = 0; i < TOTAL_WAIFU; i++)
        {
            Vector3 position = new Vector3(Random.Range(-size.x / 2, size.x /2), size.y, Random.Range(-size.z /2, size.z /2));

            m_Waifu[i] = Instantiate(m_RefWaifu, position, Quaternion.identity).GetComponent<SpriteNew>();

            int Chance = Random.Range(0, s_Waifu.Length);

            m_Waifu[i].WaifuSpriteRenderer.sprite = s_Waifu[Chance];
            m_Waifu[i].waifuIndex = Chance;

            m_Waifu[i].transform.SetParent(groundPlane.transform);
            m_Waifu[i].gameObject.SetActive(true);
        }
    }

   public void Reset_Button()
    {
        foreach (SpriteNew _s in m_Waifu)
        {
            int Chance = Random.Range(0, s_Waifu.Length);
            _s.WaifuSpriteRenderer.sprite = s_Waifu[Chance];
            _s.waifuIndex = Chance;
            //_s.t_Body.Translate(Random.Range(-0.215f, 0.474f), 0.1599348f, Random.Range(-0.464f, 0.615f));
        }

        for(int i = 0; i < m_Waifu.Length; i++)
		{
            m_Waifu[i].gameObject.SetActive(true);
            m_Waifu[i].transform.position = new Vector3(Random.Range(-size.x / 2,size.x / 2),groundPlane.transform.position.y + size.y, Random.Range(-size.z / 2,size.z /2));
		}
    }

	private void OnDrawGizmosSelected()
	{
        Gizmos.color = Color.green;
        Gizmos.DrawCube(transform.position, size);
	}
}
