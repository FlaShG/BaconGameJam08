using UnityEngine;
using System.Collections;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class TextureCollection : ScriptableObject
{

    public Sprite[] sprites;

    public Sprite GetRandom()
    {
        return sprites[Random.Range(0, sprites.Length)];
    }
#if UNITY_EDITOR
    [MenuItem("ScriptableObject/Create Sound Collection")]
    static void CreateAsset()
    {
        ScriptableObject asset = ScriptableObject.CreateInstance(typeof(TextureCollection));
        AssetDatabase.CreateAsset(asset, "Assets/New Sound Collection.asset");
        EditorUtility.FocusProjectWindow();
        Selection.activeObject = asset;
    }
#endif
}