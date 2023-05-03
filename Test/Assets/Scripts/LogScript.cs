using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogScript : MonoBehaviour
{

	

	 void Start()
	{
		AddToLogFile.userNumber = "Demo";
		AddToLogFile.CreateNewLogFileWithId("Demo");
		AddToLogFile.LogLine("Start");
		//SceneManager.LoadScene("scene2");
	}
	
}
