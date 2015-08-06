using System.Reflection;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections;

public class DropMe : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
	public Image containerImage;
	public Image receivingImage;
	public GameObject Copepod;
	public GameObject Urchin;
	public GameObject Shrimp;
	public GameObject Crab;
	public GameObject Bogue;
	public GameObject Star;
	public GameObject Jelly;
	public GameObject Octopus;
	public GameObject Squid;
	public GameObject Bass;
	public GameObject Turtle;
	public GameObject Gulper;
	public GameObject Tuna;
	public GameObject Dolphin;
	public GameObject Shark;
	private GameObject Active; 
	private Color normalColor;
	public Color highlightColor = Color.yellow;
	private Vector3 mousepos;

	public GameObject creature;
	public string StoreName;


	public void OnEnable ()
	{
		if (containerImage != null)
			normalColor = containerImage.color;
	}
	
	public void OnDrop(PointerEventData data)
	{
		containerImage.color = normalColor;
		
		if (receivingImage == null)
			return;
		
		Sprite dropSprite = GetDropSprite (data);
		if (dropSprite != null) {
		
	
			//mousepos = new Vector3 (data.position.x, data.position.y, 0) - mousepress;
			if(StoreName == "Copepod"){
				mousepos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,4.0f));
				Active = Instantiate (Copepod, mousepos, transform.rotation) as GameObject;
				Active.transform.localScale = new Vector3 (0.2f, 0.2f, 0.2f);	
			}
			if(StoreName == "Urchin"){
				mousepos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,4.0f));
				Active = Instantiate (Urchin, mousepos, transform.rotation) as GameObject;
				Active.transform.localScale = new Vector3 (0.2f, 0.2f, 0.2f);	
			}
			if(StoreName == "Shrimp"){
				mousepos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,4.0f));
				Active = Instantiate (Shrimp, mousepos, transform.rotation) as GameObject;
				Active.transform.localScale = new Vector3 (0.4f, 0.4f, 0.4f);
			}
			if(StoreName == "Crab"){
				mousepos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,4.0f));
				Active = Instantiate (Crab, mousepos, transform.rotation) as GameObject;
				Active.transform.localScale = new Vector3 (0.2f, 0.2f, 0.2f);
			}
			if(StoreName == "Bogue"){
				mousepos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,4.0f));
				Active = Instantiate (Bogue, mousepos, transform.rotation) as GameObject;
				Active.transform.localScale = new Vector3 (0.2f, 0.2f, 0.2f);
			}
			if(StoreName == "Star"){
				mousepos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,4.0f));
				Active = Instantiate (Star, mousepos, transform.rotation) as GameObject;
				Active.transform.localScale = new Vector3 (0.2f, 0.2f, 0.2f);
			}
			if(StoreName == "Jelly"){
				mousepos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,4.0f));
				Active = Instantiate (Jelly, mousepos, transform.rotation) as GameObject;
				Active.transform.localScale = new Vector3 (0.4f, 0.4f, 0.4f);
			}
			if(StoreName == "Octopus"){
				mousepos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,4.0f));
				Active = Instantiate (Octopus, mousepos, transform.rotation) as GameObject;
				Active.transform.localScale = new Vector3 (0.2f, 0.2f, 0.2f);
			}
			if(StoreName == "Squid"){
				mousepos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,4.0f));
				Active = Instantiate (Squid, mousepos, transform.rotation) as GameObject;
				Active.transform.localScale = new Vector3 (0.2f, 0.2f, 0.2f);
			}
			if(StoreName == "Bass"){
				mousepos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,4.0f));
				Active = Instantiate (Bass, mousepos, transform.rotation) as GameObject;
				Active.transform.localScale = new Vector3 (0.2f, 0.2f, 0.2f);
			}
			if(StoreName == "Turtle"){
				mousepos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,4.0f));
				Active = Instantiate (Turtle, mousepos, transform.rotation) as GameObject;
				Active.transform.localScale = new Vector3 (0.2f, 0.2f, 0.2f);
			}
			if(StoreName == "Gulper"){
				mousepos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,4.0f));
				Active = Instantiate (Gulper, mousepos, transform.rotation) as GameObject;
				Active.transform.localScale = new Vector3 (0.2f, 0.2f, 0.2f);
			}
			if(StoreName == "Tuna"){
				mousepos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,4.0f));
				Active = Instantiate (Tuna, mousepos, transform.rotation) as GameObject;
				Active.transform.localScale = new Vector3 (0.2f, 0.2f, 0.2f);
			}
			if(StoreName == "Dolphin"){
				mousepos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,4.0f));
				Active = Instantiate (Dolphin, mousepos, transform.rotation) as GameObject;
				Active.transform.localScale = new Vector3 (0.2f, 0.2f, 0.2f);
			}
			if(StoreName == "Shark"){
				mousepos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,4.0f));
				Active = Instantiate (Shark, mousepos, transform.rotation) as GameObject;
				Active.transform.localScale = new Vector3 (0.2f, 0.2f, 0.2f);
			}
			
		}
	}

	public void OnPointerEnter(PointerEventData data)
	{

		if (containerImage == null)
			return;
		
		Sprite dropSprite = GetDropSprite (data);
		if (dropSprite != null)
			containerImage.color = highlightColor;
	}

	public void OnPointerExit(PointerEventData data)
	{
		if (containerImage == null)
			return;
		
		containerImage.color = normalColor;
	}
	
	private Sprite GetDropSprite(PointerEventData data)
	{
		var originalObj = data.pointerDrag;
		if (originalObj == null)
			return null;

		var srcImage = originalObj.GetComponent<Image>();
		if (srcImage == null)
			return null;
		
		return srcImage.sprite;
	}
}
