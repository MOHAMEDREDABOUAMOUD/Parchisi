using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class folow_the_path32 : MonoBehaviour
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
    private void Start()
    {
        transform.position = firstplace3.position;
        Dice2.pos3 = -1;
        x=-1;
        Length=waypoints.Length;
    }

    void Update()
    {
        if (firstmove3 == true && transform.position == firstplace3.position && Dice2.freered)
        {
            if (Dice2.pos == 0)
            {
                if(Dice2.pos1!=0 && Dice2.pos2!=0)
                {
                    Dice2.pos3 = 0;
                    if (Dice2.posLeft == true)
                    {
                        transform.position = waypoints[0].position;
                    }
                    else
                    {
                        transform.position = waypoints1[0].position;
                        Dice2.posLeft3 = true;
                    }
                }
            }
            else if (Dice2.pos1 == 0)
            {
                if(Dice2.pos!=0 && Dice2.pos2!=0)
                {
                    Dice2.pos3 = 0;
                    if (Dice2.posLeft1 == true)
                    {
                        transform.position = waypoints[0].position;
                    }
                    else
                    {
                        transform.position = waypoints1[0].position;
                        Dice2.posLeft3 = true;
                    }
                }
            }
            else if (Dice2.pos2 == 0)
            {
                if(Dice2.pos!=0 && Dice2.pos1!=0)
                {
                    Dice2.pos3 = 0;
                    if (Dice2.posLeft2 == true)
                    {
                        transform.position = waypoints[0].position;
                    }
                    else
                    {
                        transform.position = waypoints1[0].position;
                        Dice2.posLeft3 = true;
                    }
                }
            }
            else
            {
                if(follow_the_path_y12.x==0)
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
                    follow_the_path_y12.initpos=true;
                }
                else if(follow_the_path_y_22.x==0)
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
                    follow_the_path_y_22.initpos=true;
                }
                else if(follow_the_path_y_32.x==0)
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
                    follow_the_path_y_32.initpos=true;
                }
                else  if(follow_the_path_y_42.x==0)
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
                    follow_the_path_y_42.initpos=true;
                }
                else
                {
                    Dice2.pos3 = 0;
                    transform.position = waypoints[0].position;    
                }
                
            }
            x=0;
            if(folow_the_path12.firstmove1==false && folow_the_path22.firstmove2==false && folow_the_pathr2.firstmove==false) Dice2.freered=false;
            firstmove3=false;
        }
        else if(initpos==true)
        {
            transform.position = firstplace3.position;
            Dice2.pos3= -1;
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
        if(Dice2.accessred)
        {
            if (Dice2.pos >= 0)
            {
                if (numberImg2.show == true)
                {
                    numberImg2.hideimg(); numberImg2.show = false;///////////////
                    numberImg12.hideimg(); numberImg12.show = false;//////////////
                    Dice2.selected = 0;
                }
                else
                {
                    numberImg2.showimg(); numberImg2.show = true;///////////////
                    numberImg12.showimg(); numberImg12.show = true;/////////////////
                    Dice2.selected = 4;
                }
            }    
        }
        
    }
    IEnumerator move()
    {
        if(Dice2.pos3 + Dice2.nbr == waypoints.Length)
        {
            numberImg2.hideimg();numberImg2.show = false;////////////////
            numberImg12.hideimg();numberImg12.show = false;///////////////////
            Dice2.posLeft = false;
            for (int i =Dice2.pos3;i< Dice2.pos3 + Dice2.nbr ; i++)
            {
                transform.position = waypoints[i].position;
                yield return new WaitForSeconds(0.5f);
            }
            Dice2.pos3= Dice2.pos3 + Dice2.nbr;
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
            Dice2.enterr++;
        }
        else if (Dice2.pos3 + Dice2.nbr <= waypoints.Length - 1)
        {
            numberImg2.hideimg(); numberImg2.show = false;////////////////
            numberImg12.hideimg(); numberImg12.show = false;///////////////////
            Dice2.posLeft3 = false;
            for (int i =Dice2.pos3 ;i<= Dice2.pos3 + Dice2.nbr; i++)
            {
                transform.position = waypoints[i].position;
                yield return new WaitForSeconds(0.1f);
            }
            Dice2.pos3 += Dice2.nbr;
            for(int i=1;i<=Dice2.nbr;i++)
            {
                if(x<63)
                {
                    x++;  
                }
            }
            if (Dice2.pos == Dice2.pos3)
            {
                if (Dice2.posLeft == true)
                {
                    transform.position = waypoints[Dice2.pos3].position;
                }
                else
                {
                    transform.position = waypoints1[Dice2.pos3].position;
                    Dice2.posLeft3 = true;
                }
            }
            else if (Dice2.pos1 == Dice2.pos3)
            {
                if (Dice2.posLeft1 == true)
                {
                    transform.position = waypoints[Dice2.pos3].position;
                }
                else
                {
                    transform.position = waypoints1[Dice2.pos3].position;
                    Dice2.posLeft3 = true;
                }
            }
            else if (Dice2.pos2 == Dice2.pos3)
            {
                if (Dice2.posLeft2 == true)
                {
                    transform.position = waypoints[Dice2.pos3].position;
                }
                else
                {
                    transform.position = waypoints1[Dice2.pos3].position;
                    Dice2.posLeft3 = true;
                }
            }
            if(x==follow_the_path_y12.x)
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
                follow_the_path_y12.initpos=true;
            }
            else if(x==follow_the_path_y_22.x)
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
                follow_the_path_y_22.initpos=true;
            }
            else if(x==follow_the_path_y_32.x)
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
                follow_the_path_y_32.initpos=true;
            }
            else  if(x==follow_the_path_y_42.x)
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
                follow_the_path_y_42.initpos=true;
            }
            //transform.position = waypoints[waypointsIndex + nbr].position;
            //transform.position = Vector2.MoveTowards(transform.position,waypoints[waypointsIndex + nbr].position, movspeed );
            
        }
    }
}
