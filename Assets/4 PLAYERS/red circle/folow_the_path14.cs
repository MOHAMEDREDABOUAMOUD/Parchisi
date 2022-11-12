using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class folow_the_path14 : MonoBehaviour
{
    //[SerializeField] private GameObject dest;
    [SerializeField] Transform[] waypoints;
    [SerializeField] Transform[] waypoints1;
    [SerializeField] Transform firstplace1;
    [SerializeField] Transform final2;
    [SerializeField] public static Transform curentpos;
    // [SerializeField] GameObject[] waypoints;
    [SerializeField] float movspeed=3f;
    public static bool allowMove1 = false,firstmove1=false;
    public static bool click =false;
    public static int Length;
    public static bool initpos=false;
    public static int x;
    // Start is called before the first frame update
    private void Start()
    {
        transform.position = firstplace1.position;
        Dice4.pos1 = -1;
        x=-1;
        Length=waypoints.Length;
    }

    void Update()
    {
        if (firstmove1 == true && transform.position == firstplace1.position && Dice4.freered)
        {
            if (Dice4.pos == 0)
            {
                if(Dice4.pos2!=0 && Dice4.pos3!=0)
                {
                    Dice4.pos1 = 0;
                    if (Dice4.posLeft == true)
                    {
                        transform.position = waypoints[0].position;
                    }
                    else
                    {
                        transform.position = waypoints1[0].position;
                        Dice4.posLeft1 = true;
                    }
                }
            }
            else if (Dice4.pos2 == 0)
            {
                if(Dice4.pos!=0 && Dice4.pos3!=0)
                {
                    Dice4.pos1 = 0;
                    if (Dice4.posLeft2 == true)
                    {
                        transform.position = waypoints[0].position;
                    }
                    else
                    {
                        transform.position = waypoints1[0].position;
                        Dice4.posLeft1 = true;
                    }
                }
            }
            else if (Dice4.pos3 == 0)
            {
                if(Dice4.pos!=0 && Dice4.pos2!=0)
                {
                    Dice4.pos1 = 0;
                    if (Dice4.posLeft3 == true)
                    {
                        transform.position = waypoints[0].position;
                    }
                    else
                    {
                        transform.position = waypoints1[0].position;
                        Dice4.posLeft1 = true;
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
                    Dice4.pos1 = 0;
                    transform.position = waypoints[0].position;
                }
            }
            x=0;
            if(folow_the_path4.firstmove==false && folow_the_path24.firstmove2==false && folow_the_path34.firstmove3==false) Dice4.freered=false;
            firstmove1=false;
        }
        else if(initpos==true)
        {
            transform.position = firstplace1.position;
            Dice4.pos1= -1;
            x=-1;
            initpos=false;
        }
        else if (click == true && transform.position!=firstplace1.position)
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
                if (numberImg4.show == true)
                {
                    numberImg4.hideimg(); numberImg4.show = false;///////////////
                    numberImg14.hideimg(); numberImg14.show = false;//////////////
                    Dice4.selected = 0;
                }
                else
                {
                    numberImg4.showimg(); numberImg4.show = true;///////////////
                    numberImg14.showimg(); numberImg14.show = true;/////////////////
                    Dice4.selected = 2;
                }
            }    
        }
    }
    IEnumerator move()
    {
        if(Dice4.pos1 + Dice4.nbr == waypoints.Length)
        {
            numberImg4.hideimg();numberImg4.show = false;////////////////
            numberImg14.hideimg();numberImg14.show = false;///////////////////
            Dice4.posLeft = false;
            for (int i =Dice4.pos1;i< Dice4.pos1 + Dice4.nbr ; i++)
            {
                transform.position = waypoints[i].position;
                yield return new WaitForSeconds(0.5f);
            }
            Dice4.pos1= Dice4.pos1 + Dice4.nbr;
            x=x+Dice4.nbr;
            transform.position = final2.position;
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
        else if (Dice4.pos1 + Dice4.nbr <= waypoints.Length - 1)
        {
            numberImg4.hideimg(); numberImg4.show = false;////////////////
            numberImg14.hideimg(); numberImg14.show = false;///////////////////
            Dice4.posLeft1 = false;
            for (int i =Dice4.pos1;i<= Dice4.pos1 + Dice4.nbr; i++)
            {
                //Time.timeScale = 1f;
                transform.position = waypoints[i].position;
                yield return new WaitForSeconds(0.1f);
                //Time.timeScale = 0f;
            }
            Dice4.pos1 += Dice4.nbr;
            for(int i=1;i<=Dice4.nbr;i++)
            {
                if(x<63)
                {
                    x++;  
                }
                else x=100;
            }
            if (Dice4.pos == Dice4.pos1)
            {
                if (Dice4.posLeft == true)
                {
                    transform.position = waypoints[Dice4.pos1].position;
                }
                else
                {
                    transform.position = waypoints1[Dice4.pos1].position;
                    Dice4.posLeft1 = true;
                }
            }
            else if (Dice4.pos2 == Dice4.pos1)
            {
                if (Dice4.posLeft2 == true)
                {
                    transform.position = waypoints[Dice4.pos1].position;
                }
                else
                {
                    transform.position = waypoints1[Dice4.pos1].position;
                    Dice4.posLeft1 = true;
                }
            }
            else if (Dice4.pos3 == Dice4.pos1)
            {
                if (Dice4.posLeft3 == true)
                {
                    transform.position = waypoints[Dice4.pos1].position;
                }
                else
                {
                    transform.position = waypoints1[Dice4.pos1].position;
                    Dice4.posLeft1 = true;
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
            else if(x==follow_the_path_y_34.x)
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
            //Time.timeScale = 1f;
            //transform.position = waypoints[waypointsIndex + nbr].position;
            //transform.position = Vector2.MoveTowards(transform.position,waypoints[waypointsIndex + nbr].position, movspeed );
            
        }
    }
}
