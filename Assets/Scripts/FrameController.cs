using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameController
{
    private static int numberOfFrames = 0;
    private static Dictionary<int,Dictionary<string,Vector3>> frames = new Dictionary<int,Dictionary<string,Vector3>>();
    
    public FrameController() {}

    public void newFrame() {
        numberOfFrames++;
    }

    public int getNumberOfFrames() {
        return numberOfFrames;
    }

    public Dictionary<int,Dictionary<string,Vector3>> getFrames() {
        return frames;
    }

    public Dictionary<string,Vector3> frameAtIndex(int i) {
        if(frames.ContainsKey(i))
            return frames[i];
        return null;
    }

    public void frameToDictionary(int i, Dictionary<string,Vector3> connectors) {
        if(frames.ContainsKey(i)){  
            frames[i] = connectors;
        } else {
            frames.Add(i, connectors);
        }
    }

    public bool doesFrameExist(int i) {
        if(frames.ContainsKey(i))
            return true;
        return false;
    }

    public void deleteFrame(int i) {
        if(frames.ContainsKey(i)) {
            frames.Remove(i);
        }
    }
}
