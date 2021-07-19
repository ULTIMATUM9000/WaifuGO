using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

	public TextMeshProUGUI waifuCounter;

	public int waifusCollected;

	private void Awake()
	{
		instance = this;
	}

	private void Update()
	{
		waifuCounter.SetText("Waifus Collected: " + waifusCollected.ToString());
	}
}
