using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Danger : MonoBehaviour
{
    private Text text;
    private float alltime;
    [SerializeField] float danger_score;
    // Start is called before the first frame update

    void Start()
    {
        text = this.GetComponent<Text>();
        alltime = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        alltime += Time.deltaTime;
        Debug.Log(Mathf.Sin(alltime));
        danger_score += (Mathf.Sin(alltime)*0.08f) ;   //リアルタイム変動
        danger_score = Mathf.Clamp(danger_score, 0.0f, 100.0f);
        Debug.Log(danger_score);
        text.text = "危険度:"+(int)danger_score+"%";                         //テキスト内容
    }
    public void ScoreAction(int value)
    {
        danger_score = Mathf.Clamp(danger_score + value, 0.0f, 100.0f);
    }
}
