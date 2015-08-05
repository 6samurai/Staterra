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
	public GameObject Squid; 
	public GameObject Turtle; 
	public GameObject Shark;
	public GameObject Crab;
	public GameObject Octopus;
	private GameObject Active; 
	private Color normalColor;
	public Color highlightColor = Color.yellow;
	private Vector3 mousepos;

	public GameObject creature;
	public string name;


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
			if(name == "Copepod"){
				mousepos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,4.0f));
				Active = Instantiate (Copepod, mousepos, transform.rotation) as GameObject;
				Active.transform.localScale = new Vector3 (0.2f, 0.2f, 0.2f);
				
			}
			if(name == "Urchin"){
				mousepos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,4.0f));
				Active = Instantiate (Urchin, mousepos, transform.rotation) as GameObject;
				Active.transform.localScale = new Vector3 (1f, 1f, 1f);
				
			}
			if(name == "Shrimp"){
				mousepos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,4.0f));
				Active = Instantiate (Shrimp, mousepos, transform.rotation) as GameObject;
				Active.transform.localScale = new Vector3 (0.4f, 0.4f, 0.4f);
				
			}

			if(name == "Squid"){
			mousepos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,4.0f));
			Active = Instantiate (Squid, mousepos, transform.rotation) as GameObject;
			Active.transform.localScale = new Vector3 (0.2f, 0.2f, 0.2f);

			}

			if(name == "Turtle"){
				mousepos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,4.0f));
				Active = Instantiate (Turtle, mousepos, transform.rotation) as GameObject;
				Active.transform.localScale = new Vector3 (0.2f, 0.2f, 0.2f);

			}
			if(name == "Shark"){
				mousepos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,4.0f));
				Active = Instantiate (Shark, mousepos, transform.rotation) as GameObject;
				Active.transform.localScale = new Vector3 (0.2f, 0.2f, 0.2f);
			}
			if(name == "Crab"){
				mousepos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,4.0f));
				Active = Instantiate (Crab, mousepos, transform.rotation) as GameObject;
				Active.transform.localScale = new Vector3 (0.2f, 0.2f, 0.2f);
			}
			if(name == "Octopus"){
				mousepos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,4.0f));
				Active = Instantiate (Octopus, mousepos, transform.rotation) as GameObject;
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
