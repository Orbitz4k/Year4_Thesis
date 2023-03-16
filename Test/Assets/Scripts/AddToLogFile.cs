using UnityEngine; 
using System.IO; 
using System;
using UnityEngine.SceneManagement;


public class AddToLogFile : MonoBehaviour
{
	public static string userNumber = "(no participant number chosen)";
	private static string _fileName = "";
	private static string _folderName = "Logs";
	private static string _filePath = "(no file path yet)";

	public static void CreateNewLogFileWithId(string userID)
	{
		_fileName = "USER_" + userID + "--" + DateTime.Now.ToString("yyy_MM_dd--HH_mm_ss") + ".csv";
		_filePath = Path.Combine(Application.dataPath, _folderName);
		_filePath = Path.Combine(_filePath, _fileName);
		
		LogLine("participant number, " + userNumber);
	}

	public static string TimeStamp()
	{
		return DateTime.Now.ToString("yyyy/MM/dd") + "," + DateTime.Now.ToString("HH:mm:ss");
	}
	
	public static void LogLine(string textLine)
	{
		string sceneName = SceneManager.GetActiveScene().name;
		textLine = TimeStamp() + "," + sceneName + "," + textLine;
		
		// This text is added only once to the file.
		if (!File.Exists(_filePath)) 
		{
			// Create a file to write to.
			using (StreamWriter sw = File.CreateText(_filePath)) 
			{
				sw.WriteLine(TimeStamp() + ",created");
			}	
		}

		// This text is always added, making the file longer over time
		// if it is not deleted.
		using (StreamWriter sw = File.AppendText(_filePath)) 
		{
			sw.WriteLine(textLine);
		}	
	}
	
	
	
} 