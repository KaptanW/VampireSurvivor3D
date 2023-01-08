using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MESSEGESYSTEM : MonoBehaviour
{
    [SerializeField] GameObject damageMessage;
    string text;
    public static MESSEGESYSTEM instance;

    public void PostMessage(string test, Vector3 worldPosition){
        GameObject go = Instantiate(damageMessage, transform);
        go.transform.position = worldPosition;
        go.GetComponent<TMPro.TextMeshPro>().text = text;
    }
}
