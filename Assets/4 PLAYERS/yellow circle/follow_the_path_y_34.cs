using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class follow_the_path_y_34 : MonoBehaviour
{
    //[SerializeField] private GameObject dest;
    [SerializeField] Transform[] waypoints;
    [SerializeField] Transform[] waypoints1;
    [SerializeField] Transform firstplace2;
    [SerializeField] Transform final3;
    [SerializeField] public static Transform curentpos;
    public static bool allowMove2 = false,firstmove2=false;
    public static bool click =false;
    public static int Length;
    public static bool initpos=false;
    public static int x;
    private void Start()
    {
        transform.position = firstplace2.position;
        Dice4.posy2=-1;
        x=-1;
        Length=waypoints.Length;
    }

    void Update()
    {
        if (firstmove2 == true && transform.position == firstplace2.position && Dice4.freeyellow)
        {
            if (Dice4.posy == 0)
            {
                if(Dice4.posy1!=0 && Dice4.posy3!=0)
                {
                    Dice4.posy2 = 0;
                    if (Dice4.posyLeft == true)
                    {
                        transform.position = waypoints[0].position;
                    }
                    else
                    {
                        transform.position = waypoints1[0].position;
                        Dice4.posyLeft2 = true;
                    }
                }
            }
            else if (Dice4.posy1 == 0)
            {
                Dice4.posy2 = 0;
                if (Dice4.posy!=0 && Dice4.posy3!=0)
                {
                    if (Dice4.posyLeft1 == true)
                    {
                        transform.position = waypoints[0].position;
                    }
                    else
                    {
                        transform.position = waypoints1[0].position;
                        Dice4.posyLeft2 = true;
                    }
                }
            }
            else if (Dice4.posy3 == 0)
            {
                Dice4.posy2 = 0;
                if (Dice4.posy!=0 && Dice4.posy1!=0)
                {
                    if (Dice4.posyLeft3 == true)
                    {
                        transform.position = waypoints[0].position;
                    }
                    else
                    {
                        transform.position = waypoints1[0].position;
                        Dice4.posyLeft2 = true;
                    }
                }
            }
            else
            {
                if(folow_the_path4.x==34)
                {
                    Debug.Log("enter eat");
                    if(Dice4.access1==false)
                    {
                        numberImg4.setimg(20);
                        Dice4.access1=Dice4.canaccess(20,2);
                    }
                    else if(Dice4.access2==false)
                    {
                        numberImg14.setimg(20);
                        Dice4.access2=Dice4.canaccess(20,2);
                    }
                    folow_the_path4.initpos=true;
                }
                else if(folow_the_path14.x==34)
                {
                    Debug.Log("enter eat");
                    if(Dice4.access1==false)
                    {
                        numberImg4.setimg(20);
                        Dice4.access1=Dice4.canaccess(20,2);
                    }
                    else if(Dice4.access2==false)
                    {
                        numberImg14.setimg(20);
                        Dice4.access2=Dice4.canaccess(20,2);
                    }
                    folow_the_path14.initpos=true;
                }
                else if(folow_the_path24.x==34)
                {
                    Debug.Log("enter eat");
                    if(Dice4.access1==false)
                    {
                        numberImg4.setimg(20);
                        Dice4.access1=Dice4.canaccess(20,2);
                    }
                    else if(Dice4.access2==false)
                    {
                        numberImg14.setimg(20);
                        Dice4.access2=Dice4.canaccess(20,2);
                    }
                    folow_the_path24.initpos=true;
                }
                else if(folow_the_path34.x==34)
                {
                    Debug.Log("enter eat");
                    if(Dice4.access1==false)
                    {
                        numberImg4.setimg(20);
                        Dice4.access1=Dice4.canaccess(20,2);
                    }
                    else if(Dice4.access2==false)
                    {
                        numberImg14.setimg(20);
                        Dice4.access2=Dice4.canaccess(20,2);
                    }
                    folow_the_path34.initpos=true;
                }
                else if(follow_the_path_g14.x==34)
                {
                    Debug.Log("enter eat");
                    if(Dice4.access1==false)
                    {
                        numberImg4.setimg(20);
                        Dice4.access1=Dice4.canaccess(20,2);
                    }
                    else if(Dice4.access2==false)
                    {
                        numberImg14.setimg(20);
                        Dice4.access2=Dice4.canaccess(20,2);
                    }
                    follow_the_path_g14.initpos=true;
                }
                else if(follow_the_path_g24.x==34)
                {
                    Debug.Log("enter eat");
                    if(Dice4.access1==false)
                    {
                        numberImg4.setimg(20);
                        Dice4.access1=Dice4.canaccess(20,2);
                    }
                    else if(Dice4.access2==false)
                    {
                        numberImg14.setimg(20);
                        Dice4.access2=Dice4.canaccess(20,2);
                    }
                    follow_the_path_g24.initpos=true;
                }
                else if(follow_the_path_g34.x==34)
                {
                    Debug.Log("enter eat");
                    if(Dice4.access1==false)
                    {
                        numberImg4.setimg(20);
                        Dice4.access1=Dice4.canaccess(20,2);
                    }
                    else if(Dice4.access2==false)
                    {
                        numberImg14.setimg(20);
                        Dice4.access2=Dice4.canaccess(20,2);
                    }
                    follow_the_path_g34.initpos=true;
                }
                else if(follow_the_path_g44.x==34)
                {
                    Debug.Log("enter eat");
                    if(Dice4.access1==false)
                    {
                        numberImg4.setimg(20);
                        Dice4.access1=Dice4.canaccess(20,2);
                    }
                    else if(Dice4.access2==false)
                    {
                        numberImg14.setimg(20);
                        Dice4.access2=Dice4.canaccess(20,2);
                    }
                    follow_the_path_g44.initpos=true;
                }
                else if(follow_the_path_b14.x==34)
                {
                    Debug.Log("enter eat");
                    if(Dice4.access1==false)
                    {
                        numberImg4.setimg(20);
                        Dice4.access1=Dice4.canaccess(20,2);
                    }
                    else if(Dice4.access2==false)
                    {
                        numberImg14.setimg(20);
                        Dice4.access2=Dice4.canaccess(20,2);
                    }
                    follow_the_path_b14.initpos=true;
                }
                else if(follow_the_path_b24.x==34)
                {
                    Debug.Log("enter eat");
                    if(Dice4.access1==false)
                    {
                        numberImg4.setimg(20);
                        Dice4.access1=Dice4.canaccess(20,2);
                    }
                    else if(Dice4.access2==false)
                    {
                        numberImg14.setimg(20);
                        Dice4.access2=Dice4.canaccess(20,2);
                    }
                    follow_the_path_b24.initpos=true;
                }
                else if(follow_the_path_b34.x==34)
                {
                    Debug.Log("enter eat");
                    if(Dice4.access1==false)
                    {
                        numberImg4.setimg(20);
                        Dice4.access1=Dice4.canaccess(20,2);
                    }
                    else if(Dice4.access2==false)
                    {
                        numberImg14.setimg(20);
                        Dice4.access2=Dice4.canaccess(20,2);
                    }
                    follow_the_path_b34.initpos=true;
                }
                else if(follow_the_path_b44.x==34)
                {
                    Debug.Log("enter eat");
                    if(Dice4.access1==false)
                    {
                        numberImg4.setimg(20);
                        Dice4.access1=Dice4.canaccess(20,2);
                    }
                    else if(Dice4.access2==false)
                    {
                        numberImg14.setimg(20);
                        Dice4.access2=Dice4.canaccess(20,2);
                    }
                    follow_the_path_b44.initpos=true;
                }
                else
                {
                    Dice4.posy2 = 0;
                    transform.position = waypoints[0].position;    
                }
            }
            x=34;
            if(follow_the_path_y_24.firstmove1==false && follow_the_path_y14.firstmove==false && follow_the_path_y_44.firstmove3==false) Dice4.freeyellow=false;
            firstmove2=false;
        }
        else if(initpos==true)
        {
            transform.position = firstplace2.position;
            Dice4.posy2= -1;
            x=-1;
            initpos=false;
        }
        else if (click == true && transform.position!=firstplace2.position)
        {
            StartCoroutine(move());
            click = false;
        }
    }
    private void OnMouseDown()
    {
        if(Dice4.accessyellow)
        {
            if (Dice4.posy >= 0)
            {
                if (numberImg4.show == true)
                {
                    numberImg4.hideimg(); numberImg4.show = false;///////////////
                    numberImg14.hideimg(); numberImg14.show = false;//////////////
                    Dice4.selectedy = 0;
                }
                else
                {
                    numberImg4.showimg(); numberImg4.show = true;///////////////
                    numberImg14.showimg(); numberImg14.show = true;/////////////////
                    Dice4.selectedy = 3;
                }
            }    
        }
        
    }
    IEnumerator move()
    {
        if(Dice4.posy2 + Dice4.nbr == waypoints.Length)
        {
            numberImg4.hideimg();numberImg4.show = false;////////////////
            numberImg14.hideimg();numberImg14.show = false;///////////////////
            Dice4.posyLeft2 = false;
            for (int i =Dice4.posy2;i< Dice4.posy2 + Dice4.nbr ; i++)
            {
                transform.position = waypoints[i].position;
                yield return new WaitForSeconds(0.5f);
            }
            Dice4.posy2= Dice4.posy2 + Dice4.nbr;
            x=x+ Dice4.nbr;
            transform.position = final3.position;
            if(Dice4.access1==false)
            {
                numberImg4.setimg(10);
                Dice4.access1=Dice4.canaccess(10,2);
            }
            else if(Dice4.access2==false)
            {
                numberImg14.setimg(10);
                Dice4.access2=Dice4.canaccess(10,2);
            }
            Dice4.entery++;
        }
        else if (Dice4.posy2 + Dice4.nbr <= waypoints.Length - 1)
        {
            numberImg4.hideimg(); numberImg4.show = false;////////////////
            numberImg14.hideimg(); numberImg14.show = false;///////////////////
            Dice4.posyLeft2 = false;
            for (int i =Dice4.posy2;i<= Dice4.posy2 + Dice4.nbr; i++)
            {
                //Time.timeScale = 1f;
                transform.position = waypoints[i].position;
                yield return new WaitForSeconds(0.1f);
                //Time.timeScale = 0f;
            }
            Dice4.posy2 += Dice4.nbr;
            for(int i=1;i<=Dice4.nbr;i++)
            {
                if(x==68)
                {
                    x=0;x++;
                }
                else if(Dice4.posy2<63)
                {
                    x++;  
                }
                else x=100;
            }
            if (Dice4.posy == Dice4.posy2)
            {
                if (Dice4.posyLeft == true)
                {
                    transform.position = waypoints[Dice4.posy2].position;
                }
                else
                {
                    transform.position = waypoints1[Dice4.posy2].position;
                    Dice4.posyLeft2 = true;
                }
            }
            else if (Dice4.posy1 == Dice4.posy2)
            {
                if (Dice4.posyLeft1 == true)
                {
                    transform.position = waypoints[Dice4.posy2].position;
                }
                else
                {
                    transform.position = waypoints1[Dice4.posy2].position;
                    Dice4.posyLeft2 = true;
                }
            }
            else if (Dice4.posy3 == Dice4.posy2)
            {
                if (Dice4.posyLeft3 == true)
                {
                    transform.position = waypoints[Dice4.posy2].position;
                }
                else
                {
                    transform.position = waypoints1[Dice4.posy2].position;
                    Dice4.posyLeft2 = true;
                }
            }
            if(x==folow_the_path4.x)
            {
                Debug.Log("enter eat");
                if(Dice4.access1==false)
                {
                    numberImg4.setimg(20);
                    Dice4.access1=Dice4.canaccess(20,2);
                }
                else if(Dice4.access2==false)
                {
                    numberImg14.setimg(20);
                    Dice4.access2=Dice4.canaccess(20,2);
                }
                folow_the_path4.initpos=true;
            }
            else if(x==folow_the_path14.x)
            {
                Debug.Log("enter eat");
                if(Dice4.access1==false)
                {
                    numberImg4.setimg(20);
                    Dice4.access1=Dice4.canaccess(20,2);
                }
                else if(Dice4.access2==false)
                {
                    numberImg14.setimg(20);
                    Dice4.access2=Dice4.canaccess(20,2);
                }
                folow_the_path14.initpos=true;
            }
            else if(x==folow_the_path24.x)
            {
                Debug.Log("enter eat");
                if(Dice4.access1==false)
                {
                    numberImg4.setimg(20);
                    Dice4.access1=Dice4.canaccess(20,2);
                }
                else if(Dice4.access2==false)
                {
                    numberImg14.setimg(20);
                    Dice4.access2=Dice4.canaccess(20,2);
                }
                folow_the_path24.initpos=true;
            }
            else  if(x==folow_the_path34.x)
            {
                Debug.Log("enter eat");
                if(Dice4.access1==false)
                {
                    numberImg4.setimg(20);
                    Dice4.access1=Dice4.canaccess(20,2);
                }
                else if(Dice4.access2==false)
                {
                    numberImg14.setimg(20);
                    Dice4.access2=Dice4.canaccess(20,2);
                }
                folow_the_path34.initpos=true;
            }
            else if(x==follow_the_path_g14.x)
            {
                Debug.Log("enter eat");
                if(Dice4.access1==false)
                {
                    numberImg4.setimg(20);
                    Dice4.access1=Dice4.canaccess(20,2);
                }
                else if(Dice4.access2==false)
                {
                    numberImg14.setimg(20);
                    Dice4.access2=Dice4.canaccess(20,2);
                }
                follow_the_path_g14.initpos=true;
            }
            else if(x==follow_the_path_g24.x)
            {
                Debug.Log("enter eat");
                if(Dice4.access1==false)
                {
                    numberImg4.setimg(20);
                    Dice4.access1=Dice4.canaccess(20,2);
                }
                else if(Dice4.access2==false)
                {
                    numberImg14.setimg(20);
                    Dice4.access2=Dice4.canaccess(20,2);
                }
                follow_the_path_g24.initpos=true;
            }
            else if(x==follow_the_path_g34.x)
            {
                Debug.Log("enter eat");
                if(Dice4.access1==false)
                {
                    numberImg4.setimg(20);
                    Dice4.access1=Dice4.canaccess(20,2);
                }
                else if(Dice4.access2==false)
                {
                    numberImg14.setimg(20);
                    Dice4.access2=Dice4.canaccess(20,2);
                }
                follow_the_path_g34.initpos=true;
            }
            else if(x==follow_the_path_g44.x)
            {
                Debug.Log("enter eat");
                if(Dice4.access1==false)
                {
                    numberImg4.setimg(20);
                    Dice4.access1=Dice4.canaccess(20,2);
                }
                else if(Dice4.access2==false)
                {
                    numberImg14.setimg(20);
                    Dice4.access2=Dice4.canaccess(20,2);
                }
                follow_the_path_g44.initpos=true;
            }
            else if(x==follow_the_path_b14.x)
            {
                Debug.Log("enter eat");
                if(Dice4.access1==false)
                {
                    numberImg4.setimg(20);
                    Dice4.access1=Dice4.canaccess(20,2);
                }
                else if(Dice4.access2==false)
                {
                    numberImg14.setimg(20);
                    Dice4.access2=Dice4.canaccess(20,2);
                }
                follow_the_path_b14.initpos=true;
            }
            else if(x==follow_the_path_b24.x)
            {
                Debug.Log("enter eat");
                if(Dice4.access1==false)
                {
                    numberImg4.setimg(20);
                    Dice4.access1=Dice4.canaccess(20,2);
                }
                else if(Dice4.access2==false)
                {
                    numberImg14.setimg(20);
                    Dice4.access2=Dice4.canaccess(20,2);
                }
                follow_the_path_b24.initpos=true;
            }
            else if(x==follow_the_path_b34.x)
            {
                Debug.Log("enter eat");
                if(Dice4.access1==false)
                {
                    numberImg4.setimg(20);
                    Dice4.access1=Dice4.canaccess(20,2);
                }
                else if(Dice4.access2==false)
                {
                    numberImg14.setimg(20);
                    Dice4.access2=Dice4.canaccess(20,2);
                }
                follow_the_path_b34.initpos=true;
            }
            else if(x==follow_the_path_b44.x)
            {
                Debug.Log("enter eat");
                if(Dice4.access1==false)
                {
                    numberImg4.setimg(20);
                    Dice4.access1=Dice4.canaccess(20,2);
                }
                else if(Dice4.access2==false)
                {
                    numberImg14.setimg(20);
                    Dice4.access2=Dice4.canaccess(20,2);
                }
                follow_the_path_b44.initpos=true;
            }
            //Time.timeScale = 1f;
            //transform.position = waypoints[waypointsIndex + nbr].position;
            //transform.position = Vector2.MoveTowards(transform.position,waypoints[waypointsIndex + nbr].position, movspeed );
            
        }
    }
}
