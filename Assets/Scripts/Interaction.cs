using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Interaction 
{
    public Action action;

    [TextArea]
    public string response;

    public string textToMatch;

    public List<Item> itemsToDisable = new List<Item>();
    public List<Item> itemsToEnable = new List<Item>();

    public List<connection> connectionsToDisable = new List<connection>();
    public List<connection> connectionsToEnable = new List<connection>();

    public location teleportLocation = null;

}
