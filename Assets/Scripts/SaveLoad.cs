using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEditor.U2D.Animation;
using Unity.VisualScripting.Antlr3.Runtime;

public static class SaveLoad
{

    public static void SaveData(Character character){
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/Memory";
        FileStream stream = new FileStream(path, FileMode.Create);
        CharacterStats charData = new CharacterStats(character);
        formatter.Serialize(stream, charData);
        stream.Close();
    }

    public static CharacterStats LoadData()
    {
        string path = Application.persistentDataPath + "/Memory";
        if(File.Exists(path)){
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            CharacterStats data = formatter.Deserialize(stream) as CharacterStats;
            stream.Close();
            return data;
        }   else{
            Debug.LogError("Funkarrr inteeeee");
            return null;
        }
    }
}
