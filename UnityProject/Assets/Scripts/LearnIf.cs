
using UnityEngine;

public class LearnIf : MonoBehaviour
{
    public bool open;
    //這是一個整數值 連擊
    public int Combo;
    private void Start()
    {
        //判斷式if(switch)
        //
    }
    void Update()
    {
        if (Combo>=100)
        {
            print("攻擊4倍");
        }
        else if (Combo>=75)
        {
            print("攻擊3倍");
        }

        else if (Combo >= 50)
        {
            print("攻擊2倍");
        }
        else
        {

        }
    }























}
