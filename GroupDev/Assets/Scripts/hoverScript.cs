﻿using UnityEngine;
using System.Collections;

public class hoverScript : MonoBehaviour {
	
	public string destination = "";
	bool click = false;
	bool inside = false;
	Color color = Color.red;
	void OnMouseEnter(){
		//change text color
		renderer.material.color=Color.red;
		//inside = true;
	}
	
	void OnMouseExit(){
		//change text color
		renderer.material.color=Color.white;
		//inside = false;
	}
	public void enter()
	{
		inside = true;
	}
	public void leave()
	{
		inside = false;
	}
	public void clicked()
	{
		//renderer.material.color = color;
		if (inside)
		{
			switch(destination)
			{
			case "quit":
				Application.Quit();
				break;
			case "control":
				Application.LoadLevel(2);
				break;
			case "return":
				Application.LoadLevel(0);
				break;
			case "returntc":
				Application.LoadLevel(0);
				break;
			case "play":
				//HasKey(string key);
				if (!PlayerPrefs.HasKey("punch"))
					PlayerPrefs.SetString("punch","J");
				if (!PlayerPrefs.HasKey("kick"))
					PlayerPrefs.SetString("kick","K");
				if (!PlayerPrefs.HasKey("jump"))
					PlayerPrefs.SetString("jump","Space");

				//HasKey(string key);
				if (!PlayerPrefs.HasKey("punchP2"))
					PlayerPrefs.SetString("punchP2","SemiColon");
				if (!PlayerPrefs.HasKey("kickP2"))
					PlayerPrefs.SetString("kickP2","Quote");
				if (!PlayerPrefs.HasKey("jumpP2"))
					PlayerPrefs.SetString("jumpP2","Numpad5");

				Application.LoadLevel(1);
				break;
			case "controlP1":
					PlayerPrefs.SetString("punch","J");
					PlayerPrefs.SetString("kick","K");
					PlayerPrefs.SetString("jump","Space");
				Application.LoadLevel(3);
				break;
			case "controlP2":
					PlayerPrefs.SetString("punchP2","SemiColon");
					PlayerPrefs.SetString("kickP2","Quote");
					PlayerPrefs.SetString("jumpP2","Numpad5");
				Application.LoadLevel(4);
				break;
			}
		}
		/*if (inside)
		{
			if (isQuit)
				Application.Quit();
			else if (isControl)
				Application.LoadLevel(3);
			else
				Application.LoadLevel(1);
		}*/
	}
	void Update()
	{
		//click = false;
		/*if (Input.GetMouseButtonDown(0))
		{
			click = true;
		}*/
	}
}
