using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogScript : MonoBehaviour
{

	

	 void Start()
	{
		AddToLogFile.userNumber = "1";
		AddToLogFile.CreateNewLogFileWithId("1");
		AddToLogFile.LogLine("Start");
		//SceneManager.LoadScene("scene2");
	}
	
}
