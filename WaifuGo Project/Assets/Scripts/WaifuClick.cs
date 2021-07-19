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
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				
			if(Physics.Raycast(ray, out hit, 100.0f))
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
			Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);

			if (touch.phase == TouchPhase.Began)
			{
				Collider2D touchedCollider = Physics2D.OverlapPoint(touchPosition);

				if (touchedCollider.CompareTag("Waifu"))
				{
					touchedCollider.GetComponent<SpriteNew>().AddWaifu();
				}
			}
		}
	}
}
