using UnityEngine;
using System.Collections;
#if UNITY_EDITOR 
using UnityEditor;
#endif

public class SoundCollection : ScriptableObject {

    public AudioClip[] sounds;

    public AudioClip GetRandom()
    {
        return sounds[Random.Range(0, sounds.Length)];
    }
#if UNITY_EDITOR 
    [MenuItem("ScriptableObject/Create Sound Collection")]
    static void CreateAsset()
    {
        ScriptableObject asset = ScriptableObject.CreateInstance(typeof(SoundCollection));
        AssetDatabase.CreateAsset(asset, "Assets/New Sound Collection.asset");
        EditorUtility.FocusProjectWindow();
        Selection.activeObject = asset;
    }
#endif
}
