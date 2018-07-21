using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManaged : MonoBehaviour {
public int selectedZombie=0;
public List <GameObject> ZomieList; 
public int Score=0;
public Text ScoreText;
	// Use this for initialization
	void Start () {
		selectZombie(0); 
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.RightArrow)){
         if (selectedZombie<3)
		 selectZombie(selectedZombie+1);
			
			 else
			 selectZombie(0);
			 
		 }
		 else if (Input.GetKeyDown(KeyCode.LeftArrow)){
			 if (selectedZombie>0)
			 selectZombie(selectedZombie-1);
			 else
			 selectZombie(3); 

		 }
		 else if (Input.GetKeyDown(KeyCode.UpArrow)){
			 Rigidbody  rb = ZomieList[selectedZombie].GetComponent<Rigidbody>();
			 rb.AddForce(new Vector3(0,0,4),ForceMode.Impulse);
		 }

		}

		void selectZombie(int x){
			ZomieList[selectedZombie].transform.localScale=new Vector3(1,1,1);
			selectedZombie=x;
			ZomieList[selectedZombie].transform.localScale=new Vector3(1.5f,1.5f,1.5f);
		}
		public void addScore(){
			Score++;
			ScoreText.text="Score : "+Score;
		}	
}
