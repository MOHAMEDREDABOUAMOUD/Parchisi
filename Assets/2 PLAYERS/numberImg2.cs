using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numberImg2 : MonoBehaviour
{
    private static Sprite[] numberSides;
    private static SpriteRenderer rendNembers;
    public static bool show = false;
    public static int sidenmbr;
    void Start()
    {
        rendNembers = GetComponent<SpriteRenderer>();
        numberSides = Resources.LoadAll<Sprite>("imageNumbers/");
        hideimg();
    }

    // Update is called once per frame
    void Update()
    {
        if (show == false) hideimg();
    }
    public static void setimg(int side)
    {
        if(side==10)
        {
            rendNembers.sprite = numberSides[1];
            sidenmbr = side;
        }
        else if(side==20)
        {
            rendNembers.sprite = numberSides[3];
            sidenmbr = side;
        }
        else if(side==1)
        {
            rendNembers.sprite = numberSides[side-1];
            sidenmbr = side;
        }
        else if(side==2)
        {
            rendNembers.sprite = numberSides[side];
            sidenmbr = side;
        }
        else 
        {
            rendNembers.sprite = numberSides[side+1];
            sidenmbr = side;
        }
    }
    public static void hideimg()
    {
        rendNembers.GetComponent<SpriteRenderer>().sortingLayerID = SortingLayer.NameToID("baground");
    }
    public static void showimg()
    {
        rendNembers.GetComponent<SpriteRenderer>().sortingLayerID = SortingLayer.NameToID("Default");
    }
    private void OnMouseDown()
    {
        if(Dice2.access1==true)
        {
            Dice2.nbr = sidenmbr;
            if(Dice2.tour%2==0)
            {
                if(Dice2.selected==1)
                {
                    bool cantmov=false;
                    for(int i=Dice2.pos + 1;i<=Dice2.pos+Dice2.nbr;i++)
                    {
                        if((Dice2.pos1==i && Dice2.pos2==i)||(Dice2.pos1==i && Dice2.pos3==i)||(Dice2.pos2==i && Dice2.pos3==i))
                        {
                            cantmov=true;
                        }
                        if((follow_the_path_y12.x==i && follow_the_path_y_22.x==i)||(follow_the_path_y12.x==i && follow_the_path_y_32.x==i)||(follow_the_path_y12.x==i && follow_the_path_y_42.x==i)||(follow_the_path_y_22.x==i && follow_the_path_y_32.x==i)||(follow_the_path_y_22.x==i && follow_the_path_y_42.x==i)||(follow_the_path_y_32.x==i && follow_the_path_y_42.x==i))
                        {
                            cantmov=true;
                        }
                    }
                    if((folow_the_pathr2.x+Dice2.nbr==51 || folow_the_pathr2.x+Dice2.nbr==17 || folow_the_pathr2.x+Dice2.nbr==34 || folow_the_pathr2.x+Dice2.nbr==7 || folow_the_pathr2.x+Dice2.nbr==12 || folow_the_pathr2.x+Dice2.nbr==24 || folow_the_pathr2.x+Dice2.nbr==29 || folow_the_pathr2.x+Dice2.nbr==41 || folow_the_pathr2.x+Dice2.nbr==46 || folow_the_pathr2.x+Dice2.nbr==58 || folow_the_pathr2.x+Dice2.nbr==63)&&(follow_the_path_y12.x==folow_the_pathr2.x+Dice2.nbr || follow_the_path_y_22.x==folow_the_pathr2.x+Dice2.nbr || follow_the_path_y_32.x==folow_the_pathr2.x+Dice2.nbr || follow_the_path_y_42.x==folow_the_pathr2.x+Dice2.nbr))
                    {
                        cantmov=true;
                    }
                    if (cantmov==false) 
                    {
                        if(Dice2.pos+Dice2.nbr<=folow_the_pathr2.Length)
                        {
                            folow_the_pathr2.click = true; Dice2.access1 = false;
                        }
                    }
                }
                else if(Dice2.selected==2)
                {
                    //Debug.Log("entre to numimg mousedown");
                    bool cantmov=false;
                    for(int i=Dice2.pos1 + 1;i<=Dice2.pos1+Dice2.nbr;i++)
                    {
                        if((Dice2.pos==i && Dice2.pos2==i)||(Dice2.pos==i && Dice2.pos3==i)||(Dice2.pos2==i && Dice2.pos3==i))
                        {
                            cantmov=true;
                        }
                        if((follow_the_path_y12.x+Dice2.nbr==i && follow_the_path_y_22.x==i)||(follow_the_path_y12.x==i && follow_the_path_y_32.x==i)||(follow_the_path_y12.x==i && follow_the_path_y_42.x==i)||(follow_the_path_y_22.x==i && follow_the_path_y_32.x==i)||(follow_the_path_y_22.x==i && follow_the_path_y_42.x==i)||(follow_the_path_y_32.x==i && follow_the_path_y_42.x==i))
                        {
                            cantmov=true;
                        }
                    }
                    if(((folow_the_path12.x+Dice2.nbr==51 || folow_the_path12.x+Dice2.nbr==17 || folow_the_path12.x+Dice2.nbr==34 || folow_the_path12.x+Dice2.nbr==7 || folow_the_path12.x+Dice2.nbr==12 || folow_the_path12.x+Dice2.nbr==24 || folow_the_path12.x+Dice2.nbr==29 || folow_the_path12.x+Dice2.nbr==41 || folow_the_path12.x+Dice2.nbr==46 || folow_the_path12.x+Dice2.nbr==58 || folow_the_path12.x+Dice2.nbr==63)&&(follow_the_path_y12.x==folow_the_path12.x+Dice2.nbr || follow_the_path_y_22.x==folow_the_path12.x+Dice2.nbr || follow_the_path_y_32.x==folow_the_path12.x+Dice2.nbr || follow_the_path_y_42.x==folow_the_path12.x+Dice2.nbr)))
                    {
                        cantmov=true;
                    }
                    if (cantmov==false)
                    {
                        if(Dice2.pos1+Dice2.nbr<=folow_the_path12.Length)
                        {
                            folow_the_path12.click = true; Dice2.access1 = false;
                        }
                    }
                }
                else if(Dice2.selected==3)
                {
                    //Debug.Log("entre to numimg mousedown");
                    bool cantmov=false;
                    for(int i=Dice2.pos2 + 1;i<=Dice2.pos2+Dice2.nbr;i++)
                    {
                        if((Dice2.pos==i && Dice2.pos1==i)||(Dice2.pos==i && Dice2.pos3==i)||(Dice2.pos1==i && Dice2.pos3==i))
                        {
                            cantmov=true;
                        }
                        if((follow_the_path_y12.x+Dice2.nbr==i && follow_the_path_y_22.x==i)||(follow_the_path_y12.x==i && follow_the_path_y_32.x==i)||(follow_the_path_y12.x==i && follow_the_path_y_42.x==i)||(follow_the_path_y_22.x==i && follow_the_path_y_32.x==i)||(follow_the_path_y_22.x==i && follow_the_path_y_42.x==i)||(follow_the_path_y_32.x==i && follow_the_path_y_42.x==i))
                        {
                            cantmov=true;
                        }
                    }
                    
                    if(((folow_the_path22.x+Dice2.nbr==51 || folow_the_path22.x+Dice2.nbr==17 || folow_the_path22.x+Dice2.nbr==34 || folow_the_path22.x+Dice2.nbr==7 || folow_the_path22.x+Dice2.nbr==12 || folow_the_path22.x+Dice2.nbr==24 || folow_the_path22.x+Dice2.nbr==29 || folow_the_path22.x+Dice2.nbr==41 || folow_the_path22.x+Dice2.nbr==46 || folow_the_path22.x+Dice2.nbr==58 || folow_the_path22.x+Dice2.nbr==63)&&(follow_the_path_y12.x==folow_the_path22.x+Dice2.nbr || follow_the_path_y_22.x==folow_the_path22.x+Dice2.nbr || follow_the_path_y_32.x==folow_the_path22.x+Dice2.nbr || follow_the_path_y_42.x==folow_the_path22.x+Dice2.nbr)))
                    {
                        cantmov=true;
                    }
                    if (cantmov==false)
                    {
                        if(Dice2.pos2+Dice2.nbr<=folow_the_path22.Length)
                        {
                            folow_the_path22.click = true; Dice2.access1 = false;
                        }
                    }
                }
                else if(Dice2.selected==4)
                {
                    //Debug.Log("entre to numimg mousedown");
                    bool cantmov=false;
                    for(int i=Dice2.pos3 + 1;i<=Dice2.pos3+Dice2.nbr;i++)
                    {
                        if((Dice2.pos==i && Dice2.pos1==i)||(Dice2.pos==i && Dice2.pos2==i)||(Dice2.pos1==i && Dice2.pos2==i))
                        {
                            cantmov=true;
                        }
                        if((follow_the_path_y12.x==i && follow_the_path_y_22.x==i)||(follow_the_path_y12.x==i && follow_the_path_y_32.x==i)||(follow_the_path_y12.x==i && follow_the_path_y_42.x==i)||(follow_the_path_y_22.x==i && follow_the_path_y_32.x==i)||(follow_the_path_y_22.x==i && follow_the_path_y_42.x==i)||(follow_the_path_y_32.x==i && follow_the_path_y_42.x==i))
                        {
                            cantmov=true;
                        }
                    }
                    if(((folow_the_path32.x+Dice2.nbr==51 || folow_the_path32.x+Dice2.nbr==17 || folow_the_path32.x+Dice2.nbr==34 || folow_the_path32.x+Dice2.nbr==7 || folow_the_path32.x+Dice2.nbr==12 || folow_the_path32.x+Dice2.nbr==24 || folow_the_path32.x+Dice2.nbr==29 || folow_the_path32.x+Dice2.nbr==41 || folow_the_path32.x+Dice2.nbr==46 || folow_the_path32.x+Dice2.nbr==58 || folow_the_path32.x+Dice2.nbr==63)&&(follow_the_path_y12.x==folow_the_path32.x+Dice2.nbr || follow_the_path_y_22.x==folow_the_path32.x+Dice2.nbr || follow_the_path_y_32.x==folow_the_path32.x+Dice2.nbr || follow_the_path_y_42.x==folow_the_path32.x+Dice2.nbr)))
                    {
                        cantmov=true;
                    }
                    if (cantmov==false)
                    {
                        if(Dice2.pos3+Dice2.nbr<=folow_the_path32.Length)
                        {
                            folow_the_path32.click = true; Dice2.access1 = false;
                        }
                    }
                }
                else
                {
                    Debug.Log("not selected");
                }    
            }
            else
            {
                if(Dice2.selectedy==1)
                {
                    bool cantmov=false;
                    for(int i=follow_the_path_y12.x + 1;i<=follow_the_path_y12.x+Dice2.nbr;i++)
                    {
                        if((follow_the_path_y_22.x==i && follow_the_path_y_32.x==i)||(follow_the_path_y_22.x==i && follow_the_path_y_42.x==i)||(follow_the_path_y_32.x==i && follow_the_path_y_42.x==i))
                        {
                            cantmov=true;
                        }
                        if((folow_the_pathr2.x==i && folow_the_path12.x==i)||(folow_the_pathr2.x==i && folow_the_path22.x==i)||(folow_the_pathr2.x==i && folow_the_path32.x==i)||(folow_the_path12.x==i && folow_the_path22.x==i)||(folow_the_path12.x==i && folow_the_path32.x==i)||(folow_the_path22.x==i && folow_the_path32.x==i))
                        {
                            cantmov=true;
                        }
                    }
                    if((follow_the_path_y12.x+Dice2.nbr==51 || follow_the_path_y12.x+Dice2.nbr==17 || follow_the_path_y12.x+Dice2.nbr==34 || follow_the_path_y12.x+Dice2.nbr==7 || follow_the_path_y12.x+Dice2.nbr==12 || follow_the_path_y12.x+Dice2.nbr==24 || follow_the_path_y12.x+Dice2.nbr==29 || follow_the_path_y12.x+Dice2.nbr==41 || follow_the_path_y12.x+Dice2.nbr==46 || follow_the_path_y12.x+Dice2.nbr==58 || follow_the_path_y12.x+Dice2.nbr==63)&&(folow_the_pathr2.x==follow_the_path_y12.x+Dice2.nbr || folow_the_path12.x==follow_the_path_y12.x+Dice2.nbr || folow_the_path22.x==follow_the_path_y12.x+Dice2.nbr || folow_the_path32.x==follow_the_path_y12.x+Dice2.nbr))
                    {
                        cantmov=true;
                    }
                    if (cantmov==false) 
                    {
                        if(Dice2.posy+Dice2.nbr<=follow_the_path_y12.Length)
                        {
                            follow_the_path_y12.click = true; Dice2.access1 = false;
                        }
                    } 
                }
                else if(Dice2.selectedy==2)
                {
                    bool cantmov=false;
                    for(int i=follow_the_path_y_22.x + 1;i<=follow_the_path_y_22.x+Dice2.nbr;i++)
                    {
                        if((follow_the_path_y12.x==i && follow_the_path_y_32.x==i)||(follow_the_path_y12.x==i && follow_the_path_y_42.x==i)||(follow_the_path_y_32.x==i && follow_the_path_y_42.x==i))
                        {
                            cantmov=true;
                        }
                        if((folow_the_pathr2.x==i && folow_the_path12.x==i)||(folow_the_pathr2.x==i && folow_the_pathr2.x==i)||(folow_the_path22.x==i && folow_the_path32.x==i)||(folow_the_path12.x==i && folow_the_path22.x==i)||(folow_the_path12.x==i && folow_the_path32.x==i)||(folow_the_path22.x==i && folow_the_path32.x==i))
                        {
                            cantmov=true;
                        }
                    }
                    if((follow_the_path_y_22.x+Dice2.nbr==51 || follow_the_path_y_22.x+Dice2.nbr==17 || follow_the_path_y_22.x+Dice2.nbr==34 || follow_the_path_y_22.x+Dice2.nbr==7 || follow_the_path_y_22.x+Dice2.nbr==12 || follow_the_path_y_22.x+Dice2.nbr==24 || follow_the_path_y_22.x+Dice2.nbr==29 || follow_the_path_y_22.x+Dice2.nbr==41 || follow_the_path_y_22.x+Dice2.nbr==46 || follow_the_path_y_22.x+Dice2.nbr==58 || follow_the_path_y_22.x+Dice2.nbr==63)&&(folow_the_pathr2.x==follow_the_path_y_22.x+Dice2.nbr || folow_the_path12.x==follow_the_path_y_22.x+Dice2.nbr || folow_the_path22.x==follow_the_path_y_22.x+Dice2.nbr || folow_the_path32.x==follow_the_path_y_22.x+Dice2.nbr))
                    {
                        cantmov=true;
                    }
                    if (cantmov==false)
                    {
                        if(Dice2.posy1+Dice2.nbr<=follow_the_path_y_22.Length)
                        {
                            follow_the_path_y_22.click = true; Dice2.access1 = false;
                        }
                    }
                }
                else if(Dice2.selectedy==3)
                {
                    bool cantmov=false;
                    for(int i=follow_the_path_y_32.x + 1;i<=follow_the_path_y_32.x+Dice2.nbr;i++)
                    {
                        if((follow_the_path_y12.x==i && follow_the_path_y_22.x==i)||(follow_the_path_y12.x==i && follow_the_path_y_42.x==i)||(follow_the_path_y_22.x==i && follow_the_path_y_42.x==i))
                        {
                            cantmov=true;
                        }
                        if((folow_the_pathr2.x==i && folow_the_path12.x==i)||(folow_the_pathr2.x==i && folow_the_path22.x==i)||(folow_the_pathr2.x==i && folow_the_path32.x==i)||(folow_the_path12.x==i && folow_the_path22.x==i)||(folow_the_path12.x==i && folow_the_path32.x==i)||(folow_the_path22.x==i && folow_the_path32.x==i))
                        {
                            cantmov=true;
                        }
                    }
                    if((follow_the_path_y_32.x+Dice2.nbr==51 || follow_the_path_y_32.x+Dice2.nbr==17 || follow_the_path_y_32.x+Dice2.nbr==34 || follow_the_path_y_32.x+Dice2.nbr==7 || follow_the_path_y_32.x+Dice2.nbr==12 || follow_the_path_y_32.x+Dice2.nbr==24 || follow_the_path_y_32.x+Dice2.nbr==29 || follow_the_path_y_32.x+Dice2.nbr==41 || follow_the_path_y_32.x+Dice2.nbr==46 || follow_the_path_y_32.x+Dice2.nbr==58 || follow_the_path_y_32.x+Dice2.nbr==63)&&(folow_the_pathr2.x==follow_the_path_y_32.x+Dice2.nbr || folow_the_path12.x==follow_the_path_y_32.x+Dice2.nbr || folow_the_path22.x==follow_the_path_y_32.x+Dice2.nbr || folow_the_path32.x==follow_the_path_y_32.x+Dice2.nbr))
                    {
                        cantmov=true;
                    }
                    if (cantmov==false)
                    {
                        if(Dice2.posy2+Dice2.nbr<=follow_the_path_y_32.Length)
                        {
                            follow_the_path_y_32.click = true; Dice2.access1 = false;
                        }
                    }
                }
                else if(Dice2.selectedy==4)
                {
                    bool cantmov=false;
                    for(int i=follow_the_path_y_42.x + 1;i<=follow_the_path_y_42.x+Dice2.nbr;i++)
                    {
                        if((follow_the_path_y12.x==i && follow_the_path_y_22.x==i)||(follow_the_path_y12.x==i && follow_the_path_y_32.x==i)||(follow_the_path_y_22.x==i && follow_the_path_y_32.x==i))
                        {
                            cantmov=true;
                        }
                        if((folow_the_pathr2.x==i && folow_the_path12.x==i)||(folow_the_pathr2.x==i && folow_the_path22.x==i)||(folow_the_pathr2.x==i && folow_the_path32.x==i)||(folow_the_path12.x==i && folow_the_path22.x==i)||(folow_the_path12.x==i && folow_the_path32.x==i)||(folow_the_path22.x==i && folow_the_path32.x==i))
                        {
                            cantmov=true;
                        }
                    }
                    if((follow_the_path_y_42.x+Dice2.nbr==51 || follow_the_path_y_42.x+Dice2.nbr==17 || follow_the_path_y_42.x+Dice2.nbr==34 || follow_the_path_y_42.x+Dice2.nbr==7 || follow_the_path_y_42.x+Dice2.nbr==12 || follow_the_path_y_42.x+Dice2.nbr==24 || follow_the_path_y_42.x+Dice2.nbr==29 || follow_the_path_y_42.x+Dice2.nbr==41 || follow_the_path_y_42.x+Dice2.nbr==46 || follow_the_path_y_42.x+Dice2.nbr==58 || follow_the_path_y_42.x+Dice2.nbr==63)&&(folow_the_pathr2.x==follow_the_path_y_42.x+Dice2.nbr || folow_the_path12.x==follow_the_path_y_42.x+Dice2.nbr || folow_the_path22.x==follow_the_path_y_42.x+Dice2.nbr || folow_the_path32.x==follow_the_path_y_42.x+Dice2.nbr))
                    {
                        cantmov=true;
                    }
                    if (cantmov==false)
                    {
                        if(Dice2.posy3+Dice2.nbr<=follow_the_path_y_42.Length)
                        {
                            follow_the_path_y_42.click = true; Dice2.access1 = false;
                        }
                    }
                }
                else
                {
                    Debug.Log("not selected");
                }  
            }
        }
    }
}
