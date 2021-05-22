using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frame
{
    //connector positions
    Vector3 cHead;
    Vector3 cNeckToHead;
    Vector3 cBodyToNeck;
    Vector3 cHandToArmR;
    Vector3 cHandToArmL;
    Vector3 cHandR;
    Vector3 cHandL;
    Vector3 cLowerBody;
    Vector3 cLowerToUpperR;
    Vector3 cLowerToUpperL;
    Vector3 cFootToLowerR;
    Vector3 cFootToLowerL;
    Vector3 cFootR;
    Vector3 cFootL;
    private Dictionary<string,Vector3> connectors = default;

    /* private void Start() {
        initConnectorCoords();
    } */

    public Frame() {
        connectors = new Dictionary<string,Vector3>();
        initConnectorCoords();
    }

    public void initConnectorCoords() {
        cHead = new Vector3(GameObject.Find("ConnectorHead").GetComponent<Rigidbody2D>().position.x,
        GameObject.Find("ConnectorHead").GetComponent<Rigidbody2D>().position.y,
        GameObject.Find("ConnectorHead").GetComponent<Rigidbody2D>().rotation);
        cNeckToHead = new Vector3(GameObject.Find("ConnectorNeckToHead").GetComponent<Rigidbody2D>().position.x,
        GameObject.Find("ConnectorNeckToHead").GetComponent<Rigidbody2D>().position.y,
        GameObject.Find("ConnectorNeckToHead").GetComponent<Rigidbody2D>().rotation);
        cBodyToNeck = new Vector3(GameObject.Find("ConnectorBodyToNeck").GetComponent<Rigidbody2D>().position.x,
        GameObject.Find("ConnectorBodyToNeck").GetComponent<Rigidbody2D>().position.y,
        GameObject.Find("ConnectorBodyToNeck").GetComponent<Rigidbody2D>().rotation);
        cHandToArmR = new Vector3(GameObject.Find("ConnectorHandToArmR").GetComponent<Rigidbody2D>().position.x,
        GameObject.Find("ConnectorHandToArmR").GetComponent<Rigidbody2D>().position.y,
        GameObject.Find("ConnectorHandToArmR").GetComponent<Rigidbody2D>().rotation);
        cHandToArmL = new Vector3(GameObject.Find("ConnectorHandToArmL").GetComponent<Rigidbody2D>().position.x,
        GameObject.Find("ConnectorHandToArmL").GetComponent<Rigidbody2D>().position.y,
        GameObject.Find("ConnectorHandToArmL").GetComponent<Rigidbody2D>().rotation);
        cHandR = new Vector3(GameObject.Find("ConnectorHandR").GetComponent<Rigidbody2D>().position.x,
        GameObject.Find("ConnectorHandR").GetComponent<Rigidbody2D>().position.y,
        GameObject.Find("ConnectorHandR").GetComponent<Rigidbody2D>().rotation);
        cHandL = new Vector3(GameObject.Find("ConnectorHandL").GetComponent<Rigidbody2D>().position.x,
        GameObject.Find("ConnectorHandL").GetComponent<Rigidbody2D>().position.y,
        GameObject.Find("ConnectorHandL").GetComponent<Rigidbody2D>().rotation);
        cLowerBody = new Vector3(GameObject.Find("ConnectorLowerBody").GetComponent<Rigidbody2D>().position.x,
        GameObject.Find("ConnectorLowerBody").GetComponent<Rigidbody2D>().position.y,
        GameObject.Find("ConnectorLowerBody").GetComponent<Rigidbody2D>().rotation);
        cLowerToUpperR = new Vector3(GameObject.Find("ConnectorLowerToUpperR").GetComponent<Rigidbody2D>().position.x,
        GameObject.Find("ConnectorLowerToUpperR").GetComponent<Rigidbody2D>().position.y,
        GameObject.Find("ConnectorLowerToUpperR").GetComponent<Rigidbody2D>().rotation);
        cLowerToUpperL = new Vector3(GameObject.Find("ConnectorLowerToUpperL").GetComponent<Rigidbody2D>().position.x,
        GameObject.Find("ConnectorLowerToUpperL").GetComponent<Rigidbody2D>().position.y,
        GameObject.Find("ConnectorLowerToUpperL").GetComponent<Rigidbody2D>().rotation);
        cFootToLowerR = new Vector3(GameObject.Find("ConnectorFootToLowerR").GetComponent<Rigidbody2D>().position.x,
        GameObject.Find("ConnectorFootToLowerR").GetComponent<Rigidbody2D>().position.y,
        GameObject.Find("ConnectorFootToLowerR").GetComponent<Rigidbody2D>().rotation);
        cFootToLowerL = new Vector3(GameObject.Find("ConnectorFootToLowerL").GetComponent<Rigidbody2D>().position.x,
        GameObject.Find("ConnectorFootToLowerL").GetComponent<Rigidbody2D>().position.y,
        GameObject.Find("ConnectorFootToLowerL").GetComponent<Rigidbody2D>().rotation);
        cFootR = new Vector3(GameObject.Find("ConnectorFootR").GetComponent<Rigidbody2D>().position.x,
        GameObject.Find("ConnectorFootR").GetComponent<Rigidbody2D>().position.y,
        GameObject.Find("ConnectorFootR").GetComponent<Rigidbody2D>().rotation);
        cFootL = new Vector3(GameObject.Find("ConnectorFootL").GetComponent<Rigidbody2D>().position.x,
        GameObject.Find("ConnectorFootL").GetComponent<Rigidbody2D>().position.y,
        GameObject.Find("ConnectorFootL").GetComponent<Rigidbody2D>().rotation);
    }
/* 
    public void initConnectorCoords(Dictionary<string,Vector3> connectors) {
        cHead = connectors["cHead"];
        cNeckToHead = connectors["cNeckToHead"];
        cBodyToNeck = connectors["cBodyToNeck"];
        cHandToArmR = connectors["cHandToArmR"];
        cHandToArmL = connectors["cHandToArmL"];
        cHandR = connectors["cHandR"];
        cHandL = connectors["cHandL"];
        cLowerBody = connectors["cLowerBody"];
        cLowerToUpperR = connectors["cLowerToUpperR"];
        cLowerToUpperL = connectors["cLowerToUpperL"];
        cFootToLowerR = connectors["cFootToLowerR"];
        cFootToLowerL = connectors["cFootToLowerL"];
        cFootR = connectors["cFootR"];
        cFootL = connectors["cFootL"];
    } */

    public void initConnectorCoords(Dictionary<string,Vector3> connectors) {
        GameObject.Find("ConnectorHead").GetComponent<Rigidbody2D>().position = new Vector2(connectors["cHead"].x, connectors["cHead"].y);
        GameObject.Find("ConnectorHead").GetComponent<Rigidbody2D>().rotation = connectors["cHead"].z;

        GameObject.Find("ConnectorNeckToHead").GetComponent<Rigidbody2D>().position = new Vector2(connectors["cNeckToHead"].x, connectors["cNeckToHead"].y);
        GameObject.Find("ConnectorNeckToHead").GetComponent<Rigidbody2D>().rotation = connectors["cNeckToHead"].z;

        GameObject.Find("ConnectorBodyToNeck").GetComponent<Rigidbody2D>().position = new Vector2(connectors["cBodyToNeck"].x, connectors["cBodyToNeck"].y);
        GameObject.Find("ConnectorBodyToNeck").GetComponent<Rigidbody2D>().rotation = connectors["cBodyToNeck"].z;

        GameObject.Find("ConnectorHandToArmR").GetComponent<Rigidbody2D>().position = new Vector2(connectors["cHandToArmR"].x, connectors["cHandToArmR"].y);
        GameObject.Find("ConnectorHandToArmR").GetComponent<Rigidbody2D>().rotation = connectors["cHandToArmR"].z;

        GameObject.Find("ConnectorHandToArmL").GetComponent<Rigidbody2D>().position = new Vector2(connectors["cHandToArmL"].x, connectors["cHandToArmL"].y);
        GameObject.Find("ConnectorHandToArmL").GetComponent<Rigidbody2D>().rotation = connectors["cHandToArmL"].z;

        GameObject.Find("ConnectorHandR").GetComponent<Rigidbody2D>().position = new Vector2(connectors["cHandR"].x, connectors["cHandR"].y);
        GameObject.Find("ConnectorHandR").GetComponent<Rigidbody2D>().rotation = connectors["cHandR"].z;

        GameObject.Find("ConnectorHandL").GetComponent<Rigidbody2D>().position = new Vector2(connectors["cHandL"].x, connectors["cHandL"].y);
        GameObject.Find("ConnectorHandL").GetComponent<Rigidbody2D>().rotation = connectors["cHandL"].z;

        GameObject.Find("ConnectorLowerBody").GetComponent<Rigidbody2D>().position = new Vector2(connectors["cLowerBody"].x, connectors["cLowerBody"].y);
        GameObject.Find("ConnectorLowerBody").GetComponent<Rigidbody2D>().rotation = connectors["cLowerBody"].z;

        GameObject.Find("ConnectorLowerToUpperR").GetComponent<Rigidbody2D>().position = new Vector2(connectors["cLowerToUpperR"].x, connectors["cLowerToUpperR"].y);
        GameObject.Find("ConnectorLowerToUpperR").GetComponent<Rigidbody2D>().rotation = connectors["cLowerToUpperR"].z;

        GameObject.Find("ConnectorLowerToUpperL").GetComponent<Rigidbody2D>().position = new Vector2(connectors["cLowerToUpperL"].x, connectors["cLowerToUpperL"].y);
        GameObject.Find("ConnectorLowerToUpperL").GetComponent<Rigidbody2D>().rotation = connectors["cLowerToUpperL"].z;
        
        GameObject.Find("ConnectorFootToLowerR").GetComponent<Rigidbody2D>().position = new Vector2(connectors["cFootToLowerR"].x, connectors["cFootToLowerR"].y);
        GameObject.Find("ConnectorFootToLowerR").GetComponent<Rigidbody2D>().rotation = connectors["cFootToLowerR"].z;
        
        GameObject.Find("ConnectorFootToLowerR").GetComponent<Rigidbody2D>().position = new Vector2(connectors["cFootToLowerR"].x, connectors["cFootToLowerR"].y);
        GameObject.Find("ConnectorFootToLowerR").GetComponent<Rigidbody2D>().rotation = connectors["cFootToLowerR"].z;
        
        GameObject.Find("ConnectorFootR").GetComponent<Rigidbody2D>().position = new Vector2(connectors["cFootR"].x, connectors["cFootR"].y);
        GameObject.Find("ConnectorFootR").GetComponent<Rigidbody2D>().rotation = connectors["cFootR"].z;
        
        GameObject.Find("ConnectorFootL").GetComponent<Rigidbody2D>().position = new Vector2(connectors["cFootL"].x, connectors["cFootL"].y);
        GameObject.Find("ConnectorFootL").GetComponent<Rigidbody2D>().rotation = connectors["cFootL"].z;
    }

    public void connectorsToDictionary() {
        if(connectors.ContainsKey("cHead")){  
            connectors["cHead"] = cHead;
        } else {
            connectors.Add("cHead", cHead);
        }
        if(connectors.ContainsKey("cNeckToHead")){  
            connectors["cNeckToHead"] = cNeckToHead;
        } else {
            connectors.Add("cNeckToHead", cNeckToHead);
        }
        if(connectors.ContainsKey("cBodyToNeck")){  
            connectors["cBodyToNeck"] = cBodyToNeck;
        } else {
            connectors.Add("cBodyToNeck", cBodyToNeck);
        }
        if(connectors.ContainsKey("cHandToArmR")){  
            connectors["cHandToArmR"] = cHandToArmR;
        } else {
            connectors.Add("cHandToArmR", cHandToArmR);
        }
        if(connectors.ContainsKey("cHandToArmL")){  
            connectors["cHandToArmL"] = cHandToArmL;
        } else {
            connectors.Add("cHandToArmL", cHandToArmL);
        }
        if(connectors.ContainsKey("cHandR")){  
            connectors["cHandR"] = cHandR;
        } else {
            connectors.Add("cHandR", cHandR);
        }
        if(connectors.ContainsKey("cHandL")){  
            connectors["cHandL"] = cHandL;
        } else {
            connectors.Add("cHandL", cHandL);
        }
        if(connectors.ContainsKey("cLowerBody")){  
            connectors["cLowerBody"] = cLowerBody;
        } else {
            connectors.Add("cLowerBody", cLowerBody);
        }
        if(connectors.ContainsKey("cLowerToUpperR")){  
            connectors["cLowerToUpperR"] = cLowerToUpperR;
        } else {
            connectors.Add("cLowerToUpperR", cLowerToUpperR);
        }
        if(connectors.ContainsKey("cLowerToUpperL")){  
            connectors["cLowerToUpperL"] = cLowerToUpperL;
        } else {
            connectors.Add("cLowerToUpperL", cLowerToUpperL);
        }
        if(connectors.ContainsKey("cFootToLowerR")){  
            connectors["cFootToLowerR"] = cFootToLowerR;
        } else {
            connectors.Add("cFootToLowerR", cFootToLowerR);
        }
        if(connectors.ContainsKey("cFootToLowerL")){  
            connectors["cFootToLowerL"] = cFootToLowerL;
        } else {
            connectors.Add("cFootToLowerL", cFootToLowerL);
        }
        if(connectors.ContainsKey("cFootR")){  
            connectors["cFootR"] = cFootR;
        } else {
            connectors.Add("cFootR", cFootR);
        }
        if(connectors.ContainsKey("cFootL")){  
            connectors["cFootL"] = cFootL;
        } else {
            connectors.Add("cFootL", cFootL);
        }
    }

    public Dictionary<string,Vector3> getConnectors() {
        return connectors;
    }
}
