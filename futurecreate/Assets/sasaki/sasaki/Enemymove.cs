using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemymove : MonoBehaviour
{
    NavMeshAgent Player_Nav;
    GameObject Player;    
    
    // Start is called before the first frame update
    void Start()
    {
        //プレイヤーのNavMeshAgentを取得
        Player_Nav = GetComponent<NavMeshAgent>();
        //目的地のオブジェクトを取得
        Player = GameObject.Find("Player" );
    }

    // Update is called once per frame
    void Update()
    {
        //目的地を設定
        Player_Nav.SetDestination(Player.transform.position);
    }
}
