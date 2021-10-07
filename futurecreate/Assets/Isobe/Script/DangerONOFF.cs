using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerONOFF : MonoBehaviour
{
    private bool on_off=true;//trueだと表示
    [SerializeField] GameObject danger_score;
    public void OnoffSet()
    {
        on_off = !on_off;//ONOFF切り替え
        danger_score.SetActive(on_off);
    }
}
