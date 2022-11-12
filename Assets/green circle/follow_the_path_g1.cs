using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class follow_the_path_g1 : MonoBehaviour
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
        Dice.posg= -1;
        x=-1;
        Length=waypoints.Length;
    }
    void Update()
    {
        if (firstmove == true && transform.position == firstplace.position && Dice.freegreen)
        {
            if (Dice.posg1 == 0)
            {
                if(Dice.posg2!=0 && Dice.posg3!=0)
                {
                    Dice.posg = 0;
                    if (Dice.posgLeft1 == true)
                    {
                        transform.position = waypoints[0].position;
                    }
                    else
                    {
                        transform.position = waypoints1[0].position;
                        Dice.posgLeft = true;
                    }
                }
            }
            else if (Dice.posg2 == 0)
            {
                if(Dice.posg1!=0 && Dice.posg3!=0)
                {
                    Dice.posg = 0;
                    if (Dice.posgLeft2 == true)
                    {
                        transform.position = waypoints[0].position;
                    }
                    else
                    {
                        transform.position = waypoints1[0].position;
                        Dice.posgLeft = true;
                    }
                }
            }
            else if (Dice.posg3 == 0)
            {
                if(Dice.posg1!=0 && Dice.posg2!=0)
                {
                    Dice.posg = 0;
                    if (Dice.posgLeft3 == true)
                    {
                        transform.position = waypoints[0].position;
                    }
                    else
                    {
                        transform.position = waypoints1[0].position;
                        Dice.posgLeft = true;
                    }
                }
            }//////////////////////////////////////////////////////////////////////////////////////////////////////////////ajouter les cas du player red
            else
            {
                if(folow_the_path.x==17)
                {
                    Debug.Log("enter eat");
                    if(Dice.access1==false)
                    {
                        numberImg.setimg(20);
                        Dice.access1=Dice.canaccess(20,3);
                    }
                    else if(Dice.access2==false)
                    {
                        numberImg1.setimg(20);
                        Dice.access2=Dice.canaccess(20,3);
                    }
                    folow_the_path.initpos=true;
                }
                else if(folow_the_path1.x==17)
                {
                    Debug.Log("enter eat");
                    if(Dice.access1==false)
                    {
                        numberImg.setimg(20);
                        Dice.access1=Dice.canaccess(20,3);
                    }
                    else if(Dice.access2==false)
                    {
                        numberImg1.setimg(20);
                        Dice.access2=Dice.canaccess(20,3);
                    }
                    folow_the_path1.initpos=true;
                }
                else if(folow_the_path2.x==17)
                {
                    Debug.Log("enter eat");
                    if(Dice.access1==false)
                    {
                        numberImg.setimg(20);
                        Dice.access1=Dice.canaccess(20,3);
                    }
                    else if(Dice.access2==false)
                    {
                        numberImg1.setimg(20);
                        Dice.access2=Dice.canaccess(20,3);
                    }
                    folow_the_path2.initpos=true;
                }
                else if(folow_the_path3.x==17)
                {
                    Debug.Log("enter eat");
                    if(Dice.access1==false)
                    {
                        numberImg.setimg(20);
                        Dice.access1=Dice.canaccess(20,3);
                    }
                    else if(Dice.access2==false)
                    {
                        numberImg1.setimg(20);
                        Dice.access2=Dice.canaccess(20,3);
                    }
                    folow_the_path3.initpos=true;
                }
                else if(follow_the_path_y1.x==17)
                {
                    Debug.Log("enter eat");
                    if(Dice.access1==false)
                    {
                        numberImg.setimg(20);
                        Dice.access1=Dice.canaccess(20,3);
                    }
                    else if(Dice.access2==false)
                    {
                        numberImg1.setimg(20);
                        Dice.access2=Dice.canaccess(20,3);
                    }
                    follow_the_path_y1.initpos=true;
                }
                else if(follow_the_path_y_2.x==17)
                {
                    Debug.Log("enter eat");
                    if(Dice.access1==false)
                    {
                        numberImg.setimg(20);
                        Dice.access1=Dice.canaccess(20,3);
                    }
                    else if(Dice.access2==false)
                    {
                        numberImg1.setimg(20);
                        Dice.access2=Dice.canaccess(20,3);
                    }
                    follow_the_path_y_2.initpos=true;
                }
                else if(follow_the_path_y_3.x==17)
                {
                    Debug.Log("enter eat");
                    if(Dice.access1==false)
                    {
                        numberImg.setimg(20);
                        Dice.access1=Dice.canaccess(20,3);
                    }
                    else if(Dice.access2==false)
                    {
                        numberImg1.setimg(20);
                        Dice.access2=Dice.canaccess(20,3);
                    }
                    follow_the_path_y_3.initpos=true;
                }
                else if(follow_the_path_y_4.x==17)
                {
                    Debug.Log("enter eat");
                    if(Dice.access1==false)
                    {
                        numberImg.setimg(20);
                        Dice.access1=Dice.canaccess(20,3);
                    }
                    else if(Dice.access2==false)
                    {
                        numberImg1.setimg(20);
                        Dice.access2=Dice.canaccess(20,3);
                    }
                    follow_the_path_y_4.initpos=true;
                }
                else
                {
                    Dice.posy = 0;
                    transform.position = waypoints[0].position;    
                }
            }
            x=17;
            if(follow_the_path_g2.firstmove1==false && follow_the_path_g3.firstmove2==false && follow_the_path_g4.firstmove3==false) Dice.freegreen=false;
            firstmove=false;
        }
        else if(initpos==true)
        {
            transform.position = firstplace.position;
            Dice.posg= -1;
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
        if(Dice.accessgreen)
        {
            if (Dice.posg >= 0)
            {
                if(numberImg.show==true)
                {
                    numberImg.hideimg();numberImg.show = false;///////////////
                    numberImg1.hideimg(); numberImg1.show = false;//////////////
                    Dice.selectedg = 0;
                }
                else
                {
                    numberImg.showimg();numberImg.show = true;///////////////
                    numberImg1.showimg(); numberImg1.show = true;/////////////////
                    Dice.selectedg = 1;
                }
            }
        }
    }
    IEnumerator move()
    {
        if(Dice.posg + Dice.nbr == waypoints.Length)
        {
            numberImg.hideimg();numberImg.show = false;////////////////
            numberImg1.hideimg();numberImg1.show = false;///////////////////
            Dice.posgLeft = false;
            for (int i =Dice.posg;i<Dice.posg + Dice.nbr; i++)
            {
                transform.position = waypoints[i].position;
                yield return new WaitForSeconds(0.1f);
            }
            Dice.posg= Dice.posg + Dice.nbr;
            x=x+ Dice.nbr;
            transform.position = final1.position;
            if(Dice.access1==false)
            {
                numberImg.setimg(10);
                Dice.access1=Dice.canaccess(10,3);
            }
            else if(Dice.access2==false)
            {
                numberImg1.setimg(10);
                Dice.access2=Dice.canaccess(10,3);
            }
            Dice.enterg++;
        }
        else if (Dice.posg + Dice.nbr <= waypoints.Length - 1)
        {
            numberImg.hideimg();numberImg.show = false;////////////////
            numberImg1.hideimg();numberImg1.show = false;///////////////////
            Dice.posgLeft = false;
            for (int i =Dice.posg;i<= Dice.posg + Dice.nbr ; i++)
            {
                transform.position = waypoints[i].position;
                yield return new WaitForSeconds(0.1f);
            }
            Dice.posg =Dice.posg + Dice.nbr;
            for(int i=1;i<=Dice.nbr;i++)
            {
                if(x==68)
                {
                    x=0;  x++;
                }
                else if(Dice.posg<63)
                {
                    x++;  
                }
                else x=100;
            }
            if (Dice.posg1 == Dice.posg)
            {
                if (Dice.posgLeft1 == true)
                {
                    transform.position = waypoints[Dice.posg].position;
                }
                else
                {
                    transform.position = waypoints1[Dice.posg].position;
                    Dice.posgLeft = true;
                }
            }
            else if (Dice.posg2 == Dice.posg)
            {
                if (Dice.posgLeft2 == true)
                {
                    transform.position = waypoints[Dice.posg].position;
                }
                else
                {
                    transform.position = waypoints1[Dice.posg].position;
                    Dice.posgLeft = true;
                }
            }
            else if (Dice.posg3 == Dice.posg)
            {
                if (Dice.posgLeft3 == true)
                {
                    transform.position = waypoints[Dice.posg].position;
                }
                else
                {
                    transform.position = waypoints1[Dice.posg].position;
                    Dice.posgLeft = true;
                }
            }///////////////////////////////////////////////////////////////////////////////////////////////////////ajouter le cas de player yellow
            if(x==folow_the_path.x)
            {
                Debug.Log("enter eat");
                if(Dice.access1==false)
                {
                    numberImg.setimg(20);
                    Dice.access1=Dice.canaccess(20,3);
                }
                else if(Dice.access2==false)
                {
                    numberImg1.setimg(20);
                    Dice.access2=Dice.canaccess(20,3);
                }
                folow_the_path.initpos=true;
            }
            else if(x==folow_the_path1.x)
            {
                Debug.Log("enter eat");
                if(Dice.access1==false)
                {
                    numberImg.setimg(20);
                    Dice.access1=Dice.canaccess(20,3);
                }
                else if(Dice.access2==false)
                {
                    numberImg1.setimg(20);
                    Dice.access2=Dice.canaccess(20,3);
                }
                folow_the_path1.initpos=true;
            }
            else if(x==folow_the_path2.x)
            {
                Debug.Log("enter eat");
                if(Dice.access1==false)
                {
                    numberImg.setimg(20);
                    Dice.access1=Dice.canaccess(20,3);
                }
                else if(Dice.access2==false)
                {
                    numberImg1.setimg(20);
                    Dice.access2=Dice.canaccess(20,3);
                }
                folow_the_path2.initpos=true;
            }
            else if(x==folow_the_path3.x)
            {
                Debug.Log("enter eat");
                if(Dice.access1==false)
                {
                    numberImg.setimg(20);
                    Dice.access1=Dice.canaccess(20,3);
                }
                else if(Dice.access2==false)
                {
                    numberImg1.setimg(20);
                    Dice.access2=Dice.canaccess(20,3);
                }
                folow_the_path3.initpos=true;
            }
            else if(x==follow_the_path_y1.x)
            {
                Debug.Log("enter eat");
                if(Dice.access1==false)
                {
                    numberImg.setimg(20);
                    Dice.access1=Dice.canaccess(20,3);
                }
                else if(Dice.access2==false)
                {
                    numberImg1.setimg(20);
                    Dice.access2=Dice.canaccess(20,3);
                }
                follow_the_path_y1.initpos=true;
            }
            else if(x==follow_the_path_y_2.x)
            {
                Debug.Log("enter eat");
                if(Dice.access1==false)
                {
                    numberImg.setimg(20);
                    Dice.access1=Dice.canaccess(20,3);
                }
                else if(Dice.access2==false)
                {
                    numberImg1.setimg(20);
                    Dice.access2=Dice.canaccess(20,3);
                }
                follow_the_path_y_2.initpos=true;
            }
            else if(x==follow_the_path_y_3.x)
            {
                Debug.Log("enter eat");
                if(Dice.access1==false)
                {
                    numberImg.setimg(20);
                    Dice.access1=Dice.canaccess(20,3);
                }
                else if(Dice.access2==false)
                {
                    numberImg1.setimg(20);
                    Dice.access2=Dice.canaccess(20,3);
                }
                follow_the_path_y_3.initpos=true;
            }
            else if(x==follow_the_path_y_4.x)
            {
                Debug.Log("enter eat");
                if(Dice.access1==false)
                {
                    numberImg.setimg(20);
                    Dice.access1=Dice.canaccess(20,3);
                }
                else if(Dice.access2==false)
                {
                    numberImg1.setimg(20);
                    Dice.access2=Dice.canaccess(20,3);
                }
                follow_the_path_y_4.initpos=true;
            }
            //transform.position = waypoints[Dice.pos + nbr].position;
            //transform.position = Vector2.MoveTowards(transform.position,waypoints[Dice.pos + nbr].position, movspeed );
        }
    }
}
