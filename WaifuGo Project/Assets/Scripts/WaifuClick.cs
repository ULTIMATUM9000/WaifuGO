using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaifuClick : MonoBehaviour
{
	Touch touch;

	private void Update()
	{
		CheckClick();
		MobileTouch();
	}

	void CheckClick()
	{
		if(Input.GetMouseButtonDown(0))
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				
			if(Physics.Raycast(ray, out RaycastHit hit))
			{
				if (hit.collider.CompareTag("Waifu"))
				{
					hit.transform.gameObject.GetComponent<SpriteNew>().AddWaifu();
				}
			}
		}
	}

	void MobileTouch()
	{
		if (Input.touchCount > 0)
		{
			touch = Input.GetTouch(0);

			if (touch.phase == TouchPhase.Began)
			{
				Ray ray = Camera.main.ScreenPointToRay(touch.position);

				if (Physics.Raycast(ray, out RaycastHit hit))
				{
					if (hit.collider.CompareTag("Waifu"))

						hit.transform.gameObject.GetComponent<SpriteNew>().AddWaifu();
				}
			}
		}
	}
}
