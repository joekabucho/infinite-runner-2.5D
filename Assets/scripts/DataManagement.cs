using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class DataManagement : MonoBehaviour {
	public static DataManagement datamanagement;
	public int currentScore;
  public int highScore;

  public int CoinsCollected;

void Start()
{
	DataManagement.datamanagement.LoadData();
}

  void Awake () {
	  if (datamanagement==null){
		  DontDestroyOnLoad(gameObject);
		  datamanagement=this;
	  }
	  else if (datamanagement!=this){
		  Destroy(gameObject);
	  }
  }
public void SaveData(){
  BinaryFormatter BinForm = new BinaryFormatter();
  FileStream file = File.Create(Application.persistentDataPath + "/gameInfo.dat");
  gameData data = new gameData();
  data.highscore=highScore;
  data.CoinsCollected=CoinsCollected;
  BinForm.Serialize(file,data);
  file.Close();
}
public void LoadData(){
  if(File.Exists(Application.persistentDataPath+"/gameInfo.dat")){
      BinaryFormatter BinForm=new BinaryFormatter();
	  FileStream file =File.Open(Application.persistentDataPath+"/gameInfo.dat",FileMode.Open);
	  gameData data = (gameData)BinForm.Deserialize(file);
	  file.Close();
	  highScore=data.highscore;
	  CoinsCollected=data.CoinsCollected;
	 

  }
}

}
[Serializable]
class gameData {
 public int highscore; 
 public int CoinsCollected;     

}
