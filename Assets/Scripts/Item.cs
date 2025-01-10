using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ CreateAssetMenu(menuName= "Data/Item")]
public class Item: ScriptableObject
{
    public string Name;
    public bool stackable;
    public Sprite icon;
    public ToolAction onAction;
    public ToolAction onTileMapAction;
    public ToolAction OnItemUsed;
    public Crop crop;
    public bool iconHighlight;
    public GameObject itemPrefab;
    public bool isWeapon;
    public int damage = 10;
}
