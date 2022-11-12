using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class folow_the_path : MonoBehaviour
{
    [SerializeField] Transform[] waypoints;
    [SerializeField] Transform[] waypoints1;
    [SerializeField] Transform firstplace;
    [SerializeField] Transform final1;
    Transform pts;

    public static bool allowMove = false,firstmove=false;
    public static bool click = false;
    public static int Length;
    public static bool initpos=false;
    public static int x;
    private void Start()
    {
        transform.position = firstplace.position;
        Dice.pos= -1;
        x=-1;
        Length=waypoints.Length;
        Dice.l=Length;
    }

    void Update()
    {
        if (firstmove == true && transform.position == firstplace.position && Dice.freered)
        {
            if (Dice.pos1 == 0)
            {
                if(Dice.pos2!=0 && Dice.pos3!=0)
                {
                    Dice.pos = 0;
                    if (Dice.posLeft1 == true)
                    {
                        transform.position = waypoints[0].position;
                    }
                    else
                    {
                        transform.position = waypoints1[0].position;
                        Dice.posLeft = true;
                    }
                }
            }
            else if (Dice.pos2 == 0)
            {
                if(Dice.pos1!=0 && Dice.pos3!=0)
                {
                    Dice.pos = 0;
                    if (Dice.posLeft2 == true)
                    {
                        transform.position = waypoints[0].position;
                    }
                    else
                    {
                        transform.position = waypoints1[0].position;
                        Dice.posLeft = true;
                    }
                }
            }
            else if (Dice.pos3 == 0)
            {
                if(Dice.pos1!=0 && Dice.pos2!=0)
                {
                    Dice.pos = 0;
                    if(Dice.posLeft3 == true)
                    {
                        transform.position = waypoints[0].position;
                    }
                    else
                    {
                        transform.position = waypoints1[0].position;
                        Dice.posLeft = true;
                    }
                }
            }
            else
            {
                if(follow_the_path_y1.x==0)
                {
                    Debug.Log("enter eat");
                    if(Dice.access1==false)
                    {
                        numberImg.setimg(20);
                        Dice.access1=Dice.canaccess(20,1);
                    }
                    else if(Dice.access2==false)
                    {
                        numberImg1.setimg(20);
                        Dice.access2=Dice.canaccess(20,1);
                    }
                    follow_the_path_y1.initpos=true;
                }
                else if(follow_the_path_y_2.x==0)
                {
                    Debug.Log("enter eat");
                    if(Dice.access1==false)
                    {
                        numberImg.setimg(20);
                        Dice.access1=Dice.canaccess(20,1);
                    }
                    else if(Dice.access2==false)
                    {
                        numberImg1.setimg(20);
                        Dice.access2=Dice.canaccess(20,1);
                    }
                    follow_the_path_y_2.initpos=true;
                }
                else if(follow_the_path_y_3.x==0)
                {
                    Debug.Log("enter eat");
                    if(Dice.access1==false)
                    {
                        numberImg.setimg(20);
                        Dice.access1=Dice.canaccess(20,1);
                    }
                    else if(Dice.access2==false)
                    {
                        numberImg1.setimg(20);
                        Dice.access2=Dice.canaccess(20,1);
                    }
                    follow_the_path_y_3.initpos=true;
                }
                else  if(follow_the_path_y_4.x==0)
                {
                    Debug.Log("enter eat");
                    if(Dice.access1==false)
                    {
                        numberImg.setimg(20);
                        Dice.access1=Dice.canaccess(20,1);
                    }
                    else if(Dice.access2==false)
                    {
                        numberImg1.setimg(20);
                        Dice.access2=Dice.canaccess(20,1);
                    }
                    follow_the_path_y_4.initpos=true;
                }
                else if(follow_the_path_g1.x==0)
                {
                    Debug.Log("enter eat");
                    if(Dice.access1==false)
                    {
                        numberImg.setimg(20);
                        Dice.access1=Dice.canaccess(20,1);
                    }
                    else if(Dice.access2==false)
                    {
                        numberImg1.setimg(20);
                        Dice.access2=Dice.canaccess(20,1);
                    }
                    follow_the_path_g1.initpos=true;
                }
                else if(follow_the_path_g2.x==0)
                {
                    Debug.Log("enter eat");
                    if(Dice.access1==false)
                    {
                        numberImg.setimg(20);
                        Dice.access1=Dice.canaccess(20,1);
                    }
                    else if(Dice.access2==false)
                    {
                        numberImg1.setimg(20);
                        Dice.access2=Dice.canaccess(20,1);
                    }
                    follow_the_path_g2.initpos=true;
                }
                else if(follow_the_path_g3.x==0)
                {
                    Debug.Log("enter eat");
                    if(Dice.access1==false)
                    {
                        numberImg.setimg(20);
                        Dice.access1=Dice.canaccess(20,1);
                    }
                    else if(Dice.access2==false)
                    {
                        numberImg1.setimg(20);
                        Dice.access2=Dice.canaccess(20,1);
                    }
                    follow_the_path_g3.initpos=true;
                }
                else if(follow_the_path_g4.x==0)
                {
                    Debug.Log("enter eat");
                    if(Dice.access1==false)
                    {
                        numberImg.setimg(20);
                        Dice.access1=Dice.canaccess(20,1);
                    }
                    else if(Dice.access2==false)
                    {
                        numberImg1.setimg(20);
                        Dice.access2=Dice.canaccess(20,1);
                    }
                    follow_the_path_g4.initpos=true;
                }
                else
                {
                    Dice.pos = 0;
                    transform.position = waypoints[0].position;
                }
            }
            x=0;
            if(folow_the_path1.firstmove1==false && folow_the_path2.firstmove2==false && folow_the_path3.firstmove3==false) Dice.freered=false;
            firstmove=false;
        }
        else if(initpos==true)
        {
            transform.position = firstplace.position;
            Dice.pos= -1;
            x=-1;
            initpos=false;
        }
        else if (click == true && transform.position!=firstplace.position)
        {
            StartCoroutine(move());
            click = false;
        }
    }
    private void OnMouseDown()
    {
        if(Dice.accessred)
        {
            if (Dice.pos >= 0)
            {
                if(numberImg.show==true)
                {
                    numberImg.hideimg();numberImg.show = false;///////////////
                    numberImg1.hideimg(); numberImg1.show = false;//////////////
                    Dice.selected = 0;
                }
                else
                {
                    numberImg.showimg();numberImg.show = true;///////////////
                    numberImg1.showimg(); numberImg1.show = true;/////////////////
                    Dice.selected = 1;
                }
            }    
        }
        
    }

    IEnumerator move()
    {
        if(Dice.pos + Dice.nbr == waypoints.Length)
        {
            numberImg.hideimg();numberImg.show = false;////////////////
            numberImg1.hideimg();numberImg1.show = false;///////////////////
            Dice.posLeft = false;
            for (int i =Dice.pos;i<Dice.pos + Dice.nbr; i++)
            {
                transform.position = waypoints[i].position;
                yield return new WaitForSeconds(0.1f);
            }
            transform.position=final1.position;
            Dice.pos= Dice.pos + Dice.nbr;
            x=x+Dice.nbr;
            if(Dice.access1==false)
            {
                numberImg.setimg(10);
                Dice.access1=Dice.canaccess(10,1);
            }
            else if(Dice.access2==false)
            {
                numberImg1.setimg(10);
                Dice.access2=Dice.canaccess(10,1);
            }
            Dice.enterr++;
        }
        else if (Dice.pos + Dice.nbr <= waypoints.Length - 1)
        {
            numberImg.hideimg();numberImg.show = false;////////////////
            numberImg1.hideimg();numberImg1.show = false;///////////////////
            Dice.posLeft = false;
            for (int i =Dice.pos;i<= Dice.pos + Dice.nbr ; i++)
            {
                transform.position = waypoints[i].position;
                yield return new WaitForSeconds(0.1f);
            }
            Dice.pos =Dice.pos + Dice.nbr;
            for(int i=1;i<=Dice.nbr;i++)
            {
                if(x<63)
                {
                    x++;
                }
            }
            if (Dice.pos1 == Dice.pos)
            {
                if (Dice.posLeft1 == true)
                {
                    transform.position = waypoints[Dice.pos].position;
                }
                else
                {
                    transform.position = waypoints1[Dice.pos].position;
                    Dice.posLeft = true;
                }
            }
            else if (Dice.pos2 == Dice.pos)
            {
                if (Dice.posLeft2 == true)
                {
                    transform.position = waypoints[Dice.pos].position;
                }
                else
                {
                    transform.position = waypoints1[Dice.pos].position;
                    Dice.posLeft = true;
                }
            }
            else if (Dice.pos3 == Dice.pos)
            {
                if (Dice.posLeft3 == true)
                {
                    transform.position = waypoints[Dice.pos].position;
                }
                else
                {
                    transform.position = waypoints1[Dice.pos].position;
                    Dice.posLeft = true;
                }
            }
            if(x==follow_the_path_y1.x)
            {
                Debug.Log("enter eat");
                if(Dice.access1==false)
                {
                    numberImg.setimg(20);
                    Dice.access1=Dice.canaccess(20,1);
                }
                else if(Dice.access2==false)
                {
                    numberImg1.setimg(20);
                    Dice.access2=Dice.canaccess(20,1);
                }
                follow_the_path_y1.initpos=true;
            }
            else if(x==follow_the_path_y_2.x)
            {
                Debug.Log("enter eat");
                if(Dice.access1==false)
                {
                    numberImg.setimg(20);
                    Dice.access1=Dice.canaccess(20,1);
                }
                else if(Dice.access2==false)
                {
                    numberImg1.setimg(20);
                    Dice.access2=Dice.canaccess(20,1);
                }
                follow_the_path_y_2.initpos=true;
            }
            else if(x==follow_the_path_y_3.x)
            {
                Debug.Log("enter eat");
                if(Dice.access1==false)
                {
                    numberImg.setimg(20);
                    Dice.access1=Dice.canaccess(20,1);
                }
                else if(Dice.access2==false)
                {
                    numberImg1.setimg(20);
                    Dice.access2=Dice.canaccess(20,1);
                }
                follow_the_path_y_3.initpos=true;
            }
            else  if(x==follow_the_path_y_4.x)
            {
                Debug.Log("enter eat");
                if(Dice.access1==false)
                {
                    numberImg.setimg(20);
                    Dice.access1=Dice.canaccess(20,1);
                }
                else if(Dice.access2==false)
                {
                    numberImg1.setimg(20);
                    Dice.access2=Dice.canaccess(20,1);
                }
                follow_the_path_y_4.initpos=true;
            }
            else if(x==follow_the_path_g1.x)
            {
                Debug.Log("enter eat");
                if(Dice.access1==false)
                {
                    numberImg.setimg(20);
                    Dice.access1=Dice.canaccess(20,1);
                }
                else if(Dice.access2==false)
                {
                    numberImg1.setimg(20);
                    Dice.access2=Dice.canaccess(20,1);
                }
                follow_the_path_g1.initpos=true;
            }
            else if(x==follow_the_path_g2.x)
            {
                Debug.Log("enter eat");
                if(Dice.access1==false)
                {
                    numberImg.setimg(20);
                    Dice.access1=Dice.canaccess(20,1);
                }
                else if(Dice.access2==false)
                {
                    numberImg1.setimg(20);
                    Dice.access2=Dice.canaccess(20,1);
                }
                follow_the_path_g2.initpos=true;
            }
            else if(x==follow_the_path_g3.x)
            {
                Debug.Log("enter eat");
                if(Dice.access1==false)
                {
                    numberImg.setimg(20);
                    Dice.access1=Dice.canaccess(20,1);
                }
                else if(Dice.access2==false)
                {
                    numberImg1.setimg(20);
                    Dice.access2=Dice.canaccess(20,1);
                }
                follow_the_path_g3.initpos=true;
            }
            else if(x==follow_the_path_g4.x)
            {
                Debug.Log("enter eat");
                if(Dice.access1==false)
                {
                    numberImg.setimg(20);
                    Dice.access1=Dice.canaccess(20,1);
                }
                else if(Dice.access2==false)
                {
                    numberImg1.setimg(20);
                    Dice.access2=Dice.canaccess(20,1);
                }
                follow_the_path_g4.initpos=true;
            }
            //transform.position = waypoints[Dice.pos + nbr].position;
            //transform.position = Vector2.MoveTowards(transform.position,waypoints[Dice.pos + nbr].position, movspeed );
        }
    }
}
