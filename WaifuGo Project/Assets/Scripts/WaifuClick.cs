using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaifuClick : MonoBehaviour
{
	private void Update()
	{
		CheckClick();
	}

	void CheckClick()
	{
		if(Input.GetMouseButtonDown(0))
		{
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				
			if(Physics.Raycast(ray, out hit, 100.0f))
			{
				PrintName(hit.transform.gameObject);

				if (hit.collider.CompareTag("Waifu"))
				{
					hit.transform.gameObject.GetComponent<SpriteNew>().AddWaifu();
				}
			}
		}
	}

	void PrintName(GameObject go)
	{
		print(go.name);
	}
}
