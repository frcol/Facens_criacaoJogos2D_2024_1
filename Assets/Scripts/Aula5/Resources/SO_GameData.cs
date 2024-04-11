using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameData_New", menuName = "GameData")]
public class SO_GameData : ScriptableObject, ISerializationCallbackReceiver
{
    public int score = 0;

    void ISerializationCallbackReceiver.OnAfterDeserialize()
    {
        score = 0;
    }

    void ISerializationCallbackReceiver.OnBeforeSerialize()
    {
     
    }
}
