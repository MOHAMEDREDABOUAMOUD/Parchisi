using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class follow_the_path_y_42 : MonoBehaviour
{
    [SerializeField] Transform[] waypoints;
    [SerializeField] Transform[] waypoints1;
    [SerializeField] Transform firstplace3;
    [SerializeField] Transform final4;
    public static bool firstmove3=false;
    public static bool click =false;
    public static int Length;
    public static bool initpos=false;
    public static int x;
    // Start is called before the first frame update
    private void Start()
    {
        transform.position = firstplace3.position;
        Dice2.posy3 = -1;
        x=-1;
        Length=waypoints.Length;
    }

    
    void Update()
    {
        if (firstmove3 == true && transform.position == firstplace3.position && Dice2.freeyellow)
        {
            if (Dice2.posy == 0)
            {
                if(Dice2.posy1!=0 && Dice2.posy2!=0)
                {
                    Dice2.posy3 = 0;
                    if (Dice2.posyLeft == true)
                    {
                        transform.position = waypoints[0].position;
                    }
                    else
                    {
                        transform.position = waypoints1[0].position;
                        Dice2.posyLeft3 = true;
                    }
                }
            }
            else if (Dice2.posy1 == 0)
            {
                if(Dice2.posy!=0 && Dice2.posy2!=0)
                {
                    Dice2.posy3 = 0;
                    if (Dice2.posyLeft1 == true)
                    {
                        transform.position = waypoints[0].position;
                    }
                    else
                    {
                        transform.position = waypoints1[0].position;
                        Dice2.posyLeft3 = true;
                    }
                }
            }
            else if (Dice2.posy2 == 0)
            {
                if(Dice2.posy!=0 && Dice2.posy1!=0)
                {
                    Dice2.posy3 = 0;
                    if (Dice2.posyLeft2 == true)
                    {
                        transform.position = waypoints[0].position;
                    }
                    else
                    {
                        transform.position = waypoints1[0].position;
                        Dice2.posyLeft3 = true;
                    }
                }
            }
            else
            {
                if(folow_the_pathr2.x==34)
                {
                    Debug.Log("enter eat");
                    if(Dice2.access1==false)
                    {
                        numberImg2.setimg(20);
                        Dice2.access1=true;
                    }
                    else if(Dice2.access2==false)
                    {
                        numberImg12.setimg(20);
                        Dice2.access2=true;
                    }
                    folow_the_pathr2.initpos=true;
                }
                else if(folow_the_path12.x==34)
                {
                    Debug.Log("enter eat");
                    if(Dice2.access1==false)
                    {
                        numberImg2.setimg(20);
                        Dice2.access1=true;
                    }
                    else if(Dice2.access2==false)
                    {
                        numberImg12.setimg(20);
                        Dice2.access2=true;
                    }
                    folow_the_path12.initpos=true;
                }
                else if(folow_the_path22.x==34)
                {
                    Debug.Log("enter eat");
                    if(Dice2.access1==false)
                    {
                        numberImg2.setimg(20);
                        Dice2.access1=true;
                    }
                    else if(Dice2.access2==false)
                    {
                        numberImg12.setimg(20);
                        Dice2.access2=true;
                    }
                    folow_the_path22.initpos=true;
                }
                else if(folow_the_path32.x==34)
                {
                    Debug.Log("enter eat");
                    if(Dice2.access1==false)
                    {
                        numberImg2.setimg(20);
                        Dice2.access1=true;
                    }
                    else if(Dice2.access2==false)
                    {
                        numberImg12.setimg(20);
                        Dice2.access2=true;
                    }
                    folow_the_path32.initpos=true;
                }
                else
                {
                    Dice2.posy3 = 0;
                    transform.position = waypoints[0].position;    
                }
            }
            x=34;
            if(follow_the_path_y_22.firstmove1==false && follow_the_path_y_32.firstmove2==false && follow_the_path_y12.firstmove==false) Dice2.freeyellow=false;
            firstmove3=false;
        }
        else if(initpos==true)
        {
            transform.position = firstplace3.position;
            Dice2.posy3= -1;
            x=-1;
            initpos=false;
        }
        else if (click == true && transform.position!=firstplace3.position)
        {
            StartCoroutine(move());
            click = false;
        }
    }
    private void OnMouseDown()
    {
        if(Dice2.accessyellow)
        {
            if (Dice2.posy >= 0)
            {
                if (numberImg2.show == true)
                {
                    numberImg2.hideimg(); numberImg2.show = false;///////////////
                    numberImg12.hideimg(); numberImg12.show = false;//////////////
                    Dice2.selectedy = 0;
                }
                else
                {
                    numberImg2.showimg(); numberImg2.show = true;///////////////
                    numberImg12.showimg(); numberImg12.show = true;/////////////////
                    Dice2.selectedy = 4;
                }
            }    
        }
    }
    IEnumerator move()
    {
        if(Dice2.posy3 + Dice2.nbr == waypoints.Length)
        {
            numberImg2.hideimg();numberImg2.show = false;////////////////
            numberImg12.hideimg();numberImg12.show = false;///////////////////
            Dice2.posyLeft = false;
            for (int i =Dice2.posy3;i< Dice2.posy3 + Dice2.nbr ; i++)
            {
                transform.position = waypoints[i].position;
                yield return new WaitForSeconds(0.5f);
            }
            Dice2.posy3= Dice2.posy3 + Dice2.nbr;
            x=x+ Dice2.nbr;
            transform.position = final4.position;
            if(Dice2.access1==false)
            {
                numberImg2.setimg(10);
                Dice2.access1=true;
            }
            else if(Dice2.access2==false)
            {
                numberImg12.setimg(10);
                Dice2.access2=true;
            }
            Dice2.entery++;
        }
        else if (Dice2.posy3 + Dice2.nbr <= waypoints.Length - 1)
        {
            numberImg2.hideimg(); numberImg2.show = false;////////////////
            numberImg12.hideimg(); numberImg12.show = false;///////////////////
            Dice2.posyLeft3 = false;
            for (int i =Dice2.posy3 ;i<= Dice2.posy3 + Dice2.nbr; i++)
            {
                transform.position = waypoints[i].position;
                yield return new WaitForSeconds(0.1f);
            }
            Dice2.posy3 += Dice2.nbr;
            if(x==68)
                {
                    x=0;
                    x++;  
                }
                else if(Dice2.posy3<63)
                {
                    x++;  
                }
            if (Dice2.posy == Dice2.posy3)
            {
                if (Dice2.posyLeft == true)
                {
                    transform.position = waypoints[Dice2.posy3].position;
                }
                else
                {
                    transform.position = waypoints1[Dice2.posy3].position;
                    Dice2.posyLeft3 = true;
                }
            }
            else if (Dice2.posy1 == Dice2.posy3)
            {
                if (Dice2.posyLeft1 == true)
                {
                    transform.position = waypoints[Dice2.posy3].position;
                }
                else
                {
                    transform.position = waypoints1[Dice2.posy3].position;
                    Dice2.posyLeft3 = true;
                }
            }
            else if (Dice2.posy2 == Dice2.posy3)
            {
                if (Dice2.posyLeft2 == true)
                {
                    transform.position = waypoints[Dice2.posy3].position;
                }
                else
                {
                    transform.position = waypoints1[Dice2.posy3].position;
                    Dice2.posyLeft3 = true;
                }
            }
            if(x==folow_the_pathr2.x)
            {
                Debug.Log("enter eat");
                if(Dice2.access1==false)
                {
                    numberImg2.setimg(20);
                    Dice2.access1=true;
                }
                else if(Dice2.access2==false)
                {
                    numberImg12.setimg(20);
                    Dice2.access2=true;
                }
                folow_the_pathr2.initpos=true;
            }
            else if(x==folow_the_path12.x)
            {
                Debug.Log("enter eat");
                if(Dice2.access1==false)
                {
                    numberImg2.setimg(20);
                    Dice2.access1=true;
                }
                else if(Dice2.access2==false)
                {
                    numberImg12.setimg(20);
                    Dice2.access2=true;
                }
                folow_the_path12.initpos=true;
            }
            else if(x==folow_the_path22.x)
            {
                Debug.Log("enter eat");
                if(Dice2.access1==false)
                {
                    numberImg2.setimg(20);
                    Dice2.access1=true;
                }
                else if(Dice2.access2==false)
                {
                    numberImg12.setimg(20);
                    Dice2.access2=true;
                }
                folow_the_path22.initpos=true;
            }
            else  if(x==folow_the_path32.x)
            {
                Debug.Log("enter eat");
                if(Dice2.access1==false)
                {
                    numberImg2.setimg(20);
                    Dice2.access1=true;
                }
                else if(Dice2.access2==false)
                {
                    numberImg12.setimg(20);
                    Dice2.access2=true;
                }
                folow_the_path32.initpos=true;
            }
            //transform.position = waypoints[waypointsIndex + nbr].position;
            //transform.position = Vector2.MoveTowards(transform.position,waypoints[waypointsIndex + nbr].position, movspeed );
            
        }
    }
}
