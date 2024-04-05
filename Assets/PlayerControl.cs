using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public Vector2 velocity;
    private bool Movement, Move_left, Move_right, jump;
    void Start()
    {
        
    }
    
    void Update()
    {
        CheckTheInput();
        UpdateThePlayerPos();

    }
    void UpdateThePlayerPos()
    {
        Vector3 pos = transform.localPosition;
        Vector3 scale = transform.localScale;
        if (Movement == true)
        {
            if (Move_left == true)
            {
                pos.x -= velocity.x * Time.deltaTime;
                scale.x = -1;
            }
            if(Move_right == true)
            {
                pos.x += velocity.x *Time.deltaTime;
                scale.x = 1;
            }
        }
        transform.localPosition = pos;
        transform.localScale = scale;

    }
    void CheckTheInput()
    {
        bool input_left = Input.GetKey(KeyCode.LeftArrow);
        bool input_right = Input.GetKey(KeyCode.RightArrow);
        bool input_jump = Input.GetKey(KeyCode.Space);
        Movement = input_left || input_right || input_jump;
        Move_left = input_left && !input_right;
        Move_right = input_right && !input_left;
        jump = input_jump;
    }
}
