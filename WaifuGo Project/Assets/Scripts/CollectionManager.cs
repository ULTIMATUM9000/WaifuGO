using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectionManager : MonoBehaviour
{
    public static CollectionManager instance;

	[SerializeField] Image panelPrefab;
	[SerializeField] Transform CollectedWaifuPanel;

	Sprite[] waifuSprites;


	private void Awake()
	{
		instance = this;
		waifuSprites = Resources.LoadAll<Sprite>("Waifus");
		InitializeWaifuPanel();
	}

	void InitializeWaifuPanel()
	{
		for(int i = 0;i <= waifuSprites.Length - 1; i++)
		{
			Image panel = Instantiate(panelPrefab);
			panel.transform.SetParent(CollectedWaifuPanel, false);
			panel.transform.localScale = Vector3.one;
			//panel.transform.position = Vector3.zero;
		}
	}

	public void UnlockWaifuPanel(int index)
	{
		CollectedWaifuPanel.gameObject.transform.GetChild(index).GetComponent<Image>().sprite = waifuSprites[index];
	}
}
