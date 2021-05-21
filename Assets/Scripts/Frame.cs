using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frame
{
    //connector positions
    Vector2 cHead;
    Vector2 cNeckToHead;
    Vector2 cBodyToNeck;
    Vector2 cHandToArmR;
    Vector2 cHandToArmL;
    Vector2 cHandR;
    Vector2 cHandL;
    Vector2 cLowerBody;
    Vector2 cLowerToUpperR;
    Vector2 cLowerToUpperL;
    Vector2 cFootToLowerR;
    Vector2 cFootToLowerL;
    Vector2 cFootR;
    Vector2 cFootL;
    private Dictionary<string,Vector2> connectors = default;

    /* private void Start() {
        initConnectorCoords();
    } */

    public Frame() {
        connectors = new Dictionary<string,Vector2>();
        initConnectorCoords();
    }

    public void initConnectorCoords() {
        cHead = GameObject.Find("ConnectorHead").GetComponent<Rigidbody2D>().position;
        cNeckToHead = GameObject.Find("ConnectorNeckToHead").GetComponent<Rigidbody2D>().position;
        cBodyToNeck = GameObject.Find("ConnectorBodyToNeck").GetComponent<Rigidbody2D>().position;
        cHandToArmR = GameObject.Find("ConnectorHandToArmR").GetComponent<Rigidbody2D>().position;
        cHandToArmL = GameObject.Find("ConnectorHandToArmL").GetComponent<Rigidbody2D>().position;
        cHandR = GameObject.Find("ConnectorHandR").GetComponent<Rigidbody2D>().position;
        cHandL = GameObject.Find("ConnectorHandL").GetComponent<Rigidbody2D>().position;
        cLowerBody = GameObject.Find("ConnectorLowerBody").GetComponent<Rigidbody2D>().position;
        cLowerToUpperR = GameObject.Find("ConnectorLowerToUpperR").GetComponent<Rigidbody2D>().position;
        cLowerToUpperL = GameObject.Find("ConnectorLowerToUpperL").GetComponent<Rigidbody2D>().position;
        cFootToLowerR = GameObject.Find("ConnectorFootToLowerR").GetComponent<Rigidbody2D>().position;
        cFootToLowerL = GameObject.Find("ConnectorFootToLowerL").GetComponent<Rigidbody2D>().position;
        cFootR = GameObject.Find("ConnectorFootR").GetComponent<Rigidbody2D>().position;
        cFootL = GameObject.Find("ConnectorFootL").GetComponent<Rigidbody2D>().position;
    }
/* 
    public void initConnectorCoords(Dictionary<string,Vector2> connectors) {
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

    public void initConnectorCoords(Dictionary<string,Vector2> connectors) {
        GameObject.Find("ConnectorHead").GetComponent<Rigidbody2D>().position = connectors["cHead"];
        Debug.Log(connectors["cHead"]);
        GameObject.Find("ConnectorNeckToHead").GetComponent<Rigidbody2D>().position = connectors["cNeckToHead"];
        GameObject.Find("ConnectorBodyToNeck").GetComponent<Rigidbody2D>().position = connectors["cBodyToNeck"];
        GameObject.Find("ConnectorHandToArmR").GetComponent<Rigidbody2D>().position = connectors["cHandToArmR"];
        GameObject.Find("ConnectorHandToArmL").GetComponent<Rigidbody2D>().position = connectors["cHandToArmL"];
        GameObject.Find("ConnectorHandR").GetComponent<Rigidbody2D>().position = connectors["cHandR"];
        GameObject.Find("ConnectorHandL").GetComponent<Rigidbody2D>().position = connectors["cHandL"];
        GameObject.Find("ConnectorLowerBody").GetComponent<Rigidbody2D>().position = connectors["cLowerBody"];
        GameObject.Find("ConnectorLowerToUpperR").GetComponent<Rigidbody2D>().position = connectors["cLowerToUpperR"];
        GameObject.Find("ConnectorLowerToUpperL").GetComponent<Rigidbody2D>().position = connectors["cLowerToUpperL"];
        GameObject.Find("ConnectorFootToLowerR").GetComponent<Rigidbody2D>().position = connectors["cFootToLowerR"];
        GameObject.Find("ConnectorFootToLowerL").GetComponent<Rigidbody2D>().position = connectors["cFootToLowerL"];
        GameObject.Find("ConnectorFootR").GetComponent<Rigidbody2D>().position = connectors["cFootR"];
        GameObject.Find("ConnectorFootL").GetComponent<Rigidbody2D>().position = connectors["cFootL"];
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

    public Dictionary<string,Vector2> getConnectors() {
        return connectors;
    }
}
