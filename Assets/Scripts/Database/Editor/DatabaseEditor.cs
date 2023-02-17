using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class DatabaseEditor
{
    [MenuItem("Database/Clear Database")]
    private static void ClearDatabase() { Database.ClearDatabase(); }
}
