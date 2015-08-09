using System.Collections;
using System.Reflection;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ToggleCheck : MonoBehaviour {
	
public GameObject ScrollView1;
public GameObject ScrollView2;
public GameObject ScrollView3;
public GameObject ScrollBar1;
public GameObject ScrollBar2;
public GameObject ScrollBar3;

	void Start(){
	}

	public void OnEnable(){
			ScrollView1.SetActive (false);
			ScrollView2.SetActive (false);
			ScrollView3.SetActive (false);
			ScrollBar1.SetActive (false);
			ScrollBar2.SetActive (false);
			ScrollBar3.SetActive (false);
		}
}