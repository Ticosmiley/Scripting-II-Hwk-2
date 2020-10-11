using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Inventory))]
public class InventoryEditor : Editor
{
    public override void OnInspectorGUI()
    {
        GUILayout.Box("This editor shows the items currently held in the inventory and provides fields for editing each item's name, slot, value, and rarity. " +
            "The editor also allows the inventory to be sorted by value or to be emptied using the buttons at the bottom");

        base.OnInspectorGUI();

        GUILayout.Label("Inventory functions");

        Inventory inventory = (Inventory)target;

        GUILayout.BeginHorizontal();

            if (GUILayout.Button("Sort Inventory"))
            {
                inventory.SortInventory();
            }

            if (GUILayout.Button("Clear Inventory"))
            {
                inventory.ClearInventory();
            }

        GUILayout.EndHorizontal();
    }
}
