using System;
using UnityEngine;
using UnityEngine.UI;

public class LogCounter: MonoBehaviour {
	public int counter = 0;

void Update(){
		if (Input.GetKeyUp("space")){
			Debug.Log("space pressed");
			counter ++;
			if (counter==1)
				this.GetComponent<Text>().text = "test 1";

			if (counter==2)
				this.GetComponent<Text>().text = "test 2";

			if (counter==3)
				this.GetComponent<Text>().text = "test 3";

			if (counter==4)
				this.GetComponent<Text>().text = "test 4";

			if (counter==5)
				this.GetComponent<Text>().text = "test 5";

			if (counter==6)
				this.GetComponent<Text>().text = "";

	}
}
}


