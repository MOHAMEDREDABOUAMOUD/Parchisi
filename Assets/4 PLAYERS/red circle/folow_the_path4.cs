using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class folow_the_path4 : MonoBehaviour
{
    [SerializeField] Transform[] waypoints;
    [SerializeField] Transform[] waypoints1;
    [SerializeField] Transform firstplace;
    [SerializeField] Transform final1;

    public static bool firstmove=false;
    public static bool click = false;
    public static int Length;
    public static bool initpos=false;
    public static int x;
    private void Start()
    {
        transform.position = firstplace.position;
        Dice4.pos= -1;
        x=-1;
        Length=waypoints.Length;
        Dice4.l=Length;
    }

    void Update()
    {
        if (firstmove == true && transform.position == firstplace.position && Dice4.freered)
        {
            if (Dice4.pos1 == 0)
            {
                if(Dice4.pos2!=0 && Dice4.pos3!=0)
                {
                    Dice4.pos = 0;
                    if (Dice4.posLeft1 == true)
                    {
                        transform.position = waypoints[0].position;
                    }
                    else
                    {
                        transform.position = waypoints1[0].position;
                        Dice4.posLeft = true;
                    }
                }
            }
            else if (Dice4.pos2 == 0)
            {
                if(Dice4.pos1!=0 && Dice4.pos3!=0)
                {
                    Dice4.pos = 0;
                    if (Dice4.posLeft2 == true)
                    {
                        transform.position = waypoints[0].position;
                    }
                    else
                    {
                        transform.position = waypoints1[0].position;
                        Dice4.posLeft = true;
                    }
                }
            }
            else if (Dice4.pos3 == 0)
            {
                if(Dice4.pos1!=0 && Dice4.pos2!=0)
                {
                    Dice4.pos = 0;
                    if(Dice4.posLeft3 == true)
                    {
                        transform.position = waypoints[0].position;
                    }
                    else
                    {
                        transform.position = waypoints1[0].position;
                        Dice4.posLeft = true;
                    }
                }
            }
            else
            {
                if(follow_the_path_y14.x==0)
                {
                    Debug.Log("enter eat");
                    if(Dice4.access1==false)
                    {
                        numberImg4.setimg(20);
                        Dice4.access1=Dice4.canaccess(20,1);
                    }
                    else if(Dice4.access2==false)
                    {
                        numberImg14.setimg(20);
                        Dice4.access2=Dice4.canaccess(20,1);
                    }
                    follow_the_path_y14.initpos=true;
                }
                else if(follow_the_path_y_24.x==0)
                {
                    Debug.Log("enter eat");
                    if(Dice4.access1==false)
                    {
                        numberImg4.setimg(20);
                        Dice4.access1=Dice4.canaccess(20,1);
                    }
                    else if(Dice4.access2==false)
                    {
                        numberImg14.setimg(20);
                        Dice4.access2=Dice4.canaccess(20,1);
                    }
                    follow_the_path_y_24.initpos=true;
                }
                else if(follow_the_path_y_34.x==0)
                {
                    Debug.Log("enter eat");
                    if(Dice4.access1==false)
                    {
                        numberImg4.setimg(20);
                        Dice4.access1=Dice4.canaccess(20,1);
                    }
                    else if(Dice4.access2==false)
                    {
                        numberImg14.setimg(20);
                        Dice4.access2=Dice4.canaccess(20,1);
                    }
                    follow_the_path_y_34.initpos=true;
                }
                else  if(follow_the_path_y_44.x==0)
                {
                    Debug.Log("enter eat");
                    if(Dice4.access1==false)
                    {
                        numberImg4.setimg(20);
                        Dice4.access1=Dice4.canaccess(20,1);
                    }
                    else if(Dice4.access2==false)
                    {
                        numberImg14.setimg(20);
                        Dice4.access2=Dice4.canaccess(20,1);
                    }
                    follow_the_path_y_44.initpos=true;
                }
                else if(follow_the_path_g14.x==0)
                {
                    Debug.Log("enter eat");
                    if(Dice4.access1==false)
                    {
                        numberImg4.setimg(20);
                        Dice4.access1=Dice4.canaccess(20,1);
                    }
                    else if(Dice4.access2==false)
                    {
                        numberImg14.setimg(20);
                        Dice4.access2=Dice4.canaccess(20,1);
                    }
                    follow_the_path_g14.initpos=true;
                }
                else if(follow_the_path_g24.x==0)
                {
                    Debug.Log("enter eat");
                    if(Dice4.access1==false)
                    {
                        numberImg4.setimg(20);
                        Dice4.access1=Dice4.canaccess(20,1);
                    }
                    else if(Dice4.access2==false)
                    {
                        numberImg14.setimg(20);
                        Dice4.access2=Dice4.canaccess(20,1);
                    }
                    follow_the_path_g24.initpos=true;
                }
                else if(follow_the_path_g34.x==0)
                {
                    Debug.Log("enter eat");
                    if(Dice4.access1==false)
                    {
                        numberImg4.setimg(20);
                        Dice4.access1=Dice4.canaccess(20,1);
                    }
                    else if(Dice4.access2==false)
                    {
                        numberImg14.setimg(20);
                        Dice4.access2=Dice4.canaccess(20,1);
                    }
                    follow_the_path_g34.initpos=true;
                }
                else if(follow_the_path_g44.x==0)
                {
                    Debug.Log("enter eat");
                    if(Dice4.access1==false)
                    {
                        numberImg4.setimg(20);
                        Dice4.access1=Dice4.canaccess(20,1);
                    }
                    else if(Dice4.access2==false)
                    {
                        numberImg14.setimg(20);
                        Dice4.access2=Dice4.canaccess(20,1);
                    }
                    follow_the_path_g44.initpos=true;
                }
                else if(follow_the_path_b14.x==0)
                {
                    Debug.Log("enter eat");
                    if(Dice4.access1==false)
                    {
                        numberImg4.setimg(20);
                        Dice4.access1=Dice4.canaccess(20,1);
                    }
                    else if(Dice4.access2==false)
                    {
                        numberImg14.setimg(20);
                        Dice4.access2=Dice4.canaccess(20,1);
                    }
                    follow_the_path_b14.initpos=true;
                }
                else if(follow_the_path_b24.x==0)
                {
                    Debug.Log("enter eat");
                    if(Dice4.access1==false)
                    {
                        numberImg4.setimg(20);
                        Dice4.access1=Dice4.canaccess(20,1);
                    }
                    else if(Dice4.access2==false)
                    {
                        numberImg14.setimg(20);
                        Dice4.access2=Dice4.canaccess(20,1);
                    }
                    follow_the_path_b24.initpos=true;
                }
                else if(follow_the_path_b34.x==0)
                {
                    Debug.Log("enter eat");
                    if(Dice4.access1==false)
                    {
                        numberImg4.setimg(20);
                        Dice4.access1=Dice4.canaccess(20,1);
                    }
                    else if(Dice4.access2==false)
                    {
                        numberImg14.setimg(20);
                        Dice4.access2=Dice4.canaccess(20,1);
                    }
                    follow_the_path_b34.initpos=true;
                }
                else if(follow_the_path_b44.x==0)
                {
                    Debug.Log("enter eat");
                    if(Dice4.access1==false)
                    {
                        numberImg4.setimg(20);
                        Dice4.access1=Dice4.canaccess(20,1);
                    }
                    else if(Dice4.access2==false)
                    {
                        numberImg14.setimg(20);
                        Dice4.access2=Dice4.canaccess(20,1);
                    }
                    follow_the_path_b44.initpos=true;
                }
                else
                {
                    Dice4.pos = 0;
                    transform.position = waypoints[0].position;
                }
            }
            x=0;
            if(folow_the_path14.firstmove1==false && folow_the_path24.firstmove2==false && folow_the_path34.firstmove3==false) Dice4.freered=false;
            firstmove=false;
        }
        else if(initpos==true)
        {
            transform.position = firstplace.position;
            Dice4.pos= -1;
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
        if(Dice4.accessred)
        {
            if (Dice4.pos >= 0)
            {
                if(numberImg4.show==true)
                {
                    numberImg4.hideimg();numberImg4.show = false;///////////////
                    numberImg14.hideimg(); numberImg14.show = false;//////////////
                    Dice4.selected = 0;
                }
                else
                {
                    numberImg4.showimg();numberImg4.show = true;///////////////
                    numberImg14.showimg(); numberImg14.show = true;/////////////////
                    Dice4.selected = 1;
                }
            }    
        }
        
    }

    IEnumerator move()
    {
        if(Dice4.pos + Dice4.nbr == waypoints.Length)
        {
            numberImg4.hideimg();numberImg4.show = false;////////////////
            numberImg14.hideimg();numberImg14.show = false;///////////////////
            Dice4.posLeft = false;
            for (int i =Dice4.pos;i<Dice4.pos + Dice4.nbr; i++)
            {
                transform.position = waypoints[i].position;
                yield return new WaitForSeconds(0.1f);
            }
            transform.position=final1.position;
            Dice4.pos= Dice4.pos + Dice4.nbr;
            x=x+Dice4.nbr;
            if(Dice4.access1==false)
            {
                numberImg4.setimg(10);
                Dice4.access1=Dice4.canaccess(10,1);
            }
            else if(Dice4.access2==false)
            {
                numberImg14.setimg(10);
                Dice4.access2=Dice4.canaccess(10,1);
            }
            Dice4.enterr++;
        }
        else if (Dice4.pos + Dice4.nbr <= waypoints.Length - 1)
        {
            numberImg4.hideimg();numberImg4.show = false;////////////////
            numberImg14.hideimg();numberImg14.show = false;///////////////////
            Dice4.posLeft = false;
            for (int i =Dice4.pos;i<= Dice4.pos + Dice4.nbr ; i++)
            {
                transform.position = waypoints[i].position;
                yield return new WaitForSeconds(0.1f);
            }
            Dice4.pos =Dice4.pos + Dice4.nbr;
            for(int i=1;i<=Dice4.nbr;i++)
            {
                if(x<63)
                {
                    x++;
                }
                else x=100;
            }
            if (Dice4.pos1 == Dice4.pos)
            {
                if (Dice4.posLeft1 == true)
                {
                    transform.position = waypoints[Dice4.pos].position;
                }
                else
                {
                    transform.position = waypoints1[Dice4.pos].position;
                    Dice4.posLeft = true;
                }
            }
            else if (Dice4.pos2 == Dice4.pos)
            {
                if (Dice4.posLeft2 == true)
                {
                    transform.position = waypoints[Dice4.pos].position;
                }
                else
                {
                    transform.position = waypoints1[Dice4.pos].position;
                    Dice4.posLeft = true;
                }
            }
            else if (Dice4.pos3 == Dice4.pos)
            {
                if (Dice4.posLeft3 == true)
                {
                    transform.position = waypoints[Dice4.pos].position;
                }
                else
                {
                    transform.position = waypoints1[Dice4.pos].position;
                    Dice4.posLeft = true;
                }
            }
            if(x==follow_the_path_y14.x)
            {
                Debug.Log("enter eat");
                if(Dice4.access1==false)
                {
                    numberImg4.setimg(20);
                    Dice4.access1=Dice4.canaccess(20,1);
                }
                else if(Dice4.access2==false)
                {
                    numberImg14.setimg(20);
                    Dice4.access2=Dice4.canaccess(20,1);
                }
                follow_the_path_y14.initpos=true;
            }
            else if(x==follow_the_path_y_24.x)
            {
                Debug.Log("enter eat");
                if(Dice4.access1==false)
                {
                    numberImg4.setimg(20);
                    Dice4.access1=Dice4.canaccess(20,1);
                }
                else if(Dice4.access2==false)
                {
                    numberImg14.setimg(20);
                    Dice4.access2=Dice4.canaccess(20,1);
                }
                follow_the_path_y_24.initpos=true;
            }
            else if(x==follow_the_path_y_3.x)
            {
                Debug.Log("enter eat");
                if(Dice4.access1==false)
                {
                    numberImg4.setimg(20);
                    Dice4.access1=Dice4.canaccess(20,1);
                }
                else if(Dice4.access2==false)
                {
                    numberImg14.setimg(20);
                    Dice4.access2=Dice4.canaccess(20,1);
                }
                follow_the_path_y_3.initpos=true;
            }
            else  if(x==follow_the_path_y_44.x)
            {
                Debug.Log("enter eat");
                if(Dice4.access1==false)
                {
                    numberImg4.setimg(20);
                    Dice4.access1=Dice4.canaccess(20,1);
                }
                else if(Dice4.access2==false)
                {
                    numberImg14.setimg(20);
                    Dice4.access2=Dice4.canaccess(20,1);
                }
                follow_the_path_y_44.initpos=true;
            }
            else if(x==follow_the_path_g14.x)
            {
                Debug.Log("enter eat");
                if(Dice4.access1==false)
                {
                    numberImg4.setimg(20);
                    Dice4.access1=Dice4.canaccess(20,1);
                }
                else if(Dice4.access2==false)
                {
                    numberImg14.setimg(20);
                    Dice4.access2=Dice4.canaccess(20,1);
                }
                follow_the_path_g14.initpos=true;
            }
            else if(x==follow_the_path_g24.x)
            {
                Debug.Log("enter eat");
                if(Dice4.access1==false)
                {
                    numberImg4.setimg(20);
                    Dice4.access1=Dice4.canaccess(20,1);
                }
                else if(Dice4.access2==false)
                {
                    numberImg14.setimg(20);
                    Dice4.access2=Dice4.canaccess(20,1);
                }
                follow_the_path_g24.initpos=true;
            }
            else if(x==follow_the_path_g34.x)
            {
                Debug.Log("enter eat");
                if(Dice4.access1==false)
                {
                    numberImg4.setimg(20);
                    Dice4.access1=Dice4.canaccess(20,1);
                }
                else if(Dice4.access2==false)
                {
                    numberImg14.setimg(20);
                    Dice4.access2=Dice4.canaccess(20,1);
                }
                follow_the_path_g34.initpos=true;
            }
            else if(x==follow_the_path_g44.x)
            {
                Debug.Log("enter eat");
                if(Dice4.access1==false)
                {
                    numberImg4.setimg(20);
                    Dice4.access1=Dice4.canaccess(20,1);
                }
                else if(Dice4.access2==false)
                {
                    numberImg14.setimg(20);
                    Dice4.access2=Dice4.canaccess(20,1);
                }
                follow_the_path_g44.initpos=true;
            }
            else if(x==follow_the_path_b14.x)
            {
                Debug.Log("enter eat");
                if(Dice4.access1==false)
                {
                    numberImg4.setimg(20);
                    Dice4.access1=Dice4.canaccess(20,1);
                }
                else if(Dice4.access2==false)
                {
                    numberImg14.setimg(20);
                    Dice4.access2=Dice4.canaccess(20,1);
                }
                follow_the_path_b14.initpos=true;
            }
            else if(x==follow_the_path_b24.x)
            {
                Debug.Log("enter eat");
                if(Dice4.access1==false)
                {
                    numberImg4.setimg(20);
                    Dice4.access1=Dice4.canaccess(20,1);
                }
                else if(Dice4.access2==false)
                {
                    numberImg14.setimg(20);
                    Dice4.access2=Dice4.canaccess(20,1);
                }
                follow_the_path_b24.initpos=true;
            }
            else if(x==follow_the_path_b34.x)
            {
                Debug.Log("enter eat");
                if(Dice4.access1==false)
                {
                    numberImg4.setimg(20);
                    Dice4.access1=Dice4.canaccess(20,1);
                }
                else if(Dice4.access2==false)
                {
                    numberImg14.setimg(20);
                    Dice4.access2=Dice4.canaccess(20,1);
                }
                follow_the_path_b34.initpos=true;
            }
            else if(x==follow_the_path_b44.x)
            {
                Debug.Log("enter eat");
                if(Dice4.access1==false)
                {
                    numberImg4.setimg(20);
                    Dice4.access1=Dice4.canaccess(20,1);
                }
                else if(Dice4.access2==false)
                {
                    numberImg14.setimg(20);
                    Dice4.access2=Dice4.canaccess(20,1);
                }
                follow_the_path_b44.initpos=true;
            }
            //transform.position = waypoints[Dice4.pos + nbr].position;
            //transform.position = Vector2.MoveTowards(transform.position,waypoints[Dice4.pos + nbr].position, movspeed );
        }
    }
}
