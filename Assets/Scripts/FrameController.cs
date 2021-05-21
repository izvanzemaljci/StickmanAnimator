using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameController
{
    private static int numberOfFrames = 0;
    private static Dictionary<int,Dictionary<string,Vector2>> frames = new Dictionary<int,Dictionary<string,Vector2>>();
    
    public FrameController() {

    }

    public void newFrame() {
        numberOfFrames++;
    }

    public int getNumberOfFrames() {
        return numberOfFrames;
    }

    public Dictionary<int,Dictionary<string,Vector2>> getFrames() {
        return frames;
    }

    public void frameToDictionary(int i, Dictionary<string,Vector2> connectors) {
        if(frames.ContainsKey(i)){  
            frames[i] = connectors;
        } else {
            frames.Add(i, connectors);
        }
    }
}
