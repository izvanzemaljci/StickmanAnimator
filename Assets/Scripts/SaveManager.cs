using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System;

public static class SaveManager
{
    public static string DictionaryToString(Dictionary<int,Dictionary<string,Vector3>> frames) {
        StringBuilder builder = new StringBuilder();
        foreach(var values in frames)
            {
                builder.Append(values.Key).Append(":{");
                foreach(var value in values.Value) {
                    builder.Append(value.Key).Append(":").Append(value.Value).Append(",");
                }
                builder.Append("},");
                builder.Replace(",}","}");
            }
        string result = builder.ToString();
        result = result.TrimEnd(',');
        Debug.Log(result);
        return result;
    }

    public static void SaveAnimation(Dictionary<int,Dictionary<string,Vector3>> frames) {
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/animation.anim";
        FileStream fileStream = new FileStream(path, FileMode.Create);

        string animationData = DictionaryToString(frames);

        binaryFormatter.Serialize(fileStream, animationData);
        fileStream.Close();
    }
}
