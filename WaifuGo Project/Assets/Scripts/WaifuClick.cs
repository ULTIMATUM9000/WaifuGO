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
				PrintName(hit.transform.gameObject);

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
			//Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);

			if (touch.phase == TouchPhase.Began)
			{
				//Collider touchedCollider = Physics.OverlapBox(touchPosition, 0f,Quaternion.identity);

				//if (col = touchedCollider)
				//{
					
				//}
			}
			if (touch.phase == TouchPhase.Moved)
			{

			}
			if (touch.phase == TouchPhase.Ended)
			{

			}
		}
	}

	void PrintName(GameObject go)
	{
		print(go.name);
	}
}
